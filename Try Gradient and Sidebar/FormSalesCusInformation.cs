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
    }
}
