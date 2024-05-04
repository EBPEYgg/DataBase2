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
    }
}