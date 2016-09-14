using System;
using System.Windows.Forms;

namespace KalkulatorBMI
{
    class BMI
    {

        #region BMI VARIABLES

        public double weight;
        public double height;
        public double score;
        public int weighttype;
        public int heighttype;

        private string status;

        #endregion

        #region BMI METHODS

        /// <summary>
        /// Zwraca obliczoną wartość BMI.
        /// </summary>
        public double ObliczBMI(double x, double y)
        {
            try
            {
                if (weighttype == 0 && heighttype == 0)
                {
                    return x / ((y * 0.01) * (y * 0.01));
                }
                else if (weighttype == 0 && heighttype == 1)
                {
                    return x / (((y * 2.54) * 0.01) * ((y * 2.54) * 0.01));
                }
                else if (weighttype == 1 && heighttype == 0)
                {
                    return (x * 703) / ((y * 0.393701) * (y * 0.393701));
                }
                else if (weighttype == 1 && heighttype == 1)
                {
                    return (x * 703) / (y * y);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return 0;
        }

        /// <summary>
        /// Zwraca string z zakresu wartości BMI
        /// </summary>
        public string bmitype()
        {
            if (score <= 16)
            {
                status = "wygłodzenie";
            }
            else if (score > 16 && score <= 16.99)
            {
                status = "wychudzenie";
            }
            else if (score > 17 && score <= 18.49)
            {
                status = "niedowaga";
            }
            else if (score > 18.5 && score <= 24.99)
            {
                status = "wartość prawidłowa";
            }
            else if (score > 25 && score <= 29.99)
            {
                status = "nadwaga";
            }
            else if (score > 30 && score <= 34.99)
            {
                status = "I stopień otyłości";
            }
            else if (score > 35 && score <= 39.99)
            {
                status = "II stopień otyłości";
            }
            else if (score > 40)
            {
                status = "otyłość skrajna";
            }
            return status;
        }

        #endregion

    }
}
