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
    public partial class Form3 : Form
    {
        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int largo_cadena(string str);
        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int escribir_cadena(StringBuilder str, int len_buffer);
        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int PromedioDelUsuario(StringBuilder str, string nombre, int cal1, int cal2, int cal3);

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(100);
            int largo = PromedioDelUsuario(sb ,"Nombre22", 7, 8, 8);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }
    }



}
