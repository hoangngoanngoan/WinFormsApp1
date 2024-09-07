namespace WinFormsApp1
{
    partial class FormTSLN
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(441, 46);
            label1.TabIndex = 0;
            label1.Text = "Tìm số lớn nhất trong 3 số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 95);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 136);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 1;
            label3.Text = "Nhập b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 183);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 1;
            label4.Text = "Nhập c:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 230);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 1;
            label5.Text = "Kết quả:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(129, 227);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(336, 27);
            textBox4.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(322, 92);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 3;
            button1.Text = "Thực hiện";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(322, 133);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 3;
            button2.Text = "Tiếp tục";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(322, 178);
            button3.Name = "button3";
            button3.Size = new Size(143, 29);
            button3.TabIndex = 3;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormTSLN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 305);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTSLN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}