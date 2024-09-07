using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormDSTC : Form
    {
        public FormDSTC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string[] chuSo = ["Vui lòng điền số từ 1 đến 10", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín"];
        private int GetInput()
        {
            int input;
            if (!int.TryParse(textBox1.Text, out input))
            {
                MessageBox.Show("Lỗi kiểu dữ liệu không đúng: Vui lòng nhập số","Lỗi");
                return input = 0;
            }
            if (input > 10 || input < 0)
            {
                MessageBox.Show("Lỗi vui lòng nhập số từ 1 đến 10","Lỗi");
                return input = 0;
            }
            return input;            
        }

        private string DocSo()
        {
            int index = GetInput();
            string ketQua = chuSo[index];
            return ketQua;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = DocSo();
            textBox1.Text = "";            
        }
    }
}
