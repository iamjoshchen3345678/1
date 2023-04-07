namespace 計數器
{
    partial class 計數開始
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.開始計數 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 開始計數
            // 
            this.開始計數.Location = new System.Drawing.Point(250, 150);
            this.開始計數.Name = "開始計數";
            this.開始計數.Size = new System.Drawing.Size(264, 123);
            this.開始計數.TabIndex = 0;
            this.開始計數.Text = "開始計數";
            this.開始計數.UseVisualStyleBackColor = true;
            this.開始計數.Click += new System.EventHandler(this.開始計數_Click);
            // 
            // 計數開始
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.開始計數);
            this.Name = "計數開始";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 開始計數;
    }
}

