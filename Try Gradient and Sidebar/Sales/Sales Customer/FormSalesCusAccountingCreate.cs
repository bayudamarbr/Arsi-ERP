using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_Gradient_and_Sidebar
{
    public partial class FormSalesCusAccountingCreate : Form
    {
        FormSalesCusCreateInformation salesCusCreate;
        FormSalesCusCreateCustomer salesCustomer;
        FormSalesCusDelivery salesDelivery;
        FormSalesInvoice salesInvoice;
        FormSalesCusAccounting salesAcounting;
        public FormSalesCusAccountingCreate()
        {
            InitializeComponent();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            if (salesCusCreate == null)
            {
                salesCusCreate = new FormSalesCusCreateInformation();
                salesCusCreate.FormClosed += salesCusCreate_FormClosed;
                salesCusCreate.MdiParent = this.ParentForm;
                salesCusCreate.Dock = DockStyle.Fill;
                salesCusCreate.Show();
            }
            else
            {
                salesCusCreate.Activate();
            }
        }

        private void salesCusCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesCusCreate = null;
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            {
                if (salesInvoice == null)
                {
                    salesInvoice = new FormSalesInvoice();
                    salesInvoice.FormClosed += salesInvoice_FormClosed;
                    salesInvoice.MdiParent = this.ParentForm;
                    salesInvoice.Dock = DockStyle.Fill;
                    salesInvoice.Show();
                }
                else
                {
                    salesInvoice.Activate();
                }
            }

        }

        private void salesInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesInvoice = null;
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            if (salesCustomer == null)
            {
                salesCustomer = new FormSalesCusCreateCustomer();
                salesCustomer.FormClosed += FormSalesCustomer_FormClosed;
                salesCustomer.MdiParent = this.ParentForm;
                salesCustomer.Dock = DockStyle.Fill;
                salesCustomer.Show();
            }
            else
            {
                salesCustomer.Activate();
            }
        }

        private void FormSalesCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesCustomer = null;
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            if (salesDelivery == null)
            {
                salesDelivery = new FormSalesCusDelivery();
                salesDelivery.FormClosed += FormSalesDelivery_FormClosed;
                salesDelivery.MdiParent = this.ParentForm;
                salesDelivery.Dock = DockStyle.Fill;
                salesDelivery.Show();
            }
            else
            {
                salesDelivery.Activate();
            }
        }

        private void FormSalesDelivery_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesDelivery = null;
        }

        private void buttonAccounting_Click(object sender, EventArgs e)
        {
            if (salesAcounting == null)
            {
                salesAcounting = new FormSalesCusAccounting();
                salesAcounting.FormClosed += FormSalesAccounting_FormClosed;
                salesAcounting.MdiParent = this.ParentForm;
                salesAcounting.Dock = DockStyle.Fill;
                salesAcounting.Show();
            }
            else
            {
                salesAcounting.Activate();
            }
        }

        private void FormSalesAccounting_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesAcounting = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
