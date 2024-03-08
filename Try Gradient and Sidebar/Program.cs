using System;
using System.Windows.Forms;
using Try_Gradient_and_Sidebar;

namespace Coba_ERP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();

            // Mulai timer di Form1
            Timer timer = new Timer();
            timer.Interval = 5000; // 5 detik
            timer.Tick += (sender, args) =>
            {
                timer.Stop(); // Stop timer
                form1.Hide(); // Sembunyikan Form1
                Form2 form2 = new Form2(); // Buat instance Form2
                form2.Show(); // Tampilkan Form2
            };

            // Event handler untuk menampilkan Form1 ketika aplikasi dijalankan
            form1.Load += (sender, args) =>
            {
                timer.Start(); // Mulai timer saat Form1 dimuat
            };

            Application.Run(form1);
        }
    }
}
