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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbxField.SelectedIndex)
                {
                    case 0://所有订单
                        bdsOrders.DataSource = orderService.GetAllOrders();
                        break;
                    case 1://根据ID查询
                        int id = Convert.ToInt32(Keyword);
                        Order order = orderService.GetOrder(id);
                        List<Order> result = new List<Order>();
                        if (order != null) result.Add(order);
                        bdsOrders.DataSource = result;
                        break;
                    case 2://根据客户查询
                        bdsOrders.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                        break;
                    case 3://根据货物查询
                        bdsOrders.DataSource = orderService.QueryOrdersByGoodsName(Keyword);
                        break;
                    case 4://根据总价格查询（大于某个总价）
                        float totalPrice = Convert.ToInt32(Keyword);
                        bdsOrders.DataSource =
                               orderService.QueryByTotalAmount(totalPrice);
                        break;
                }
                bdsOrders.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dbvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit(new Order(), false, orderService);
            ShowEditForm(formEdit);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditOrder();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order order = bdsOrders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("选择需要进行删除操作的订单");
                return;
            }
            DialogResult result = MessageBox.Show($"确认要删除Id为{order.OrderId}的订单吗？", "删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                orderService.RemoveOrder(order.OrderId);
                QueryAll();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
