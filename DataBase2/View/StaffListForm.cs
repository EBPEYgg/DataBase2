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
    }
}