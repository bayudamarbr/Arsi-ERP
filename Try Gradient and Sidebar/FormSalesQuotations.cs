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
    public partial class FormSalesQuotations : Form
    {
        FormSalesQuotationCreate quotationCreate;
        public FormSalesQuotations()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (quotationCreate == null)
            {
                quotationCreate = new FormSalesQuotationCreate();
                quotationCreate.FormClosed += quotationCreate_FormClosed;
                quotationCreate.MdiParent = this.ParentForm;
                quotationCreate.Dock = DockStyle.Fill;
                quotationCreate.Show();
            }
            else
            {
                quotationCreate.Activate();
            }
        }

        private void quotationCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            quotationCreate = null;
        }

    }
}
