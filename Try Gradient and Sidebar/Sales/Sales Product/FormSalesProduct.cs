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
    public partial class FormSalesProduct : Form
    {
        FormSalesProductCreate productCreate;
        public FormSalesProduct()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (productCreate == null)
            {
                productCreate = new FormSalesProductCreate();
                productCreate.FormClosed += productCreate_FormClosed;
                productCreate.MdiParent = this.ParentForm;
                productCreate.Dock = DockStyle.Fill;
                productCreate.Show();
            }
            else
            {
                productCreate.Activate();
            }
        }

        private void productCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            productCreate = null;
        }
    }
}
