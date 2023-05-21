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
    public partial class PC_2023_2_Velocidad : Form
    {
        
        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int velocidad(StringBuilder strRes, string str, int distancia, int tiempo);

        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int addNum2Cadena(StringBuilder strRes, int indice, int numero);

        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int addCadena2Cadena(StringBuilder strRes, int indice, int cadena);

        public PC_2023_2_Velocidad()
        {
            InitializeComponent();
        }
        StringBuilder sb;
        private void PC_2023_2_Velocidad_Load(object sender, EventArgs e)
        {
            sb = new StringBuilder(100);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sb.Clear(); 
            int largo = velocidad(sb, "Coche Azulito", 120, 2);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }
    }
}
