using System.Windows.Forms;
using System;

namespace DataBase2.View
{
    public partial class GuestsListForm : Form
    {
        /// <summary>
        /// Текущий ID комнаты.
        /// </summary>
        private int _currentId = -1;

        /// <summary>
        /// Экземпляр формы <see cref="GuestsListForm"/>.
        /// </summary>
        private static GuestsListForm _form;

        /// <summary>
        /// Возвращает экземпляр формы <see cref="GuestsListForm"/>, 
        /// если она уже существует, иначе создает новую форму.
        /// </summary>
        public static GuestsListForm guestsListForm
        {
            get
            {
                if (_form == null || _form.IsDisposed)
                {
                    _form = new GuestsListForm();
                }
                return _form;
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="GuestsListForm"/>.
        /// </summary>
        public GuestsListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который возвращает идентификатор выбранной комнаты.
        /// </summary>
        /// <param name="id">id комнаты.</param>
        /// <returns>Возвращает id комнаты текущей строки.</returns>
        public int ShowSelectForm(int id)
        {
            _currentId = id;
            if (ShowDialog() == DialogResult.OK)
            {
                return GuestsBindingSource.Find("id", _currentId);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Метод, который отображает форму и переводит на нее фокус.
        /// </summary>
        public void ShowForm()
        {
            GuestsBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void GuestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.GuestsBindingSource.EndEdit();
                this.GuestsTableAdapterManager.UpdateAll(this.hotelDataSet);
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
                this.GuestsBindingSource.EndEdit();
                this.GuestsTableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuestsListForm_Load(object sender, EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Заказ".
            // При необходимости она может быть перемещена или удалена.
            this.OrdersTableAdapter.Fill(this.hotelDataSet.Заказ);
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Гость".
            // При необходимости она может быть перемещена или удалена.
            this.GuestsTableAdapter.Fill(this.hotelDataSet.Гость);
        }

        private void GuestsListForm_Shown(object sender, EventArgs e)
        {
            GuestsBindingSource.Position = GuestsBindingSource.Find("id", _currentId);
        }
    }
}