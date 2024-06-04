using System.Windows.Forms;
using System;
using System.Data;

namespace DataBase2.View
{
    public partial class StaffListForm : Form
    {
        /// <summary>
        /// Экземпляр формы <see cref="StaffListForm"/>.
        /// </summary>
        private static StaffListForm _form;

        /// <summary>
        /// Возвращает экземпляр формы <see cref="StaffListForm"/>, 
        /// если она уже существует, иначе создает новую форму.
        /// </summary>
        public static StaffListForm staffListForm
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new StaffListForm();
                }
                return _form;
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="StaffListForm"/>.
        /// </summary>
        public StaffListForm()
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

        private void StaffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.StaffBindingSource.EndEdit();
                this.StaffTableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.StaffBindingSource.EndEdit();
                this.StaffTableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffListForm_Load(object sender, EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Заказ".
            // При необходимости она может быть перемещена или удалена.
            this.OrderTableAdapter.Fill(this.hotelDataSet.Заказ);
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Персонал".
            // При необходимости она может быть перемещена или удалена.
            this.StaffTableAdapter.Fill(this.hotelDataSet.Персонал);
        }

        private void ShowOrderButton_Click(object sender, EventArgs e)
        {
            int idStaff = -1;
            if (idTextBox.Text.ToString() != "")
            {
                idStaff = int.Parse(idTextBox.Text.ToString());
            }

            idStaff = OrdersListForm.ordersListForm.ShowSelectForm(idStaff);

            if (idStaff >= 0)
            {
                MessageBox.Show(idStaff.ToString());
                idTextBox.Text = idStaff.ToString();
                StaffBindingSource.EndEdit();
                StaffTableAdapter.Fill(this.hotelDataSet.Персонал);
            }
        }
    }
}