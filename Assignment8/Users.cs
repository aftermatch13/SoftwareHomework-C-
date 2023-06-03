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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userform uf = new Userform();
            uf.ShowDialog();
        }
    }
}
