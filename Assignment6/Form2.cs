using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class Form2 : Form
    {
        public OrderDetail Detail { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public FormDetailEdit(OrderDetail detail) : this()
        {
            this.Detail = detail;
            this.bdsDetail.DataSource = detail;
            bdsGoods.Add(new Goods("1", "pear", 150.0));
            bdsGoods.Add(new Goods("2", "beef", 270.0));
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
