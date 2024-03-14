using System;
using System.Windows.Forms;

namespace Try_Gradient_and_Sidebar
{
    public partial class FormSalesCus : Form


    {

        FormSalesCusCreate salesCusCreate;
        public FormSalesCus()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Tambahkan kolom ke DataGridView
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");

            // Tambahkan baris secara dinamis
            for (int i = 0; i < 100; i++)
            {
                dataGridView1.Rows.Add(); // Tambahkan baris kosong
                dataGridView1.Rows[i].Cells[0].Value = "Data " + (i + 1); // Isi data pada kolom 1
                dataGridView1.Rows[i].Cells[1].Value = "Data " + (i + 2); // Isi data pada kolom 2
                dataGridView1.Rows[i].Cells[2].Value = "Data " + (i + 3); // Isi data pada kolom 3
            }
        }

        private void FormSalesCus_Load(object sender, EventArgs e)
        {
            // Panggil method untuk menginisialisasi DataGridView saat form dimuat
            InitializeDataGridView();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika pencarian jika diperlukan
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tambahkan logika jika sel di DataGridView diklik
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (salesCusCreate == null)
            {
                salesCusCreate = new FormSalesCusCreate();
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
    }
}
