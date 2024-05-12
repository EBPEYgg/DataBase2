using System.Windows.Forms;

namespace DataBase2.View
{
    public partial class StaffListForm : Form
    {
        private static StaffListForm form;

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

        public StaffListForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void StaffListForm_Load(object sender, System.EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Персонал".
            // При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);

        }
    }
}