namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGPTBH bai1 = new FormGPTBH();
            bai1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTTDS bai2 = new FormTTDS();
            bai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKT_TSNT bai3 = new FormKT_TSNT();
            bai3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTSLN bai4 = new FormTSLN();
            bai4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDSTC bai5 = new FormDSTC();
            bai5.ShowDialog();
        }
    }
}
