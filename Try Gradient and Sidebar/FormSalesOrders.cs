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
    public partial class FormSalesOrders : Form
    {
        FormSalesOrderCreate orderCreate;
        public FormSalesOrders()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (orderCreate == null)
            {
                orderCreate = new FormSalesOrderCreate();
                orderCreate.FormClosed += orderCreate_FormClosed;
                orderCreate.MdiParent = this.ParentForm;
                orderCreate.Dock = DockStyle.Fill;
                orderCreate.Show();
            }
            else
            {
                orderCreate.Activate();
            }
        }

        private void orderCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderCreate = null;
        }

    }
}
