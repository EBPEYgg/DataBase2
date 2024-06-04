using System.Windows.Forms;
using System.Drawing;
using System;
using System.Data;

namespace DataBase2.View
{
    public partial class OrdersListForm : Form
    {
        /// <summary>
        /// Текущий ID сотрудника.
        /// </summary>
        private int _currentId;

        /// <summary>
        /// Экземпляр формы <see cref="OrdersListForm"/>.
        /// </summary>
        private static OrdersListForm _form;

        /// <summary>
        /// Возвращает экземпляр формы <see cref="OrdersListForm"/>, 
        /// если она уже существует, иначе создает новую форму.
        /// </summary>
        public static OrdersListForm ordersListForm
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new OrdersListForm();
                }
                return _form;
            }
        }

        /// <summary>
        /// Метод, который возвращает идентификатор выбранного сотрудника.
        /// </summary>
        /// <param name="id">id сотрудника.</param>
        /// <returns>Возвращает id сотрудника текущей строки.</returns>
        public int ShowSelectForm(int id)
        {
            OkToolStripButton.Visible = true;
            _currentId = id;
            if (ShowDialog() == DialogResult.OK)
            {
                return (int)((DataRowView)OrdersBindingSource.Current)["id_персонала"];
            }
            else
            {
                return -1;
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
            OkToolStripButton.Visible = false;
            OrdersBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void OrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.OrdersBindingSource.EndEdit();
                this.OrdersTableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrdersListForm_Load(object sender, EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Гость".
            // При необходимости она может быть перемещена или удалена.
            this.GuestTableAdapter.Fill(this.hotelDataSet.Гость);
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Заказ".
            // При необходимости она может быть перемещена или удалена.
            this.OrdersTableAdapter.Fill(this.hotelDataSet.Заказ);
        }

        private void OrderDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && OrderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
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

        /// <summary>
        /// Метод, который возвращает название выбранного столбца в OrderDataGridView.
        /// </summary>
        /// <returns>Название выбранного столбца.</returns>
        private string GetSelectedFieldName()
        {
            return OrderDataGridView.Columns[OrderDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void FindToolStripButton_Click(object sender, EventArgs e)
        {
            string searchText = FindToolStripTextBox.Text.Trim();
            OrderDataGridView.ClearSelection();

            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in OrderDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                        {
                            row.Selected = true;
                            OrderDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                            return;
                        }
                    }
                }
                MessageBox.Show("Не найдено", "Результаты поиска",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ничего не задано", "Результаты поиска",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FindCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FindCheckBox.Checked)
            {
                if (FindToolStripTextBox.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FindCheckBox.Checked = false;
                }
                else
                {
                    try
                    {
                        OrdersBindingSource.Filter = 
                            GetSelectedFieldName() + "='" + FindToolStripTextBox.Text + "'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" + ex.Message);
                        FindCheckBox.Checked = false;
                    }
                }
            }
            else
            {
                OrdersBindingSource.Filter = "";
            }
            if (OrdersBindingSource.Count == 0)
            {
                MessageBox.Show("Не найдено", "Результат поиска", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdersBindingSource.Filter = "";
                FindCheckBox.Checked = false;
            }
        }

        private void OkToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void OrdersListForm_Shown(object sender, EventArgs e)
        {
            OrdersBindingSource.Position = OrdersBindingSource.Find("id_персонала", _currentId);
        }

        private void OrderDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //OrderDataGridView.ClearSelection();
        }
    }
}