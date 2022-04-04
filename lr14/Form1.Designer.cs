
namespace lr14
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButtoDateTime = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTime = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxX = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxY = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxZ = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxA = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxB = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonT2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemZ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemXY = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelState,
            this.toolStripStatusLabelClock,
            this.toolStripDropDownButtoDateTime,
            this.toolStripDropDownButtonT2});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 512);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(895, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip2";
            this.MainStatusStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "белый",
            "красный",
            "черный",
            "синий",
            "желтый"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.ToolTipText = "Готовые цвета";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Красный";
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Зеленый";
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Синий";
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "E&xit";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(793, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuComboBox2,
            this.contextMenuTextBox1,
            this.contextMenuTextBox2,
            this.contextMenuTextBox3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 106);
            // 
            // contextMenuComboBox2
            // 
            this.contextMenuComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contextMenuComboBox2.Items.AddRange(new object[] {
            "белый",
            "красный",
            "черный",
            "синий",
            "желтый"});
            this.contextMenuComboBox2.Name = "contextMenuComboBox2";
            this.contextMenuComboBox2.Size = new System.Drawing.Size(121, 23);
            this.contextMenuComboBox2.ToolTipText = "Готовые цвета";
            this.contextMenuComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // contextMenuTextBox1
            // 
            this.contextMenuTextBox1.Name = "contextMenuTextBox1";
            this.contextMenuTextBox1.Size = new System.Drawing.Size(100, 23);
            this.contextMenuTextBox1.Text = "0";
            this.contextMenuTextBox1.ToolTipText = "Красный";
            this.contextMenuTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // contextMenuTextBox2
            // 
            this.contextMenuTextBox2.Name = "contextMenuTextBox2";
            this.contextMenuTextBox2.Size = new System.Drawing.Size(100, 23);
            this.contextMenuTextBox2.Text = "0";
            this.contextMenuTextBox2.ToolTipText = "Зеленый";
            this.contextMenuTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // contextMenuTextBox3
            // 
            this.contextMenuTextBox3.Name = "contextMenuTextBox3";
            this.contextMenuTextBox3.Size = new System.Drawing.Size(100, 23);
            this.contextMenuTextBox3.Text = "0";
            this.contextMenuTextBox3.ToolTipText = "Синий";
            this.contextMenuTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(692, 17);
            this.toolStripStatusLabelState.Spring = true;
            this.toolStripStatusLabelState.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripStatusLabelState.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // toolStripStatusLabelClock
            // 
            this.toolStripStatusLabelClock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            this.toolStripStatusLabelClock.Size = new System.Drawing.Size(4, 17);
            this.toolStripStatusLabelClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // toolStripDropDownButtoDateTime
            // 
            this.toolStripDropDownButtoDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtoDateTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDate,
            this.toolStripMenuItemTime});
            this.toolStripDropDownButtoDateTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtoDateTime.Image")));
            this.toolStripDropDownButtoDateTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtoDateTime.Name = "toolStripDropDownButtoDateTime";
            this.toolStripDropDownButtoDateTime.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButtoDateTime.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButtoDateTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // toolStripMenuItemDate
            // 
            this.toolStripMenuItemDate.Name = "toolStripMenuItemDate";
            this.toolStripMenuItemDate.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDate.Text = "Текущая дата";
            this.toolStripMenuItemDate.Click += new System.EventHandler(this.toolStripMenuItemDate_Click);
            // 
            // toolStripMenuItemTime
            // 
            this.toolStripMenuItemTime.Name = "toolStripMenuItemTime";
            this.toolStripMenuItemTime.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemTime.Text = "Текущее время";
            this.toolStripMenuItemTime.Click += new System.EventHandler(this.toolStripMenuItemTime_Click);
            // 
            // timerDateTimeUpdate
            // 
            this.timerDateTimeUpdate.Enabled = true;
            this.timerDateTimeUpdate.Interval = 1000;
            this.timerDateTimeUpdate.Tick += new System.EventHandler(this.timerDateTimeUpdate_Tick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxX,
            this.toolStripTextBoxY,
            this.toolStripTextBoxZ,
            this.toolStripComboBoxA,
            this.toolStripComboBoxB,
            this.toolStripSeparator2,
            this.toolStripMenuItemCalc});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem2.Text = "Задание 1";
            this.toolStripMenuItem2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // toolStripTextBoxX
            // 
            this.toolStripTextBoxX.Name = "toolStripTextBoxX";
            this.toolStripTextBoxX.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxX.Text = "0";
            this.toolStripTextBoxX.ToolTipText = "Переменная х";
            // 
            // toolStripTextBoxY
            // 
            this.toolStripTextBoxY.Name = "toolStripTextBoxY";
            this.toolStripTextBoxY.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxY.Text = "0";
            this.toolStripTextBoxY.ToolTipText = "Переменная y";
            // 
            // toolStripTextBoxZ
            // 
            this.toolStripTextBoxZ.Name = "toolStripTextBoxZ";
            this.toolStripTextBoxZ.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxZ.Text = "0";
            this.toolStripTextBoxZ.ToolTipText = "Переменная z";
            // 
            // toolStripComboBoxA
            // 
            this.toolStripComboBoxA.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.toolStripComboBoxA.Name = "toolStripComboBoxA";
            this.toolStripComboBoxA.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxA.Text = "a";
            this.toolStripComboBoxA.ToolTipText = "Константа а";
            // 
            // toolStripComboBoxB
            // 
            this.toolStripComboBoxB.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.toolStripComboBoxB.Name = "toolStripComboBoxB";
            this.toolStripComboBoxB.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxB.Text = "b";
            this.toolStripComboBoxB.ToolTipText = "Константа b";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItemCalc
            // 
            this.toolStripMenuItemCalc.Name = "toolStripMenuItemCalc";
            this.toolStripMenuItemCalc.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItemCalc.Text = "Вычислить";
            this.toolStripMenuItemCalc.Click += new System.EventHandler(this.toolStripMenuItemCalc_Click);
            // 
            // toolStripDropDownButtonT2
            // 
            this.toolStripDropDownButtonT2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonT2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemZ,
            this.toolStripMenuItemXY});
            this.toolStripDropDownButtonT2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonT2.Image")));
            this.toolStripDropDownButtonT2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonT2.Name = "toolStripDropDownButtonT2";
            this.toolStripDropDownButtonT2.Size = new System.Drawing.Size(74, 20);
            this.toolStripDropDownButtonT2.Text = "Задание 2";
            this.toolStripDropDownButtonT2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // toolStripMenuItemZ
            // 
            this.toolStripMenuItemZ.Name = "toolStripMenuItemZ";
            this.toolStripMenuItemZ.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItemZ.Text = "Результат выражения z";
            this.toolStripMenuItemZ.Click += new System.EventHandler(this.toolStripMenuItemZ_Click);
            // 
            // toolStripMenuItemXY
            // 
            this.toolStripMenuItemXY.Name = "toolStripMenuItemXY";
            this.toolStripMenuItemXY.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItemXY.Text = "Координаты курсора";
            this.toolStripMenuItemXY.Click += new System.EventHandler(this.toolStripMenuItemXY_Click);
            this.toolStripMenuItemXY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ImageLocation = "C:\\Users\\retak\\source\\repos\\lr12-21\\lr14\\Screenshot_14.png";
            this.pictureBox1.Location = new System.Drawing.Point(156, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 534);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox contextMenuComboBox2;
        private System.Windows.Forms.ToolStripTextBox contextMenuTextBox1;
        private System.Windows.Forms.ToolStripTextBox contextMenuTextBox2;
        private System.Windows.Forms.ToolStripTextBox contextMenuTextBox3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClock;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtoDateTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTime;
        private System.Windows.Forms.Timer timerDateTimeUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxX;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxY;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxZ;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxA;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCalc;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonT2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZ;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemXY;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

