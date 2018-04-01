namespace Diversified_Code_Challenge
{
    partial class Form1
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
            this.onOffBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.volLbl = new System.Windows.Forms.Label();
            this.volTrackBar = new System.Windows.Forms.TrackBar();
            this.volTxtLbl = new System.Windows.Forms.Label();
            this.muteBtn = new System.Windows.Forms.Button();
            this.vgaBtn1 = new System.Windows.Forms.RadioButton();
            this.vgaBtn2 = new System.Windows.Forms.RadioButton();
            this.videoBtn = new System.Windows.Forms.RadioButton();
            this.CompoBtn = new System.Windows.Forms.RadioButton();
            this.hdmiBtn1 = new System.Windows.Forms.RadioButton();
            this.hdmiBtn2 = new System.Windows.Forms.RadioButton();
            this.LanNetworkBtn = new System.Windows.Forms.RadioButton();
            this.deviceName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lampLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lampLifeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.volTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // onOffBtn
            // 
            this.onOffBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.onOffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onOffBtn.Location = new System.Drawing.Point(307, 69);
            this.onOffBtn.Name = "onOffBtn";
            this.onOffBtn.Size = new System.Drawing.Size(90, 82);
            this.onOffBtn.TabIndex = 0;
            this.onOffBtn.UseVisualStyleBackColor = true;
            this.onOffBtn.Click += new System.EventHandler(this.onOffBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Power";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(12, 393);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(149, 47);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // volLbl
            // 
            this.volLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volLbl.AutoSize = true;
            this.volLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volLbl.Location = new System.Drawing.Point(307, 217);
            this.volLbl.Name = "volLbl";
            this.volLbl.Size = new System.Drawing.Size(90, 25);
            this.volLbl.TabIndex = 3;
            this.volLbl.Text = "Volume";
            // 
            // volTrackBar
            // 
            this.volTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volTrackBar.Location = new System.Drawing.Point(227, 255);
            this.volTrackBar.Name = "volTrackBar";
            this.volTrackBar.Size = new System.Drawing.Size(254, 45);
            this.volTrackBar.TabIndex = 4;
            this.volTrackBar.Scroll += new System.EventHandler(this.volTrackBar_Scroll);
            // 
            // volTxtLbl
            // 
            this.volTxtLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volTxtLbl.AutoSize = true;
            this.volTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volTxtLbl.Location = new System.Drawing.Point(498, 255);
            this.volTxtLbl.Name = "volTxtLbl";
            this.volTxtLbl.Size = new System.Drawing.Size(24, 25);
            this.volTxtLbl.TabIndex = 5;
            this.volTxtLbl.Text = "0";
            // 
            // muteBtn
            // 
            this.muteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.muteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteBtn.Location = new System.Drawing.Point(578, 246);
            this.muteBtn.Name = "muteBtn";
            this.muteBtn.Size = new System.Drawing.Size(134, 34);
            this.muteBtn.TabIndex = 6;
            this.muteBtn.Text = "Mute";
            this.muteBtn.UseVisualStyleBackColor = true;
            this.muteBtn.Click += new System.EventHandler(this.muteBtn_Click);
            // 
            // vgaBtn1
            // 
            this.vgaBtn1.AutoSize = true;
            this.vgaBtn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.vgaBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vgaBtn1.Location = new System.Drawing.Point(30, 94);
            this.vgaBtn1.Name = "vgaBtn1";
            this.vgaBtn1.Size = new System.Drawing.Size(92, 29);
            this.vgaBtn1.TabIndex = 7;
            this.vgaBtn1.TabStop = true;
            this.vgaBtn1.Text = "VGA 1";
            this.vgaBtn1.UseVisualStyleBackColor = true;
            this.vgaBtn1.CheckedChanged += new System.EventHandler(this.vgaBtn1_CheckedChanged);
            // 
            // vgaBtn2
            // 
            this.vgaBtn2.AutoSize = true;
            this.vgaBtn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.vgaBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vgaBtn2.Location = new System.Drawing.Point(30, 126);
            this.vgaBtn2.Name = "vgaBtn2";
            this.vgaBtn2.Size = new System.Drawing.Size(92, 29);
            this.vgaBtn2.TabIndex = 8;
            this.vgaBtn2.TabStop = true;
            this.vgaBtn2.Text = "VGA 2";
            this.vgaBtn2.UseVisualStyleBackColor = true;
            this.vgaBtn2.CheckedChanged += new System.EventHandler(this.vgaBtn2_CheckedChanged);
            // 
            // videoBtn
            // 
            this.videoBtn.AutoSize = true;
            this.videoBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.videoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoBtn.Location = new System.Drawing.Point(30, 159);
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Size = new System.Drawing.Size(85, 29);
            this.videoBtn.TabIndex = 9;
            this.videoBtn.TabStop = true;
            this.videoBtn.Text = "Video";
            this.videoBtn.UseVisualStyleBackColor = true;
            this.videoBtn.CheckedChanged += new System.EventHandler(this.videoBtn_CheckedChanged);
            // 
            // CompoBtn
            // 
            this.CompoBtn.AutoSize = true;
            this.CompoBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.CompoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompoBtn.Location = new System.Drawing.Point(30, 191);
            this.CompoBtn.Name = "CompoBtn";
            this.CompoBtn.Size = new System.Drawing.Size(140, 29);
            this.CompoBtn.TabIndex = 10;
            this.CompoBtn.TabStop = true;
            this.CompoBtn.Text = "Component";
            this.CompoBtn.UseVisualStyleBackColor = true;
            this.CompoBtn.CheckedChanged += new System.EventHandler(this.CompoBtn_CheckedChanged);
            // 
            // hdmiBtn1
            // 
            this.hdmiBtn1.AutoSize = true;
            this.hdmiBtn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.hdmiBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdmiBtn1.Location = new System.Drawing.Point(30, 217);
            this.hdmiBtn1.Name = "hdmiBtn1";
            this.hdmiBtn1.Size = new System.Drawing.Size(101, 29);
            this.hdmiBtn1.TabIndex = 11;
            this.hdmiBtn1.TabStop = true;
            this.hdmiBtn1.Text = "HDMI 1";
            this.hdmiBtn1.UseVisualStyleBackColor = true;
            this.hdmiBtn1.CheckedChanged += new System.EventHandler(this.hdmiBtn1_CheckedChanged);
            // 
            // hdmiBtn2
            // 
            this.hdmiBtn2.AutoSize = true;
            this.hdmiBtn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.hdmiBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdmiBtn2.Location = new System.Drawing.Point(30, 242);
            this.hdmiBtn2.Name = "hdmiBtn2";
            this.hdmiBtn2.Size = new System.Drawing.Size(101, 29);
            this.hdmiBtn2.TabIndex = 12;
            this.hdmiBtn2.TabStop = true;
            this.hdmiBtn2.Text = "HDMI 2";
            this.hdmiBtn2.UseVisualStyleBackColor = true;
            this.hdmiBtn2.CheckedChanged += new System.EventHandler(this.hdmiBtn2_CheckedChanged);
            // 
            // LanNetworkBtn
            // 
            this.LanNetworkBtn.AutoSize = true;
            this.LanNetworkBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.LanNetworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanNetworkBtn.Location = new System.Drawing.Point(30, 265);
            this.LanNetworkBtn.Name = "LanNetworkBtn";
            this.LanNetworkBtn.Size = new System.Drawing.Size(155, 29);
            this.LanNetworkBtn.TabIndex = 13;
            this.LanNetworkBtn.TabStop = true;
            this.LanNetworkBtn.Text = "LAN/Network";
            this.LanNetworkBtn.UseVisualStyleBackColor = true;
            this.LanNetworkBtn.CheckedChanged += new System.EventHandler(this.LanNetworkBtn_CheckedChanged);
            // 
            // deviceName
            // 
            this.deviceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deviceName.AutoSize = true;
            this.deviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceName.Location = new System.Drawing.Point(339, 397);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(142, 20);
            this.deviceName.TabIndex = 14;
            this.deviceName.Text = "No device selected";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Device Input";
            // 
            // lampLbl
            // 
            this.lampLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lampLbl.AutoSize = true;
            this.lampLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lampLbl.Location = new System.Drawing.Point(560, 69);
            this.lampLbl.Name = "lampLbl";
            this.lampLbl.Size = new System.Drawing.Size(117, 24);
            this.lampLbl.TabIndex = 17;
            this.lampLbl.Text = "Lamp 1 Life";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lampLifeTextBox
            // 
            this.lampLifeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lampLifeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lampLifeTextBox.Location = new System.Drawing.Point(564, 126);
            this.lampLifeTextBox.Name = "lampLifeTextBox";
            this.lampLifeTextBox.Size = new System.Drawing.Size(148, 26);
            this.lampLifeTextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(733, 452);
            this.Controls.Add(this.lampLifeTextBox);
            this.Controls.Add(this.lampLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceName);
            this.Controls.Add(this.LanNetworkBtn);
            this.Controls.Add(this.hdmiBtn2);
            this.Controls.Add(this.hdmiBtn1);
            this.Controls.Add(this.CompoBtn);
            this.Controls.Add(this.videoBtn);
            this.Controls.Add(this.vgaBtn2);
            this.Controls.Add(this.vgaBtn1);
            this.Controls.Add(this.muteBtn);
            this.Controls.Add(this.volTxtLbl);
            this.Controls.Add(this.volTrackBar);
            this.Controls.Add(this.volLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onOffBtn);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEC Projector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onOffBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label volLbl;
        private System.Windows.Forms.TrackBar volTrackBar;
        private System.Windows.Forms.Label volTxtLbl;
        private System.Windows.Forms.Button muteBtn;
        private System.Windows.Forms.RadioButton vgaBtn1;
        private System.Windows.Forms.RadioButton vgaBtn2;
        private System.Windows.Forms.RadioButton videoBtn;
        private System.Windows.Forms.RadioButton CompoBtn;
        private System.Windows.Forms.RadioButton hdmiBtn1;
        private System.Windows.Forms.RadioButton hdmiBtn2;
        private System.Windows.Forms.RadioButton LanNetworkBtn;
        private System.Windows.Forms.Label deviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lampLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox lampLifeTextBox;
    }
}

