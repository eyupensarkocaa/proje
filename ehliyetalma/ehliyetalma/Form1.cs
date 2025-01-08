namespace ehliyetalma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt32(textBox1.Text);
            if (yas > 17)
            {
                MessageBox.Show("ehliyet alabilirsiniz");
            }
            else
            {
                MessageBox.Show("yaþýnýz tutmuyor");
            }
        }
    }
}
 