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

        private bool DotWasClicked = false;

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
            DotWasClicked = false;
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

        private void Square_Click(object sender, EventArgs e)
        {
            Operation("^");
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            Operation("%");
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (DotWasClicked) return;
            else { richTextBox1.Text += "."; DotWasClicked = true; }
        }

        private void Result_Click(object sender, EventArgs e)
        {
            double.TryParse(richTextBox1.Text, out num2);
            if (operation == "+") result = num1 + num2;

            if (operation == "-") result = num1 - num2;

            if (operation == "x") result = num1 * num2;

            if (operation == "/") result = num1 / num2;

            if (operation == "^") result = Math.Pow(num1, num2);

            if (operation == "%") result = (num1 * num2) / 100;
            richTextBox1.Text = result.ToString();
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length < 2) { richTextBox1.Text = "0"; result = 0; DotWasClicked = false; }

            else
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
                if (richTextBox1.Text.Contains('.')) DotWasClicked = true;
                else DotWasClicked = false;
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = "";
            DotWasClicked = false;
        }
    }
}
