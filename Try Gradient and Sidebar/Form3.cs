using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Try_Gradient_and_Sidebar
{
    public partial class Form3 : Form
    {
        FormSalesCus salesCus;
        FormDashboard dashboard;
        FormSalesCusCreateInformation salesCusCreate;
        FormSalesContact salesContact;
        FormSalesProduct salesProduct;
        FormSalesQuotations salesQuotations;
        FormSalesOrders salesOrders;
        FormSalesDeliveryOrder salesDelivery;
        FormSalesReportSalesman reportSalesman;
        FormSalesReportSalesManager reportSalesManager;
        FormSalesReportSalesDetail reportSalesDetail;
        FormSalesReportTurnoverStudy reportTurnoverStudy;
        FormSalesReportCustomer reportCustomer;
        public Form3(string username)
        {
            InitializeComponent();
            label3.Text = username;
            this.Load += Form3_Load;
            this.MdiChildActivate += Form3_MdiChildActivate;
        }

        bool menuExpand = false;

        private void menuTransition1_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                flowLayoutPanelSales.Height += 10;
                if (flowLayoutPanelSales.Height >= 333)
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
                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    buttonDashboard.Width = 48;
                    buttonSales.Width = 48;
                    buttonPurchase.Width = 48;
                    buttonInventory.Width = 48;
                    buttonProduction.Width = 48;
                    buttonAccounting.Width = 48;
                    buttonUtility.Width = 48;
                    buttonLogout.Width = 48;
                    buttonSalesCustomer.Width = 48;
                    buttonSalesContacts.Width = 48;
                    buttonSalesProducts.Width = 48;
                    buttonSQ.Width = 48;
                    buttonSO.Width = 48;
                    buttonDO.Width = 48;
                    buttonSlsReport.Width = 48;
                    buttonSalesman.Width = 48;
                    buttonSM.Width = 48;
                    buttonSD.Width = 48;
                    buttonTS.Width = 48;
                    buttonCT.Width = 48;



                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 244)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    buttonDashboard.Width = sidebar.Width;
                    buttonSales.Width = sidebar.Width;
                    buttonPurchase.Width = sidebar.Width;
                    buttonInventory.Width = sidebar.Width;
                    buttonProduction.Width = sidebar.Width;
                    buttonAccounting.Width = sidebar.Width;
                    buttonUtility.Width = sidebar.Width;
                    buttonLogout.Width = sidebar.Width;
                    buttonSalesCustomer.Width = sidebar.Width;
                    buttonSalesContacts.Width = sidebar.Width;
                    buttonSalesProducts.Width = sidebar.Width;
                    buttonSQ.Width = sidebar.Width;
                    buttonSO.Width = sidebar.Width;
                    buttonDO.Width = sidebar.Width;
                    buttonSlsReport.Width = sidebar.Width;
                    buttonSalesman.Width = sidebar.Width;
                    buttonSM.Width = sidebar.Width;
                    buttonSD.Width = sidebar.Width;
                    buttonTS.Width = sidebar.Width;
                    buttonCT.Width = sidebar.Width;
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

        private void UpdateDashboardLabel()
        {
            if (this.ActiveMdiChild != null)
            {
                this.labelTittle.Text = this.ActiveMdiChild.Text;
            }
            else
            {
                this.labelTittle.Text = "Welcome to ERP Desktop App";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UpdateDashboardLabel();
            buttonSales.Height = 37;
        }

        private void Form3_MdiChildActivate(object sender, EventArgs e)
        {
            UpdateDashboardLabel();
            buttonSales.Height = 37;
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new FormDashboard();
                dashboard.FormClosed += dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            if (salesCus == null)
            {
                salesCus = new FormSalesCus();
                salesCus.FormClosed += salesCus_FormClosed;
                salesCus.MdiParent = this;
                salesCus.Dock = DockStyle.Fill;
                salesCus.Show();
            }
            else
            {
                salesCus.Activate();
            }
        }

        private void salesCus_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesCus = null;
        }

        private void buttonSalesContacts_Click(object sender, EventArgs e)
        {
            if (salesContact == null)
            {
                salesContact = new FormSalesContact();
                salesContact.FormClosed += salesContact_FormClosed;
                salesContact.MdiParent = this;
                salesContact.Dock = DockStyle.Fill;
                salesContact.Show();
            }
            else
            {
                salesContact.Activate();
            }
        }

        private void salesContact_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesContact = null;
        }

        private void buttonSalesProducts_Click(object sender, EventArgs e)
        {
            if (salesProduct == null)
            {
                salesProduct = new FormSalesProduct();
                salesProduct.FormClosed += salesProduct_FormClosed;
                salesProduct.MdiParent = this;
                salesProduct.Dock = DockStyle.Fill;
                salesProduct.Show();
            }
            else
            {
                salesProduct.Activate();
            }
        }

        private void salesProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesProduct = null;
        }

        private void buttonSQ_Click(object sender, EventArgs e)
        {
            if (salesQuotations == null)
            {
                salesQuotations = new FormSalesQuotations();
                salesQuotations.FormClosed += salesQuotations_FormClosed;
                salesQuotations.MdiParent = this;
                salesQuotations.Dock = DockStyle.Fill;
                salesQuotations.Show();
            }
            else
            {
                salesQuotations.Activate();
            }
        }

        private void salesQuotations_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesQuotations = null;
        }

        private void buttonSO_Click(object sender, EventArgs e)
        {
            if (salesOrders == null)
            {
                salesOrders = new FormSalesOrders();
                salesOrders.FormClosed += salesOrders_FormClosed;
                salesOrders.MdiParent = this;
                salesOrders.Dock = DockStyle.Fill;
                salesOrders.Show();
            }
            else
            {
                salesOrders.Activate();
            }
        }

        private void salesOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesOrders = null;
        }

        private void buttonDO_Click(object sender, EventArgs e)
        {
            if (salesDelivery == null)
            {
                salesDelivery = new FormSalesDeliveryOrder();
                salesDelivery.FormClosed += salesDelivery_FormClosed;
                salesDelivery.MdiParent = this;
                salesDelivery.Dock = DockStyle.Fill;
                salesDelivery.Show();
            }
            else
            {
                salesDelivery.Activate();
            }
        }

        private void salesDelivery_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesDelivery = null;
        }

        private void buttonSlsReport_Click(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                // Menghentikan timer transisi jika sedang berjalan
                menuTransition1.Stop();

                // Memperbarui tinggi flowLayoutPanelSales menjadi 518
                flowLayoutPanelSales.Height = 518;

                // Memulai kembali timer transisi
                menuTransition1.Start();
            }
            else
            {
                // Menghentikan timer transisi jika sedang berjalan
                menuTransition1.Stop();

                // Memperbarui tinggi flowLayoutPanelSales menjadi 333
                flowLayoutPanelSales.Height = 333;

                // Memulai kembali timer transisi
                menuTransition1.Start();
            }
        }







        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSalesman_Click(object sender, EventArgs e)
        {
            if (reportSalesman == null)
            {
                reportSalesman = new FormSalesReportSalesman();
                reportSalesman.FormClosed += reportSalesman_FormClosed;
                reportSalesman.MdiParent = this;
                reportSalesman.Dock = DockStyle.Fill;
                reportSalesman.Show();
            }
            else
            {
                reportSalesman.Activate();
            }
        }

        private void reportSalesman_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportSalesman = null;
        }

        private void buttonSM_Click(object sender, EventArgs e)
        {
            if (reportSalesManager == null)
            {
                reportSalesManager = new FormSalesReportSalesManager();
                reportSalesManager.FormClosed += reportSalesManager_FormClosed;
                reportSalesManager.MdiParent = this;
                reportSalesManager.Dock = DockStyle.Fill;
                reportSalesManager.Show();
            }
            else
            {
                reportSalesManager.Activate();
            }
        }

        private void reportSalesManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportSalesManager = null;
        }

        private void buttonSD_Click(object sender, EventArgs e)
        {
            if (reportSalesDetail == null)
            {
                reportSalesDetail = new FormSalesReportSalesDetail();
                reportSalesDetail.FormClosed += reportSalesDetail_FormClosed;
                reportSalesDetail.MdiParent = this;
                reportSalesDetail.Dock = DockStyle.Fill;
                reportSalesDetail.Show();
            }
            else
            {
                reportSalesDetail.Activate();
            }
        }

        private void reportSalesDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportSalesDetail = null;
        }

        private void buttonTS_Click(object sender, EventArgs e)
        {
            if (reportTurnoverStudy == null)
            {
                reportTurnoverStudy = new FormSalesReportTurnoverStudy();
                reportTurnoverStudy.FormClosed += reportTurnoverStudy_FormClosed;
                reportTurnoverStudy.MdiParent = this;
                reportTurnoverStudy.Dock = DockStyle.Fill;
                reportTurnoverStudy.Show();
            }
            else
            {
                reportTurnoverStudy.Activate();
            }
        }

        private void reportTurnoverStudy_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportTurnoverStudy = null;
        }

        private void buttonCT_Click(object sender, EventArgs e)
        {
            if (reportCustomer == null)
            {
                reportCustomer = new FormSalesReportCustomer();
                reportCustomer.FormClosed += reportCustomer_FormClosed;
                reportCustomer.MdiParent = this;
                reportCustomer.Dock = DockStyle.Fill;
                reportCustomer.Show();
            }
            else
            {
                reportCustomer.Activate();
            }
        }

        private void reportCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportCustomer = null;
        }
    }
}
