namespace winFormsTut2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string date = monthCalendar.SelectionStart.ToShortDateString();
            string note = noteTextBox.Text;
            ListViewItem item = new ListViewItem(new[] { date, note });
            calenderListView.Items.Add(item);
            noteTextBox.Text = "";
            notifyIcon1.ShowBalloonTip(1000, "smthng smthng tip title", "new event added", ToolTipIcon.Info);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in calenderListView.SelectedItems)
            {
                calenderListView.Items.Remove(item);
            }

        }

        private void calenderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = calenderListView.SelectedItems.Count > 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIconContextMenu.Items.Add("exit", null, ExitContextMenu_Clik);
        }

        private void ExitContextMenu_Clik(object sender, EventArgs e)
        {
            Close();
        }
    }
}