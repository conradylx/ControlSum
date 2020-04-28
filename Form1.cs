using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            //nrbOutput.Text = nrbInput.Text;
            Regex validation = new Regex("^[1-9]{24}$");
            Boolean isValid = validation.IsMatch(nrbInput.Text);

            if (!isValid)
            {
                MessageBox.Show("Wprowadź numer rachunku w formacie NRB [24 cyfry]");
            }
            else
            {
                string number = nrbInput.Text + Convert.ToByte('P') + Convert.ToByte('L');
                int modulo = 0;

                foreach (char znak in number)
                    modulo = (10 * modulo + int.Parse(znak.ToString())) % 97;
                modulo = 98 - modulo;

                nrbOutput.Text = string.Format("{0}{1}", modulo, nrbInput.Text);
            }
        }
    }
}
