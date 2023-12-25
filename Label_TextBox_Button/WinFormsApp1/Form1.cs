namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Enes";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = ("Kübra");
            label7.Text = ("EYMÜRTEPE");
            label8.Text = ("Biliþim Uzmaný");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = ("Yazýlým Mühendisliði");

            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }

    /* 3 textbox - 3 label ekle. 
       Butona bastýðýnýzda verileri textboxtan alýp labela aktarsýn.
    */

}

