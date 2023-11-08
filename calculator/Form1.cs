namespace calculator
{

    public partial class Form1 : Form
    {
        int number1, number2, result;
        double dnumber1, dnumber2, dresult;
        bool status;

        public void adding(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            if (dnumber1 == 0 && dnumber2 == 0)
            {
                result = number1 + number2;
            }
            else if (dnumber1 != 0 && number2 != 0)
            {
                dresult = dnumber1 + Convert.ToDouble(number2);
            }
            else
            {
                dresult = Convert.ToDouble(number1) + dnumber2;
            }
        }

        public void dadding(double dnumber1, double dnumber2)
        {
            this.dnumber1 = dnumber1;
            this.dnumber2 = dnumber2;
            dresult = dnumber1 + dnumber2;
        }

        public void subtracting(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            if (dnumber1 == 0 && dnumber2 == 0)
            {
                result = number1 - number2;
            }
            else if (dnumber1 != 0 && number2 != 0)
            {
                dresult = dnumber1 - Convert.ToDouble(number2);
            }
            else
            {
                dresult = Convert.ToDouble(number1) - dnumber2;
            }
        }

        public void d_subtracting(double dnumber1, double dnumber2)
        {
            this.dnumber1 = dnumber1;
            this.dnumber2 = dnumber2;
            dresult = dnumber1 - dnumber2;
        }

        public void division(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            if (dnumber1 == 0 && dnumber2 == 0)
            {
                if (number1 % number2 == 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    dresult = (double)number1 / (double)number2;
                }
            } 
            else if (dnumber1 != 0 && number2 != 0)
            {
                dresult = dnumber1 / Convert.ToDouble(number2);
            }
            else
            {
                dresult = Convert.ToDouble(number1) / dnumber2;
            }
        }

        public void d_division(double dnumber1, double dnumber2)
        {
            this.dnumber1 = dnumber1;
            this.dnumber2 = dnumber2;
            dresult = dnumber1 / dnumber2;
        }
        public void multiplication(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            result = number1 * number2;
            if (dnumber1 != 0 && number2 != 0)
            {
                dresult = dnumber1 * Convert.ToDouble(number2);
            }
            else
            {
                dresult = Convert.ToDouble(number1) * dnumber2;
            }
        }

        public void d_multiplication(double dnumber1, double dnumber2)
        {
            this.dnumber1 = dnumber1;
            this.dnumber2 = dnumber2;
            dresult = dnumber1 * dnumber2;
        }
        public void resetNumbers(int number1, int number2, double dnumber1, double dnumber2)
        {
            this.number1 = 0;
            this.number2 = 0;
            this.dnumber1 = 0;
            this.dnumber2 = 0;
            result = 0;
            dresult = 0;
        }

        bool IntParser(bool status)
        {
            if (int.TryParse(NumberTextBox.Text, out int value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool DoubleParser(bool status)
        {
            if (double.TryParse(NumberTextBox.Text, out double dvalue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            if (IntParser(true))
            {
                if (number1 == 0 || dnumber1 != 0)
                {
                    if (dnumber1 != 0)
                    {
                        number2 = Convert.ToInt32(NumberTextBox.Text);
                        StatusText.Text = dnumber1 + " + " + number2;
                    }
                    else
                    {
                        number1 = Convert.ToInt32(NumberTextBox.Text);
                        StatusText.Text = number1.ToString();
                    }
                }
                else
                {
                    number2 = Convert.ToInt32(NumberTextBox.Text);
                    StatusText.Text = number1 + " + " + number2;
                }
            }
            else if (DoubleParser(true))
            {
                if (dnumber1 == 0 || number1 != 0)
                {
                    if (number1 != 0)
                    {
                        dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                        StatusText.Text = number1.ToString() + " + " + dnumber2.ToString();
                    }
                    else
                    {
                        dnumber1 = Convert.ToDouble(NumberTextBox.Text);
                        StatusText.Text = dnumber1.ToString();
                    }
                }
                else
                {
                    dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                    StatusText.Text = dnumber1.ToString() + " + " + dnumber2.ToString();
                }
            }
            else
            {
                StatusText.Text = "error";
            }
            NumberTextBox.Text = string.Empty;
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (dnumber1 != 0 && dnumber2 != 0 && StatusText.Text.Contains(" + "))
            {
                dadding(dnumber1, dnumber2);
                StatusText.Text = dnumber1 + " + " + dnumber2 + " = " + dresult;
            }
            else
            {
                if (StatusText.Text.Contains(" + "))
                {
                    adding(number1, number2);
                    if (number1 != 0 && number2 != 0)
                    {
                        StatusText.Text = number1 + " + " + number2 + " = " + result;
                    }
                    if (dnumber1 != 0 && number2 != 0)
                    {
                        StatusText.Text = dnumber1 + " + " + number2 + " = " + dresult;
                    }
                    else if (number1 != 0 && dnumber2 != 0)
                    {
                        StatusText.Text = number1 + " + " + dnumber2 + " = " + dresult;
                    }
                }
                else if (StatusText.Text.Contains(" - "))
                {
                    subtracting(number1, number2);
                    if (dnumber1 != 0 && number2 != 0)
                    {
                        StatusText.Text = dnumber1 + " - " + number2 + " = " + dresult;
                    }
                    else if (number1 != 0 && dnumber2 != 0)
                    {
                        StatusText.Text = number1 + " - " + dnumber2 + " = " + dresult;
                    }
                    else
                    {
                        if (dnumber1 == 0 && dnumber2 == 0)
                        {
                            if (dnumber1 == 0 && dnumber2 == 0 && dresult != 0)
                            {
                                StatusText.Text = number1 + " - " + number2 + " = " + dresult;
                            }
                            else
                            {
                                StatusText.Text = number1 + " - " + number2 + " = " + result;
                            }
                        }
                        else
                        {
                            d_subtracting(dnumber1, dnumber2);
                            StatusText.Text = dnumber1 + " - " + dnumber2 + " = " + dresult;
                        }
                    }
                }
                else if (StatusText.Text.Contains(" / "))
                {
                    division(number1, number2);
                    if (dnumber1 != 0 && number2 != 0)
                    {
                        StatusText.Text = dnumber1 + " / " + number2 + " = " + dresult;
                    }
                    else if (number1 != 0 && dnumber2 != 0)
                    {
                        StatusText.Text = number1 + " / " + dnumber2 + " = " + dresult;
                    }
                    else
                    {
                        if (dnumber1 == 0 && dnumber2 == 0)
                        {
                            if (dnumber1 == 0 && dnumber2 == 0 && dresult != 0)
                            {
                                StatusText.Text = number1 + " / " + number2 + " = " + dresult;
                            }
                            else
                            {
                                StatusText.Text = number1 + " / " + number2 + " = " + result;
                            }
                        }
                        else
                        {
                            d_division(dnumber1, dnumber2);
                            StatusText.Text = dnumber1 + " / " + dnumber2 + " = " + dresult;
                        }
                    }
                }
                else if (StatusText.Text.Contains(" * "))
                {
                    if (dnumber1 == 0 && dnumber2 == 0)
                    {
                        multiplication(number1, number2);
                        if (dnumber1 == 0 && dnumber2 == 0 && dresult != 0)
                        {
                            StatusText.Text = number1 + " * " + number2 + " = " + dresult;
                        }
                        else
                        {
                            StatusText.Text = number1 + " * " + number2 + " = " + result;
                        }
                    }
                    else
                    {
                        multiplication(number1, number2);
                        if (dnumber1 != 0 && number2 != 0)
                        {   
                            StatusText.Text = dnumber1 + " * " + number2 + " = " + dresult;
                        }
                        else if (number1 != 0 && dnumber2 != 0)
                        {
                            StatusText.Text = number1 + " * " + dnumber2 + " = " + dresult;
                        }
                        else
                        {
                            d_multiplication(dnumber1, dnumber2);
                            StatusText.Text = dnumber1 + " * " + dnumber2 + " = " + dresult;
                        }
                    }
                }
                else
                {
                    StatusText.Text = "Hiányzó szám(ok).";
                }
            }
            resetNumbers(number1, number2, dnumber1, dnumber2);
            NumberTextBox.Text = string.Empty;
        }
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (IntParser(true))
            {
                if (number1 == 0 || dnumber1 != 0)
                {
                    if (Convert.ToInt32(NumberTextBox.Text) == 0)
                    {
                        StatusText.Text = "Nem lehet az oszto 0! Reset.";
                        resetNumbers(number1, number2, dnumber1, dnumber2);
                    }
                    else if (dnumber1 != 0)
                    {
                        number2 = Convert.ToInt32(NumberTextBox.Text);
                        StatusText.Text = dnumber1 + " / " + number2;
                    }
                    else
                    {
                        number1 = Convert.ToInt32(NumberTextBox.Text);
                        StatusText.Text = number1.ToString();
                    }
                }
                else
                {
                    number2 = Convert.ToInt32(NumberTextBox.Text);
                    StatusText.Text = number1 + " / " + number2;
                }

            }
            else if (DoubleParser(true))
            {
                if (dnumber1 == 0 || number1 != 0)
                {
                    if (Convert.ToDouble(NumberTextBox.Text) == 0)
                    {
                        StatusText.Text = "Nem lehet az oszto 0! Reset.";
                        resetNumbers(number1, number2, dnumber1, dnumber2);
                    }
                    else if (number1 != 0)
                    {
                        dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                        StatusText.Text = number1.ToString() + " / " + dnumber2.ToString();
                    }
                    else
                    {
                        dnumber1 = Convert.ToDouble(NumberTextBox.Text);
                        StatusText.Text = dnumber1.ToString();
                    }
                }
                else
                {
                    dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                    StatusText.Text = dnumber1.ToString() + " / " + dnumber2.ToString();
                }
            }
            else
            {
                StatusText.Text = "error";
            }
            NumberTextBox.Text = string.Empty;
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (IntParser(true))
            {
                if (number1 == 0 || dnumber1 != 0)
                {
                    if (dnumber1 != 0)
                    {
                        number2 = Convert.ToInt32(NumberTextBox.Text);
                        StatusText.Text = dnumber1 + " * " + number2;
                    }
                    else
                    {
                        number1 = Convert.ToInt32(NumberTextBox.Text);
                        StatusText.Text = number1.ToString();
                    }
                }
                else
                {
                    number2 = Convert.ToInt32(NumberTextBox.Text);
                    StatusText.Text = number1 + " * " + number2;
                }
            }
            else if (DoubleParser(true))
            {
                if (dnumber1 == 0 || number1 != 0)
                {
                    if (number1 != 0)
                    {
                        dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                        StatusText.Text = number1.ToString() + " * " + dnumber2.ToString();
                    }
                    else
                    {
                        dnumber1 = Convert.ToDouble(NumberTextBox.Text);
                        StatusText.Text = dnumber1.ToString();
                    }
                }
                else
                {
                    dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                    StatusText.Text = dnumber1.ToString() + " * " + dnumber2.ToString();
                }
            }
            else
            {
                StatusText.Text = "error";
            }
            NumberTextBox.Text = string.Empty;
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            if (IntParser(true))
            {
                if (number1 == 0 || dnumber1 != 0)
                {
                    if (dnumber1 != 0)
                    {
                        number2 = Convert.ToInt32(NumberTextBox.Text);
                        StatusText.Text = dnumber1 + " - " + number2;
                    }
                    else
                    {
                        number1 = Convert.ToInt32(NumberTextBox.Text);
                        StatusText.Text = number1.ToString();
                    }
                }
                else
                {
                    number2 = Convert.ToInt32(NumberTextBox.Text);
                    StatusText.Text = number1 + " - " + number2;
                }
            }
            else if (DoubleParser(true))
            {
                if (dnumber1 == 0 || number1 != 0)
                {
                    if (number1 != 0)
                    {
                        dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                        StatusText.Text = number1.ToString() + " - " + dnumber2.ToString();
                    }
                    else
                    {
                        dnumber1 = Convert.ToDouble(NumberTextBox.Text);
                        StatusText.Text = dnumber1.ToString();
                    }
                }
                else
                {
                    dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                    StatusText.Text = dnumber1.ToString() + " - " + dnumber2.ToString();
                }
            }
            else
            {
                StatusText.Text = "error";
            }
            NumberTextBox.Text = string.Empty;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StatusText.Text = "Adja meg az elso szamot!";
        }
    }
}