
namespace QUIZ01_09156213_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.left_to_right = new System.Windows.Forms.RadioButton();
            this.multiplay_then_addition = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left_to_right
            // 
            this.left_to_right.Location = new System.Drawing.Point(12, 73);
            this.left_to_right.Name = "left_to_right";
            this.left_to_right.Size = new System.Drawing.Size(99, 24);
            this.left_to_right.TabIndex = 0;
            this.left_to_right.TabStop = true;
            this.left_to_right.Text = "由左至右計算";
            this.left_to_right.UseVisualStyleBackColor = true;
            // 
            // multiplay_then_addition
            // 
            this.multiplay_then_addition.Location = new System.Drawing.Point(117, 73);
            this.multiplay_then_addition.Name = "multiplay_then_addition";
            this.multiplay_then_addition.Size = new System.Drawing.Size(99, 24);
            this.multiplay_then_addition.TabIndex = 1;
            this.multiplay_then_addition.TabStop = true;
            this.multiplay_then_addition.Text = "先乘除後加減";
            this.multiplay_then_addition.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(13, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 45);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(93, 104);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 45);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(171, 104);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 45);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_calculate
            // 
            this.button_calculate.BackColor = System.Drawing.Color.DarkRed;
            this.button_calculate.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_calculate.ForeColor = System.Drawing.SystemColors.Control;
            this.button_calculate.Location = new System.Drawing.Point(13, 169);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(279, 59);
            this.button_calculate.TabIndex = 5;
            this.button_calculate.Text = "計算";
            this.button_calculate.UseVisualStyleBackColor = false;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // output_label
            // 
            this.output_label.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output_label.Location = new System.Drawing.Point(242, 104);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(60, 45);
            this.output_label.TabIndex = 6;
            this.output_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QUIZ01_09156213_2.Properties.Resources.Equal_symbol_svg;
            this.pictureBox3.Location = new System.Drawing.Point(222, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QUIZ01_09156213_2.Properties.Resources._1024px_Multiplication_Sign_svg;
            this.pictureBox2.Location = new System.Drawing.Point(144, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUIZ01_09156213_2.Properties.Resources._1443620;
            this.pictureBox1.Location = new System.Drawing.Point(66, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(12, 252);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(280, 49);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "還是我幫你隨機放數字算ㄋ(不過讓我決定的話就依照正規的計算方式，先乘除後加減喔)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 378);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.multiplay_then_addition);
            this.Controls.Add(this.left_to_right);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton left_to_right;
        private System.Windows.Forms.RadioButton multiplay_then_addition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

