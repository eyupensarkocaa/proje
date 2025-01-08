namespace yuzdealma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sayi1, yuzdelik;
            sayi1 = Convert.ToInt32(textBox1.Text);
            int yuzde = (sayi1 * 18 / 100);
            MessageBox.Show(yuzde.ToString());
        }
    }
    }

