namespace WinFormsApp1
{
    partial class FormTTDS
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
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(373, 41);
            label1.TabIndex = 0;
            label1.Text = "Nhập dãy số và tính tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 151);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Dãy số vừa nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 192);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 3;
            label4.Text = "Tổng các phần tử trong dãy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 231);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "Tổng chẳn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 231);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "Tổng lẻ:";
            // 
            // button1
            // 
            button1.Location = new Point(106, 299);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 6;
            button1.Text = "Tiếp tục";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(213, 299);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 6;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 108);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 7;
            // 
            // txtTongDaySo
            // 
            txtTongDaySo.Location = new Point(231, 185);
            txtTongDaySo.Margin = new Padding(3, 4, 3, 4);
            txtTongDaySo.Name = "txtTongDaySo";
            txtTongDaySo.Size = new Size(138, 27);
            txtTongDaySo.TabIndex = 7;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(291, 227);
            txtTongLe.Margin = new Padding(3, 4, 3, 4);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(77, 27);
            txtTongLe.TabIndex = 7;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(117, 227);
            txtTongChan.Margin = new Padding(3, 4, 3, 4);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(89, 27);
            txtTongChan.TabIndex = 7;
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(179, 146);
            txtNhapSo.Margin = new Padding(3, 4, 3, 4);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(190, 27);
            txtNhapSo.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 372);
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
            Margin = new Padding(3, 4, 3, 4);
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