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

    public partial class Change : Form
    {
        string ID = "";
        public Change()
        {
            InitializeComponent();
        }
        public Change(string id, string name, string p_name, string date, string number)
        {
            InitializeComponent();
            textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = p_name;
            textBox4.Text = date;
            textBox5.Text = number;

        }

        private void Change_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update orders set id = '{textBox1.Text}',[name] = '{textBox2.Text}',[auther]='{textBox3.Text}',[date]='{textBox4.Text}',[number]='{textBox5.Text}'";
            Dao dao = new Dao();
            if(dao.Execute(sql)>0){
                MessageBox.Show("Change Success");
            }
        }
    }
}
