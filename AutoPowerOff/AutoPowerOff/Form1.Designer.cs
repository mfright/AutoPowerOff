namespace AutoPowerOff
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.myTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(250, 27);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "00分後にシャットダウン";
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.lblCountDown.Location = new System.Drawing.Point(12, 57);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(105, 40);
            this.lblCountDown.TabIndex = 1;
            this.lblCountDown.Text = "00:00";
            // 
            // myTimer1
            // 
            this.myTimer1.Enabled = true;
            this.myTimer1.Interval = 1000;
            this.myTimer1.Tick += new System.EventHandler(this.myTimer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 127);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoPowerOff";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer myTimer1;
    }
}

