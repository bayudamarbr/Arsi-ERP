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
    public partial class FormSalesInvoice : Form
    {
        FormSalesCusCreateInformation salesCusCreate;
        FormSalesCusAccounting salesAcounting;
        FormSalesCusCreateCustomer salesCustomer;
        FormSalesCusDelivery salesDelivery;
        public FormSalesInvoice()
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

        private void FormSalesInvoice_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void buttonAccounting_Click_1(object sender, EventArgs e)
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

        private void buttonCustomer_Click_1(object sender, EventArgs e)
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

        private void buttonDelivery_Click_1(object sender, EventArgs e)
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

        private void buttonInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
