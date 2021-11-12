using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ01_09156213_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            int result = 0;
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            //int number1 = Convert.ToInt32(textBox1.Text);
            //int number2 = Convert.ToInt32(textBox2.Text);
            //int number3 = Convert.ToInt32(textBox3.Text);

            if (left_to_right.Checked)
            {
                number1 = Convert.ToInt32(textBox1.Text);
                number2 = Convert.ToInt32(textBox2.Text);
                number3 = Convert.ToInt32(textBox3.Text);
                result = number1 + number2;
                result = result * number3;

                output_label.Text = result.ToString();
            }
            else if(multiplay_then_addition.Checked)
            {
                number1 = Convert.ToInt32(textBox1.Text);
                number2 = Convert.ToInt32(textBox2.Text);
                number3 = Convert.ToInt32(textBox3.Text);
                result = number2 * number3 + number1;

                output_label.Text = result.ToString();
            }
            else
            {
                Random random = new Random();
                number1 = random.Next(1, 100);
                number2 = random.Next(1, 100);
                number3 = random.Next(1, 100);
                textBox1.Text = number1.ToString();
                textBox2.Text = number2.ToString();
                textBox3.Text = number3.ToString();

                result = number2 * number3 + number1;
                output_label.Text = result.ToString();

            }
        }
    }
}
