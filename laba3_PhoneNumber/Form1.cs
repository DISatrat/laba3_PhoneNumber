using System.Security.Cryptography.X509Certificates;

namespace laba3_PhoneNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;


            if (input.Length == 9)
            {
                string formattedText = "8(9"+input.Substring(0, 2)+")"+input.Substring(2, 3)+"-"+input.Substring(5, 2)+"-"+input.Substring(7);


                label3.Text = formattedText;
              
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}