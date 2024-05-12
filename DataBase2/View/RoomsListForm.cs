using System.Drawing;
using System.Windows.Forms;

namespace DataBase2.View
{
    public partial class RoomsListForm : Form
    {
        private static RoomsListForm form;

        private string fileImage = "";

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

        private void комнатаBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.комнатаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void RoomsListForm_Load(object sender, System.EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Комната".
            // При необходимости она может быть перемещена или удалена.
            this.комнатаTableAdapter.Fill(this.hotelDataSet.Комната);

        }

        private void OpenPhotoButton_Click(object sender, System.EventArgs e)
        {
            PhotoOpenFileDialog.Title = "Укажите файл для фото";
            if (PhotoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileImage = PhotoOpenFileDialog.FileName;
                try
                {
                    изображениеPictureBox.Image = new Bitmap(PhotoOpenFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }
    }
}