using System.Windows.Forms;
using System.Drawing;
using System;

namespace DataBase2.View
{
    public partial class OrdersListForm : Form
    {
        /// <summary>
        /// Экземпляр формы <see cref="OrdersListForm"/>.
        /// </summary>
        private static OrdersListForm form;

        /// <summary>
        /// Возвращает экземпляр формы <see cref="OrdersListForm"/>, 
        /// если она уже существует, иначе создает новую форму.
        /// </summary>
        public static OrdersListForm ordersListForm
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new OrdersListForm();
                }
                return form;
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="OrdersListForm"/>.
        /// </summary>
        public OrdersListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который отображает форму и переводит на нее фокус.
        /// </summary>
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void OrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.OrdersBindingSource.EndEdit();
            this.OrdersTableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void OrdersListForm_Load(object sender, EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Заказ".
            // При необходимости она может быть перемещена или удалена.
            this.OrdersTableAdapter.Fill(this.hotelDataSet.Заказ);
        }

        private void OrderDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Завершен")
                {
                    // green row
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 153, 51);
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Подтвержден")
                {
                    // red row
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255,51,0);
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Отменен")
                {
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}