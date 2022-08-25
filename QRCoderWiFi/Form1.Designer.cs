
namespace QRCoderWiFi
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbWiFiSSID = new System.Windows.Forms.Label();
            this.txtMyWiFisName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbWiFiPassword = new System.Windows.Forms.Label();
            this.txttxtMyWiFisPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWiFiSSID
            // 
            this.lbWiFiSSID.AccessibleDescription = "0";
            this.lbWiFiSSID.AutoSize = true;
            this.lbWiFiSSID.Location = new System.Drawing.Point(8, 16);
            this.lbWiFiSSID.Name = "lbWiFiSSID";
            this.lbWiFiSSID.Size = new System.Drawing.Size(65, 12);
            this.lbWiFiSSID.TabIndex = 0;
            this.lbWiFiSSID.Text = "WiFi SSID:";
            // 
            // txtMyWiFisName
            // 
            this.txtMyWiFisName.Location = new System.Drawing.Point(79, 12);
            this.txtMyWiFisName.Name = "txtMyWiFisName";
            this.txtMyWiFisName.Size = new System.Drawing.Size(83, 21);
            this.txtMyWiFisName.TabIndex = 1;
            this.txtMyWiFisName.Text = "HellWiFi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create QR Coder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbWiFiPassword
            // 
            this.lbWiFiPassword.AccessibleDescription = "0";
            this.lbWiFiPassword.AutoSize = true;
            this.lbWiFiPassword.Location = new System.Drawing.Point(170, 17);
            this.lbWiFiPassword.Name = "lbWiFiPassword";
            this.lbWiFiPassword.Size = new System.Drawing.Size(89, 12);
            this.lbWiFiPassword.TabIndex = 2;
            this.lbWiFiPassword.Text = "WiFi Password:";
            // 
            // txttxtMyWiFisPassword
            // 
            this.txttxtMyWiFisPassword.Location = new System.Drawing.Point(265, 13);
            this.txttxtMyWiFisPassword.Name = "txttxtMyWiFisPassword";
            this.txttxtMyWiFisPassword.Size = new System.Drawing.Size(110, 21);
            this.txttxtMyWiFisPassword.TabIndex = 3;
            this.txttxtMyWiFisPassword.Text = "123456789";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(10, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttxtMyWiFisPassword);
            this.Controls.Add(this.lbWiFiPassword);
            this.Controls.Add(this.txtMyWiFisName);
            this.Controls.Add(this.lbWiFiSSID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "WiFi Info QR Coder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWiFiSSID;
        private System.Windows.Forms.TextBox txtMyWiFisName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbWiFiPassword;
        private System.Windows.Forms.TextBox txttxtMyWiFisPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

