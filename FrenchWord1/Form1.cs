namespace FrenchWord1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //one
            this.displayText.Text = "un";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this is two
            this.displayText.Text = "deux";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this is three
            this.displayText.Text = "trois";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this is four
            this.displayText.Text = "quatre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is five
            this.displayText.Text = "cinq";
        }

        private void displayText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //most effecient way to close program Ref:
            //https://stackoverflow.com/questions/9586664/using-exit-button-to-close-a-winform-program
            this.Close();
        }
    }
}
