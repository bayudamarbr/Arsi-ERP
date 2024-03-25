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
    public partial class FormSalesCusCreateInformation : Form
    {

        FormSalesInvoice FormSalesInvoice;
        FormSalesCusAccounting salesAcounting;
        FormSalesCusCreateCustomer salesCustomer;
        FormSalesCusDelivery salesDelivery;
        public FormSalesCusCreateInformation()
        {
            InitializeComponent();
        }


        private void FormSalesCusCreate_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownEmployess_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownTurnover_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void buttonInvoice_Click_2(object sender, EventArgs e)
        {
            if (FormSalesInvoice == null)
            {
                FormSalesInvoice = new FormSalesInvoice();
                FormSalesInvoice.FormClosed += FormSalesInvoice_FormClosed;
                FormSalesInvoice.MdiParent = this.ParentForm;
                FormSalesInvoice.Dock = DockStyle.Fill;
                FormSalesInvoice.Show();
            }
            else
            {
                FormSalesInvoice.Activate();
            }
        }

        private void FormSalesInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormSalesInvoice = null;
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {

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

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
