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
            this.hotelDataSet = new DataBase2.HotelDataSet();
            this.StaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StaffTableAdapter = new DataBase2.HotelDataSetTableAdapters.ПерсоналTableAdapter();
            this.StaffTableAdapterManager = new DataBase2.HotelDataSetTableAdapters.TableAdapterManager();
            this.StaffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.StaffBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.зарплатаTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.трудовой_стажTextBox = new System.Windows.Forms.TextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            трудовой_стажLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffBindingNavigator)).BeginInit();
            this.StaffBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(61, 84);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(61, 110);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(61, 136);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 5;
            полLabel.Text = "Пол:";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.Location = new System.Drawing.Point(61, 162);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(58, 13);
            зарплатаLabel.TabIndex = 7;
            зарплатаLabel.Text = "Зарплата:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(61, 188);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(68, 13);
            должностьLabel.TabIndex = 9;
            должностьLabel.Text = "Должность:";
            // 
            // трудовой_стажLabel
            // 
            трудовой_стажLabel.AutoSize = true;
            трудовой_стажLabel.Location = new System.Drawing.Point(61, 214);
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
            this.StaffBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.StaffBindingNavigator.BindingSource = this.StaffBindingSource;
            this.StaffBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.StaffBindingNavigator.CountItemFormat = "из {0}";
            this.StaffBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.StaffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.StaffBindingNavigatorSaveItem});
            this.StaffBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.StaffBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.StaffBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.StaffBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.StaffBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.StaffBindingNavigator.Name = "StaffBindingNavigator";
            this.StaffBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.StaffBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.StaffBindingNavigator.TabIndex = 0;
            this.StaffBindingNavigator.Text = "bindingNavigator1";
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
            this.idTextBox.Location = new System.Drawing.Point(153, 81);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(190, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(153, 107);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(190, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // зарплатаTextBox
            // 
            this.зарплатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "Зарплата", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.зарплатаTextBox.Location = new System.Drawing.Point(153, 159);
            this.зарплатаTextBox.Name = "зарплатаTextBox";
            this.зарплатаTextBox.Size = new System.Drawing.Size(190, 20);
            this.зарплатаTextBox.TabIndex = 8;
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "Должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(153, 185);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(190, 20);
            this.должностьTextBox.TabIndex = 10;
            // 
            // трудовой_стажTextBox
            // 
            this.трудовой_стажTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaffBindingSource, "Трудовой_стаж", true));
            this.трудовой_стажTextBox.Location = new System.Drawing.Point(153, 211);
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
            this.полComboBox.Location = new System.Drawing.Point(153, 133);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(190, 21);
            this.полComboBox.TabIndex = 14;
            // 
            // StaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "StaffListForm";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.StaffListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffBindingNavigator)).EndInit();
            this.StaffBindingNavigator.ResumeLayout(false);
            this.StaffBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource StaffBindingSource;
        private HotelDataSetTableAdapters.ПерсоналTableAdapter StaffTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager StaffTableAdapterManager;
        private System.Windows.Forms.BindingNavigator StaffBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton StaffBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox зарплатаTextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.TextBox трудовой_стажTextBox;
        private System.Windows.Forms.ComboBox полComboBox;
    }
}