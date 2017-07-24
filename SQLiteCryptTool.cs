using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteCryptTool
{
    public partial class SQLiteCryptTool : Form
    {
        public SQLiteCryptTool()
        {
            InitializeComponent();
        }

        private void btnOpenSQLite_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;

            dlg.Title = "请选择SQLite数据库";
            dlg.Filter = "ZDB(*.zdb)|*.zdb|所有文件(*.*)|*.*";
            dlg.CheckFileExists = true;
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            txtSQLiteDB.Text = dlg.FileName;
            txtSQLiteCrypt.Enabled = true;
            txtNewCrypt.Enabled = false;
            lblSetCrypt.Enabled = false;
            btnSetCrypt.Enabled = false;
        }

        private void btnTestCrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSQLiteDB.Text))
            {
                MessageBox.Show("请选择SQLite数据库!");
                return;
            }

            string sConnString = "Data Source=" + txtSQLiteDB.Text;
            if (!string.IsNullOrEmpty(txtSQLiteCrypt.Text))
            {
                sConnString += ";Password=" + txtSQLiteCrypt.Text;
            }

            SQLiteConnection conn = new SQLiteConnection(sConnString);
            try
            {
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "select * from sqlite_master";
                DataTable dt = new DataTable("sqlite_master");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                txtSQLiteCrypt.Enabled = false;
                txtNewCrypt.Enabled = true;
                lblSetCrypt.Enabled = true;
                btnSetCrypt.Enabled = true;
                if (string.IsNullOrEmpty(txtSQLiteCrypt.Text))
                {
                    lblSetCrypt.Text = "设置密码：";
                    btnSetCrypt.Text = "设置密码";
                }
                else
                {
                    lblSetCrypt.Text = "重置密码：";
                    btnSetCrypt.Text = "重置密码";
                }
                MessageBox.Show("连接成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接测试失败，详细信息：\n\r" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSetCrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSQLiteCrypt.Text) && string.IsNullOrEmpty(txtNewCrypt.Text))
            {
                MessageBox.Show("请填写数据库密码");
                return;
            }

            if (string.IsNullOrEmpty(txtNewCrypt.Text))
            {
                if (MessageBox.Show("是否清空当前数据库密码？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
            }

            string sConnString = "Data Source=" + txtSQLiteDB.Text;
            if (!string.IsNullOrEmpty(txtSQLiteCrypt.Text))
            {
                sConnString += ";Password=" + txtSQLiteCrypt.Text;
            }

            SQLiteConnection conn = new SQLiteConnection(sConnString);
            try
            {
                conn.Open();
                conn.ChangePassword(txtNewCrypt.Text);
                txtSQLiteCrypt.Text = txtNewCrypt.Text;
                txtNewCrypt.Text = "";
                txtSQLiteCrypt.Enabled = true;
                txtNewCrypt.Enabled = false;
                lblSetCrypt.Enabled = false;
                btnSetCrypt.Enabled = false;
                MessageBox.Show("数据库密码设置成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接测试失败，详细信息：\n\r" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
