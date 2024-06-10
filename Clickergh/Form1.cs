namespace Clickergh
{
    public partial class Form1 : Form
    {
        public bool isClick = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.Location = new Point(233, 73);
            isClick = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(350, 300);
            pictureBox1.Location = new Point(208, 73);
        }
    }
}
