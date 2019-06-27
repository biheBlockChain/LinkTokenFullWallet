namespace LinkTokenFullWallet.WinFormEx
{
    partial class FormSplash
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.lbAppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTick = new System.Windows.Forms.Label();
            this.lbVer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright © 2018 BiHeBlockChain. All rights reserved.";
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.BackColor = System.Drawing.Color.Transparent;
            this.lbProgress.ForeColor = System.Drawing.Color.White;
            this.lbProgress.Location = new System.Drawing.Point(38, 96);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(71, 12);
            this.lbProgress.TabIndex = 2;
            this.lbProgress.Text = "正在加载...";
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.BackColor = System.Drawing.Color.Transparent;
            this.lbAppName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAppName.ForeColor = System.Drawing.Color.White;
            this.lbAppName.Location = new System.Drawing.Point(35, 32);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(88, 25);
            this.lbAppName.TabIndex = 3;
            this.lbAppName.Text = "应用名称";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LinkTokenFullWallet.Properties.Resources.SplashProgress;
            this.pictureBox1.Location = new System.Drawing.Point(21, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 6);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTick
            // 
            this.lbTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTick.BackColor = System.Drawing.Color.Transparent;
            this.lbTick.ForeColor = System.Drawing.Color.White;
            this.lbTick.Location = new System.Drawing.Point(178, 122);
            this.lbTick.Name = "lbTick";
            this.lbTick.Size = new System.Drawing.Size(165, 12);
            this.lbTick.TabIndex = 5;
            this.lbTick.Text = "0";
            this.lbTick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbVer
            // 
            this.lbVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVer.BackColor = System.Drawing.Color.Transparent;
            this.lbVer.Font = new System.Drawing.Font("宋体", 10F);
            this.lbVer.ForeColor = System.Drawing.Color.White;
            this.lbVer.Location = new System.Drawing.Point(171, 9);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(177, 23);
            this.lbVer.TabIndex = 6;
            this.lbVer.Text = "v1.0.0";
            this.lbVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LinkTokenFullWallet.Properties.Resources.backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 180);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.lbTick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbAppName);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplash";
            this.Load += new System.EventHandler(this.FormSplash_Load);
            this.TextChanged += new System.EventHandler(this.FormSplash_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Label lbAppName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTick;
        private System.Windows.Forms.Label lbVer;
    }
}