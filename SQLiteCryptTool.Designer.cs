namespace SQLiteCryptTool
{
    partial class SQLiteCryptTool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSQLiteDB = new System.Windows.Forms.TextBox();
            this.btnOpenSQLite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSQLiteCrypt = new System.Windows.Forms.TextBox();
            this.btnTestCrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewCrypt = new System.Windows.Forms.TextBox();
            this.lblSetCrypt = new System.Windows.Forms.Label();
            this.btnSetCrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSQLiteDB
            // 
            this.txtSQLiteDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQLiteDB.Enabled = false;
            this.txtSQLiteDB.Location = new System.Drawing.Point(13, 13);
            this.txtSQLiteDB.Name = "txtSQLiteDB";
            this.txtSQLiteDB.Size = new System.Drawing.Size(333, 21);
            this.txtSQLiteDB.TabIndex = 0;
            // 
            // btnOpenSQLite
            // 
            this.btnOpenSQLite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSQLite.Location = new System.Drawing.Point(352, 12);
            this.btnOpenSQLite.Name = "btnOpenSQLite";
            this.btnOpenSQLite.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSQLite.TabIndex = 1;
            this.btnOpenSQLite.Text = "打开数据库";
            this.btnOpenSQLite.UseVisualStyleBackColor = true;
            this.btnOpenSQLite.Click += new System.EventHandler(this.btnOpenSQLite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据库密码：";
            // 
            // txtSQLiteCrypt
            // 
            this.txtSQLiteCrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQLiteCrypt.Location = new System.Drawing.Point(88, 44);
            this.txtSQLiteCrypt.Name = "txtSQLiteCrypt";
            this.txtSQLiteCrypt.Size = new System.Drawing.Size(258, 21);
            this.txtSQLiteCrypt.TabIndex = 3;
            // 
            // btnTestCrypt
            // 
            this.btnTestCrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestCrypt.Location = new System.Drawing.Point(352, 44);
            this.btnTestCrypt.Name = "btnTestCrypt";
            this.btnTestCrypt.Size = new System.Drawing.Size(75, 23);
            this.btnTestCrypt.TabIndex = 4;
            this.btnTestCrypt.Text = "测试连接";
            this.btnTestCrypt.UseVisualStyleBackColor = true;
            this.btnTestCrypt.Click += new System.EventHandler(this.btnTestCrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "____________________________________________________________________";
            // 
            // txtNewCrypt
            // 
            this.txtNewCrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewCrypt.Location = new System.Drawing.Point(88, 84);
            this.txtNewCrypt.Name = "txtNewCrypt";
            this.txtNewCrypt.Size = new System.Drawing.Size(258, 21);
            this.txtNewCrypt.TabIndex = 7;
            // 
            // lblSetCrypt
            // 
            this.lblSetCrypt.AutoSize = true;
            this.lblSetCrypt.Location = new System.Drawing.Point(12, 88);
            this.lblSetCrypt.Name = "lblSetCrypt";
            this.lblSetCrypt.Size = new System.Drawing.Size(65, 12);
            this.lblSetCrypt.TabIndex = 6;
            this.lblSetCrypt.Text = "设置密码：";
            // 
            // btnSetCrypt
            // 
            this.btnSetCrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCrypt.Location = new System.Drawing.Point(352, 82);
            this.btnSetCrypt.Name = "btnSetCrypt";
            this.btnSetCrypt.Size = new System.Drawing.Size(75, 23);
            this.btnSetCrypt.TabIndex = 9;
            this.btnSetCrypt.Text = "设置密码";
            this.btnSetCrypt.UseVisualStyleBackColor = true;
            this.btnSetCrypt.Click += new System.EventHandler(this.btnSetCrypt_Click);
            // 
            // SQLiteCryptTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 113);
            this.Controls.Add(this.btnSetCrypt);
            this.Controls.Add(this.txtNewCrypt);
            this.Controls.Add(this.lblSetCrypt);
            this.Controls.Add(this.btnTestCrypt);
            this.Controls.Add(this.txtSQLiteCrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenSQLite);
            this.Controls.Add(this.txtSQLiteDB);
            this.Controls.Add(this.label2);
            this.Name = "SQLiteCryptTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLite密码设置工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSQLiteDB;
        private System.Windows.Forms.Button btnOpenSQLite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSQLiteCrypt;
        private System.Windows.Forms.Button btnTestCrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewCrypt;
        private System.Windows.Forms.Label lblSetCrypt;
        private System.Windows.Forms.Button btnSetCrypt;
    }
}

