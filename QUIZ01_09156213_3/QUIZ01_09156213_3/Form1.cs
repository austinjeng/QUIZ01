using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ01_09156213_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //createButton(2, 2);
        }

        List<Button> buttonsAdded = new List<Button>();

        public void createButton(int width, int height)
        {

            int index = 1;

            for (int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    int buttonWidth = 35;
                    int buttonHeight = 35;

                    int buttonSpace = 5;

                    int buttonX = buttonSpace + x * (buttonWidth + buttonSpace);
                    int buttonY = 55 + buttonSpace + y * (buttonHeight + buttonSpace);

                    Button button = new Button();

                    button.Location = new Point(buttonX, buttonY);
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.TabIndex = 0;
                    button.Text = "" + index;
                    button.Tag = index;
                    button.UseVisualStyleBackColor = true;

                    index++;
                    this.Controls.Add(button);
                    buttonsAdded.Add(button);

                }
            }
        }

        void deleteButton()
        {
            foreach(Button btn in buttonsAdded)
            {
                this.Controls.Remove(btn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteButton();
            createButton(Convert.ToInt32(width_text.Text), Convert.ToInt32(height_text.Text));
        }
    }
}
