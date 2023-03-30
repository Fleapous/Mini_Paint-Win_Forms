namespace WInFormsGallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colordiag = new ColorDialog();
            if (colordiag.ShowDialog() == DialogResult.OK)
            {
                galleryLayoutPanel.GetControlFromPosition(1, 1).BackColor = colordiag.Color;
                galleryLayoutPanel.GetControlFromPosition(0, 1).BackColor = colordiag.Color;
            }
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDiag = new OpenFileDialog();
            fileDiag.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if(fileDiag.ShowDialog() == DialogResult.OK)
            {
                galleryLayoutPanel.GetControlFromPosition(0, 0).BackgroundImage =
                    new Bitmap(fileDiag.FileName);
                galleryLayoutPanel.GetControlFromPosition(0, 0).BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}