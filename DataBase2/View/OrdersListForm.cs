using System.Windows.Forms;

namespace DataBase2.View
{
    public partial class OrdersListForm : Form
    {
        private static OrdersListForm form;

        public static OrdersListForm ordersListForm
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new OrdersListForm();
                }
                return form;
            }
        }

        public OrdersListForm()
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