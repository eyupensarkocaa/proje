namespace swichcaseornegi
{
    public partial class Form1 : Form
    {
        string isim;
        private void button1_Click(object sender, EventArgs e)
        {
            isim = textBox1.Text;
            switch (isim)
            {
                case "ey�p ensar":
                    MessageBox.Show("giri� yap�l�yor");
                    break;
                case "bekir":
                    MessageBox.Show("Giri� yap�l�yor");
                    break;
                case "selim":
                    MessageBox.Show("Giri� yap�l�yor");
                    break;
                default:
                    MessageBox.Show("Giri� yap�lamad�");
                    break;
            }
        }
    }
}
        
