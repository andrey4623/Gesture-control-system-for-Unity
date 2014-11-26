using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gesture_viewer.cs
{
    class GestureRecognition
    {
        private MainForm form;
        private bool disconnected = false;
        private PXCMGesture.GeoNode[][] nodes = new PXCMGesture.GeoNode[2][] { new PXCMGesture.GeoNode[11], new PXCMGesture.GeoNode[11] };
        private PXCMGesture.Gesture[] gestures = new PXCMGesture.Gesture[2];

        public GestureRecognition(MainForm form)
        {
            this.form = form;
        }

        private bool DisplayDeviceConnection(bool state)
        {
            if (state)
            {
                if (!disconnected) form.UpdateStatus("Device Disconnected");
                disconnected = true;
            }
            else
            {
                if (disconnected) form.UpdateStatus("Device Reconnected");
                disconnected = false;
            }
            return disconnected;
        }

        private void DisplayPicture(PXCMImage depth, PXCMGesture gesture)
        {
            PXCMImage image = depth;
            bool dispose = false;
            if (form.GetLabelmapState())
            {
                if (gesture.QueryBlobImage(PXCMGesture.Blob.Label.LABEL_SCENE,0,out image)<pxcmStatus.PXCM_STATUS_NO_ERROR) return;
                dispose = true;
            }

            PXCMImage.ImageData data;
            if (image.AcquireAccess(PXCMImage.Access.ACCESS_READ, PXCMImage.ColorFormat.COLOR_FORMAT_RGB32, out data) >= pxcmStatus.PXCM_STATUS_NO_ERROR)
            {
                form.DisplayBitmap(data.ToBitmap(image.info.width,image.info.height));
                image.ReleaseAccess(ref data);
            }

            if (dispose) image.Dispose();
        }

        private void DisplayGeoNodes(PXCMGesture gesture)
        {
            if (form.GetGeoNodeState())
            {
                gesture.QueryNodeData(0, PXCMGesture.GeoNode.Label.LABEL_BODY_HAND_PRIMARY, nodes[0]);
                gesture.QueryNodeData(0, PXCMGesture.GeoNode.Label.LABEL_BODY_HAND_SECONDARY, nodes[1]);
                gesture.QueryNodeData(0, PXCMGesture.GeoNode.Label.LABEL_BODY_ELBOW_PRIMARY, out nodes[0][nodes.Length-1]);
                gesture.QueryNodeData(0, PXCMGesture.GeoNode.Label.LABEL_BODY_ELBOW_SECONDARY, out nodes[1][nodes.Length-1]);
                form.DisplayGeoNodes(nodes);
            }
            else
            {
                form.DisplayGeoNodes(null);
            }
        }

        private void DisplayGesture(PXCMGesture gesture) {
            gesture.QueryGestureData(0, PXCMGesture.GeoNode.Label.LABEL_BODY_HAND_PRIMARY, 0, out gestures[0]);
            gesture.QueryGestureData(0, PXCMGesture.GeoNode.Label.LABEL_BODY_HAND_SECONDARY, 0, out gestures[1]);
            form.DisplayGestures(gestures);
        }

        public void SimplePipeline()
        {
            bool sts = true;
            UtilMPipeline pp = null;
            disconnected = false;

            /* Set Source */
            if (form.GetRecordState()) {
                pp = new UtilMPipeline(form.GetFileName(), true);
                pp.QueryCapture().SetFilter(form.GetCheckedDevice());
            }
            else if (form.GetPlaybackState())
            {
                pp = new UtilMPipeline(form.GetFileName(), false);
            }
            else
            {
                pp = new UtilMPipeline();
                pp.QueryCapture().SetFilter(form.GetCheckedDevice());
            }

            /* Set Module */
            pp.EnableGesture(form.GetCheckedModule());

            /* Initialization */
            form.UpdateStatus("Init Started");
            if (pp.Init())
            {
                form.UpdateStatus("Streaming");

                while (!form.stop)
                {
                    if (!pp.AcquireFrame(true)) break;
                    if (!DisplayDeviceConnection(pp.IsDisconnected()))
                    {
                        /* Display Results */
                        PXCMGesture gesture = pp.QueryGesture();
                        PXCMImage depth = pp.QueryImage(PXCMImage.ImageType.IMAGE_TYPE_DEPTH);
                        DisplayPicture(depth, gesture);
                        DisplayGeoNodes(gesture);
                        DisplayGesture(gesture);
                        form.UpdatePanel();
                    }
                    pp.ReleaseFrame();
                }
            }
            else
            {
                form.UpdateStatus("Init Failed");
                sts = false;
            }

            pp.Close();
            pp.Dispose();
            if (sts) form.UpdateStatus("Stopped");
        }

        public void AdvancedPipeline()
        {
            PXCMSession session;
            pxcmStatus sts = PXCMSession.CreateInstance(out session);
            if (sts<pxcmStatus.PXCM_STATUS_NO_ERROR) {
                form.UpdateStatus("Failed to create an SDK session");
                return;
            }

            /* Set Module */
            PXCMSession.ImplDesc desc=new PXCMSession.ImplDesc();
            desc.friendlyName.set(form.GetCheckedModule());

            PXCMGesture gesture;
            sts=session.CreateImpl<PXCMGesture>(ref desc,PXCMGesture.CUID,out gesture);
            if (sts<pxcmStatus.PXCM_STATUS_NO_ERROR) {
                form.UpdateStatus("Failed to create the gesture module");
                session.Dispose();
                return;
            }

            UtilMCapture capture=null;
            if (form.GetRecordState())
            {
                capture = new UtilMCaptureFile(session,form.GetFileName(),true);
                capture.SetFilter(form.GetCheckedDevice());
            }
            else if (form.GetPlaybackState())
            {
                capture = new UtilMCaptureFile(session, form.GetFileName(), false);
            }
            else
            {
                capture = new UtilMCapture(session);
                capture.SetFilter(form.GetCheckedDevice());
            }

            form.UpdateStatus("Pair moudle with I/O");
            for (uint i=0;;i++) {
                PXCMGesture.ProfileInfo pinfo;
                sts=gesture.QueryProfile(i,out pinfo);
                if (sts<pxcmStatus.PXCM_STATUS_NO_ERROR) break;
                sts=capture.LocateStreams(ref pinfo.inputs);
                if (sts<pxcmStatus.PXCM_STATUS_NO_ERROR) continue;
                sts=gesture.SetProfile(ref pinfo);
                if (sts>=pxcmStatus.PXCM_STATUS_NO_ERROR) break;
            }
            if (sts<pxcmStatus.PXCM_STATUS_NO_ERROR) {
                form.UpdateStatus("Failed to pair the gesture module with I/O");
                capture.Dispose();
                gesture.Dispose();
                session.Dispose();
                return;
            }

            form.UpdateStatus("Streaming");
            PXCMImage[] images = new PXCMImage[PXCMCapture.VideoStream.STREAM_LIMIT];
            PXCMScheduler.SyncPoint[] sps = new PXCMScheduler.SyncPoint[2];
            while (!form.stop)
            {
                PXCMImage.Dispose(images); 
                PXCMScheduler.SyncPoint.Dispose(sps);
                sts = capture.ReadStreamAsync(images, out sps[0]);
                if (DisplayDeviceConnection(sts == pxcmStatus.PXCM_STATUS_DEVICE_LOST)) continue;
                if (sts < pxcmStatus.PXCM_STATUS_NO_ERROR) break;

                sts = gesture.ProcessImageAsync(images, out sps[1]);
                if (sts < pxcmStatus.PXCM_STATUS_NO_ERROR) break;

                PXCMScheduler.SyncPoint.SynchronizeEx(sps);
                sts=sps[0].Synchronize();
                if (DisplayDeviceConnection(sts==pxcmStatus.PXCM_STATUS_DEVICE_LOST)) continue;
                if (sts < pxcmStatus.PXCM_STATUS_NO_ERROR) break;

                /* Display Results */
                PXCMImage depth=capture.QueryImage(images,PXCMImage.ImageType.IMAGE_TYPE_DEPTH);
                DisplayPicture(depth,gesture);
                DisplayGeoNodes(gesture);
                DisplayGesture(gesture);
                form.UpdatePanel();
            }
            PXCMImage.Dispose(images);
            PXCMScheduler.SyncPoint.Dispose(sps);

            capture.Dispose();
            gesture.Dispose();
            session.Dispose();
            form.UpdateStatus("Stopped");
        }
    }
}
