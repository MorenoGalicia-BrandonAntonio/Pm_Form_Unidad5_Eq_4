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
    public partial class PC_2023_1_ComparaNumeros : Form
    {
        [DllImport(@"C:\Users\puto\source\repos\PM_Undiad5_Eq_4\Debug\PM_Undiad5_Eq_4.dll")]
        static extern int SumaNumerosVector(StringBuilder strRes, string str, int[] auxVector1);
        public PC_2023_1_ComparaNumeros()
        {
            InitializeComponent();
        }
        StringBuilder sb;
        private void PC_2023_1_ComparaNumeros_Load(object sender, EventArgs e)
        {
            /*
            sb.Clear();
            int largo = comparaNumeros(sb, "Coche Azulito", 500, 500, 2);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
            */

            sb = new StringBuilder(100);
            sb.Clear();

            int[] arregloNums = new int[3];
            arregloNums[0] = 5; //cantidad de elementos que tiene el arreglo
            arregloNums[1] = 10; //para obtener la longitud de la cadena de resultado
            arregloNums[2] = 2; //decimal 1
            arregloNums[3] = 3; //decimal 2
            arregloNums[4] = 7; //decimal 3
            arregloNums[5] = 8; //decimal 4

            IntPtr ptr = SumaNumerosVector(sb, "Hola :D",arregloNums);
            int arrayLenght = Marshal.ReadInt32(ptr);

 
            IntPtr start = IntPtr.Add(ptr, 4);
            int[] result = new int[arrayLenght];
            Marshal.Copy(startIndex, result, 0, arrayLength);

            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show(result[i].ToString());
            }
        }
    }
}
