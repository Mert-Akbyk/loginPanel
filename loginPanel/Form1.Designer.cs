namespace loginPanel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(23, 178);
            label1.Name = "label1";
            label1.Size = new Size(119, 27);
            label1.TabIndex = 0;
            label1.Text = "User ID   :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PowderBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(23, 218);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 1;
            label2.Text = "User PW :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PowderBlue;
            textBox1.Location = new Point(147, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 38);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.PowderBlue;
            maskedTextBox1.Location = new Point(147, 170);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(202, 38);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 139);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(556, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(16, 30);
            label3.Name = "label3";
            label3.Size = new Size(549, 73);
            label3.TabIndex = 6;
            label3.Text = "Basic User Login Page";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-4, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(789, 44);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(192, 288);
            button1.Name = "button1";
            button1.Size = new Size(108, 46);
            button1.TabIndex = 6;
            button1.Text = "Sign İn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            checkBox1.ForeColor = Color.PowderBlue;
            checkBox1.Location = new Point(180, 258);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(169, 0);
            label4.Name = "label4";
            label4.Size = new Size(428, 32);
            label4.TabIndex = 8;
            label4.Text = "All rights belong to Mert AKBIYIK.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(783, 429);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "userLoginPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private CheckBox checkBox1;
        private Label label4;
    }
}
