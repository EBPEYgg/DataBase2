namespace DataBase2.View
{
    partial class OrdersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hotelDataSet = new DataBase2.HotelDataSet();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersTableAdapter = new DataBase2.HotelDataSetTableAdapters.ЗаказTableAdapter();
            this.OrdersTableAdapterManager = new DataBase2.HotelDataSetTableAdapters.TableAdapterManager();
            this.OrdersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OrdersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OkToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FindToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.FindToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя_гостя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FindCheckBox = new System.Windows.Forms.CheckBox();
            this.GuestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuestTableAdapter = new DataBase2.HotelDataSetTableAdapters.ГостьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingNavigator)).BeginInit();
            this.OrdersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Заказ";
            this.OrdersBindingSource.DataSource = this.hotelDataSet;
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersTableAdapterManager
            // 
            this.OrdersTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.OrdersTableAdapterManager.UpdateOrder = DataBase2.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.OrdersTableAdapterManager.Гость_комнатаTableAdapter = null;
            this.OrdersTableAdapterManager.ГостьTableAdapter = null;
            this.OrdersTableAdapterManager.ЗаказTableAdapter = this.OrdersTableAdapter;
            this.OrdersTableAdapterManager.КомнатаTableAdapter = null;
            this.OrdersTableAdapterManager.ПерсоналTableAdapter = null;
            // 
            // OrdersBindingNavigator
            // 
            this.OrdersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.OrdersBindingNavigator.BindingSource = this.OrdersBindingSource;
            this.OrdersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.OrdersBindingNavigator.CountItemFormat = "из {0}";
            this.OrdersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.OrdersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.OrdersBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.OkToolStripButton,
            this.FindToolStripTextBox,
            this.FindToolStripButton});
            this.OrdersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.OrdersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.OrdersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.OrdersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.OrdersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.OrdersBindingNavigator.Name = "OrdersBindingNavigator";
            this.OrdersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.OrdersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.OrdersBindingNavigator.TabIndex = 0;
            this.OrdersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // OrdersBindingNavigatorSaveItem
            // 
            this.OrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrdersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("OrdersBindingNavigatorSaveItem.Image")));
            this.OrdersBindingNavigatorSaveItem.Name = "OrdersBindingNavigatorSaveItem";
            this.OrdersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.OrdersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.OrdersBindingNavigatorSaveItem.Click += new System.EventHandler(this.OrdersBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // OkToolStripButton
            // 
            this.OkToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OkToolStripButton.Image")));
            this.OkToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OkToolStripButton.Name = "OkToolStripButton";
            this.OkToolStripButton.Size = new System.Drawing.Size(74, 22);
            this.OkToolStripButton.Text = "Выбрать";
            this.OkToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OkToolStripButton.Click += new System.EventHandler(this.OkToolStripButton_Click);
            // 
            // FindToolStripTextBox
            // 
            this.FindToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FindToolStripTextBox.Name = "FindToolStripTextBox";
            this.FindToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // FindToolStripButton
            // 
            this.FindToolStripButton.Image = global::DataBase2.Properties.Resources.find_128x128;
            this.FindToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindToolStripButton.Name = "FindToolStripButton";
            this.FindToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.FindToolStripButton.Text = "Find";
            this.FindToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FindToolStripButton.Click += new System.EventHandler(this.FindToolStripButton_Click);
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AllowUserToResizeRows = false;
            this.OrderDataGridView.AutoGenerateColumns = false;
            this.OrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Имя_гостя,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.OrderDataGridView.DataSource = this.OrdersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGridView.Location = new System.Drawing.Point(0, 25);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowHeadersVisible = false;
            this.OrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGridView.Size = new System.Drawing.Size(800, 425);
            this.OrderDataGridView.TabIndex = 1;
            this.OrderDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OrderDataGridView_CellFormatting);
            this.OrderDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OrderDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 60.91371F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_гостя";
            this.dataGridViewTextBoxColumn2.FillWeight = 59.74306F;
            this.dataGridViewTextBoxColumn2.HeaderText = "id_гостя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Имя_гостя
            // 
            this.Имя_гостя.DataPropertyName = "Имя_гостя";
            this.Имя_гостя.FillWeight = 119.8358F;
            this.Имя_гостя.HeaderText = "Имя_гостя";
            this.Имя_гостя.Name = "Имя_гостя";
            this.Имя_гостя.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_комнаты";
            this.dataGridViewTextBoxColumn3.FillWeight = 119.8358F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_комнаты";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_персонала";
            this.dataGridViewTextBoxColumn4.FillWeight = 119.8358F;
            this.dataGridViewTextBoxColumn4.HeaderText = "id_персонала";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Статус_заказа";
            this.dataGridViewTextBoxColumn5.FillWeight = 119.8358F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Статус_заказа";
            this.dataGridViewTextBoxColumn5.Items.AddRange(new object[] {
            "Подтвержден",
            "Завершен",
            "Отменен"});
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FindCheckBox
            // 
            this.FindCheckBox.AutoSize = true;
            this.FindCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.FindCheckBox.Location = new System.Drawing.Point(508, 4);
            this.FindCheckBox.Name = "FindCheckBox";
            this.FindCheckBox.Size = new System.Drawing.Size(48, 17);
            this.FindCheckBox.TabIndex = 2;
            this.FindCheckBox.Text = "Filter";
            this.FindCheckBox.UseVisualStyleBackColor = false;
            this.FindCheckBox.CheckedChanged += new System.EventHandler(this.FindCheckBox_CheckedChanged);
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
            // OrdersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindCheckBox);
            this.Controls.Add(this.OrderDataGridView);
            this.Controls.Add(this.OrdersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "OrdersListForm";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrdersListForm_Load);
            this.Shown += new System.EventHandler(this.OrdersListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingNavigator)).EndInit();
            this.OrdersBindingNavigator.ResumeLayout(false);
            this.OrdersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private HotelDataSetTableAdapters.ЗаказTableAdapter OrdersTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager OrdersTableAdapterManager;
        private System.Windows.Forms.BindingNavigator OrdersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton OrdersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox FindToolStripTextBox;
        private System.Windows.Forms.ToolStripButton FindToolStripButton;
        private System.Windows.Forms.CheckBox FindCheckBox;
        private System.Windows.Forms.ToolStripButton OkToolStripButton;
        private System.Windows.Forms.BindingSource GuestBindingSource;
        private HotelDataSetTableAdapters.ГостьTableAdapter GuestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя_гостя;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}