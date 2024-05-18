using System.Drawing;
using System.Windows.Forms;
using System;

namespace DataBase2.View
{
    public partial class RoomsListForm : Form
    {
        /// <summary>
        /// Экземпляр формы <see cref="RoomsListForm"/>.
        /// </summary>
        private static RoomsListForm form;

        /// <summary>
        /// Имя изображения комнаты.
        /// </summary>
        private string fileImage = "";

        /// <summary>
        /// Возвращает экземпляр формы <see cref="RoomsListForm"/>, 
        /// если она уже существует, иначе создает новую форму.
        /// </summary>
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

        /// <summary>
        /// Конструктор класса <see cref="RoomsListForm"/>.
        /// </summary>
        public RoomsListForm()
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

        private void RoomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.RoomsBindingSource.EndEdit();
            this.RoomsTableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void RoomsListForm_Load(object sender, EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Комната".
            // При необходимости она может быть перемещена или удалена.
            this.RoomsTableAdapter.Fill(this.hotelDataSet.Комната);

        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            PhotoOpenFileDialog.Title = "Укажите файл для фото";
            if (PhotoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileImage = PhotoOpenFileDialog.FileName;
                try
                {
                    PhotoPictureBox.Image = new Bitmap(PhotoOpenFileDialog.FileName);
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