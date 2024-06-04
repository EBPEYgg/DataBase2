namespace DataBase2
{
    partial class SQLForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SQLTabControl = new System.Windows.Forms.TabControl();
            this.FirstTabPage = new System.Windows.Forms.TabPage();
            this.SQLDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectGroupBox = new System.Windows.Forms.GroupBox();
            this.GuestsRadioButton = new System.Windows.Forms.RadioButton();
            this.RoomsRadioButton = new System.Windows.Forms.RadioButton();
            this.OrdersRadioButton = new System.Windows.Forms.RadioButton();
            this.StaffRadioButton = new System.Windows.Forms.RadioButton();
            this.SecondTabPage = new System.Windows.Forms.TabPage();
            this.SelectDataGridView = new System.Windows.Forms.DataGridView();
            this.StaffGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowResultButton = new System.Windows.Forms.Button();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.WithoutDetalizationRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthRadioButton = new System.Windows.Forms.RadioButton();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.SubqueryTabPage = new System.Windows.Forms.TabPage();
            this.SubQueryDataGridView = new System.Windows.Forms.DataGridView();
            this.SubqueryGroupBox = new System.Windows.Forms.GroupBox();
            this.SubqueryButton = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NoCorrelatedRadioButton = new System.Windows.Forms.RadioButton();
            this.CorrelatedRadioButton = new System.Windows.Forms.RadioButton();
            this.DMLTabPage = new System.Windows.Forms.TabPage();
            this.RoomDataGridView = new System.Windows.Forms.DataGridView();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.AllInclusiveCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenPhotoButton = new System.Windows.Forms.Button();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.PhotoLabel = new System.Windows.Forms.Label();
            this.AllInclusiveLabel = new System.Windows.Forms.Label();
            this.CleaningFrequencyLabel = new System.Windows.Forms.Label();
            this.ServiceNameLabel = new System.Windows.Forms.Label();
            this.StatusRoomLabel = new System.Windows.Forms.Label();
            this.TypeRoomLabel = new System.Windows.Forms.Label();
            this.CleaningFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.StatusRoomTextBox = new System.Windows.Forms.TextBox();
            this.TypeRoomTextBox = new System.Windows.Forms.TextBox();
            this.NameRenterTextBox = new System.Windows.Forms.TextBox();
            this.NameRenterLabel = new System.Windows.Forms.Label();
            this.IdGuestTextBox = new System.Windows.Forms.TextBox();
            this.IdGuestLabel = new System.Windows.Forms.Label();
            this.DMLGroupBox = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.DMLExecuteButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.IdLabel = new System.Windows.Forms.Label();
            this.UpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.InsertRadioButton = new System.Windows.Forms.RadioButton();
            this.PhotoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SQLTabControl.SuspendLayout();
            this.FirstTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataGridView)).BeginInit();
            this.SelectGroupBox.SuspendLayout();
            this.SecondTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).BeginInit();
            this.StaffGroupBox.SuspendLayout();
            this.DetailsGroupBox.SuspendLayout();
            this.SubqueryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubQueryDataGridView)).BeginInit();
            this.SubqueryGroupBox.SuspendLayout();
            this.DMLTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridView)).BeginInit();
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.DMLGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQLTabControl
            // 
            this.SQLTabControl.Controls.Add(this.FirstTabPage);
            this.SQLTabControl.Controls.Add(this.SecondTabPage);
            this.SQLTabControl.Controls.Add(this.SubqueryTabPage);
            this.SQLTabControl.Controls.Add(this.DMLTabPage);
            this.SQLTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLTabControl.Location = new System.Drawing.Point(0, 0);
            this.SQLTabControl.Name = "SQLTabControl";
            this.SQLTabControl.SelectedIndex = 0;
            this.SQLTabControl.Size = new System.Drawing.Size(800, 450);
            this.SQLTabControl.TabIndex = 0;
            // 
            // FirstTabPage
            // 
            this.FirstTabPage.Controls.Add(this.SQLDataGridView);
            this.FirstTabPage.Controls.Add(this.SelectGroupBox);
            this.FirstTabPage.Location = new System.Drawing.Point(4, 22);
            this.FirstTabPage.Name = "FirstTabPage";
            this.FirstTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTabPage.Size = new System.Drawing.Size(792, 424);
            this.FirstTabPage.TabIndex = 0;
            this.FirstTabPage.Text = "Примеры запросов";
            this.FirstTabPage.UseVisualStyleBackColor = true;
            // 
            // SQLDataGridView
            // 
            this.SQLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLDataGridView.Location = new System.Drawing.Point(3, 128);
            this.SQLDataGridView.Name = "SQLDataGridView";
            this.SQLDataGridView.Size = new System.Drawing.Size(786, 293);
            this.SQLDataGridView.TabIndex = 2;
            // 
            // SelectGroupBox
            // 
            this.SelectGroupBox.Controls.Add(this.GuestsRadioButton);
            this.SelectGroupBox.Controls.Add(this.RoomsRadioButton);
            this.SelectGroupBox.Controls.Add(this.OrdersRadioButton);
            this.SelectGroupBox.Controls.Add(this.StaffRadioButton);
            this.SelectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectGroupBox.Name = "SelectGroupBox";
            this.SelectGroupBox.Size = new System.Drawing.Size(786, 125);
            this.SelectGroupBox.TabIndex = 0;
            this.SelectGroupBox.TabStop = false;
            this.SelectGroupBox.Text = "Запросы по данным";
            // 
            // GuestsRadioButton
            // 
            this.GuestsRadioButton.AutoSize = true;
            this.GuestsRadioButton.Location = new System.Drawing.Point(6, 88);
            this.GuestsRadioButton.Name = "GuestsRadioButton";
            this.GuestsRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GuestsRadioButton.TabIndex = 3;
            this.GuestsRadioButton.TabStop = true;
            this.GuestsRadioButton.Text = "Гости";
            this.GuestsRadioButton.UseVisualStyleBackColor = true;
            this.GuestsRadioButton.CheckedChanged += new System.EventHandler(this.GuestsRadioButton_CheckedChanged);
            // 
            // RoomsRadioButton
            // 
            this.RoomsRadioButton.AutoSize = true;
            this.RoomsRadioButton.Location = new System.Drawing.Point(6, 65);
            this.RoomsRadioButton.Name = "RoomsRadioButton";
            this.RoomsRadioButton.Size = new System.Drawing.Size(71, 17);
            this.RoomsRadioButton.TabIndex = 2;
            this.RoomsRadioButton.TabStop = true;
            this.RoomsRadioButton.Text = "Комнаты";
            this.RoomsRadioButton.UseVisualStyleBackColor = true;
            this.RoomsRadioButton.CheckedChanged += new System.EventHandler(this.RoomsRadioButton_CheckedChanged);
            // 
            // OrdersRadioButton
            // 
            this.OrdersRadioButton.AutoSize = true;
            this.OrdersRadioButton.Location = new System.Drawing.Point(6, 42);
            this.OrdersRadioButton.Name = "OrdersRadioButton";
            this.OrdersRadioButton.Size = new System.Drawing.Size(64, 17);
            this.OrdersRadioButton.TabIndex = 1;
            this.OrdersRadioButton.TabStop = true;
            this.OrdersRadioButton.Text = "Заказы";
            this.OrdersRadioButton.UseVisualStyleBackColor = true;
            this.OrdersRadioButton.CheckedChanged += new System.EventHandler(this.OrdersRadioButton_CheckedChanged);
            // 
            // StaffRadioButton
            // 
            this.StaffRadioButton.AutoSize = true;
            this.StaffRadioButton.Location = new System.Drawing.Point(6, 19);
            this.StaffRadioButton.Name = "StaffRadioButton";
            this.StaffRadioButton.Size = new System.Drawing.Size(75, 17);
            this.StaffRadioButton.TabIndex = 0;
            this.StaffRadioButton.TabStop = true;
            this.StaffRadioButton.Text = "Персонал";
            this.StaffRadioButton.UseVisualStyleBackColor = true;
            this.StaffRadioButton.CheckedChanged += new System.EventHandler(this.StaffRadioButton_CheckedChanged);
            // 
            // SecondTabPage
            // 
            this.SecondTabPage.Controls.Add(this.SelectDataGridView);
            this.SecondTabPage.Controls.Add(this.StaffGroupBox);
            this.SecondTabPage.Location = new System.Drawing.Point(4, 22);
            this.SecondTabPage.Name = "SecondTabPage";
            this.SecondTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTabPage.Size = new System.Drawing.Size(792, 424);
            this.SecondTabPage.TabIndex = 1;
            this.SecondTabPage.Text = "Полная запись SELECT";
            this.SecondTabPage.UseVisualStyleBackColor = true;
            // 
            // SelectDataGridView
            // 
            this.SelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectDataGridView.Location = new System.Drawing.Point(3, 97);
            this.SelectDataGridView.Name = "SelectDataGridView";
            this.SelectDataGridView.Size = new System.Drawing.Size(786, 324);
            this.SelectDataGridView.TabIndex = 1;
            // 
            // StaffGroupBox
            // 
            this.StaffGroupBox.Controls.Add(this.ShowResultButton);
            this.StaffGroupBox.Controls.Add(this.DetailsGroupBox);
            this.StaffGroupBox.Controls.Add(this.CountTextBox);
            this.StaffGroupBox.Controls.Add(this.CountLabel);
            this.StaffGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaffGroupBox.Location = new System.Drawing.Point(3, 3);
            this.StaffGroupBox.Name = "StaffGroupBox";
            this.StaffGroupBox.Size = new System.Drawing.Size(786, 94);
            this.StaffGroupBox.TabIndex = 0;
            this.StaffGroupBox.TabStop = false;
            this.StaffGroupBox.Text = "Количество оформленных заказов";
            // 
            // ShowResultButton
            // 
            this.ShowResultButton.Location = new System.Drawing.Point(229, 16);
            this.ShowResultButton.Name = "ShowResultButton";
            this.ShowResultButton.Size = new System.Drawing.Size(111, 23);
            this.ShowResultButton.TabIndex = 3;
            this.ShowResultButton.Text = "Show Result";
            this.ShowResultButton.UseVisualStyleBackColor = true;
            this.ShowResultButton.Click += new System.EventHandler(this.ShowResultButton_Click);
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Controls.Add(this.MonthComboBox);
            this.DetailsGroupBox.Controls.Add(this.WithoutDetalizationRadioButton);
            this.DetailsGroupBox.Controls.Add(this.MonthRadioButton);
            this.DetailsGroupBox.Location = new System.Drawing.Point(518, 17);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Size = new System.Drawing.Size(262, 66);
            this.DetailsGroupBox.TabIndex = 2;
            this.DetailsGroupBox.TabStop = false;
            this.DetailsGroupBox.Text = "Детализация";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.MonthComboBox.Location = new System.Drawing.Point(146, 18);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(110, 21);
            this.MonthComboBox.TabIndex = 2;
            // 
            // WithoutDetalizationRadioButton
            // 
            this.WithoutDetalizationRadioButton.AutoSize = true;
            this.WithoutDetalizationRadioButton.Location = new System.Drawing.Point(6, 42);
            this.WithoutDetalizationRadioButton.Name = "WithoutDetalizationRadioButton";
            this.WithoutDetalizationRadioButton.Size = new System.Drawing.Size(112, 17);
            this.WithoutDetalizationRadioButton.TabIndex = 1;
            this.WithoutDetalizationRadioButton.TabStop = true;
            this.WithoutDetalizationRadioButton.Text = "Без детализации";
            this.WithoutDetalizationRadioButton.UseVisualStyleBackColor = true;
            this.WithoutDetalizationRadioButton.CheckedChanged += new System.EventHandler(this.WithoutDetalizationRadioButton_CheckedChanged);
            // 
            // MonthRadioButton
            // 
            this.MonthRadioButton.AutoSize = true;
            this.MonthRadioButton.Location = new System.Drawing.Point(6, 19);
            this.MonthRadioButton.Name = "MonthRadioButton";
            this.MonthRadioButton.Size = new System.Drawing.Size(134, 17);
            this.MonthRadioButton.TabIndex = 0;
            this.MonthRadioButton.TabStop = true;
            this.MonthRadioButton.Text = "За выбранный месяц";
            this.MonthRadioButton.UseVisualStyleBackColor = true;
            this.MonthRadioButton.CheckedChanged += new System.EventHandler(this.MonthRadioButton_CheckedChanged);
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(123, 17);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountTextBox.TabIndex = 1;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(7, 20);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(110, 13);
            this.CountLabel.TabIndex = 0;
            this.CountLabel.Text = "Введите количество";
            // 
            // SubqueryTabPage
            // 
            this.SubqueryTabPage.Controls.Add(this.SubQueryDataGridView);
            this.SubqueryTabPage.Controls.Add(this.SubqueryGroupBox);
            this.SubqueryTabPage.Location = new System.Drawing.Point(4, 22);
            this.SubqueryTabPage.Name = "SubqueryTabPage";
            this.SubqueryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SubqueryTabPage.Size = new System.Drawing.Size(792, 424);
            this.SubqueryTabPage.TabIndex = 2;
            this.SubqueryTabPage.Text = "Примеры подзапросов";
            this.SubqueryTabPage.UseVisualStyleBackColor = true;
            // 
            // SubQueryDataGridView
            // 
            this.SubQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubQueryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubQueryDataGridView.Location = new System.Drawing.Point(3, 103);
            this.SubQueryDataGridView.Name = "SubQueryDataGridView";
            this.SubQueryDataGridView.Size = new System.Drawing.Size(786, 318);
            this.SubQueryDataGridView.TabIndex = 1;
            // 
            // SubqueryGroupBox
            // 
            this.SubqueryGroupBox.Controls.Add(this.SubqueryButton);
            this.SubqueryGroupBox.Controls.Add(this.NumberTextBox);
            this.SubqueryGroupBox.Controls.Add(this.NumberLabel);
            this.SubqueryGroupBox.Controls.Add(this.NoCorrelatedRadioButton);
            this.SubqueryGroupBox.Controls.Add(this.CorrelatedRadioButton);
            this.SubqueryGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubqueryGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SubqueryGroupBox.Name = "SubqueryGroupBox";
            this.SubqueryGroupBox.Size = new System.Drawing.Size(786, 100);
            this.SubqueryGroupBox.TabIndex = 0;
            this.SubqueryGroupBox.TabStop = false;
            this.SubqueryGroupBox.Text = "Подзапросы по данным";
            // 
            // SubqueryButton
            // 
            this.SubqueryButton.Location = new System.Drawing.Point(276, 63);
            this.SubqueryButton.Name = "SubqueryButton";
            this.SubqueryButton.Size = new System.Drawing.Size(156, 23);
            this.SubqueryButton.TabIndex = 4;
            this.SubqueryButton.Text = "Выполнить подзапрос";
            this.SubqueryButton.UseVisualStyleBackColor = true;
            this.SubqueryButton.Click += new System.EventHandler(this.SubqueryButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(89, 65);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 3;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(3, 68);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(80, 13);
            this.NumberLabel.TabIndex = 2;
            this.NumberLabel.Text = "Номер заказа";
            // 
            // NoCorrelatedRadioButton
            // 
            this.NoCorrelatedRadioButton.AutoSize = true;
            this.NoCorrelatedRadioButton.Location = new System.Drawing.Point(6, 42);
            this.NoCorrelatedRadioButton.Name = "NoCorrelatedRadioButton";
            this.NoCorrelatedRadioButton.Size = new System.Drawing.Size(188, 17);
            this.NoCorrelatedRadioButton.TabIndex = 1;
            this.NoCorrelatedRadioButton.TabStop = true;
            this.NoCorrelatedRadioButton.Text = "Некоррелированный подзапрос";
            this.NoCorrelatedRadioButton.UseVisualStyleBackColor = true;
            // 
            // CorrelatedRadioButton
            // 
            this.CorrelatedRadioButton.AutoSize = true;
            this.CorrelatedRadioButton.Location = new System.Drawing.Point(6, 19);
            this.CorrelatedRadioButton.Name = "CorrelatedRadioButton";
            this.CorrelatedRadioButton.Size = new System.Drawing.Size(175, 17);
            this.CorrelatedRadioButton.TabIndex = 0;
            this.CorrelatedRadioButton.TabStop = true;
            this.CorrelatedRadioButton.Text = "Коррелированный подзапрос";
            this.CorrelatedRadioButton.UseVisualStyleBackColor = true;
            // 
            // DMLTabPage
            // 
            this.DMLTabPage.Controls.Add(this.RoomDataGridView);
            this.DMLTabPage.Controls.Add(this.RoomPanel);
            this.DMLTabPage.Controls.Add(this.DMLGroupBox);
            this.DMLTabPage.Location = new System.Drawing.Point(4, 22);
            this.DMLTabPage.Name = "DMLTabPage";
            this.DMLTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DMLTabPage.Size = new System.Drawing.Size(792, 424);
            this.DMLTabPage.TabIndex = 3;
            this.DMLTabPage.Text = "Запросы изменения данных";
            this.DMLTabPage.UseVisualStyleBackColor = true;
            // 
            // RoomDataGridView
            // 
            this.RoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RoomDataGridView.Location = new System.Drawing.Point(3, 310);
            this.RoomDataGridView.Name = "RoomDataGridView";
            this.RoomDataGridView.Size = new System.Drawing.Size(786, 111);
            this.RoomDataGridView.TabIndex = 5;
            // 
            // RoomPanel
            // 
            this.RoomPanel.Controls.Add(this.AllInclusiveCheckBox);
            this.RoomPanel.Controls.Add(this.OpenPhotoButton);
            this.RoomPanel.Controls.Add(this.PhotoPictureBox);
            this.RoomPanel.Controls.Add(this.PhotoLabel);
            this.RoomPanel.Controls.Add(this.AllInclusiveLabel);
            this.RoomPanel.Controls.Add(this.CleaningFrequencyLabel);
            this.RoomPanel.Controls.Add(this.ServiceNameLabel);
            this.RoomPanel.Controls.Add(this.StatusRoomLabel);
            this.RoomPanel.Controls.Add(this.TypeRoomLabel);
            this.RoomPanel.Controls.Add(this.CleaningFrequencyTextBox);
            this.RoomPanel.Controls.Add(this.ServiceNameTextBox);
            this.RoomPanel.Controls.Add(this.StatusRoomTextBox);
            this.RoomPanel.Controls.Add(this.TypeRoomTextBox);
            this.RoomPanel.Controls.Add(this.NameRenterTextBox);
            this.RoomPanel.Controls.Add(this.NameRenterLabel);
            this.RoomPanel.Controls.Add(this.IdGuestTextBox);
            this.RoomPanel.Controls.Add(this.IdGuestLabel);
            this.RoomPanel.Location = new System.Drawing.Point(3, 125);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(775, 179);
            this.RoomPanel.TabIndex = 3;
            // 
            // AllInclusiveCheckBox
            // 
            this.AllInclusiveCheckBox.AutoSize = true;
            this.AllInclusiveCheckBox.Location = new System.Drawing.Point(171, 161);
            this.AllInclusiveCheckBox.Name = "AllInclusiveCheckBox";
            this.AllInclusiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AllInclusiveCheckBox.TabIndex = 16;
            this.AllInclusiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // OpenPhotoButton
            // 
            this.OpenPhotoButton.Location = new System.Drawing.Point(523, 30);
            this.OpenPhotoButton.Name = "OpenPhotoButton";
            this.OpenPhotoButton.Size = new System.Drawing.Size(77, 23);
            this.OpenPhotoButton.TabIndex = 15;
            this.OpenPhotoButton.Text = "Open Photo";
            this.OpenPhotoButton.UseVisualStyleBackColor = true;
            this.OpenPhotoButton.Click += new System.EventHandler(this.OpenPhotoButton_Click);
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Location = new System.Drawing.Point(606, 7);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(166, 166);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 14;
            this.PhotoPictureBox.TabStop = false;
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.AutoSize = true;
            this.PhotoLabel.Location = new System.Drawing.Point(520, 11);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(80, 13);
            this.PhotoLabel.TabIndex = 13;
            this.PhotoLabel.Text = "Изображение:";
            // 
            // AllInclusiveLabel
            // 
            this.AllInclusiveLabel.AutoSize = true;
            this.AllInclusiveLabel.Location = new System.Drawing.Point(7, 161);
            this.AllInclusiveLabel.Name = "AllInclusiveLabel";
            this.AllInclusiveLabel.Size = new System.Drawing.Size(119, 13);
            this.AllInclusiveLabel.TabIndex = 12;
            this.AllInclusiveLabel.Text = "Услуга все включено:";
            // 
            // CleaningFrequencyLabel
            // 
            this.CleaningFrequencyLabel.AutoSize = true;
            this.CleaningFrequencyLabel.Location = new System.Drawing.Point(7, 138);
            this.CleaningFrequencyLabel.Name = "CleaningFrequencyLabel";
            this.CleaningFrequencyLabel.Size = new System.Drawing.Size(90, 13);
            this.CleaningFrequencyLabel.TabIndex = 11;
            this.CleaningFrequencyLabel.Text = "Частота уборки:";
            // 
            // ServiceNameLabel
            // 
            this.ServiceNameLabel.AutoSize = true;
            this.ServiceNameLabel.Location = new System.Drawing.Point(7, 112);
            this.ServiceNameLabel.Name = "ServiceNameLabel";
            this.ServiceNameLabel.Size = new System.Drawing.Size(158, 13);
            this.ServiceNameLabel.TabIndex = 10;
            this.ServiceNameLabel.Text = "Название обсл. организации:";
            // 
            // StatusRoomLabel
            // 
            this.StatusRoomLabel.AutoSize = true;
            this.StatusRoomLabel.Location = new System.Drawing.Point(7, 86);
            this.StatusRoomLabel.Name = "StatusRoomLabel";
            this.StatusRoomLabel.Size = new System.Drawing.Size(92, 13);
            this.StatusRoomLabel.TabIndex = 9;
            this.StatusRoomLabel.Text = "Статус комнаты:";
            // 
            // TypeRoomLabel
            // 
            this.TypeRoomLabel.AutoSize = true;
            this.TypeRoomLabel.Location = new System.Drawing.Point(7, 60);
            this.TypeRoomLabel.Name = "TypeRoomLabel";
            this.TypeRoomLabel.Size = new System.Drawing.Size(77, 13);
            this.TypeRoomLabel.TabIndex = 8;
            this.TypeRoomLabel.Text = "Тип комнаты:";
            // 
            // CleaningFrequencyTextBox
            // 
            this.CleaningFrequencyTextBox.Location = new System.Drawing.Point(171, 135);
            this.CleaningFrequencyTextBox.Name = "CleaningFrequencyTextBox";
            this.CleaningFrequencyTextBox.Size = new System.Drawing.Size(150, 20);
            this.CleaningFrequencyTextBox.TabIndex = 7;
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.Location = new System.Drawing.Point(171, 109);
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.ServiceNameTextBox.TabIndex = 6;
            // 
            // StatusRoomTextBox
            // 
            this.StatusRoomTextBox.Location = new System.Drawing.Point(171, 83);
            this.StatusRoomTextBox.Name = "StatusRoomTextBox";
            this.StatusRoomTextBox.Size = new System.Drawing.Size(150, 20);
            this.StatusRoomTextBox.TabIndex = 5;
            // 
            // TypeRoomTextBox
            // 
            this.TypeRoomTextBox.Location = new System.Drawing.Point(171, 57);
            this.TypeRoomTextBox.Name = "TypeRoomTextBox";
            this.TypeRoomTextBox.Size = new System.Drawing.Size(150, 20);
            this.TypeRoomTextBox.TabIndex = 4;
            // 
            // NameRenterTextBox
            // 
            this.NameRenterTextBox.Location = new System.Drawing.Point(171, 31);
            this.NameRenterTextBox.Name = "NameRenterTextBox";
            this.NameRenterTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameRenterTextBox.TabIndex = 3;
            // 
            // NameRenterLabel
            // 
            this.NameRenterLabel.AutoSize = true;
            this.NameRenterLabel.Location = new System.Drawing.Point(7, 34);
            this.NameRenterLabel.Name = "NameRenterLabel";
            this.NameRenterLabel.Size = new System.Drawing.Size(99, 13);
            this.NameRenterLabel.TabIndex = 2;
            this.NameRenterLabel.Text = "ФИО арендатора:";
            // 
            // IdGuestTextBox
            // 
            this.IdGuestTextBox.Location = new System.Drawing.Point(171, 8);
            this.IdGuestTextBox.Name = "IdGuestTextBox";
            this.IdGuestTextBox.Size = new System.Drawing.Size(150, 20);
            this.IdGuestTextBox.TabIndex = 1;
            // 
            // IdGuestLabel
            // 
            this.IdGuestLabel.AutoSize = true;
            this.IdGuestLabel.Location = new System.Drawing.Point(7, 8);
            this.IdGuestLabel.Name = "IdGuestLabel";
            this.IdGuestLabel.Size = new System.Drawing.Size(49, 13);
            this.IdGuestLabel.TabIndex = 0;
            this.IdGuestLabel.Text = "id гостя:";
            // 
            // DMLGroupBox
            // 
            this.DMLGroupBox.Controls.Add(this.FindButton);
            this.DMLGroupBox.Controls.Add(this.DMLExecuteButton);
            this.DMLGroupBox.Controls.Add(this.SelectButton);
            this.DMLGroupBox.Controls.Add(this.IdTextBox);
            this.DMLGroupBox.Controls.Add(this.DeleteRadioButton);
            this.DMLGroupBox.Controls.Add(this.IdLabel);
            this.DMLGroupBox.Controls.Add(this.UpdateRadioButton);
            this.DMLGroupBox.Controls.Add(this.InsertRadioButton);
            this.DMLGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DMLGroupBox.Location = new System.Drawing.Point(3, 3);
            this.DMLGroupBox.Name = "DMLGroupBox";
            this.DMLGroupBox.Size = new System.Drawing.Size(786, 116);
            this.DMLGroupBox.TabIndex = 0;
            this.DMLGroupBox.TabStop = false;
            this.DMLGroupBox.Text = "Операторы";
            // 
            // FindButton
            // 
            this.FindButton.FlatAppearance.BorderSize = 0;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Image = global::DataBase2.Properties.Resources.loupe_24x24;
            this.FindButton.Location = new System.Drawing.Point(204, 85);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(24, 24);
            this.FindButton.TabIndex = 5;
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Visible = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // DMLExecuteButton
            // 
            this.DMLExecuteButton.Location = new System.Drawing.Point(264, 86);
            this.DMLExecuteButton.Name = "DMLExecuteButton";
            this.DMLExecuteButton.Size = new System.Drawing.Size(136, 23);
            this.DMLExecuteButton.TabIndex = 2;
            this.DMLExecuteButton.Text = "Выполнить запрос";
            this.DMLExecuteButton.UseVisualStyleBackColor = true;
            this.DMLExecuteButton.Click += new System.EventHandler(this.DMLExecuteButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(464, 86);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(136, 23);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "Показать список";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(98, 88);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 2;
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.AutoSize = true;
            this.DeleteRadioButton.Location = new System.Drawing.Point(6, 65);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(208, 17);
            this.DeleteRadioButton.TabIndex = 2;
            this.DeleteRadioButton.TabStop = true;
            this.DeleteRadioButton.Text = "Удалить данные с заданным кодом";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            this.DeleteRadioButton.CheckedChanged += new System.EventHandler(this.DeleteRadioButton_CheckedChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 91);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(89, 13);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Номер комнаты";
            // 
            // UpdateRadioButton
            // 
            this.UpdateRadioButton.AutoSize = true;
            this.UpdateRadioButton.Location = new System.Drawing.Point(6, 42);
            this.UpdateRadioButton.Name = "UpdateRadioButton";
            this.UpdateRadioButton.Size = new System.Drawing.Size(216, 17);
            this.UpdateRadioButton.TabIndex = 1;
            this.UpdateRadioButton.TabStop = true;
            this.UpdateRadioButton.Text = "Изменить данные с заданным кодом";
            this.UpdateRadioButton.UseVisualStyleBackColor = true;
            this.UpdateRadioButton.CheckedChanged += new System.EventHandler(this.UpdateRadioButton_CheckedChanged);
            // 
            // InsertRadioButton
            // 
            this.InsertRadioButton.AutoSize = true;
            this.InsertRadioButton.Location = new System.Drawing.Point(6, 19);
            this.InsertRadioButton.Name = "InsertRadioButton";
            this.InsertRadioButton.Size = new System.Drawing.Size(116, 17);
            this.InsertRadioButton.TabIndex = 0;
            this.InsertRadioButton.TabStop = true;
            this.InsertRadioButton.Text = "Добавить данные";
            this.InsertRadioButton.UseVisualStyleBackColor = true;
            this.InsertRadioButton.CheckedChanged += new System.EventHandler(this.InsertRadioButton_CheckedChanged);
            // 
            // PhotoOpenFileDialog
            // 
            this.PhotoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SQLTabControl);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SQLForm";
            this.Text = "Запросы";
            this.SQLTabControl.ResumeLayout(false);
            this.FirstTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataGridView)).EndInit();
            this.SelectGroupBox.ResumeLayout(false);
            this.SelectGroupBox.PerformLayout();
            this.SecondTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).EndInit();
            this.StaffGroupBox.ResumeLayout(false);
            this.StaffGroupBox.PerformLayout();
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.SubqueryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubQueryDataGridView)).EndInit();
            this.SubqueryGroupBox.ResumeLayout(false);
            this.SubqueryGroupBox.PerformLayout();
            this.DMLTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridView)).EndInit();
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.DMLGroupBox.ResumeLayout(false);
            this.DMLGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SQLTabControl;
        private System.Windows.Forms.TabPage FirstTabPage;
        private System.Windows.Forms.TabPage SecondTabPage;
        private System.Windows.Forms.GroupBox SelectGroupBox;
        private System.Windows.Forms.RadioButton StaffRadioButton;
        private System.Windows.Forms.RadioButton OrdersRadioButton;
        private System.Windows.Forms.DataGridView SQLDataGridView;
        private System.Windows.Forms.RadioButton RoomsRadioButton;
        private System.Windows.Forms.RadioButton GuestsRadioButton;
        private System.Windows.Forms.GroupBox StaffGroupBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.GroupBox DetailsGroupBox;
        private System.Windows.Forms.TabPage SubqueryTabPage;
        private System.Windows.Forms.GroupBox SubqueryGroupBox;
        private System.Windows.Forms.RadioButton NoCorrelatedRadioButton;
        private System.Windows.Forms.RadioButton CorrelatedRadioButton;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Button SubqueryButton;
        private System.Windows.Forms.DataGridView SubQueryDataGridView;
        private System.Windows.Forms.TabPage DMLTabPage;
        private System.Windows.Forms.GroupBox DMLGroupBox;
        private System.Windows.Forms.RadioButton InsertRadioButton;
        private System.Windows.Forms.RadioButton DeleteRadioButton;
        private System.Windows.Forms.RadioButton UpdateRadioButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label IdGuestLabel;
        private System.Windows.Forms.TextBox IdGuestTextBox;
        private System.Windows.Forms.OpenFileDialog PhotoOpenFileDialog;
        private System.Windows.Forms.Button DMLExecuteButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridView RoomDataGridView;
        private System.Windows.Forms.Button ShowResultButton;
        private System.Windows.Forms.DataGridView SelectDataGridView;
        private System.Windows.Forms.RadioButton WithoutDetalizationRadioButton;
        private System.Windows.Forms.RadioButton MonthRadioButton;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label ServiceNameLabel;
        private System.Windows.Forms.Label StatusRoomLabel;
        private System.Windows.Forms.Label TypeRoomLabel;
        private System.Windows.Forms.TextBox CleaningFrequencyTextBox;
        private System.Windows.Forms.TextBox ServiceNameTextBox;
        private System.Windows.Forms.TextBox StatusRoomTextBox;
        private System.Windows.Forms.TextBox TypeRoomTextBox;
        private System.Windows.Forms.TextBox NameRenterTextBox;
        private System.Windows.Forms.Label NameRenterLabel;
        private System.Windows.Forms.Label CleaningFrequencyLabel;
        private System.Windows.Forms.Button OpenPhotoButton;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Label PhotoLabel;
        private System.Windows.Forms.Label AllInclusiveLabel;
        private System.Windows.Forms.CheckBox AllInclusiveCheckBox;
        private System.Windows.Forms.Button FindButton;
    }
}