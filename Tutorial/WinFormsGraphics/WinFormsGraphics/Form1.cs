namespace WinFormsGraphics
{
    public partial class Form1 : Form
    {
        private Bitmap drawArea;
        private const int RADIUS = 10;
        private Pen pen;
        public Form1()
        {
            InitializeComponent();
            drawArea = new Bitmap(canvas.Width, canvas.Height);
            canvas.Image = drawArea;

            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.LightBlue);
            }
            pen = new Pen(Brushes.Black, 3);
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                using(Graphics g = Graphics.FromImage(drawArea))
                {
                    g.FillEllipse(Brushes.White, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                    g.DrawEllipse(pen, e.X - RADIUS, e.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                }
                canvas.Refresh();
            }
        }
    }
}