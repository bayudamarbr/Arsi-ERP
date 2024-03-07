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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void menuTransition1_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                flowLayoutPanelSales.Height += 10;
                if (flowLayoutPanelSales.Height >= 165)
                {
                    menuTransition1.Stop();
                }
            }
            else
            {
                flowLayoutPanelSales.Height -= 10;
                if (flowLayoutPanelSales.Height <= 37)
                {
                    menuTransition1.Stop();
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonDashboard, "Dashboard");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                // Mengatur kembali tinggi flowLayoutPanelSales ke ukuran aslinya
                flowLayoutPanelSales.Height = 37;

                // Menghentikan timer transisi
                menuTransition1.Stop();

                // Mengubah status menuExpand menjadi false
                menuExpand = false;
            }
            else
            {
                // Jika menu belum diperluas, maka memulai timer transisi menu untuk memperluas flowLayoutPanelSales
                menuTransition1.Start();

                // Mengubah status menuExpand menjadi true
                menuExpand = true;
            }
        }

        private void buttonSales_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonSales, "Sales");
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {

        }

        private void buttonPurchase_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonPurchase, "Purchase");
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void buttonUtility_Click(object sender, EventArgs e)
        {

        }

        private void buttonUtility_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonUtility, "Utility");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 54)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 244)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void slideNav_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSales2_Click(object sender, EventArgs e)
        {

        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {

        }

        private void buttonInventory_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonInventory, "Inventory");
        }

        private void buttonProduction_Click(object sender, EventArgs e)
        {

        }

        private void buttonProduction_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonProduction, "Production");
        }

        private void buttonAccounting_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccounting_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonAccounting, "Accounting");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonLogout, "Logout");
        }

        private void buttonMaster_Click(object sender, EventArgs e)
        {

        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {

        }
    }
}
