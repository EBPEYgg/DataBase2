using System.Windows.Forms;

namespace DataBase2.View
{
    public partial class RoomsListForm : Form
    {
        private static RoomsListForm form;

        public static RoomsListForm roomsListForm
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new RoomsListForm();
                }
                return form;
            }
        }

        public RoomsListForm()
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