namespace gesture_viewer.cs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.PipelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Live = new System.Windows.Forms.ToolStripMenuItem();
            this.Playback = new System.Windows.Forms.ToolStripMenuItem();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoNode = new System.Windows.Forms.CheckBox();
            this.Depth = new System.Windows.Forms.RadioButton();
            this.Labelmap = new System.Windows.Forms.RadioButton();
            this.Gesture = new System.Windows.Forms.CheckBox();
            this.Params = new System.Windows.Forms.CheckBox();
            this.Status2 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Scale2 = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.PictureBox();
            this.Gesture1 = new System.Windows.Forms.PictureBox();
            this.Gesture2 = new System.Windows.Forms.PictureBox();
            this.Mirror = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            this.Status2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gesture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gesture2)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(609, 334);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 28);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(609, 369);
            this.Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(107, 28);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.sourceToolStripMenuItem.Text = "Device";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.moduleToolStripMenuItem.Text = "Module";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceToolStripMenuItem,
            this.moduleToolStripMenuItem,
            this.PipelineToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(725, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // PipelineToolStripMenuItem
            // 
            this.PipelineToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.PipelineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.PipelineToolStripMenuItem.Name = "PipelineToolStripMenuItem";
            this.PipelineToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.PipelineToolStripMenuItem.Text = "Pipeline";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Checked = true;
            this.simpleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.advancedToolStripMenuItem.Text = "Advanced";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.advancedToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Live,
            this.Playback,
            this.Record});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // Live
            // 
            this.Live.Checked = true;
            this.Live.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(136, 24);
            this.Live.Text = "Live";
            this.Live.Click += new System.EventHandler(this.Live_Click);
            // 
            // Playback
            // 
            this.Playback.Name = "Playback";
            this.Playback.Size = new System.Drawing.Size(136, 24);
            this.Playback.Text = "Playback";
            this.Playback.Click += new System.EventHandler(this.Playback_Click);
            // 
            // Record
            // 
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(136, 24);
            this.Record.Text = "Record";
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // GeoNode
            // 
            this.GeoNode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeoNode.AutoSize = true;
            this.GeoNode.Checked = true;
            this.GeoNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GeoNode.Location = new System.Drawing.Point(614, 162);
            this.GeoNode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeoNode.Name = "GeoNode";
            this.GeoNode.Size = new System.Drawing.Size(91, 21);
            this.GeoNode.TabIndex = 19;
            this.GeoNode.Text = "GeoNode";
            this.GeoNode.UseVisualStyleBackColor = true;
            // 
            // Depth
            // 
            this.Depth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Depth.AutoSize = true;
            this.Depth.Checked = true;
            this.Depth.Location = new System.Drawing.Point(614, 33);
            this.Depth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(67, 21);
            this.Depth.TabIndex = 20;
            this.Depth.TabStop = true;
            this.Depth.Text = "Depth";
            this.Depth.UseVisualStyleBackColor = true;
            // 
            // Labelmap
            // 
            this.Labelmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Labelmap.AutoSize = true;
            this.Labelmap.Location = new System.Drawing.Point(613, 62);
            this.Labelmap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Labelmap.Name = "Labelmap";
            this.Labelmap.Size = new System.Drawing.Size(91, 21);
            this.Labelmap.TabIndex = 21;
            this.Labelmap.Text = "Labelmap";
            this.Labelmap.UseVisualStyleBackColor = true;
            // 
            // Gesture
            // 
            this.Gesture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gesture.AutoSize = true;
            this.Gesture.Checked = true;
            this.Gesture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Gesture.Location = new System.Drawing.Point(612, 191);
            this.Gesture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gesture.Name = "Gesture";
            this.Gesture.Size = new System.Drawing.Size(81, 21);
            this.Gesture.TabIndex = 23;
            this.Gesture.Text = "Gesture";
            this.Gesture.UseVisualStyleBackColor = true;
            // 
            // Params
            // 
            this.Params.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Params.AutoSize = true;
            this.Params.Checked = true;
            this.Params.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Params.Location = new System.Drawing.Point(612, 219);
            this.Params.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Params.Name = "Params";
            this.Params.Size = new System.Drawing.Size(78, 21);
            this.Params.TabIndex = 24;
            this.Params.Text = "Params";
            this.Params.UseVisualStyleBackColor = true;
            // 
            // Status2
            // 
            this.Status2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.Status2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Status2.Location = new System.Drawing.Point(0, 541);
            this.Status2.Name = "Status2";
            this.Status2.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.Status2.Size = new System.Drawing.Size(725, 25);
            this.Status2.TabIndex = 25;
            this.Status2.Text = "Status2";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(29, 20);
            this.StatusLabel.Text = "OK";
            // 
            // Scale2
            // 
            this.Scale2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Scale2.AutoSize = true;
            this.Scale2.Location = new System.Drawing.Point(615, 90);
            this.Scale2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Scale2.Name = "Scale2";
            this.Scale2.Size = new System.Drawing.Size(65, 21);
            this.Scale2.TabIndex = 26;
            this.Scale2.Text = "Scale";
            this.Scale2.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.ErrorImage = null;
            this.Panel2.InitialImage = null;
            this.Panel2.Location = new System.Drawing.Point(16, 33);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(583, 501);
            this.Panel2.TabIndex = 27;
            this.Panel2.TabStop = false;
            // 
            // Gesture1
            // 
            this.Gesture1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gesture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gesture1.ErrorImage = null;
            this.Gesture1.InitialImage = null;
            this.Gesture1.Location = new System.Drawing.Point(609, 266);
            this.Gesture1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gesture1.Name = "Gesture1";
            this.Gesture1.Size = new System.Drawing.Size(49, 45);
            this.Gesture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gesture1.TabIndex = 28;
            this.Gesture1.TabStop = false;
            // 
            // Gesture2
            // 
            this.Gesture2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gesture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gesture2.ErrorImage = null;
            this.Gesture2.InitialImage = null;
            this.Gesture2.Location = new System.Drawing.Point(666, 266);
            this.Gesture2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gesture2.Name = "Gesture2";
            this.Gesture2.Size = new System.Drawing.Size(49, 45);
            this.Gesture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gesture2.TabIndex = 29;
            this.Gesture2.TabStop = false;
            // 
            // Mirror
            // 
            this.Mirror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mirror.AutoSize = true;
            this.Mirror.Checked = true;
            this.Mirror.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Mirror.Location = new System.Drawing.Point(611, 118);
            this.Mirror.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(67, 21);
            this.Mirror.TabIndex = 30;
            this.Mirror.Text = "Mirror";
            this.Mirror.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mirror);
            this.Controls.Add(this.Gesture2);
            this.Controls.Add(this.Gesture1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Scale2);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.Params);
            this.Controls.Add(this.Gesture);
            this.Controls.Add(this.Labelmap);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.GeoNode);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Intel(R) Perceptual Computing SDK 2013: Gesture Viewer";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Status2.ResumeLayout(false);
            this.Status2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gesture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gesture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.CheckBox GeoNode;
        private System.Windows.Forms.RadioButton Depth;
        private System.Windows.Forms.RadioButton Labelmap;
        private System.Windows.Forms.CheckBox Gesture;
        private System.Windows.Forms.CheckBox Params;
        private System.Windows.Forms.StatusStrip Status2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.CheckBox Scale2;
        private System.Windows.Forms.PictureBox Panel2;
        private System.Windows.Forms.PictureBox Gesture1;
        private System.Windows.Forms.PictureBox Gesture2;
        private System.Windows.Forms.CheckBox Mirror;
        private System.Windows.Forms.ToolStripMenuItem PipelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Live;
        private System.Windows.Forms.ToolStripMenuItem Playback;
        private System.Windows.Forms.ToolStripMenuItem Record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}