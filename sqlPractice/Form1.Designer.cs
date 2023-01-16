namespace sqlPractice
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
            this.sqltest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqltest
            // 
            this.sqltest.Location = new System.Drawing.Point(85, 74);
            this.sqltest.Name = "sqltest";
            this.sqltest.Size = new System.Drawing.Size(105, 91);
            this.sqltest.TabIndex = 0;
            this.sqltest.Text = "SQL TEST";
            this.sqltest.UseVisualStyleBackColor = true;
            this.sqltest.Click += new System.EventHandler(this.sqltest_Clicked);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sqltest);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sqltest;
    }
}

