namespace DataBase2.View
{
    partial class GuestsListForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_заездаLabel;
            System.Windows.Forms.Label дата_выездаLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestsListForm));
            this.hotelDataSet = new DataBase2.HotelDataSet();
            this.GuestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuestsTableAdapter = new DataBase2.HotelDataSetTableAdapters.ГостьTableAdapter();
            this.GuestsTableAdapterManager = new DataBase2.HotelDataSetTableAdapters.TableAdapterManager();
            this.GuestsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.GuestBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.GuestBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.GuestBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.GuestBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.GuestBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.GuestBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GuestBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.GuestBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GuestBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.дата_заездаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_выездаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrdersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.OrderBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.OrdersTableAdapter = new DataBase2.HotelDataSetTableAdapters.ЗаказTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            дата_заездаLabel = new System.Windows.Forms.Label();
            дата_выездаLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestsBindingNavigator)).BeginInit();
            this.GuestsBindingNavigator.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingNavigator)).BeginInit();
            this.OrdersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(209, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(209, 70);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // дата_заездаLabel
            // 
            дата_заездаLabel.AutoSize = true;
            дата_заездаLabel.Location = new System.Drawing.Point(209, 97);
            дата_заездаLabel.Name = "дата_заездаLabel";
            дата_заездаLabel.Size = new System.Drawing.Size(75, 13);
            дата_заездаLabel.TabIndex = 5;
            дата_заездаLabel.Text = "Дата заезда:";
            // 
            // дата_выездаLabel
            // 
            дата_выездаLabel.AutoSize = true;
            дата_выездаLabel.Location = new System.Drawing.Point(209, 123);
            дата_выездаLabel.Name = "дата_выездаLabel";
            дата_выездаLabel.Size = new System.Drawing.Size(77, 13);
            дата_выездаLabel.TabIndex = 7;
            дата_выездаLabel.Text = "Дата выезда:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(209, 148);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(96, 13);
            номер_телефонаLabel.TabIndex = 9;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GuestsBindingSource
            // 
            this.GuestsBindingSource.DataMember = "Гость";
            this.GuestsBindingSource.DataSource = this.hotelDataSet;
            // 
            // GuestsTableAdapter
            // 
            this.GuestsTableAdapter.ClearBeforeFill = true;
            // 
            // GuestsTableAdapterManager
            // 
            this.GuestsTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.GuestsTableAdapterManager.UpdateOrder = DataBase2.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.GuestsTableAdapterManager.Гость_комнатаTableAdapter = null;
            this.GuestsTableAdapterManager.ГостьTableAdapter = this.GuestsTableAdapter;
            this.GuestsTableAdapterManager.ЗаказTableAdapter = null;
            this.GuestsTableAdapterManager.КомнатаTableAdapter = null;
            this.GuestsTableAdapterManager.ПерсоналTableAdapter = null;
            // 
            // GuestsBindingNavigator
            // 
            this.GuestsBindingNavigator.AddNewItem = this.GuestBindingNavigatorAddNewItem;
            this.GuestsBindingNavigator.BindingSource = this.GuestsBindingSource;
            this.GuestsBindingNavigator.CountItem = this.GuestBindingNavigatorCountItem;
            this.GuestsBindingNavigator.CountItemFormat = "из {0}";
            this.GuestsBindingNavigator.DeleteItem = this.GuestBindingNavigatorDeleteItem;
            this.GuestsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuestBindingNavigatorMoveFirstItem,
            this.GuestBindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.GuestBindingNavigatorPositionItem,
            this.GuestBindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.GuestBindingNavigatorMoveNextItem,
            this.GuestBindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.GuestBindingNavigatorAddNewItem,
            this.GuestBindingNavigatorDeleteItem,
            this.GuestBindingNavigatorSaveItem});
            this.GuestsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.GuestsBindingNavigator.MoveFirstItem = this.GuestBindingNavigatorMoveFirstItem;
            this.GuestsBindingNavigator.MoveLastItem = this.GuestBindingNavigatorMoveLastItem;
            this.GuestsBindingNavigator.MoveNextItem = this.GuestBindingNavigatorMoveNextItem;
            this.GuestsBindingNavigator.MovePreviousItem = this.GuestBindingNavigatorMovePreviousItem;
            this.GuestsBindingNavigator.Name = "GuestsBindingNavigator";
            this.GuestsBindingNavigator.PositionItem = this.GuestBindingNavigatorPositionItem;
            this.GuestsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.GuestsBindingNavigator.TabIndex = 0;
            this.GuestsBindingNavigator.Text = "bindingNavigator1";
            // 
            // GuestBindingNavigatorAddNewItem
            // 
            this.GuestBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuestBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("GuestBindingNavigatorAddNewItem.Image")));
            this.GuestBindingNavigatorAddNewItem.Name = "GuestBindingNavigatorAddNewItem";
            this.GuestBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.GuestBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.GuestBindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // GuestBindingNavigatorCountItem
            // 
            this.GuestBindingNavigatorCountItem.Name = "GuestBindingNavigatorCountItem";
            this.GuestBindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.GuestBindingNavigatorCountItem.Text = "из {0}";
            this.GuestBindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // GuestBindingNavigatorDeleteItem
            // 
            this.GuestBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuestBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("GuestBindingNavigatorDeleteItem.Image")));
            this.GuestBindingNavigatorDeleteItem.Name = "GuestBindingNavigatorDeleteItem";
            this.GuestBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.GuestBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.GuestBindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // GuestBindingNavigatorMoveFirstItem
            // 
            this.GuestBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuestBindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("GuestBindingNavigatorMoveFirstItem.Image")));
            this.GuestBindingNavigatorMoveFirstItem.Name = "GuestBindingNavigatorMoveFirstItem";
            this.GuestBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.GuestBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.GuestBindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // GuestBindingNavigatorMovePreviousItem
            // 
            this.GuestBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuestBindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("GuestBindingNavigatorMovePreviousItem.Image")));
            this.GuestBindingNavigatorMovePreviousItem.Name = "GuestBindingNavigatorMovePreviousItem";
            this.GuestBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.GuestBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.GuestBindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // GuestBindingNavigatorPositionItem
            // 
            this.GuestBindingNavigatorPositionItem.AccessibleName = "Положение";
            this.GuestBindingNavigatorPositionItem.AutoSize = false;
            this.GuestBindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GuestBindingNavigatorPositionItem.Name = "GuestBindingNavigatorPositionItem";
            this.GuestBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.GuestBindingNavigatorPositionItem.Text = "0";
            this.GuestBindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // GuestBindingNavigatorMoveNextItem
            // 
            this.GuestBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuestBindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("GuestBindingNavigatorMoveNextItem.Image")));
            this.GuestBindingNavigatorMoveNextItem.Name = "GuestBindingNavigatorMoveNextItem";
            this.GuestBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.GuestBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.GuestBindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // GuestBindingNavigatorMoveLastItem
            // 
            this.GuestBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuestBindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("GuestBindingNavigatorMoveLastItem.Image")));
            this.GuestBindingNavigatorMoveLastItem.Name = "GuestBindingNavigatorMoveLastItem";
            this.GuestBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.GuestBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.GuestBindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // GuestBindingNavigatorSaveItem
            // 
            this.GuestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuestBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("GuestBindingNavigatorSaveItem.Image")));
            this.GuestBindingNavigatorSaveItem.Name = "GuestBindingNavigatorSaveItem";
            this.GuestBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.GuestBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.GuestBindingNavigatorSaveItem.Click += new System.EventHandler(this.GuestsBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuestsBindingSource, "id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.idTextBox.Location = new System.Drawing.Point(311, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuestsBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(311, 67);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // дата_заездаDateTimePicker
            // 
            this.дата_заездаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.GuestsBindingSource, "Дата_заезда", true));
            this.дата_заездаDateTimePicker.Location = new System.Drawing.Point(311, 93);
            this.дата_заездаDateTimePicker.Name = "дата_заездаDateTimePicker";
            this.дата_заездаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заездаDateTimePicker.TabIndex = 6;
            // 
            // дата_выездаDateTimePicker
            // 
            this.дата_выездаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.GuestsBindingSource, "Дата_выезда", true));
            this.дата_выездаDateTimePicker.Location = new System.Drawing.Point(311, 119);
            this.дата_выездаDateTimePicker.Name = "дата_выездаDateTimePicker";
            this.дата_выездаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_выездаDateTimePicker.TabIndex = 8;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuestsBindingSource, "Номер_телефона", true));
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(311, 145);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_телефонаTextBox.TabIndex = 10;
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.OrdersBindingNavigator);
            this.OrderGroupBox.Controls.Add(this.OrderDataGridView);
            this.OrderGroupBox.Location = new System.Drawing.Point(126, 171);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(549, 323);
            this.OrderGroupBox.TabIndex = 11;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Заказ";
            // 
            // OrdersBindingNavigator
            // 
            this.OrdersBindingNavigator.AddNewItem = this.OrderBindingNavigatorAddNewItem;
            this.OrdersBindingNavigator.BindingSource = this.OrdersBindingSource;
            this.OrdersBindingNavigator.CountItem = this.OrderBindingNavigatorCountItem;
            this.OrdersBindingNavigator.CountItemFormat = "из {0}";
            this.OrdersBindingNavigator.DeleteItem = this.OrderBindingNavigatorDeleteItem;
            this.OrdersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.OrdersBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.OrdersBindingNavigator.MoveFirstItem = this.OrderBindingNavigatorMoveFirstItem;
            this.OrdersBindingNavigator.MoveLastItem = this.OrderBindingNavigatorMoveLastItem;
            this.OrdersBindingNavigator.MoveNextItem = this.OrderBindingNavigatorMoveNextItem;
            this.OrdersBindingNavigator.MovePreviousItem = this.OrderBindingNavigatorMovePreviousItem;
            this.OrdersBindingNavigator.Name = "OrdersBindingNavigator";
            this.OrdersBindingNavigator.PositionItem = this.OrderBindingNavigatorPositionItem;
            this.OrdersBindingNavigator.Size = new System.Drawing.Size(543, 25);
            this.OrdersBindingNavigator.TabIndex = 1;
            this.OrdersBindingNavigator.Text = "bindingNavigator1";
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
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "FK_Заказ_id_гостя";
            this.OrdersBindingSource.DataSource = this.GuestsBindingSource;
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
            this.OrderDataGridView.DataSource = this.OrdersBindingSource;
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderDataGridView.Location = new System.Drawing.Point(3, 44);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.Size = new System.Drawing.Size(543, 276);
            this.OrderDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_гостя";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_гостя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_комнаты";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_комнаты";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_персонала";
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
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // GuestsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(дата_заездаLabel);
            this.Controls.Add(this.дата_заездаDateTimePicker);
            this.Controls.Add(дата_выездаLabel);
            this.Controls.Add(this.дата_выездаDateTimePicker);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(this.номер_телефонаTextBox);
            this.Controls.Add(this.GuestsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 546);
            this.Name = "GuestsListForm";
            this.Text = "Guests";
            this.Load += new System.EventHandler(this.GuestsListForm_Load);
            this.Shown += new System.EventHandler(this.GuestsListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestsBindingNavigator)).EndInit();
            this.GuestsBindingNavigator.ResumeLayout(false);
            this.GuestsBindingNavigator.PerformLayout();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingNavigator)).EndInit();
            this.OrdersBindingNavigator.ResumeLayout(false);
            this.OrdersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource GuestsBindingSource;
        private HotelDataSetTableAdapters.ГостьTableAdapter GuestsTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager GuestsTableAdapterManager;
        private System.Windows.Forms.BindingNavigator GuestsBindingNavigator;
        private System.Windows.Forms.ToolStripButton GuestBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel GuestBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton GuestBindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton GuestBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton GuestBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox GuestBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton GuestBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton GuestBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton GuestBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.DateTimePicker дата_заездаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_выездаDateTimePicker;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private HotelDataSetTableAdapters.ЗаказTableAdapter OrdersTableAdapter;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingNavigator OrdersBindingNavigator;
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
    }
}