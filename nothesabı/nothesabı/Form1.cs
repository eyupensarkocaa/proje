namespace nothesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlıs, matYanlış;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(textBox1.Text);
            turkceYanlıs = Convert.ToDouble(textBox2.Text);
            turkceNet = (turkceDogru - (turkceYanlıs / 4));
            textBox3.Text = turkceNet.ToString();
            matDogru = Convert.ToDouble(textBox4.Text);
            matYanlış = Convert.ToDouble(textBox5.Text);
            matNet = (matDogru - (matYanlış / 4));
            textBox6.Text = matNet.ToString();
        }
    }
    }

