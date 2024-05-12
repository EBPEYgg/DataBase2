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
            this.гостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гостьTableAdapter = new DataBase2.HotelDataSetTableAdapters.ГостьTableAdapter();
            this.tableAdapterManager = new DataBase2.HotelDataSetTableAdapters.TableAdapterManager();
            this.гостьBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.гостьBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.дата_заездаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_выездаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            дата_заездаLabel = new System.Windows.Forms.Label();
            дата_выездаLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостьBindingNavigator)).BeginInit();
            this.гостьBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(202, 138);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(202, 164);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // дата_заездаLabel
            // 
            дата_заездаLabel.AutoSize = true;
            дата_заездаLabel.Location = new System.Drawing.Point(202, 191);
            дата_заездаLabel.Name = "дата_заездаLabel";
            дата_заездаLabel.Size = new System.Drawing.Size(75, 13);
            дата_заездаLabel.TabIndex = 5;
            дата_заездаLabel.Text = "Дата заезда:";
            // 
            // дата_выездаLabel
            // 
            дата_выездаLabel.AutoSize = true;
            дата_выездаLabel.Location = new System.Drawing.Point(202, 217);
            дата_выездаLabel.Name = "дата_выездаLabel";
            дата_выездаLabel.Size = new System.Drawing.Size(77, 13);
            дата_выездаLabel.TabIndex = 7;
            дата_выездаLabel.Text = "Дата выезда:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(202, 242);
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
            // гостьBindingSource
            // 
            this.гостьBindingSource.DataMember = "Гость";
            this.гостьBindingSource.DataSource = this.hotelDataSet;
            // 
            // гостьTableAdapter
            // 
            this.гостьTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DataBase2.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Гость_комнатаTableAdapter = null;
            this.tableAdapterManager.ГостьTableAdapter = this.гостьTableAdapter;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КомнатаTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            // 
            // гостьBindingNavigator
            // 
            this.гостьBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.гостьBindingNavigator.BindingSource = this.гостьBindingSource;
            this.гостьBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.гостьBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.гостьBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.гостьBindingNavigatorSaveItem});
            this.гостьBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.гостьBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.гостьBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.гостьBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.гостьBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.гостьBindingNavigator.Name = "гостьBindingNavigator";
            this.гостьBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.гостьBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.гостьBindingNavigator.TabIndex = 0;
            this.гостьBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
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
            // гостьBindingNavigatorSaveItem
            // 
            this.гостьBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.гостьBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("гостьBindingNavigatorSaveItem.Image")));
            this.гостьBindingNavigatorSaveItem.Name = "гостьBindingNavigatorSaveItem";
            this.гостьBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.гостьBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.гостьBindingNavigatorSaveItem.Click += new System.EventHandler(this.гостьBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гостьBindingSource, "id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.idTextBox.Location = new System.Drawing.Point(304, 135);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гостьBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(304, 161);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // дата_заездаDateTimePicker
            // 
            this.дата_заездаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.гостьBindingSource, "Дата_заезда", true));
            this.дата_заездаDateTimePicker.Location = new System.Drawing.Point(304, 187);
            this.дата_заездаDateTimePicker.Name = "дата_заездаDateTimePicker";
            this.дата_заездаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заездаDateTimePicker.TabIndex = 6;
            // 
            // дата_выездаDateTimePicker
            // 
            this.дата_выездаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.гостьBindingSource, "Дата_выезда", true));
            this.дата_выездаDateTimePicker.Location = new System.Drawing.Point(304, 213);
            this.дата_выездаDateTimePicker.Name = "дата_выездаDateTimePicker";
            this.дата_выездаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_выездаDateTimePicker.TabIndex = 8;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.гостьBindingSource, "Номер_телефона", true));
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(304, 239);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_телефонаTextBox.TabIndex = 10;
            // 
            // GuestsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.гостьBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestsListForm";
            this.Text = "Guests";
            this.Load += new System.EventHandler(this.GuestsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостьBindingNavigator)).EndInit();
            this.гостьBindingNavigator.ResumeLayout(false);
            this.гостьBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource гостьBindingSource;
        private HotelDataSetTableAdapters.ГостьTableAdapter гостьTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator гостьBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton гостьBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.DateTimePicker дата_заездаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_выездаDateTimePicker;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
    }
}