namespace DataBase2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAppToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guestsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.CloseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AboutAppToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RoomsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StaffToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GuestsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OrdersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainMenuStrip.SuspendLayout();
            this.MainContextMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.directoryToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem,
            this.AboutAppToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Image = global::DataBase2.Properties.Resources.exit_icon_128x128;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // AboutAppToolStripMenuItem
            // 
            this.AboutAppToolStripMenuItem.Image = global::DataBase2.Properties.Resources.information_icon_128x128;
            this.AboutAppToolStripMenuItem.Name = "AboutAppToolStripMenuItem";
            this.AboutAppToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.AboutAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutAppToolStripMenuItem.Text = "About app";
            this.AboutAppToolStripMenuItem.Click += new System.EventHandler(this.AboutAppToolStripMenuItem_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoomsToolStripMenuItem,
            this.StaffToolStripMenuItem,
            this.GuestsToolStripMenuItem,
            this.OrdersToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // RoomsToolStripMenuItem
            // 
            this.RoomsToolStripMenuItem.Image = global::DataBase2.Properties.Resources.hotel_icon_128x128;
            this.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem";
            this.RoomsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RoomsToolStripMenuItem.Text = "Rooms";
            this.RoomsToolStripMenuItem.Click += new System.EventHandler(this.RoomsToolStripMenuItem_Click);
            // 
            // StaffToolStripMenuItem
            // 
            this.StaffToolStripMenuItem.Image = global::DataBase2.Properties.Resources.staff_icon_100x100;
            this.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem";
            this.StaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StaffToolStripMenuItem.Text = "Staff";
            this.StaffToolStripMenuItem.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // GuestsToolStripMenuItem
            // 
            this.GuestsToolStripMenuItem.Image = global::DataBase2.Properties.Resources.staff_icon_128x128;
            this.GuestsToolStripMenuItem.Name = "GuestsToolStripMenuItem";
            this.GuestsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GuestsToolStripMenuItem.Text = "Guests";
            this.GuestsToolStripMenuItem.Click += new System.EventHandler(this.GuestsToolStripMenuItem_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Image = global::DataBase2.Properties.Resources.order_icon_100x100;
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OrdersToolStripMenuItem.Text = "Orders";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.directoryToolStripMenuItem1});
            this.MainContextMenuStrip.Name = "MainContextMenuStrip";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(160, 48);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.AboutAppToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::DataBase2.Properties.Resources.exit_icon_128x128;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Close";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // AboutAppToolStripMenuItem1
            // 
            this.AboutAppToolStripMenuItem1.Image = global::DataBase2.Properties.Resources.information_icon_128x128;
            this.AboutAppToolStripMenuItem1.Name = "AboutAppToolStripMenuItem1";
            this.AboutAppToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.AboutAppToolStripMenuItem1.Text = "About app";
            this.AboutAppToolStripMenuItem1.Click += new System.EventHandler(this.AboutAppToolStripMenuItem_Click);
            // 
            // directoryToolStripMenuItem1
            // 
            this.directoryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem1,
            this.staffToolStripMenuItem1,
            this.guestsToolStripMenuItem1,
            this.ordersToolStripMenuItem1});
            this.directoryToolStripMenuItem1.Name = "directoryToolStripMenuItem1";
            this.directoryToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.directoryToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.directoryToolStripMenuItem1.Text = "Directory";
            // 
            // roomsToolStripMenuItem1
            // 
            this.roomsToolStripMenuItem1.Image = global::DataBase2.Properties.Resources.hotel_icon_128x128;
            this.roomsToolStripMenuItem1.Name = "roomsToolStripMenuItem1";
            this.roomsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.roomsToolStripMenuItem1.Text = "Rooms";
            this.roomsToolStripMenuItem1.Click += new System.EventHandler(this.RoomsToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem1
            // 
            this.staffToolStripMenuItem1.Image = global::DataBase2.Properties.Resources.staff_icon_100x100;
            this.staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            this.staffToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.staffToolStripMenuItem1.Text = "Staff";
            this.staffToolStripMenuItem1.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // guestsToolStripMenuItem1
            // 
            this.guestsToolStripMenuItem1.Image = global::DataBase2.Properties.Resources.staff_icon_128x128;
            this.guestsToolStripMenuItem1.Name = "guestsToolStripMenuItem1";
            this.guestsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.guestsToolStripMenuItem1.Text = "Guests";
            this.guestsToolStripMenuItem1.Click += new System.EventHandler(this.GuestsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem1
            // 
            this.ordersToolStripMenuItem1.Image = global::DataBase2.Properties.Resources.order_icon_100x100;
            this.ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            this.ordersToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ordersToolStripMenuItem1.Text = "Orders";
            this.ordersToolStripMenuItem1.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripButton,
            this.AboutAppToolStripButton,
            this.RoomsToolStripButton,
            this.StaffToolStripButton,
            this.GuestsToolStripButton,
            this.OrdersToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(800, 25);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // CloseToolStripButton
            // 
            this.CloseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseToolStripButton.Image = global::DataBase2.Properties.Resources.exit_icon_128x128;
            this.CloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseToolStripButton.Name = "CloseToolStripButton";
            this.CloseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CloseToolStripButton.Text = "Close";
            this.CloseToolStripButton.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // AboutAppToolStripButton
            // 
            this.AboutAppToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutAppToolStripButton.Image = global::DataBase2.Properties.Resources.information_icon_128x128;
            this.AboutAppToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutAppToolStripButton.Name = "AboutAppToolStripButton";
            this.AboutAppToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AboutAppToolStripButton.Text = "About app";
            this.AboutAppToolStripButton.Click += new System.EventHandler(this.AboutAppToolStripMenuItem_Click);
            // 
            // RoomsToolStripButton
            // 
            this.RoomsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoomsToolStripButton.Image = global::DataBase2.Properties.Resources.hotel_icon_128x128;
            this.RoomsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RoomsToolStripButton.Name = "RoomsToolStripButton";
            this.RoomsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RoomsToolStripButton.Text = "Rooms";
            this.RoomsToolStripButton.Click += new System.EventHandler(this.RoomsToolStripMenuItem_Click);
            // 
            // StaffToolStripButton
            // 
            this.StaffToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffToolStripButton.Image = global::DataBase2.Properties.Resources.staff_icon_100x100;
            this.StaffToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StaffToolStripButton.Name = "StaffToolStripButton";
            this.StaffToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.StaffToolStripButton.Text = "Staff";
            this.StaffToolStripButton.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // GuestsToolStripButton
            // 
            this.GuestsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuestsToolStripButton.Image = global::DataBase2.Properties.Resources.staff_icon_128x128;
            this.GuestsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuestsToolStripButton.Name = "GuestsToolStripButton";
            this.GuestsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.GuestsToolStripButton.Text = "Guests";
            this.GuestsToolStripButton.Click += new System.EventHandler(this.GuestsToolStripMenuItem_Click);
            // 
            // OrdersToolStripButton
            // 
            this.OrdersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrdersToolStripButton.Image = global::DataBase2.Properties.Resources.order_icon_100x100;
            this.OrdersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdersToolStripButton.Name = "OrdersToolStripButton";
            this.OrdersToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OrdersToolStripButton.Text = "Orders";
            this.OrdersToolStripButton.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.MainContextMenuStrip;
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::DataBase2.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::DataBase2.Properties.Settings.Default.FormPos;
            this.Name = "MainForm";
            this.Text = "Hotel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainContextMenuStrip.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutAppToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guestsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton CloseToolStripButton;
        private System.Windows.Forms.ToolStripButton AboutAppToolStripButton;
        private System.Windows.Forms.ToolStripButton RoomsToolStripButton;
        private System.Windows.Forms.ToolStripButton StaffToolStripButton;
        private System.Windows.Forms.ToolStripButton GuestsToolStripButton;
        private System.Windows.Forms.ToolStripButton OrdersToolStripButton;
    }
}

