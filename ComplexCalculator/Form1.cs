namespace ComplexCalculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendDigit(string d)
        {
            if (richTextBox1.Text == "0") richTextBox1.Text = d;
            else richTextBox1.Text += d;
        }

        private void Operation(string o)
        {
            operation = o;
            if (result.ToString() == "0") double.TryParse(richTextBox1.Text, out num1);
            else num1 = result;
            richTextBox1.Text = "0";
        }

        private void Digit1_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void Digit2_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void Digit3_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void Digit4_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void Digit5_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void Digit6_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void Digit7_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void Digit8_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void Digit9_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }

        private void Digit0_Click(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0") richTextBox1.Text = "-";
            else Operation("-");
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Operation("x");
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            Operation("sqrt");
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            Operation("%");
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains('.')) return;
            else richTextBox1.Text += ".";
        }

        private void Result_Click(object sender, EventArgs e)
        {
            double.TryParse(richTextBox1.Text, out num2);
            switch (operation)
            {
                case "+":
                    result = num1 + num2; break;

                case "-":
                    result = num1 - num2; break;

                case "*":
                    result = num1 * num2; break;

                case "/":
                    result = num1 / num2; break;

                case "%":
                    result = num1 % num2; break;

                case "sqrt":
                    result = double.Parse(richTextBox1.Text);
                    result = Math.Sqrt(result); break;
            }
            richTextBox1.Text = result.ToString();
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }

            else richTextBox1.Text = "0";
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = "";
        }

    }
}
