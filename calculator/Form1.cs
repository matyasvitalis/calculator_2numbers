namespace calculator
{

    public partial class Form1 : Form
    {
        int number1, number2, result;
        double dnumber1, dnumber2, dresult;

        public void adding(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            result = number1 + number2;
        }

        public void dadding(double dnumber1, double dnumber2)
        {
            this.dnumber1 = dnumber1;
            this.dnumber2 = dnumber2;
            dresult = dnumber1 + dnumber2;
        }

        public void subtracting(int number1, int number2){
            this.number1 = number1;
            this.number2 = number2;
            result = number1 - number2;
        }

        public void division(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            if (number1 % number2 == 0)
            {
                result = number1 / number2;
            }
            else
            {
                dresult = (double)number1 / (double)number2;
            }
        }

        public void multiplication(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            result = number1 * number2;
        }
        public void resetNumbers(int number1, int number2)
        {
            this.number1 = 0;
            this.number2 = 0;
            result = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StatusText.Text = "Adja meg az elso szamot!";
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            if (NumberTextBox.Text.Contains(','))
            {
                if (dnumber1 == 0)
                {
                    dnumber1 = Convert.ToDouble(NumberTextBox.Text);
                    StatusText.Text = "" + dnumber1;
                }
                else
                {
                    dnumber2 = Convert.ToDouble(NumberTextBox.Text);
                    StatusText.Text = "" + dnumber1 + " + " + dnumber2;
                }
            }
            else
            {   
                if (number1 == 0)
                {
                    number1 = Convert.ToInt32(NumberTextBox.Text);
                    StatusText.Text = "" + number1;
                }
                else
                {
                    number2 = Convert.ToInt32(NumberTextBox.Text);
                    StatusText.Text = "" + number1 + " + " + number2;
                }
            }
        
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (dnumber1 != 0 && dnumber1 != 0)
            {
                dadding(dnumber1, dnumber2);
                StatusText.Text = "" + dnumber1 + " + " + dnumber2 + " = " + dresult;
            }
            else
            {
                if (StatusText.Text.Contains(" + "))
                {
                    adding(number1, number2);
                    StatusText.Text = "" + number1 + " + " + number2 + " = " + result;
                }
                else if (StatusText.Text.Contains(" - "))
                {
                    subtracting(number1, number2);
                    StatusText.Text = "" + number1 + " - " + number2 + " = " + result;
                }
                else if (StatusText.Text.Contains(" / "))
                {
                    division(number1, number2);
                    if (dresult != 0)
                    {
                        StatusText.Text = "" + number1 + " / " + number2 + " = " + dresult;
                    }
                    else
                    {
                        StatusText.Text = "" + number1 + " / " + number2 + " = " + result;
                    }
                }
                else if (StatusText.Text.Contains(" * "))
                {
                    multiplication(number1, number2);
                    StatusText.Text = "" + number1 + " * " + number2 + " = " + result;
                }
                else
                {
                    StatusText.Text = "Hiányzó szám(ok).";
                    resetNumbers(number1, number2);
                }
            }
            resetNumbers(number1, number2);
        }
        private void StatusText_Click(object sender, EventArgs e)
        {

        }
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            //osztas
            if (number1 == 0)
            {
                number1 = Convert.ToInt32(NumberTextBox.Text);
                StatusText.Text = "" + number1;
            }
            else
            {
                if (Convert.ToInt32(NumberTextBox.Text) == 0)
                {
                    StatusText.Text = "Nem lehet az oszto 0! Reset.";
                    resetNumbers(number1, number2);
                }
                else
                {
                    number2 = Convert.ToInt32(NumberTextBox.Text);
                    StatusText.Text = "" + number1 + " / " + number2;
                }
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            //szorzas
            if (number1 == 0)
            {
                number1 = Convert.ToInt32(NumberTextBox.Text);
                StatusText.Text = "" + number1;
            }
            else
            {
                number2 = Convert.ToInt32(NumberTextBox.Text);
                StatusText.Text = "" + number1 + " * " + number2;
            }
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            if (number1 == 0)
            {
                number1 = Convert.ToInt32(NumberTextBox.Text);
                StatusText.Text = "" + number1;
            }
            else
            {
                number2 = Convert.ToInt32(NumberTextBox.Text);
                StatusText.Text = "" + number1 + " - " + number2;
            }
        }
    }
}