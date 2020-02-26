using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_test
{
    public partial class Kalkulator : Form
    {
        Double wyświetlWartość = 0;
        String wykonanieOperacji = "";
        bool wykonywanieOperacji = false;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void bt_click(object sender, EventArgs e)
        {
            if ((textBox_Wyświetlanie.Text == "0") || (wykonywanieOperacji))
                textBox_Wyświetlanie.Clear();

            wykonywanieOperacji = false; 

            Button bt = (Button)sender;

            if (bt.Text == ".")
            {
                if (!textBox_Wyświetlanie.Text.Contains("."))
                    textBox_Wyświetlanie.Text = textBox_Wyświetlanie.Text + bt.Text;
            }
            else
                textBox_Wyświetlanie.Text = textBox_Wyświetlanie.Text + bt.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (wyświetlWartość != 0)
            {
                Wynik.PerformClick();
                wykonanieOperacji = bt.Text;
                wykonywanieOperacji = true;
            }
            else
            {
                wykonanieOperacji = bt.Text;
                wyświetlWartość = double.Parse(textBox_Wyświetlanie.Text);
                wykonywanieOperacji = true;
            }
        }

        private void btWynik_click(object sender, EventArgs e)
        {
            switch (wykonanieOperacji)
            {
                case "+":
                    textBox_Wyświetlanie.Text = (wyświetlWartość + double.Parse(textBox_Wyświetlanie.Text)).ToString();
                    break;

                case "-":
                    textBox_Wyświetlanie.Text = (wyświetlWartość - double.Parse(textBox_Wyświetlanie.Text)).ToString();
                    break;

                case "*":
                    textBox_Wyświetlanie.Text = (wyświetlWartość * double.Parse(textBox_Wyświetlanie.Text)).ToString();
                    break;

                case "/":
                    textBox_Wyświetlanie.Text = (wyświetlWartość / double.Parse(textBox_Wyświetlanie.Text)).ToString();
                    break;
            }
            if (textBox_Wyświetlanie.Text == "∞")
            {
                textBox_Wyświetlanie.Text = "Nie dziel przez zero";
            }
            else
            {
                wyświetlWartość = double.Parse(textBox_Wyświetlanie.Text);
            }
        }

        private void btReset_click(object sender, EventArgs e)
        {
            textBox_Wyświetlanie.Text = "0";
            wyświetlWartość = 0;

        }
    }
}
