using System.Windows.Forms;
using System;

namespace DataBase2.View
{
    public partial class StaffListForm : Form
    {
        /// <summary>
        /// Экземпляр формы <see cref="StaffListForm"/>.
        /// </summary>
        private static StaffListForm form;

        /// <summary>
        /// Возвращает экземпляр формы <see cref="StaffListForm"/>, 
        /// если она уже существует, иначе создает новую форму.
        /// </summary>
        public static StaffListForm staffListForm
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new StaffListForm();
                }
                return form;
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
            this.Validate();
            this.StaffBindingSource.EndEdit();
            this.StaffTableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void StaffListForm_Load(object sender, EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Персонал".
            // При необходимости она может быть перемещена или удалена.
            this.StaffTableAdapter.Fill(this.hotelDataSet.Персонал);
        }
    }
}