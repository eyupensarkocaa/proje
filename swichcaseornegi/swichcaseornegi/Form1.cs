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
                case "eyüp ensar":
                    MessageBox.Show("giriþ yapýlýyor");
                    break;
                case "bekir":
                    MessageBox.Show("Giriþ yapýlýyor");
                    break;
                case "selim":
                    MessageBox.Show("Giriþ yapýlýyor");
                    break;
                default:
                    MessageBox.Show("Giriþ yapýlamadý");
                    break;
            }
        }
    }
}
        
