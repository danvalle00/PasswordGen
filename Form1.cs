

using PasswordGen.Generator;

namespace PasswordGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordRandomizer genPassword = new PasswordRandomizer();
            string newPass = genPassword.GeneratePassword();
            label2.Text = newPass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(label2.Text);
            MessageBox.Show("Copied to Clipboard!");
        }
    }
}
