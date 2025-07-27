namespace تکلیف3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int16 Oper;
        Int64 num1;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
            Oper = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Log(Convert.ToDouble(textBox1.Text)));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
            Oper = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
            Oper = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
            Oper = 3;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
                textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Int64 num2 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
            Int64 ans = 0;
            switch (Oper)
            {
                case 0:
                    ans = num1 + num2;
                    textBox1.Text = Convert.ToString(ans);
                    break;
                case 1:
                    ans = num1 / num2;
                    textBox1.Text = Convert.ToString(ans);
                    break;
                case 2:
                    ans = num1 * num2;
                    textBox1.Text = Convert.ToString(ans);
                    break;
                case 3:
                    ans = num1 - num2;
                    textBox1.Text = Convert.ToString(ans);
                    break;
                    //می توان از دستور شرطی ایف هم استفاده کرد

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
