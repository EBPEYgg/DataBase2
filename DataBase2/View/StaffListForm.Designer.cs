namespace DataBase2.View
{
    partial class StaffListForm
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
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label зарплатаLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label трудовой_стажLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffListForm));
            System.Windows.Forms.Label AboutStaffLabel;
            this.hotelDataSet = new DataBase2.HotelDataSet();
            this.StaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StaffTableAdapter = new DataBase2.HotelDataSetTableAdapters.ПерсоналTableAdapter();
            this.StaffTableAdapterManager = new DataBase2.HotelDataSetTableAdapters.TableAdapterManager();
            this.StaffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.StaffBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.StaffBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.StaffBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.StaffBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.StaffBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.StaffBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StaffBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.StaffBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StaffBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.зарплатаTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.трудовой_стажTextBox = new System.Windows.Forms.TextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.ShowOrderButton = new System.Windows.Forms.Button();
            this.OrderTableAdapter = new DataBase2.HotelDataSetTableAdapters.ЗаказTableAdapter();
            this.OrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.OrdersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AboutStaffTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            трудовой_стажLabel = new System.Windows.Forms.Label();
            AboutStaffLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffBindingNavigator)).BeginInit();
            this.StaffBindingNavigator.SuspendLayout();
            this.OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingNavigator)).BeginInit();
            this.OrdersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(238, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(238, 51);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(238, 77);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 5;
            полLabel.Text = "Пол:";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.Location = new System.Drawing.Point(238, 103);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(58, 13);
            зарплатаLabel.TabIndex = 7;
            зарплатаLabel.Text = "Зарплата:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(238, 129);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(68, 13);
            должностьLabel.TabIndex = 9;
            должностьLabel.Text = "Должность:";
            // 
            // трудовой_стажLabel
            // 
            трудовой_стажLabel.AutoSize = true;
            трудовой_стажLabel.Location = new System.Drawing.Point(238, 155);
            трудовой_стажLabel.Name = "трудовой_стажLabel";
            трудовой_стажLabel.Size = new System.Drawing.Size(86, 13);
            трудовой_стажLabel.TabIndex = 11;
            трудовой_стажLabel.Text = "Трудовой стаж:";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StaffBindingSource
            // 
            this.StaffBindingSource.DataMember = "Персонал";
            this.StaffBindingSource.DataSource = this.hotelDataSet;
            // 
            // StaffTableAdapter
            // 
            this.StaffTableAdapter.ClearBeforeFill = true;
            // 
            // StaffTableAdapterManager
            // 
            this.StaffTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.StaffTableAdapterManager.UpdateOrder = DataBase2.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.StaffTableAdapterManager.Гость_комнатаTableAdapter = null;
            this.StaffTableAdapterManager.ГостьTableAdapter = null;
            this.StaffTableAdapterManager.ЗаказTableAdapter = null;
            this.StaffTableAdapterManager.КомнатаTableAdapter = null;
            this.StaffTableAdapterManager.ПерсоналTableAdapter = this.StaffTableAdapter;
            // 
            // StaffBindingNavigator
            // 
            this.StaffBindingNavigator.AddNewItem = this.StaffBindingNavigatorAddNewItem;
            this.StaffBindingNavigator.BindingSource = this.StaffBindingSource;
            this.StaffBindingNavigator.CountItem = this.StaffBindingNavigatorCountItem;
            this.StaffBindingNavigator.CountItemFormat = "из {0}";
            this.StaffBindingNavigator.DeleteItem = this.StaffBindingNavigatorDeleteItem;
            this.StaffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffBindingNavigatorMoveFirstItem,
            this.StaffBindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.StaffBindingNavigatorPositionItem,
            this.StaffBindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.StaffBindingNavigatorMoveNextItem,
            this.StaffBindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.StaffBindingNavigatorAddNewItem,
            this.StaffBindingNavigatorDeleteItem,
            this.StaffBindingNavigatorSaveItem});
            this.StaffBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.StaffBindingNavigator.MoveFirstItem = this.StaffBindingNavigatorMoveFirstItem;
            this.StaffBindingNavigator.MoveLastItem = this.StaffBindingNavigatorMoveLastItem;
            this.StaffBindingNavigator.MoveNextItem = this.StaffBindingNavigatorMoveNextItem;
            this.StaffBindingNavigator.MovePreviousItem = this.StaffBindingNavigatorMovePreviousItem;
            this.StaffBindingNavigator.Name = "StaffBindingNavigator";
            this.StaffBindingNavigator.PositionItem = this.StaffBindingNavigatorPositionItem;
            this.StaffBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.StaffBindingNavigator.TabIndex = 0;
            this.StaffBindingNavigator.Text = "bindingNavigator1";
            // 
            // StaffBindingNavigatorAddNewItem
            // 
            this.StaffBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("StaffBindingNavigatorAddNewItem.Image")));
            this.StaffBindingNavigatorAddNewItem.Name = "StaffBindingNavigatorAddNewItem";
            this.StaffBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.StaffBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.StaffBindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // StaffBindingNavigatorCountItem
            // 
            this.StaffBindingNavigatorCountItem.Name = "StaffBindingNavigatorCountItem";
            this.StaffBindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.StaffBindingNavigatorCountItem.Text = "из {0}";
            this.StaffBindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // StaffBindingNavigatorDeleteItem
            // 
            this.StaffBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("StaffBindingNavigatorDeleteItem.Image")));
            this.StaffBindingNavigatorDeleteItem.Name = "StaffBindingNavigatorDeleteItem";
            this.StaffBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.StaffBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.StaffBindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // StaffBindingNavigatorMoveFirstItem
            // 
            this.StaffBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffBindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("StaffBindingNavigatorMoveFirstItem.Image")));
            this.StaffBindingNavigatorMoveFirstItem.Name = "StaffBindingNavigatorMoveFirstItem";
            this.StaffBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.StaffBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.StaffBindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // StaffBindingNavigatorMovePreviousItem
            // 
            this.StaffBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffBindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("StaffBindingNavigatorMovePreviousItem.Image")));
            this.StaffBindingNavigatorMovePreviousItem.Name = "StaffBindingNavigatorMovePreviousItem";
            this.StaffBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.StaffBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.StaffBindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // StaffBindingNavigatorPositionItem
            // 
            this.StaffBindingNavigatorPositionItem.AccessibleName = "Положение";
            this.StaffBindingNavigatorPositionItem.AutoSize = false;
            this.StaffBindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StaffBindingNavigatorPositionItem.Name = "StaffBindingNavigatorPositionItem";
            this.StaffBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.StaffBindingNavigatorPositionItem.Text = "0";
            this.StaffBindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // StaffBindingNavigatorMoveNextItem
            // 
            this.StaffBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffBindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("StaffBindingNavigatorMoveNextItem.Image")));
            this.StaffBindingNavigatorMoveNextItem.Name = "StaffBindingNavigatorMoveNextItem";
            this.StaffBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.StaffBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.StaffBindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // StaffBindingNavigatorMoveLastItem
            // 
            this.StaffBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffBindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("StaffBindingNavigatorMoveLastItem.Image")));
            this.StaffBindingNavigatorMoveLastItem.Name = "StaffBindingNavigatorMoveLastItem";
            this.StaffBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.StaffBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.StaffBindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // StaffBindingNavigatorSaveItem
            // 
            this.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("StaffBindingNavigatorSaveItem.Image")));
            this.StaffBindingNavigatorSaveItem.Name = "StaffBindingNavigatorSaveItem";
            this.StaffBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.StaffBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.StaffBindingNavigatorSaveItem.Click += new System.EventHandler(this.StaffBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.idTextBox.Location = new System.Drawing.Point(330, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(190, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(330, 48);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(190, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // зарплатаTextBox
            // 
            this.зарплатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "Зарплата", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.зарплатаTextBox.Location = new System.Drawing.Point(330, 100);
            this.зарплатаTextBox.Name = "зарплатаTextBox";
            this.зарплатаTextBox.Size = new System.Drawing.Size(190, 20);
            this.зарплатаTextBox.TabIndex = 8;
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "Должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(330, 126);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(190, 20);
            this.должностьTextBox.TabIndex = 10;
            // 
            // трудовой_стажTextBox
            // 
            this.трудовой_стажTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "Трудовой_стаж", true));
            this.трудовой_стажTextBox.Location = new System.Drawing.Point(330, 152);
            this.трудовой_стажTextBox.Name = "трудовой_стажTextBox";
            this.трудовой_стажTextBox.Size = new System.Drawing.Size(190, 20);
            this.трудовой_стажTextBox.TabIndex = 12;
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "Пол", true));
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.полComboBox.Location = new System.Drawing.Point(330, 74);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(190, 21);
            this.полComboBox.TabIndex = 14;
            // 
            // ShowOrderButton
            // 
            this.ShowOrderButton.Location = new System.Drawing.Point(241, 204);
            this.ShowOrderButton.Name = "ShowOrderButton";
            this.ShowOrderButton.Size = new System.Drawing.Size(279, 23);
            this.ShowOrderButton.TabIndex = 15;
            this.ShowOrderButton.Text = "Show order";
            this.ShowOrderButton.UseVisualStyleBackColor = true;
            this.ShowOrderButton.Click += new System.EventHandler(this.ShowOrderButton_Click);
            // 
            // OrderTableAdapter
            // 
            this.OrderTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersGroupBox
            // 
            this.OrdersGroupBox.Controls.Add(this.OrdersBindingNavigator);
            this.OrdersGroupBox.Controls.Add(this.OrderDataGridView);
            this.OrdersGroupBox.Location = new System.Drawing.Point(69, 233);
            this.OrdersGroupBox.Name = "OrdersGroupBox";
            this.OrdersGroupBox.Size = new System.Drawing.Size(656, 213);
            this.OrdersGroupBox.TabIndex = 16;
            this.OrdersGroupBox.TabStop = false;
            this.OrdersGroupBox.Text = "Заказы";
            // 
            // OrdersBindingNavigator
            // 
            this.OrdersBindingNavigator.AddNewItem = this.OrderBindingNavigatorAddNewItem;
            this.OrdersBindingNavigator.BindingSource = this.OrderBindingSource;
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
            this.OrdersBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.OrdersBindingNavigator.TabIndex = 1;
            this.OrdersBindingNavigator.Text = "Navigator";
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
            this.OrderBindingSource.DataMember = "FK_Заказ_id_персонала";
            this.OrderBindingSource.DataSource = this.StaffBindingSource;
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
            this.OrderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDataGridView.AutoGenerateColumns = false;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.OrderDataGridView.DataSource = this.OrderBindingSource;
            this.OrderDataGridView.Location = new System.Drawing.Point(6, 44);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.Size = new System.Drawing.Size(644, 163);
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Имя_гостя";
            this.dataGridViewTextBoxColumn6.HeaderText = "Имя_гостя";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // AboutStaffLabel
            // 
            AboutStaffLabel.AutoSize = true;
            AboutStaffLabel.Location = new System.Drawing.Point(239, 181);
            AboutStaffLabel.Name = "AboutStaffLabel";
            AboutStaffLabel.Size = new System.Drawing.Size(108, 13);
            AboutStaffLabel.TabIndex = 16;
            AboutStaffLabel.Text = "Инфо о сотруднике:";
            // 
            // AboutStaffTextBox
            // 
            this.AboutStaffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "Инфо_о_сотруднике", true));
            this.AboutStaffTextBox.Location = new System.Drawing.Point(353, 178);
            this.AboutStaffTextBox.Name = "AboutStaffTextBox";
            this.AboutStaffTextBox.Size = new System.Drawing.Size(167, 20);
            this.AboutStaffTextBox.TabIndex = 17;
            // 
            // StaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(AboutStaffLabel);
            this.Controls.Add(this.AboutStaffTextBox);
            this.Controls.Add(this.OrdersGroupBox);
            this.Controls.Add(this.ShowOrderButton);
            this.Controls.Add(this.полComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(зарплатаLabel);
            this.Controls.Add(this.зарплатаTextBox);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.должностьTextBox);
            this.Controls.Add(трудовой_стажLabel);
            this.Controls.Add(this.трудовой_стажTextBox);
            this.Controls.Add(this.StaffBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "StaffListForm";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.StaffListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffBindingNavigator)).EndInit();
            this.StaffBindingNavigator.ResumeLayout(false);
            this.StaffBindingNavigator.PerformLayout();
            this.OrdersGroupBox.ResumeLayout(false);
            this.OrdersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingNavigator)).EndInit();
            this.OrdersBindingNavigator.ResumeLayout(false);
            this.OrdersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource StaffBindingSource;
        private HotelDataSetTableAdapters.ПерсоналTableAdapter StaffTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager StaffTableAdapterManager;
        private System.Windows.Forms.BindingNavigator StaffBindingNavigator;
        private System.Windows.Forms.ToolStripButton StaffBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel StaffBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton StaffBindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton StaffBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton StaffBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox StaffBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton StaffBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton StaffBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton StaffBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox зарплатаTextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.TextBox трудовой_стажTextBox;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.Button ShowOrderButton;
        private HotelDataSetTableAdapters.ЗаказTableAdapter OrderTableAdapter;
        private System.Windows.Forms.GroupBox OrdersGroupBox;
        private System.Windows.Forms.BindingNavigator OrdersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel OrderBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox OrderBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton OrderBindingNavigatorDeleteItem;
        private System.Windows.Forms.TextBox AboutStaffTextBox;
    }
}