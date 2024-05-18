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
            this.hotelDataSet = new DataBase2.HotelDataSet();
            this.RoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomsTableAdapter = new DataBase2.HotelDataSetTableAdapters.КомнатаTableAdapter();
            this.RoomsTableAdapterManager = new DataBase2.HotelDataSetTableAdapters.TableAdapterManager();
            this.RoomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            номер_комнатыLabel = new System.Windows.Forms.Label();
            id_гостяLabel = new System.Windows.Forms.Label();
            фИО_арендатораLabel = new System.Windows.Forms.Label();
            тип_комнатыLabel = new System.Windows.Forms.Label();
            статус_комнатыLabel = new System.Windows.Forms.Label();
            название_обслуживающей_организацииLabel = new System.Windows.Forms.Label();
            частота_уборкиLabel = new System.Windows.Forms.Label();
            услуга_все_включеноLabel = new System.Windows.Forms.Label();
            изображениеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingNavigator)).BeginInit();
            this.RoomsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_комнатыLabel
            // 
            номер_комнатыLabel.AutoSize = true;
            номер_комнатыLabel.Location = new System.Drawing.Point(49, 88);
            номер_комнатыLabel.Name = "номер_комнатыLabel";
            номер_комнатыLabel.Size = new System.Drawing.Size(92, 13);
            номер_комнатыLabel.TabIndex = 1;
            номер_комнатыLabel.Text = "Номер комнаты:";
            // 
            // id_гостяLabel
            // 
            id_гостяLabel.AutoSize = true;
            id_гостяLabel.Location = new System.Drawing.Point(49, 114);
            id_гостяLabel.Name = "id_гостяLabel";
            id_гостяLabel.Size = new System.Drawing.Size(49, 13);
            id_гостяLabel.TabIndex = 3;
            id_гостяLabel.Text = "id гостя:";
            // 
            // фИО_арендатораLabel
            // 
            фИО_арендатораLabel.AutoSize = true;
            фИО_арендатораLabel.Location = new System.Drawing.Point(49, 140);
            фИО_арендатораLabel.Name = "фИО_арендатораLabel";
            фИО_арендатораLabel.Size = new System.Drawing.Size(99, 13);
            фИО_арендатораLabel.TabIndex = 5;
            фИО_арендатораLabel.Text = "ФИО арендатора:";
            // 
            // тип_комнатыLabel
            // 
            тип_комнатыLabel.AutoSize = true;
            тип_комнатыLabel.Location = new System.Drawing.Point(49, 166);
            тип_комнатыLabel.Name = "тип_комнатыLabel";
            тип_комнатыLabel.Size = new System.Drawing.Size(77, 13);
            тип_комнатыLabel.TabIndex = 7;
            тип_комнатыLabel.Text = "Тип комнаты:";
            // 
            // статус_комнатыLabel
            // 
            статус_комнатыLabel.AutoSize = true;
            статус_комнатыLabel.Location = new System.Drawing.Point(49, 192);
            статус_комнатыLabel.Name = "статус_комнатыLabel";
            статус_комнатыLabel.Size = new System.Drawing.Size(92, 13);
            статус_комнатыLabel.TabIndex = 9;
            статус_комнатыLabel.Text = "Статус комнаты:";
            // 
            // название_обслуживающей_организацииLabel
            // 
            название_обслуживающей_организацииLabel.AutoSize = true;
            название_обслуживающей_организацииLabel.Location = new System.Drawing.Point(49, 218);
            название_обслуживающей_организацииLabel.Name = "название_обслуживающей_организацииLabel";
            название_обслуживающей_организацииLabel.Size = new System.Drawing.Size(158, 13);
            название_обслуживающей_организацииLabel.TabIndex = 11;
            название_обслуживающей_организацииLabel.Text = "Название обсл. организации:";
            // 
            // частота_уборкиLabel
            // 
            частота_уборкиLabel.AutoSize = true;
            частота_уборкиLabel.Location = new System.Drawing.Point(49, 244);
            частота_уборкиLabel.Name = "частота_уборкиLabel";
            частота_уборкиLabel.Size = new System.Drawing.Size(132, 13);
            частота_уборкиLabel.TabIndex = 13;
            частота_уборкиLabel.Text = "Частота уборки (в день):";
            // 
            // услуга_все_включеноLabel
            // 
            услуга_все_включеноLabel.AutoSize = true;
            услуга_все_включеноLabel.Location = new System.Drawing.Point(49, 272);
            услуга_все_включеноLabel.Name = "услуга_все_включеноLabel";
            услуга_все_включеноLabel.Size = new System.Drawing.Size(119, 13);
            услуга_все_включеноLabel.TabIndex = 15;
            услуга_все_включеноLabel.Text = "Услуга все включено:";
            // 
            // изображениеLabel
            // 
            изображениеLabel.AutoSize = true;
            изображениеLabel.Location = new System.Drawing.Point(408, 88);
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
            this.RoomsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.RoomsBindingNavigator.BindingSource = this.RoomsBindingSource;
            this.RoomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.RoomsBindingNavigator.CountItemFormat = "из {0}";
            this.RoomsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.RoomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.RoomsBindingNavigatorSaveItem});
            this.RoomsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.RoomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.RoomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.RoomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.RoomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.RoomsBindingNavigator.Name = "RoomsBindingNavigator";
            this.RoomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.RoomsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.RoomsBindingNavigator.TabIndex = 0;
            this.RoomsBindingNavigator.Text = "bindingNavigator1";
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
            this.номер_комнатыTextBox.Location = new System.Drawing.Point(210, 85);
            this.номер_комнатыTextBox.Name = "номер_комнатыTextBox";
            this.номер_комнатыTextBox.ReadOnly = true;
            this.номер_комнатыTextBox.Size = new System.Drawing.Size(164, 20);
            this.номер_комнатыTextBox.TabIndex = 2;
            // 
            // id_гостяTextBox
            // 
            this.id_гостяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "id_гостя", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.id_гостяTextBox.Location = new System.Drawing.Point(210, 111);
            this.id_гостяTextBox.Name = "id_гостяTextBox";
            this.id_гостяTextBox.Size = new System.Drawing.Size(164, 20);
            this.id_гостяTextBox.TabIndex = 4;
            // 
            // фИО_арендатораTextBox
            // 
            this.фИО_арендатораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "ФИО_арендатора", true));
            this.фИО_арендатораTextBox.Location = new System.Drawing.Point(210, 137);
            this.фИО_арендатораTextBox.Name = "фИО_арендатораTextBox";
            this.фИО_арендатораTextBox.Size = new System.Drawing.Size(164, 20);
            this.фИО_арендатораTextBox.TabIndex = 6;
            // 
            // тип_комнатыTextBox
            // 
            this.тип_комнатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Тип_комнаты", true));
            this.тип_комнатыTextBox.Location = new System.Drawing.Point(210, 163);
            this.тип_комнатыTextBox.Name = "тип_комнатыTextBox";
            this.тип_комнатыTextBox.Size = new System.Drawing.Size(164, 20);
            this.тип_комнатыTextBox.TabIndex = 8;
            // 
            // статус_комнатыTextBox
            // 
            this.статус_комнатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Статус_комнаты", true));
            this.статус_комнатыTextBox.Location = new System.Drawing.Point(210, 189);
            this.статус_комнатыTextBox.Name = "статус_комнатыTextBox";
            this.статус_комнатыTextBox.Size = new System.Drawing.Size(164, 20);
            this.статус_комнатыTextBox.TabIndex = 10;
            // 
            // название_обслуживающей_организацииTextBox
            // 
            this.название_обслуживающей_организацииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Название_обслуживающей_организации", true));
            this.название_обслуживающей_организацииTextBox.Location = new System.Drawing.Point(210, 215);
            this.название_обслуживающей_организацииTextBox.Name = "название_обслуживающей_организацииTextBox";
            this.название_обслуживающей_организацииTextBox.Size = new System.Drawing.Size(164, 20);
            this.название_обслуживающей_организацииTextBox.TabIndex = 12;
            // 
            // частота_уборкиTextBox
            // 
            this.частота_уборкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Частота_уборки", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.частота_уборкиTextBox.Location = new System.Drawing.Point(210, 241);
            this.частота_уборкиTextBox.Name = "частота_уборкиTextBox";
            this.частота_уборкиTextBox.Size = new System.Drawing.Size(164, 20);
            this.частота_уборкиTextBox.TabIndex = 14;
            // 
            // услуга_все_включеноCheckBox
            // 
            this.услуга_все_включеноCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.RoomsBindingSource, "Услуга_все_включено", true));
            this.услуга_все_включеноCheckBox.Location = new System.Drawing.Point(210, 267);
            this.услуга_все_включеноCheckBox.Name = "услуга_все_включеноCheckBox";
            this.услуга_все_включеноCheckBox.Size = new System.Drawing.Size(15, 24);
            this.услуга_все_включеноCheckBox.TabIndex = 16;
            this.услуга_все_включеноCheckBox.UseVisualStyleBackColor = true;
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.RoomsBindingSource, "Изображение", true));
            this.PhotoPictureBox.Location = new System.Drawing.Point(494, 88);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(266, 197);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 18;
            this.PhotoPictureBox.TabStop = false;
            // 
            // OpenPhotoButton
            // 
            this.OpenPhotoButton.Location = new System.Drawing.Point(409, 104);
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
            // RoomsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "RoomsListForm";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.RoomsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingNavigator)).EndInit();
            this.RoomsBindingNavigator.ResumeLayout(false);
            this.RoomsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource RoomsBindingSource;
        private HotelDataSetTableAdapters.КомнатаTableAdapter RoomsTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager RoomsTableAdapterManager;
        private System.Windows.Forms.BindingNavigator RoomsBindingNavigator;
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
    }
}