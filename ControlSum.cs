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
    public partial class ControlSum : Form
    {
        public ControlSum()
        {
            InitializeComponent();
        }

        public void Poland()
        {
            Regex validation = new Regex("^[1-9]{24}$");
            Boolean isValid = validation.IsMatch(nrbInput.Text);

            if (!isValid)
            {
                MessageBox.Show("Wprowadź Polski numer rachunku w formacie NRB [24 cyfry]");
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
        public void Germany()
        {
            Regex validation = new Regex("^[1-9]{20}$");
            Boolean isValid = validation.IsMatch(nrbInput.Text);

            if (!isValid)
            {
                MessageBox.Show("Wprowadź Niemiecki numer rachunku w formacie NRB [20 cyfr]");
            }
            else
            {
                string number = nrbInput.Text + Convert.ToByte('D') + Convert.ToByte('E');
                int modulo = 0;

                foreach (char znak in number)
                    modulo = (10 * modulo + int.Parse(znak.ToString())) % 97;
                modulo = 98 - modulo;

                nrbOutput.Text = string.Format("{0}{1}", modulo, nrbInput.Text);
            }
        }
        public void Slovakia()
        {
            Regex validation = new Regex("^[1-9]{22}$");
            Boolean isValid = validation.IsMatch(nrbInput.Text);

            if (!isValid)
            {
                MessageBox.Show("Wprowadź Słowacki numer rachunku w formacie NRB [22 cyfry]");
            }
            else
            {
                string number = nrbInput.Text + Convert.ToByte('D') + Convert.ToByte('E');
                int modulo = 0;

                foreach (char znak in number)
                    modulo = (10 * modulo + int.Parse(znak.ToString())) % 97;
                modulo = 98 - modulo;

                nrbOutput.Text = string.Format("{0}{1}", modulo, nrbInput.Text);
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (country.Text == "PL")
            {
                Poland();
            }

            if (country.Text == "DE")
            {
                Germany();
            }

            if (country.Text == "SK")
            {
                Slovakia();
            }
        }
    }
}
