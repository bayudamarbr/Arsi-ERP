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
    public partial class FormSalesCusAccounting : Form
    {
        FormSalesCusCreateInformation salesCusCreate;
        FormSalesCusCreateCustomer salesCustomer;
        FormSalesCusDelivery salesDelivery;
        FormSalesInvoice salesInvoice;
        FormSalesCusAccountingCreate createAccounting;

        public FormSalesCusAccounting()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (createAccounting == null)
            {
                createAccounting = new FormSalesCusAccountingCreate();
                createAccounting.FormClosed += createAccounting_FormClosed;
                createAccounting.MdiParent = this.ParentForm;
                createAccounting.Dock = DockStyle.Fill;
                createAccounting.Show();
            }
            else
            {
                createAccounting.Activate();
            }
        }

        private void createAccounting_FormClosed(object sender, FormClosedEventArgs e)
        {
            createAccounting = null;
        }
    }
}
