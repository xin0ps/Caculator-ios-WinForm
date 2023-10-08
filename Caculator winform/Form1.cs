namespace Caculator_winform
{
    public partial class Form1 : Form
    {

        char op = '!';
        int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text= "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "0";
            }
            else
            {
                label1.Text = "0";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0")
            {
                this.label1.Text += "1";
            }
            else
            {
                this.label1.Text = "1";

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0")
            {
                this.label1.Text += "2";
            }
            else
            {
                this.label1.Text = "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0")
            {
                this.label1.Text += "3";
            }
            else
            {
                this.label1.Text = "3";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0")
            {
                this.label1.Text += "4";
            }
            else
            {
                this.label1.Text = "4";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0")
            {
                this.label1.Text += "5";
            }
            else
            {
                this.label1.Text = "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0")
            {
                this.label1.Text += "6";
            }
            else
            {
                this.label1.Text = "6";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (this.label1.Text != "0")
            {
                this.label1.Text += "7";
            }
            else
            {
                this.label1.Text = "7";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0")
            {
                this.label1.Text += "8";
            }
            else
            {
                this.label1.Text = "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0")
            {
                this.label1.Text += "9";
            }
            else
            {
                this.label1.Text = "9";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+':
                    {
                        int num1 = num + int.Parse((string)this.label1.Text);
                        this.label1.Text = num1.ToString();
                        break;
                    }
                case '-':
                    {
                        int num1 = num - int.Parse((string)this.label1.Text);
                        this.label1.Text = num1.ToString();
                        break;
                    }
                case '/':
                    {
                        int num1 = num / int.Parse((string)this.label1.Text);
                        this.label1.Text = num1.ToString();
                        break;
                    }
                case 'x':
                    {
                        int num1 = num * int.Parse((string)this.label1.Text);
                        this.label1.Text = num1.ToString();
                        break;
                    }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = int.Parse((string)this.label1.Text);
            this.label1.Text = "0";
            op = '/';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = int.Parse((string)this.label1.Text);
            this.label1.Text = "0";
            op = 'x';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = int.Parse((string)this.label1.Text);
            this.label1.Text = "0";
            op = '-';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num = int.Parse((string)this.label1.Text);
            this.label1.Text = "0";
            op = '+';
        }
    }
}