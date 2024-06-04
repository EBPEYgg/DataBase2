namespace DataBase2.View
{
    partial class RoomsListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label номер_комнатыLabel;
            System.Windows.Forms.Label id_гостяLabel;
            System.Windows.Forms.Label фИО_арендатораLabel;
            System.Windows.Forms.Label тип_комнатыLabel;
            System.Windows.Forms.Label статус_комнатыLabel;
            System.Windows.Forms.Label название_обслуживающей_организацииLabel;
            System.Windows.Forms.Label частота_уборкиLabel;
            System.Windows.Forms.Label услуга_все_включеноLabel;
            System.Windows.Forms.Label изображениеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label о_гостеLabel;
            this.hotelDataSet = new DataBase2.HotelDataSet();
            this.RoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomsTableAdapter = new DataBase2.HotelDataSetTableAdapters.КомнатаTableAdapter();
            this.RoomsTableAdapterManager = new DataBase2.HotelDataSetTableAdapters.TableAdapterManager();
            this.RoomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.RoomsBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.RoomsBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.RoomsBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.RoomsBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.RoomsBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.RoomsBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RoomsBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.RoomsBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RoomsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_комнатыTextBox = new System.Windows.Forms.TextBox();
            this.id_гостяTextBox = new System.Windows.Forms.TextBox();
            this.фИО_арендатораTextBox = new System.Windows.Forms.TextBox();
            this.тип_комнатыTextBox = new System.Windows.Forms.TextBox();
            this.статус_комнатыTextBox = new System.Windows.Forms.TextBox();
            this.название_обслуживающей_организацииTextBox = new System.Windows.Forms.TextBox();
            this.частота_уборкиTextBox = new System.Windows.Forms.TextBox();
            this.услуга_все_включеноCheckBox = new System.Windows.Forms.CheckBox();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenPhotoButton = new System.Windows.Forms.Button();
            this.PhotoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.OrderBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.OrderBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.OrderBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.OrderBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OrderBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OrderBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.OrderBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.OrderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTableAdapter = new DataBase2.HotelDataSetTableAdapters.ЗаказTableAdapter();
            this.AboutGuestLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GuestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuestTableAdapter = new DataBase2.HotelDataSetTableAdapters.ГостьTableAdapter();
            this.Guest_RoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Guest_RoomTableAdapter = new DataBase2.HotelDataSetTableAdapters.Гость_комнатаTableAdapter();
            номер_комнатыLabel = new System.Windows.Forms.Label();
            id_гостяLabel = new System.Windows.Forms.Label();
            фИО_арендатораLabel = new System.Windows.Forms.Label();
            тип_комнатыLabel = new System.Windows.Forms.Label();
            статус_комнатыLabel = new System.Windows.Forms.Label();
            название_обслуживающей_организацииLabel = new System.Windows.Forms.Label();
            частота_уборкиLabel = new System.Windows.Forms.Label();
            услуга_все_включеноLabel = new System.Windows.Forms.Label();
            изображениеLabel = new System.Windows.Forms.Label();
            о_гостеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingNavigator)).BeginInit();
            this.RoomsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingNavigator)).BeginInit();
            this.OrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_RoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_комнатыLabel
            // 
            номер_комнатыLabel.AutoSize = true;
            номер_комнатыLabel.Location = new System.Drawing.Point(49, 34);
            номер_комнатыLabel.Name = "номер_комнатыLabel";
            номер_комнатыLabel.Size = new System.Drawing.Size(92, 13);
            номер_комнатыLabel.TabIndex = 1;
            номер_комнатыLabel.Text = "Номер комнаты:";
            // 
            // id_гостяLabel
            // 
            id_гостяLabel.AutoSize = true;
            id_гостяLabel.Location = new System.Drawing.Point(49, 60);
            id_гостяLabel.Name = "id_гостяLabel";
            id_гостяLabel.Size = new System.Drawing.Size(49, 13);
            id_гостяLabel.TabIndex = 3;
            id_гостяLabel.Text = "id гостя:";
            // 
            // фИО_арендатораLabel
            // 
            фИО_арендатораLabel.AutoSize = true;
            фИО_арендатораLabel.Location = new System.Drawing.Point(49, 112);
            фИО_арендатораLabel.Name = "фИО_арендатораLabel";
            фИО_арендатораLabel.Size = new System.Drawing.Size(99, 13);
            фИО_арендатораLabel.TabIndex = 5;
            фИО_арендатораLabel.Text = "ФИО арендатора:";
            // 
            // тип_комнатыLabel
            // 
            тип_комнатыLabel.AutoSize = true;
            тип_комнатыLabel.Location = new System.Drawing.Point(49, 138);
            тип_комнатыLabel.Name = "тип_комнатыLabel";
            тип_комнатыLabel.Size = new System.Drawing.Size(77, 13);
            тип_комнатыLabel.TabIndex = 7;
            тип_комнатыLabel.Text = "Тип комнаты:";
            // 
            // статус_комнатыLabel
            // 
            статус_комнатыLabel.AutoSize = true;
            статус_комнатыLabel.Location = new System.Drawing.Point(49, 164);
            статус_комнатыLabel.Name = "статус_комнатыLabel";
            статус_комнатыLabel.Size = new System.Drawing.Size(92, 13);
            статус_комнатыLabel.TabIndex = 9;
            статус_комнатыLabel.Text = "Статус комнаты:";
            // 
            // название_обслуживающей_организацииLabel
            // 
            название_обслуживающей_организацииLabel.AutoSize = true;
            название_обслуживающей_организацииLabel.Location = new System.Drawing.Point(49, 190);
            название_обслуживающей_организацииLabel.Name = "название_обслуживающей_организацииLabel";
            название_обслуживающей_организацииLabel.Size = new System.Drawing.Size(158, 13);
            название_обслуживающей_организацииLabel.TabIndex = 11;
            название_обслуживающей_организацииLabel.Text = "Название обсл. организации:";
            // 
            // частота_уборкиLabel
            // 
            частота_уборкиLabel.AutoSize = true;
            частота_уборкиLabel.Location = new System.Drawing.Point(49, 216);
            частота_уборкиLabel.Name = "частота_уборкиLabel";
            частота_уборкиLabel.Size = new System.Drawing.Size(132, 13);
            частота_уборкиLabel.TabIndex = 13;
            частота_уборкиLabel.Text = "Частота уборки (в день):";
            // 
            // услуга_все_включеноLabel
            // 
            услуга_все_включеноLabel.AutoSize = true;
            услуга_все_включеноLabel.Location = new System.Drawing.Point(49, 244);
            услуга_все_включеноLabel.Name = "услуга_все_включеноLabel";
            услуга_все_включеноLabel.Size = new System.Drawing.Size(119, 13);
            услуга_все_включеноLabel.TabIndex = 15;
            услуга_все_включеноLabel.Text = "Услуга все включено:";
            // 
            // изображениеLabel
            // 
            изображениеLabel.AutoSize = true;
            изображениеLabel.Location = new System.Drawing.Point(408, 34);
            изображениеLabel.Name = "изображениеLabel";
            изображениеLabel.Size = new System.Drawing.Size(80, 13);
            изображениеLabel.TabIndex = 17;
            изображениеLabel.Text = "Изображение:";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RoomsBindingSource
            // 
            this.RoomsBindingSource.DataMember = "Комната";
            this.RoomsBindingSource.DataSource = this.hotelDataSet;
            // 
            // RoomsTableAdapter
            // 
            this.RoomsTableAdapter.ClearBeforeFill = true;
            // 
            // RoomsTableAdapterManager
            // 
            this.RoomsTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.RoomsTableAdapterManager.UpdateOrder = DataBase2.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.RoomsTableAdapterManager.Гость_комнатаTableAdapter = null;
            this.RoomsTableAdapterManager.ГостьTableAdapter = null;
            this.RoomsTableAdapterManager.ЗаказTableAdapter = null;
            this.RoomsTableAdapterManager.КомнатаTableAdapter = this.RoomsTableAdapter;
            this.RoomsTableAdapterManager.ПерсоналTableAdapter = null;
            // 
            // RoomsBindingNavigator
            // 
            this.RoomsBindingNavigator.AddNewItem = this.RoomsBindingNavigatorAddNewItem;
            this.RoomsBindingNavigator.BindingSource = this.RoomsBindingSource;
            this.RoomsBindingNavigator.CountItem = this.RoomsBindingNavigatorCountItem;
            this.RoomsBindingNavigator.CountItemFormat = "из {0}";
            this.RoomsBindingNavigator.DeleteItem = this.RoomsBindingNavigatorDeleteItem;
            this.RoomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoomsBindingNavigatorMoveFirstItem,
            this.RoomsBindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.RoomsBindingNavigatorPositionItem,
            this.RoomsBindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.RoomsBindingNavigatorMoveNextItem,
            this.RoomsBindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.RoomsBindingNavigatorAddNewItem,
            this.RoomsBindingNavigatorDeleteItem,
            this.RoomsBindingNavigatorSaveItem});
            this.RoomsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.RoomsBindingNavigator.MoveFirstItem = this.RoomsBindingNavigatorMoveFirstItem;
            this.RoomsBindingNavigator.MoveLastItem = this.RoomsBindingNavigatorMoveLastItem;
            this.RoomsBindingNavigator.MoveNextItem = this.RoomsBindingNavigatorMoveNextItem;
            this.RoomsBindingNavigator.MovePreviousItem = this.RoomsBindingNavigatorMovePreviousItem;
            this.RoomsBindingNavigator.Name = "RoomsBindingNavigator";
            this.RoomsBindingNavigator.PositionItem = this.RoomsBindingNavigatorPositionItem;
            this.RoomsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.RoomsBindingNavigator.TabIndex = 0;
            this.RoomsBindingNavigator.Text = "bindingNavigator1";
            // 
            // RoomsBindingNavigatorAddNewItem
            // 
            this.RoomsBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoomsBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("RoomsBindingNavigatorAddNewItem.Image")));
            this.RoomsBindingNavigatorAddNewItem.Name = "RoomsBindingNavigatorAddNewItem";
            this.RoomsBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.RoomsBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.RoomsBindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // RoomsBindingNavigatorCountItem
            // 
            this.RoomsBindingNavigatorCountItem.Name = "RoomsBindingNavigatorCountItem";
            this.RoomsBindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.RoomsBindingNavigatorCountItem.Text = "из {0}";
            this.RoomsBindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // RoomsBindingNavigatorDeleteItem
            // 
            this.RoomsBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoomsBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("RoomsBindingNavigatorDeleteItem.Image")));
            this.RoomsBindingNavigatorDeleteItem.Name = "RoomsBindingNavigatorDeleteItem";
            this.RoomsBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.RoomsBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.RoomsBindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // RoomsBindingNavigatorMoveFirstItem
            // 
            this.RoomsBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoomsBindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("RoomsBindingNavigatorMoveFirstItem.Image")));
            this.RoomsBindingNavigatorMoveFirstItem.Name = "RoomsBindingNavigatorMoveFirstItem";
            this.RoomsBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.RoomsBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.RoomsBindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // RoomsBindingNavigatorMovePreviousItem
            // 
            this.RoomsBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoomsBindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("RoomsBindingNavigatorMovePreviousItem.Image")));
            this.RoomsBindingNavigatorMovePreviousItem.Name = "RoomsBindingNavigatorMovePreviousItem";
            this.RoomsBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.RoomsBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.RoomsBindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // RoomsBindingNavigatorPositionItem
            // 
            this.RoomsBindingNavigatorPositionItem.AccessibleName = "Положение";
            this.RoomsBindingNavigatorPositionItem.AutoSize = false;
            this.RoomsBindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoomsBindingNavigatorPositionItem.Name = "RoomsBindingNavigatorPositionItem";
            this.RoomsBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.RoomsBindingNavigatorPositionItem.Text = "0";
            this.RoomsBindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RoomsBindingNavigatorMoveNextItem
            // 
            this.RoomsBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoomsBindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("RoomsBindingNavigatorMoveNextItem.Image")));
            this.RoomsBindingNavigatorMoveNextItem.Name = "RoomsBindingNavigatorMoveNextItem";
            this.RoomsBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.RoomsBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.RoomsBindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // RoomsBindingNavigatorMoveLastItem
            // 
            this.RoomsBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoomsBindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("RoomsBindingNavigatorMoveLastItem.Image")));
            this.RoomsBindingNavigatorMoveLastItem.Name = "RoomsBindingNavigatorMoveLastItem";
            this.RoomsBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.RoomsBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.RoomsBindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RoomsBindingNavigatorSaveItem
            // 
            this.RoomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoomsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("RoomsBindingNavigatorSaveItem.Image")));
            this.RoomsBindingNavigatorSaveItem.Name = "RoomsBindingNavigatorSaveItem";
            this.RoomsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.RoomsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.RoomsBindingNavigatorSaveItem.Click += new System.EventHandler(this.RoomsBindingNavigatorSaveItem_Click);
            // 
            // номер_комнатыTextBox
            // 
            this.номер_комнатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Номер_комнаты", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.номер_комнатыTextBox.Location = new System.Drawing.Point(210, 31);
            this.номер_комнатыTextBox.Name = "номер_комнатыTextBox";
            this.номер_комнатыTextBox.ReadOnly = true;
            this.номер_комнатыTextBox.Size = new System.Drawing.Size(164, 20);
            this.номер_комнатыTextBox.TabIndex = 2;
            // 
            // id_гостяTextBox
            // 
            this.id_гостяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "id_гостя", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.id_гостяTextBox.Location = new System.Drawing.Point(210, 57);
            this.id_гостяTextBox.Name = "id_гостяTextBox";
            this.id_гостяTextBox.Size = new System.Drawing.Size(164, 20);
            this.id_гостяTextBox.TabIndex = 4;
            // 
            // фИО_арендатораTextBox
            // 
            this.фИО_арендатораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "ФИО_арендатора", true));
            this.фИО_арендатораTextBox.Location = new System.Drawing.Point(210, 109);
            this.фИО_арендатораTextBox.Name = "фИО_арендатораTextBox";
            this.фИО_арендатораTextBox.Size = new System.Drawing.Size(164, 20);
            this.фИО_арендатораTextBox.TabIndex = 6;
            // 
            // тип_комнатыTextBox
            // 
            this.тип_комнатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Тип_комнаты", true));
            this.тип_комнатыTextBox.Location = new System.Drawing.Point(210, 135);
            this.тип_комнатыTextBox.Name = "тип_комнатыTextBox";
            this.тип_комнатыTextBox.Size = new System.Drawing.Size(164, 20);
            this.тип_комнатыTextBox.TabIndex = 8;
            // 
            // статус_комнатыTextBox
            // 
            this.статус_комнатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Статус_комнаты", true));
            this.статус_комнатыTextBox.Location = new System.Drawing.Point(210, 161);
            this.статус_комнатыTextBox.Name = "статус_комнатыTextBox";
            this.статус_комнатыTextBox.Size = new System.Drawing.Size(164, 20);
            this.статус_комнатыTextBox.TabIndex = 10;
            // 
            // название_обслуживающей_организацииTextBox
            // 
            this.название_обслуживающей_организацииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Название_обслуживающей_организации", true));
            this.название_обслуживающей_организацииTextBox.Location = new System.Drawing.Point(210, 187);
            this.название_обслуживающей_организацииTextBox.Name = "название_обслуживающей_организацииTextBox";
            this.название_обслуживающей_организацииTextBox.Size = new System.Drawing.Size(164, 20);
            this.название_обслуживающей_организацииTextBox.TabIndex = 12;
            // 
            // частота_уборкиTextBox
            // 
            this.частота_уборкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Частота_уборки", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.частота_уборкиTextBox.Location = new System.Drawing.Point(210, 213);
            this.частота_уборкиTextBox.Name = "частота_уборкиTextBox";
            this.частота_уборкиTextBox.Size = new System.Drawing.Size(164, 20);
            this.частота_уборкиTextBox.TabIndex = 14;
            // 
            // услуга_все_включеноCheckBox
            // 
            this.услуга_все_включеноCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.RoomsBindingSource, "Услуга_все_включено", true));
            this.услуга_все_включеноCheckBox.Location = new System.Drawing.Point(210, 239);
            this.услуга_все_включеноCheckBox.Name = "услуга_все_включеноCheckBox";
            this.услуга_все_включеноCheckBox.Size = new System.Drawing.Size(15, 24);
            this.услуга_все_включеноCheckBox.TabIndex = 16;
            this.услуга_все_включеноCheckBox.UseVisualStyleBackColor = true;
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.RoomsBindingSource, "Изображение", true));
            this.PhotoPictureBox.Location = new System.Drawing.Point(494, 34);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(266, 197);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 18;
            this.PhotoPictureBox.TabStop = false;
            // 
            // OpenPhotoButton
            // 
            this.OpenPhotoButton.Location = new System.Drawing.Point(409, 50);
            this.OpenPhotoButton.Name = "OpenPhotoButton";
            this.OpenPhotoButton.Size = new System.Drawing.Size(77, 23);
            this.OpenPhotoButton.TabIndex = 19;
            this.OpenPhotoButton.Text = "Open photo";
            this.OpenPhotoButton.UseVisualStyleBackColor = true;
            this.OpenPhotoButton.Click += new System.EventHandler(this.OpenPhotoButton_Click);
            // 
            // PhotoOpenFileDialog
            // 
            this.PhotoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.OrderBindingNavigator);
            this.OrderGroupBox.Controls.Add(this.OrderDataGridView);
            this.OrderGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderGroupBox.Location = new System.Drawing.Point(0, 283);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(800, 298);
            this.OrderGroupBox.TabIndex = 20;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Order";
            // 
            // OrderBindingNavigator
            // 
            this.OrderBindingNavigator.AddNewItem = this.OrderBindingNavigatorAddNewItem;
            this.OrderBindingNavigator.BindingSource = this.OrderBindingSource;
            this.OrderBindingNavigator.CountItem = this.OrderBindingNavigatorCountItem;
            this.OrderBindingNavigator.CountItemFormat = "из {0}";
            this.OrderBindingNavigator.DeleteItem = this.OrderBindingNavigatorDeleteItem;
            this.OrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderBindingNavigatorMoveFirstItem,
            this.OrderBindingNavigatorMovePreviousItem,
            this.toolStripSeparator1,
            this.OrderBindingNavigatorPositionItem,
            this.OrderBindingNavigatorCountItem,
            this.toolStripSeparator2,
            this.OrderBindingNavigatorMoveNextItem,
            this.OrderBindingNavigatorMoveLastItem,
            this.toolStripSeparator3,
            this.OrderBindingNavigatorAddNewItem,
            this.OrderBindingNavigatorDeleteItem,
            this.OrderBindingNavigatorSaveItem});
            this.OrderBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.OrderBindingNavigator.MoveFirstItem = this.OrderBindingNavigatorMoveFirstItem;
            this.OrderBindingNavigator.MoveLastItem = this.OrderBindingNavigatorMoveLastItem;
            this.OrderBindingNavigator.MoveNextItem = this.OrderBindingNavigatorMoveNextItem;
            this.OrderBindingNavigator.MovePreviousItem = this.OrderBindingNavigatorMovePreviousItem;
            this.OrderBindingNavigator.Name = "OrderBindingNavigator";
            this.OrderBindingNavigator.PositionItem = this.OrderBindingNavigatorPositionItem;
            this.OrderBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.OrderBindingNavigator.TabIndex = 1;
            this.OrderBindingNavigator.Text = "bindingNavigator1";
            // 
            // OrderBindingNavigatorAddNewItem
            // 
            this.OrderBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("OrderBindingNavigatorAddNewItem.Image")));
            this.OrderBindingNavigatorAddNewItem.Name = "OrderBindingNavigatorAddNewItem";
            this.OrderBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.OrderBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.OrderBindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataMember = "FK_Заказ_Номер_комнаты";
            this.OrderBindingSource.DataSource = this.RoomsBindingSource;
            // 
            // OrderBindingNavigatorCountItem
            // 
            this.OrderBindingNavigatorCountItem.Name = "OrderBindingNavigatorCountItem";
            this.OrderBindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.OrderBindingNavigatorCountItem.Text = "из {0}";
            this.OrderBindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // OrderBindingNavigatorDeleteItem
            // 
            this.OrderBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("OrderBindingNavigatorDeleteItem.Image")));
            this.OrderBindingNavigatorDeleteItem.Name = "OrderBindingNavigatorDeleteItem";
            this.OrderBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.OrderBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.OrderBindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // OrderBindingNavigatorMoveFirstItem
            // 
            this.OrderBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderBindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("OrderBindingNavigatorMoveFirstItem.Image")));
            this.OrderBindingNavigatorMoveFirstItem.Name = "OrderBindingNavigatorMoveFirstItem";
            this.OrderBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.OrderBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.OrderBindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // OrderBindingNavigatorMovePreviousItem
            // 
            this.OrderBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderBindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("OrderBindingNavigatorMovePreviousItem.Image")));
            this.OrderBindingNavigatorMovePreviousItem.Name = "OrderBindingNavigatorMovePreviousItem";
            this.OrderBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.OrderBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.OrderBindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // OrderBindingNavigatorPositionItem
            // 
            this.OrderBindingNavigatorPositionItem.AccessibleName = "Положение";
            this.OrderBindingNavigatorPositionItem.AutoSize = false;
            this.OrderBindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OrderBindingNavigatorPositionItem.Name = "OrderBindingNavigatorPositionItem";
            this.OrderBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.OrderBindingNavigatorPositionItem.Text = "0";
            this.OrderBindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // OrderBindingNavigatorMoveNextItem
            // 
            this.OrderBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderBindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("OrderBindingNavigatorMoveNextItem.Image")));
            this.OrderBindingNavigatorMoveNextItem.Name = "OrderBindingNavigatorMoveNextItem";
            this.OrderBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.OrderBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.OrderBindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // OrderBindingNavigatorMoveLastItem
            // 
            this.OrderBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderBindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("OrderBindingNavigatorMoveLastItem.Image")));
            this.OrderBindingNavigatorMoveLastItem.Name = "OrderBindingNavigatorMoveLastItem";
            this.OrderBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.OrderBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.OrderBindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // OrderBindingNavigatorSaveItem
            // 
            this.OrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("OrderBindingNavigatorSaveItem.Image")));
            this.OrderBindingNavigatorSaveItem.Name = "OrderBindingNavigatorSaveItem";
            this.OrderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.OrderBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.OrderBindingNavigatorSaveItem.Click += new System.EventHandler(this.OrderBindingNavigatorSaveItem_Click);
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AutoGenerateColumns = false;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.OrderDataGridView.DataSource = this.OrderBindingSource;
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderDataGridView.Location = new System.Drawing.Point(3, 41);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.Size = new System.Drawing.Size(794, 254);
            this.OrderDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_гостя";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "id_гостя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_комнаты";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_комнаты";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_персонала";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "id_персонала";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Статус_заказа";
            this.dataGridViewTextBoxColumn5.HeaderText = "Статус_заказа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // OrderTableAdapter
            // 
            this.OrderTableAdapter.ClearBeforeFill = true;
            // 
            // о_гостеLabel
            // 
            о_гостеLabel.AutoSize = true;
            о_гостеLabel.Location = new System.Drawing.Point(49, 86);
            о_гостеLabel.Name = "о_гостеLabel";
            о_гостеLabel.Size = new System.Drawing.Size(49, 13);
            о_гостеLabel.TabIndex = 21;
            о_гостеLabel.Text = "О госте:";
            // 
            // AboutGuestLinkLabel
            // 
            this.AboutGuestLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "О_госте", true));
            this.AboutGuestLinkLabel.Location = new System.Drawing.Point(210, 86);
            this.AboutGuestLinkLabel.Name = "AboutGuestLinkLabel";
            this.AboutGuestLinkLabel.Size = new System.Drawing.Size(164, 23);
            this.AboutGuestLinkLabel.TabIndex = 22;
            this.AboutGuestLinkLabel.TabStop = true;
            this.AboutGuestLinkLabel.Text = "linkLabel1";
            this.AboutGuestLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutGuestLinkLabel_LinkClicked);
            // 
            // GuestBindingSource
            // 
            this.GuestBindingSource.DataMember = "Гость";
            this.GuestBindingSource.DataSource = this.hotelDataSet;
            // 
            // GuestTableAdapter
            // 
            this.GuestTableAdapter.ClearBeforeFill = true;
            // 
            // Guest_RoomBindingSource
            // 
            this.Guest_RoomBindingSource.DataMember = "Гость_комната";
            this.Guest_RoomBindingSource.DataSource = this.hotelDataSet;
            // 
            // Guest_RoomTableAdapter
            // 
            this.Guest_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // RoomsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(о_гостеLabel);
            this.Controls.Add(this.AboutGuestLinkLabel);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.OpenPhotoButton);
            this.Controls.Add(изображениеLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(номер_комнатыLabel);
            this.Controls.Add(this.номер_комнатыTextBox);
            this.Controls.Add(id_гостяLabel);
            this.Controls.Add(this.id_гостяTextBox);
            this.Controls.Add(фИО_арендатораLabel);
            this.Controls.Add(this.фИО_арендатораTextBox);
            this.Controls.Add(тип_комнатыLabel);
            this.Controls.Add(this.тип_комнатыTextBox);
            this.Controls.Add(статус_комнатыLabel);
            this.Controls.Add(this.статус_комнатыTextBox);
            this.Controls.Add(название_обслуживающей_организацииLabel);
            this.Controls.Add(this.название_обслуживающей_организацииTextBox);
            this.Controls.Add(частота_уборкиLabel);
            this.Controls.Add(this.частота_уборкиTextBox);
            this.Controls.Add(услуга_все_включеноLabel);
            this.Controls.Add(this.услуга_все_включеноCheckBox);
            this.Controls.Add(this.RoomsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 594);
            this.Name = "RoomsListForm";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.RoomsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingNavigator)).EndInit();
            this.RoomsBindingNavigator.ResumeLayout(false);
            this.RoomsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingNavigator)).EndInit();
            this.OrderBindingNavigator.ResumeLayout(false);
            this.OrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_RoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource RoomsBindingSource;
        private HotelDataSetTableAdapters.КомнатаTableAdapter RoomsTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager RoomsTableAdapterManager;
        private System.Windows.Forms.BindingNavigator RoomsBindingNavigator;
        private System.Windows.Forms.ToolStripButton RoomsBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel RoomsBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton RoomsBindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton RoomsBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton RoomsBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox RoomsBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton RoomsBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton RoomsBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton RoomsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_комнатыTextBox;
        private System.Windows.Forms.TextBox id_гостяTextBox;
        private System.Windows.Forms.TextBox фИО_арендатораTextBox;
        private System.Windows.Forms.TextBox тип_комнатыTextBox;
        private System.Windows.Forms.TextBox статус_комнатыTextBox;
        private System.Windows.Forms.TextBox название_обслуживающей_организацииTextBox;
        private System.Windows.Forms.TextBox частота_уборкиTextBox;
        private System.Windows.Forms.CheckBox услуга_все_включеноCheckBox;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Button OpenPhotoButton;
        private System.Windows.Forms.OpenFileDialog PhotoOpenFileDialog;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private HotelDataSetTableAdapters.ЗаказTableAdapter OrderTableAdapter;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.BindingNavigator OrderBindingNavigator;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel OrderBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox OrderBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.LinkLabel AboutGuestLinkLabel;
        private System.Windows.Forms.BindingSource GuestBindingSource;
        private HotelDataSetTableAdapters.ГостьTableAdapter GuestTableAdapter;
        private System.Windows.Forms.BindingSource Guest_RoomBindingSource;
        private HotelDataSetTableAdapters.Гость_комнатаTableAdapter Guest_RoomTableAdapter;
    }
}