using System.Windows.Forms;

namespace Mini_Paint
{
    public partial class Form1 : Form
    {
        private Bitmap drawArea;
        private Pen pen;
        private int X = -1;
        private int Y = -1;
        bool DrawClick = false;
        bool DrawButton = false;
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

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.DrawLine(pen, X, Y, e.X, e.Y);
                X = e.X; Y = e.Y;
            }
            pictureBox1.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //DrawButton = !DrawButton;
            //toolStrip1.
        }

        private void tableLayoutPanel1_Layout(object sender, LayoutEventArgs e)
        {
            int newWith = tableLayoutPanel1.GetControlFromPosition(0, 0).Size.Width;
            int newHeight = tableLayoutPanel1.GetControlFromPosition(0, 0).Size.Height;
            pictureBox1.Size = new Size(newWith, newHeight);

            drawArea?.Dispose();

            drawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = drawArea;
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
            }
        }

        //    private void ColorFill()
        //    {
        //        foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
        //        {
        //            SquareControl_ tmp = new SquareControl_();
        //            tmp.Color = color;

        //            //PictureBox button = new PictureBox();
        //            //button.BackColor = Color.FromKnownColor(color);
        //            //button.Size = new Size(25, 25);
        //            //button.Name = color.ToString();
        //            //button.Click += new EventHandler(this.btnCLick_Event);
        //            //flowLayoutPanel.Controls.Add(button);
        //        }
        //    }
    }

    //public partial class SquareControl_ : UserControl
    //{
    //    private KnownColor _color;

    //    public KnownColor Color
    //    {
    //        get { return _color; }
    //        set
    //        {
    //            _color = value;
    //            Invalidate(); // Redraw the control when the color changes
    //        }
    //    }

    //    protected override void OnPaint(PaintEventArgs e)
    //    {
    //        base.OnPaint(e);

    //        var brush = new SolidBrush(System.Drawing.Color.FromKnownColor(_color));

    //        // Draw a rectangle with the specified color to create the appearance of a square
    //        e.Graphics.FillRectangle(brush, 0, 0, Width, Height);
    //    }
    //}

}