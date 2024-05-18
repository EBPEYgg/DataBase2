using System.Windows.Forms;
using System;

namespace DataBase2.View
{
    public partial class GuestsListForm : Form
    {
        /// <summary>
        /// Экземпляр формы <see cref="GuestsListForm"/>.
        /// </summary>
        private static GuestsListForm form;

        /// <summary>
        /// Возвращает экземпляр формы <see cref="GuestsListForm"/>, 
        /// если она уже существует, иначе создает новую форму.
        /// </summary>
        public static GuestsListForm guestsListForm
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new GuestsListForm();
                }
                return form;
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
        /// Метод, который отображает форму и переводит на нее фокус.
        /// </summary>
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void GuestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.GuestsBindingSource.EndEdit();
            this.GuestsTableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void GuestsListForm_Load(object sender, EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Гость".
            // При необходимости она может быть перемещена или удалена.
            this.GuestsTableAdapter.Fill(this.hotelDataSet.Гость);
        }
    }
}