using System.Windows.Forms;

namespace DataBase2.View
{
    public partial class GuestsListForm : Form
    {
        private static GuestsListForm form;

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

        public GuestsListForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void гостьBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.гостьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void GuestsListForm_Load(object sender, System.EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Гость".
            // При необходимости она может быть перемещена или удалена.
            this.гостьTableAdapter.Fill(this.hotelDataSet.Гость);

        }
    }
}