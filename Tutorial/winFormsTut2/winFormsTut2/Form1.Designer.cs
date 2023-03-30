namespace winFormsTut2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            noteTextBox = new TextBox();
            monthCalendar = new MonthCalendar();
            removeButton = new Button();
            addButton = new Button();
            calenderListView = new ListView();
            dateColumnHeader = new ColumnHeader();
            noteColumnHeader = new ColumnHeader();
            notifyIcon1 = new NotifyIcon(components);
            notifyIconContextMenu = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.InactiveCaption;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel1.Controls.Add(noteTextBox);
            splitContainer1.Panel1.Controls.Add(monthCalendar);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel2.Controls.Add(removeButton);
            splitContainer1.Panel2.Controls.Add(addButton);
            splitContainer1.Panel2.Controls.Add(calenderListView);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(784, 461);
            splitContainer1.SplitterDistance = 261;
            splitContainer1.TabIndex = 0;
            // 
            // noteTextBox
            // 
            noteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            noteTextBox.Location = new Point(479, 9);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(302, 249);
            noteTextBox.TabIndex = 1;
            // 
            // monthCalendar
            // 
            monthCalendar.CalendarDimensions = new Size(2, 1);
            monthCalendar.Location = new Point(9, 9);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // removeButton
            // 
            removeButton.Enabled = false;
            removeButton.Location = new Point(90, 10);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 2;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(9, 10);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // calenderListView
            // 
            calenderListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calenderListView.Columns.AddRange(new ColumnHeader[] { dateColumnHeader, noteColumnHeader });
            calenderListView.FullRowSelect = true;
            calenderListView.Location = new Point(9, 39);
            calenderListView.Name = "calenderListView";
            calenderListView.Size = new Size(763, 145);
            calenderListView.TabIndex = 0;
            calenderListView.UseCompatibleStateImageBehavior = false;
            calenderListView.View = View.Details;
            calenderListView.SelectedIndexChanged += calenderListView_SelectedIndexChanged;
            // 
            // dateColumnHeader
            // 
            dateColumnHeader.Text = "Date";
            dateColumnHeader.Width = 120;
            // 
            // noteColumnHeader
            // 
            noteColumnHeader.Text = "Note";
            noteColumnHeader.Width = 200;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = notifyIconContextMenu;
            notifyIcon1.Text = "winformsCalender";
            notifyIcon1.Visible = true;
            // 
            // notifyIconContextMenu
            // 
            notifyIconContextMenu.Name = "notifyIconContextMenu";
            notifyIconContextMenu.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox noteTextBox;
        private MonthCalendar monthCalendar;
        private Button removeButton;
        private Button addButton;
        private ListView calenderListView;
        private ColumnHeader dateColumnHeader;
        private ColumnHeader noteColumnHeader;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip notifyIconContextMenu;
    }
}