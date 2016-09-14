using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;


namespace KalkulatorBMI
{
    public partial class Form1 : Form
    {

        BMI bmi = new BMI();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmi.weighttype = comboWaga.SelectedIndex = 0;
            bmi.heighttype = comboWzrost.SelectedIndex = 0;
        }

        private void btn_oblicz_Click(object sender, EventArgs e)
        {
            if (RegexCheck())
            {
                RegexToDobuleFix();
                bmi.weighttype = comboWaga.SelectedIndex;
                bmi.heighttype = comboWzrost.SelectedIndex;
                bmi.weight = Convert.ToDouble(textBoxWaga.Text, CultureInfo.CreateSpecificCulture("en-US"));
                bmi.height = Convert.ToDouble(textBoxWzrost.Text, CultureInfo.CreateSpecificCulture("en-US"));
                bmi.score = bmi.ObliczBMI(bmi.weight, bmi.height);
                lbl_twojebmi.Text = "Twoje BMI: " + Math.Round(bmi.score, 1).ToString() + " - " + bmi.bmitype();
                lbl_twojebmi.Visible = true;
            }
            else
            {
                MessageBox.Show("Nieprawidłowy format wagi lub wzrostu!");
            }
        }

        /// <summary>
        /// Sprawdza czy podana wartość wagi i wzrostu jest prawidłowa i zwraca true lub false.
        /// </summary>
        bool RegexCheck()
        {
            if (Regex.IsMatch(textBoxWaga.Text, @"^-*[0-9,\.]+$") && Regex.IsMatch(textBoxWzrost.Text, @"^-*[0-9,\.]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Funkcja zamienia przecinek na kropkę, aby nie występował błąd przy konwersji Convert.ToDouble()
        /// </summary>
        void RegexToDobuleFix()
        {
            Regex commaRegex = new Regex("\\,");
            string replacement = ".";
            textBoxWaga.Text = commaRegex.Replace(textBoxWaga.Text, replacement);
            textBoxWzrost.Text = commaRegex.Replace(textBoxWzrost.Text, replacement);
            textBoxWaga.Refresh();
            textBoxWzrost.Refresh();
        }

    }
}
