namespace WinFormsApp1
{
    partial class Form3
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
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            txtTongDaySo = new TextBox();
            txtTongLe = new TextBox();
            txtTongChan = new TextBox();
            txtNhapSo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 23);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập dãy số và tính tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 113);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Dãy số vừa nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 144);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 3;
            label4.Text = "Tổng các phần tử trong dãy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 173);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "Tổng chẳn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 173);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 5;
            label6.Text = "Tổng lẻ:";
            // 
            // button1
            // 
            button1.Location = new Point(93, 224);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Tiếp tục";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(186, 224);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 7;
            // 
            // txtTongDaySo
            // 
            txtTongDaySo.Location = new Point(188, 139);
            txtTongDaySo.Name = "txtTongDaySo";
            txtTongDaySo.Size = new Size(121, 23);
            txtTongDaySo.TabIndex = 7;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(241, 170);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(68, 23);
            txtTongLe.TabIndex = 7;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(102, 170);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(78, 23);
            txtTongChan.TabIndex = 7;
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(142, 109);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(167, 23);
            txtNhapSo.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 279);
            Controls.Add(txtNhapSo);
            Controls.Add(txtTongChan);
            Controls.Add(txtTongLe);
            Controls.Add(txtTongDaySo);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox txtTongDaySo;
        private TextBox txtTongLe;
        private TextBox txtTongChan;
        private TextBox txtNhapSo;
    }
}