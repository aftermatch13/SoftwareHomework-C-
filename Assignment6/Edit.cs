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

    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FormDetailEdit formItemEdit = new FormDetailEdit(new OrderDetail());
            try
            {
                if (formItemEdit.ShowDialog() == DialogResult.OK)
                {
                    int index = 0;
                    if (CurrentOrder.Details.Count != 0)
                    {
                        index = CurrentOrder.Details.Max(i => i.Index) + 1;
                    }
                    formItemEdit.Detail.Index = index;
                    CurrentOrder.AddItem(formItemEdit.Detail);
                    bdsDetails.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            EditDetail();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bdsDetails.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveDetail(detail);
            bdsDetails.ResetBindings(false);
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
