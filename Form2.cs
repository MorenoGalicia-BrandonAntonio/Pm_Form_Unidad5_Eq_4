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
    public partial class Form2 : Form
    {
        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int PromedioDelUsuario(string str, int cal1, int cal2, int cal3);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string nombre;
            int cal1;
            int cal2;
            int cal3;

            nombre = "Secuestrador";
            cal1 = 8;
            cal2 = 9;
            cal3 = 7;

            int resultado = PromedioDelUsuario(nombre, cal1, cal2, cal3);

            MessageBox.Show(nombre + " Tiene un Promedio de : " + resultado.ToString());
        }
    }
}
