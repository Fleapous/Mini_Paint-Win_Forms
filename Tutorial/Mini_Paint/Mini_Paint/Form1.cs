namespace Mini_Paint
{
    public partial class Form1 : Form
    {
        private Bitmap drawArea;
        private Pen pen;
        public Form1()
        {
            InitializeComponent();
            //tableLayoutPanel1.Margin = Padding.Empty;
            drawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pen = new Pen(Brushes.Black, 1);
            pictureBox1.Image = drawArea;
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
            }

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Cursor = Cursors.Cross;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               using(Graphics g = Graphics.FromImage(drawArea))
                {
                    g.FillEllipse(Brushes.Black, e.X - 10, e.Y - 10, 2 * 10, 10 * 2);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.DrawLine(pen, e.X, e.Y, e.X + 2, e.Y + 2);
            }
        }
    }
}