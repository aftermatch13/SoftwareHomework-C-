using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class Userform : Form
    {
        public void Table()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select * from orders";
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            dao.DaoClose();
        }
        public void Tablename()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from orders where name ='{textBox1.Text}'";
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            dao.DaoClose();
        }
        public void TableID()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from orders where name like'%{textBox2.Text}%'";
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            dao.DaoClose();
        }
        public Userform()
        {
            InitializeComponent();
        }
        public void Userform_load(object sender, EventArgs e)
        {
            Table();
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string p_name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string date = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string number = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                Change cg = new Change(id, name, p_name, date, number);
                cg.ShowDialog();
                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("confirm");
                if(dr == DialogResult.OK)
                {
                    string sql = $"delete from orders where id='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql)>0)
                    {
                        MessageBox.Show("delete success");
                    }
                    else
                    {
                        MessageBox.Show("delete failed");
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("Please select first");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tablename();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableID();
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            Table();
        }
    }
}
