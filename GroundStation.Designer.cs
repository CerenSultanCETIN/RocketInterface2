namespace RocketInterface2
{
    partial class GroundStation
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
            teststationbutton = new Button();
            payloadbutton = new Button();
            groundstationbutton = new Button();
            rocketlogopictureBox = new PictureBox();
            alıcıayarlarıgroupBox = new GroupBox();
            connectbutton = new Button();
            label1port = new Label();
            label3port = new Label();
            label2port = new Label();
            port3radioButton = new RadioButton();
            port2radioButton = new RadioButton();
            port1radioButton = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            port4radioButton = new RadioButton();
            label4port = new Label();
            verigonderbutton = new Button();
            autoverigonderbutton = new Button();
            vericiayarlarıgroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)rocketlogopictureBox).BeginInit();
            alıcıayarlarıgroupBox.SuspendLayout();
            vericiayarlarıgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teststationbutton
            // 
            teststationbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            teststationbutton.Location = new Point(3, 240);
            teststationbutton.Name = "teststationbutton";
            teststationbutton.Size = new Size(176, 59);
            teststationbutton.TabIndex = 1;
            teststationbutton.Text = "Test Station";
            teststationbutton.UseVisualStyleBackColor = true;
            teststationbutton.Click += teststationbutton_Click;
            // 
            // payloadbutton
            // 
            payloadbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            payloadbutton.Location = new Point(3, 305);
            payloadbutton.Name = "payloadbutton";
            payloadbutton.Size = new Size(180, 59);
            payloadbutton.TabIndex = 2;
            payloadbutton.Text = "Payload";
            payloadbutton.UseVisualStyleBackColor = true;
           
            // 
            // groundstationbutton
            // 
            groundstationbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groundstationbutton.Location = new Point(3, 175);
            groundstationbutton.Name = "groundstationbutton";
            groundstationbutton.Size = new Size(176, 59);
            groundstationbutton.TabIndex = 3;
            groundstationbutton.Text = "Ground Station";
            groundstationbutton.UseVisualStyleBackColor = true;
            // 
            // rocketlogopictureBox
            // 
            rocketlogopictureBox.Image = Properties.Resources.Screenshot_2025_01_05_120618;
            rocketlogopictureBox.Location = new Point(3, 14);
            rocketlogopictureBox.Name = "rocketlogopictureBox";
            rocketlogopictureBox.Size = new Size(176, 157);
            rocketlogopictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            rocketlogopictureBox.TabIndex = 4;
            rocketlogopictureBox.TabStop = false;
            // 
            // alıcıayarlarıgroupBox
            // 
            alıcıayarlarıgroupBox.BackColor = SystemColors.ControlLight;
            alıcıayarlarıgroupBox.Controls.Add(connectbutton);
            alıcıayarlarıgroupBox.Controls.Add(label1port);
            alıcıayarlarıgroupBox.Controls.Add(label3port);
            alıcıayarlarıgroupBox.Controls.Add(label2port);
            alıcıayarlarıgroupBox.Controls.Add(port3radioButton);
            alıcıayarlarıgroupBox.Controls.Add(port2radioButton);
            alıcıayarlarıgroupBox.Controls.Add(port1radioButton);
            alıcıayarlarıgroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            alıcıayarlarıgroupBox.Location = new Point(208, 14);
            alıcıayarlarıgroupBox.Name = "alıcıayarlarıgroupBox";
            alıcıayarlarıgroupBox.Size = new Size(204, 138);
            alıcıayarlarıgroupBox.TabIndex = 5;
            alıcıayarlarıgroupBox.TabStop = false;
            alıcıayarlarıgroupBox.Text = "Alıcı Ayarları";
            // 
            // connectbutton
            // 
            connectbutton.Location = new Point(43, 109);
            connectbutton.Name = "connectbutton";
            connectbutton.Size = new Size(94, 29);
            connectbutton.TabIndex = 7;
            connectbutton.Text = "Bağlan";
            connectbutton.UseVisualStyleBackColor = true;
            connectbutton.Click += connectbutton_Click;
            // 
            // label1port
            // 
            label1port.AutoSize = true;
            label1port.BackColor = SystemColors.ControlLight;
            label1port.ForeColor = Color.FromArgb(192, 0, 0);
            label1port.Location = new Point(92, 28);
            label1port.Name = "label1port";
            label1port.Size = new Size(96, 20);
            label1port.TabIndex = 6;
            label1port.Text = "Bağlantı Yok";
            // 
            // label3port
            // 
            label3port.AutoSize = true;
            label3port.ForeColor = Color.FromArgb(192, 0, 0);
            label3port.Location = new Point(92, 83);
            label3port.Name = "label3port";
            label3port.Size = new Size(96, 20);
            label3port.TabIndex = 4;
            label3port.Text = "Bağlantı Yok";
            // 
            // label2port
            // 
            label2port.AutoSize = true;
            label2port.ForeColor = Color.FromArgb(192, 0, 0);
            label2port.Location = new Point(92, 55);
            label2port.Name = "label2port";
            label2port.Size = new Size(96, 20);
            label2port.TabIndex = 3;
            label2port.Text = "Bağlantı Yok";
            // 
            // port3radioButton
            // 
            port3radioButton.AutoSize = true;
            port3radioButton.BackColor = SystemColors.ControlDark;
            port3radioButton.Location = new Point(6, 83);
            port3radioButton.Name = "port3radioButton";
            port3radioButton.Size = new Size(73, 24);
            port3radioButton.TabIndex = 2;
            port3radioButton.TabStop = true;
            port3radioButton.Text = "Port 3";
            port3radioButton.UseVisualStyleBackColor = false;
            // 
            // port2radioButton
            // 
            port2radioButton.AutoSize = true;
            port2radioButton.BackColor = SystemColors.ControlDark;
            port2radioButton.Location = new Point(6, 53);
            port2radioButton.Name = "port2radioButton";
            port2radioButton.Size = new Size(73, 24);
            port2radioButton.TabIndex = 1;
            port2radioButton.TabStop = true;
            port2radioButton.Text = "Port 2";
            port2radioButton.UseVisualStyleBackColor = false;
            // 
            // port1radioButton
            // 
            port1radioButton.AutoSize = true;
            port1radioButton.BackColor = SystemColors.ControlDark;
            port1radioButton.Location = new Point(6, 26);
            port1radioButton.Name = "port1radioButton";
            port1radioButton.Size = new Size(73, 24);
            port1radioButton.TabIndex = 0;
            port1radioButton.TabStop = true;
            port1radioButton.Text = "Port 1";
            port1radioButton.UseVisualStyleBackColor = false;
            // 
            // port4radioButton
            // 
            port4radioButton.AutoSize = true;
            port4radioButton.BackColor = SystemColors.ControlDark;
            port4radioButton.Location = new Point(6, 34);
            port4radioButton.Name = "port4radioButton";
            port4radioButton.Size = new Size(73, 24);
            port4radioButton.TabIndex = 0;
            port4radioButton.TabStop = true;
            port4radioButton.Text = "Port 4";
            port4radioButton.UseVisualStyleBackColor = false;
            // 
            // label4port
            // 
            label4port.AutoSize = true;
            label4port.ForeColor = Color.FromArgb(192, 0, 0);
            label4port.Location = new Point(92, 36);
            label4port.Name = "label4port";
            label4port.Size = new Size(96, 20);
            label4port.TabIndex = 1;
            label4port.Text = "Bağlantı Yok";
            // 
            // verigonderbutton
            // 
            verigonderbutton.Location = new Point(0, 67);
            verigonderbutton.Name = "verigonderbutton";
            verigonderbutton.Size = new Size(107, 29);
            verigonderbutton.TabIndex = 2;
            verigonderbutton.Text = "Veri Gönder";
            verigonderbutton.UseVisualStyleBackColor = true;
            // 
            // autoverigonderbutton
            // 
            autoverigonderbutton.Location = new Point(0, 102);
            autoverigonderbutton.Name = "autoverigonderbutton";
            autoverigonderbutton.Size = new Size(107, 48);
            autoverigonderbutton.TabIndex = 7;
            autoverigonderbutton.Text = "Otomatik Veri Gönder";
            autoverigonderbutton.UseVisualStyleBackColor = true;
            // 
            // vericiayarlarıgroupBox
            // 
            vericiayarlarıgroupBox.BackColor = SystemColors.ControlLight;
            vericiayarlarıgroupBox.Controls.Add(autoverigonderbutton);
            vericiayarlarıgroupBox.Controls.Add(verigonderbutton);
            vericiayarlarıgroupBox.Controls.Add(label4port);
            vericiayarlarıgroupBox.Controls.Add(port4radioButton);
            vericiayarlarıgroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            vericiayarlarıgroupBox.Location = new Point(208, 158);
            vericiayarlarıgroupBox.Name = "vericiayarlarıgroupBox";
            vericiayarlarıgroupBox.Size = new Size(204, 156);
            vericiayarlarıgroupBox.TabIndex = 6;
            vericiayarlarıgroupBox.TabStop = false;
            vericiayarlarıgroupBox.Text = "Verici Ayarları";
            // 
            // GroundStation
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 555);
            Controls.Add(vericiayarlarıgroupBox);
            Controls.Add(alıcıayarlarıgroupBox);
            Controls.Add(rocketlogopictureBox);
            Controls.Add(groundstationbutton);
            Controls.Add(payloadbutton);
            Controls.Add(teststationbutton);
            Name = "GroundStation";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "GroundStation";
            ((System.ComponentModel.ISupportInitialize)rocketlogopictureBox).EndInit();
            alıcıayarlarıgroupBox.ResumeLayout(false);
            alıcıayarlarıgroupBox.PerformLayout();
            vericiayarlarıgroupBox.ResumeLayout(false);
            vericiayarlarıgroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button teststationbutton;
        private Button payloadbutton;
        private Button groundstationbutton;
        private PictureBox rocketlogopictureBox;
        private GroupBox alıcıayarlarıgroupBox;
        private RadioButton port3radioButton;
        private RadioButton port2radioButton;
        private RadioButton port1radioButton;
        private Label label1port;
        private Label label3port;
        private Label label2port;
        private Button connectbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton port4radioButton;
        private Label label4port;
        private Button verigonderbutton;
        private Button autoverigonderbutton;
        private GroupBox vericiayarlarıgroupBox;
    }
}