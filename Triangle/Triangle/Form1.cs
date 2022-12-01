using System.Drawing;


namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.BackColor = Color.DarkGray;
            pictureBox1.BackColor = Color.AliceBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics graphics = Graphics.FromImage(bmp)) 
            {
                graphics.DrawLine(new Pen(Color.Red,5f), 0, 0, 180, 150);
            }

            pictureBox1.Image = bmp;
        }
    }
}