using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pm_Form_Unidad5_Eq_4
{
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int largo_cadena(string str);
        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int escribir_cadena(StringBuilder str, int len_buffer);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int len = largo_cadena("juan carlos");
            MessageBox.Show("Largo: " + len);

            try
            {
                StringBuilder sb = new StringBuilder(100);
                int largo = escribir_cadena(sb, sb.Capacity);
                string c = sb.ToString();
                c = c.Substring(0, largo);
                MessageBox.Show(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }
    }
}
