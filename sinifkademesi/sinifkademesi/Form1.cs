namespace sinifkademesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinif = Convert.ToByte(comboBox1.SelectedItem);
            if (sinif > 0 && sinif < 5)
            {
                label1.Text = ("ilkokul kademesindesiniz");
            }
            else if (sinif > 4 && sinif < 9)
            {
                label1.Text = ("ortaokul kademesindesiniz");
            }
            else if (sinif > 8 && sinif < 13)
            {
                label1.Text = ("lise kademesindesiniz");
            }
        }
    }
}
