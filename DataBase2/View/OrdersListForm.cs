using System.Windows.Forms;
using System.Drawing;

namespace DataBase2.View
{
    public partial class OrdersListForm : Form
    {
        private static OrdersListForm form;

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

        public OrdersListForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void OrdersListForm_Load(object sender, System.EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Заказ".
            // При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.hotelDataSet.Заказ);
        }

        private void OrderDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Свободна")
                {
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 153, 51);
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Забронирована")
                {
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255,51,0);
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Недоступна")
                {
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    OrderDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}