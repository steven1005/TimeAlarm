namespace TimeAlarm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTime = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.tbTimeToAlarm = new System.Windows.Forms.TextBox();
            this.btnTimeToAlarm = new System.Windows.Forms.Button();
            this.btnTimeEndAlarm = new System.Windows.Forms.Button();
            this.tbTimeEndAlarm = new System.Windows.Forms.TextBox();
            this.lbTipTimeToAlarm = new System.Windows.Forms.Label();
            this.lbTimeRemain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTime.Location = new System.Drawing.Point(54, 24);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(51, 19);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Time";
            // 
            // tTime
            // 
            this.tTime.Enabled = true;
            this.tTime.Interval = 500;
            this.tTime.Tick += new System.EventHandler(this.tTime_Tick);
            // 
            // tbTimeToAlarm
            // 
            this.tbTimeToAlarm.Location = new System.Drawing.Point(12, 67);
            this.tbTimeToAlarm.Name = "tbTimeToAlarm";
            this.tbTimeToAlarm.Size = new System.Drawing.Size(131, 22);
            this.tbTimeToAlarm.TabIndex = 1;
            this.tbTimeToAlarm.Click += new System.EventHandler(this.tbTimeToAlarm_Click);
            // 
            // btnTimeToAlarm
            // 
            this.btnTimeToAlarm.Location = new System.Drawing.Point(175, 65);
            this.btnTimeToAlarm.Name = "btnTimeToAlarm";
            this.btnTimeToAlarm.Size = new System.Drawing.Size(57, 23);
            this.btnTimeToAlarm.TabIndex = 2;
            this.btnTimeToAlarm.Text = "Set";
            this.btnTimeToAlarm.UseVisualStyleBackColor = true;
            this.btnTimeToAlarm.Click += new System.EventHandler(this.btnTimeToAlarm_Click);
            // 
            // btnTimeEndAlarm
            // 
            this.btnTimeEndAlarm.Location = new System.Drawing.Point(175, 104);
            this.btnTimeEndAlarm.Name = "btnTimeEndAlarm";
            this.btnTimeEndAlarm.Size = new System.Drawing.Size(57, 23);
            this.btnTimeEndAlarm.TabIndex = 2;
            this.btnTimeEndAlarm.Text = "Set";
            this.btnTimeEndAlarm.UseVisualStyleBackColor = true;
            this.btnTimeEndAlarm.Click += new System.EventHandler(this.btnTimeEndAlarm_Click);
            // 
            // tbTimeEndAlarm
            // 
            this.tbTimeEndAlarm.Location = new System.Drawing.Point(12, 106);
            this.tbTimeEndAlarm.Name = "tbTimeEndAlarm";
            this.tbTimeEndAlarm.Size = new System.Drawing.Size(131, 22);
            this.tbTimeEndAlarm.TabIndex = 1;
            this.tbTimeEndAlarm.Text = "00h03m00s";
            this.tbTimeEndAlarm.Click += new System.EventHandler(this.tbTimeEndAlarm_Click);
            // 
            // lbTipTimeToAlarm
            // 
            this.lbTipTimeToAlarm.AutoSize = true;
            this.lbTipTimeToAlarm.Location = new System.Drawing.Point(12, 140);
            this.lbTipTimeToAlarm.Name = "lbTipTimeToAlarm";
            this.lbTipTimeToAlarm.Size = new System.Drawing.Size(87, 12);
            this.lbTipTimeToAlarm.TabIndex = 3;
            this.lbTipTimeToAlarm.Text = "TipTimeToAlarm";
            // 
            // lbTimeRemain
            // 
            this.lbTimeRemain.AutoSize = true;
            this.lbTimeRemain.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTimeRemain.Location = new System.Drawing.Point(12, 184);
            this.lbTimeRemain.Name = "lbTimeRemain";
            this.lbTimeRemain.Size = new System.Drawing.Size(188, 35);
            this.lbTimeRemain.TabIndex = 4;
            this.lbTimeRemain.Text = "TimeRemain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbTimeRemain);
            this.Controls.Add(this.lbTipTimeToAlarm);
            this.Controls.Add(this.btnTimeEndAlarm);
            this.Controls.Add(this.btnTimeToAlarm);
            this.Controls.Add(this.tbTimeEndAlarm);
            this.Controls.Add(this.tbTimeToAlarm);
            this.Controls.Add(this.lbTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.TextBox tbTimeToAlarm;
        private System.Windows.Forms.Button btnTimeToAlarm;
        private System.Windows.Forms.Button btnTimeEndAlarm;
        private System.Windows.Forms.TextBox tbTimeEndAlarm;
        private System.Windows.Forms.Label lbTipTimeToAlarm;
        private System.Windows.Forms.Label lbTimeRemain;
    }
}

