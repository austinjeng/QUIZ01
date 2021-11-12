using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ01_09156213__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correctClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            incorrectClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            incorrectClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            incorrectClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            incorrectClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            incorrectClick(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            incorrectClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            incorrectClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            incorrectClick(sender);
        }

        //when the incorrect answer is clicked
        void incorrectClick(object sender)
        {
            incorrectLabel.Visible = true;
            correctLabel.Visible = false;
        }

        void correctClick(object sender)
        {
            incorrectLabel.Visible = false;
            correctLabel.Visible = true;
        }
    }
}
