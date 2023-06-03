using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="" && textBox2.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("The input is error,try again");
            }
        }
        public void login()
        {
            if(radioButton1.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from T_user where id= '"+textBox1.Text+"'and password = '"+textBox2.Text+"'";
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    Data.UID = dr["id"].ToString();
                    Data.Uname = dr["name"].ToString();
                    MessageBox.Show("Login Success!");
                    Users user = new Users();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
                dao.DaoClose();
            }
            if(radioButton2.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from T_admin where id= '" + textBox1.Text + "'and password = '" + textBox2.Text + "'";
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    MessageBox.Show("Login Success!");
                    Admin ad = new Admin();
                    this.Hide();
                    ad.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
                dao.DaoClose();
            }
            MessageBox.Show("Please Select your Login manner");
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
