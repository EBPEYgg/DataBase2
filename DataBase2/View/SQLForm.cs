using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using DataBase2.Properties;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace DataBase2
{
    public partial class SQLForm : Form
    {
        public SQLForm()
        {
            InitializeComponent();
            SQLDataGridView.AllowUserToResizeColumns = false;
            SQLDataGridView.AllowUserToResizeRows = false;
            MonthComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Метод, который заполняет <see cref="RoomDataGridView"/> с помощью SQL запроса
        /// и данными из базы данных Hotel.
        /// </summary>
        /// <param name="sqlSelect">SQL запрос.</param>
        /// <returns>Заполненная таблица <see cref="RoomDataGridView"/>.</returns>
        public DataTable FillDataGridView(string sqlSelect)
        {
            // Создаем объект connection класса SqlConnection для соединения с БД
            // HotelConnectionString – строка описания соединения с источником данных
            SqlConnection connection = new SqlConnection(Settings.Default.HotelConnectionString);
            // Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            // Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            // Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            // заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        // 1 вкладка
        private void StaffRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SQLDataGridView.DataSource = FillDataGridView(@"SELECT id, ФИО+' - '+Должность AS Сотрудник, 
                    CAST(Зарплата AS decimal(9,0)) AS [Зарплата до индексации], 
                    CAST(Зарплата*1.1 AS decimal(9,0)) AS [Зарплата после индексации] FROM Персонал");
            SQLDataGridView.Columns[0].Width = 25;
            SQLDataGridView.Columns[1].Width = 300;
        }

        private void OrdersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SQLDataGridView.DataSource = FillDataGridView(@"SELECT 
                    Заказ.id,
                    Заказ.id_гостя,
                    (SELECT Гость.ФИО FROM Гость WHERE Гость.id = Заказ.id_гостя) AS ""ФИО гостя"",
                    Заказ.Номер_комнаты,
                    Заказ.id_персонала,
                    (SELECT Персонал.ФИО FROM Персонал WHERE Персонал.id = Заказ.id_персонала) AS ""ФИО сотрудника"",
                    Заказ.Статус_заказа 
                    FROM Заказ;");
            SQLDataGridView.Columns[0].Width = 25;
            SQLDataGridView.Columns[1].Width = 75;
            SQLDataGridView.Columns[2].Width = 170;
            SQLDataGridView.Columns[5].Width = 170;
        }

        private void RoomsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SQLDataGridView.DataSource = FillDataGridView(@"SELECT * FROM Комната");
            SQLDataGridView.Columns[1].Width = 60;
            SQLDataGridView.Columns[2].Width = 170;
        }

        private void GuestsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SQLDataGridView.DataSource = FillDataGridView(@"SELECT
                    id, 
                    PARSENAME(REPLACE(ФИО, ' ', '.'), 3) AS Фамилия,
                    PARSENAME(REPLACE(ФИО, ' ', '.'), 2) AS Имя,
                    PARSENAME(REPLACE(ФИО, ' ', '.'), 1) AS Отчество,
                    Дата_заезда,
                    Дата_выезда,
                    Номер_телефона 
                    FROM Гость");
            SQLDataGridView.Columns[0].Width = 25;
        }

        // 2 вкладка
        private void ShowResultButton_Click(object sender, EventArgs e)
        {
            int orderCount;

            if (!int.TryParse(CountTextBox.Text, out orderCount))
            {
                MessageBox.Show("В поле количество заказов должно быть число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(CountTextBox.Text) || int.Parse(CountTextBox.Text) <= 0)
            {
                MessageBox.Show("Укажите количество оформленных заказов больше 0",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (int.TryParse(CountTextBox.Text, out orderCount) 
                && (MonthRadioButton.Checked || WithoutDetalizationRadioButton.Checked))
            {
                if (WithoutDetalizationRadioButton.Checked)
                {
                    MonthComboBox.SelectedIndex = -1;
                }

                int selectedMonth = MonthComboBox.SelectedIndex + 1;
                string query = "";

                if (MonthRadioButton.Checked)
                {
                    if (MonthComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Выберите месяц из выпадающего списка", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    query = @"SELECT 
                            Персонал.id,
                            Персонал.ФИО,
                            COUNT(Заказ.id) AS Количество_заказов
                            FROM Персонал
                            JOIN Заказ ON Персонал.id = Заказ.id_персонала
                            JOIN Гость ON Заказ.id_гостя = Гость.id
                            WHERE 
                                (Заказ.Статус_заказа = 'завершен' OR Заказ.Статус_заказа = 'подтвержден')
                                AND MONTH(Гость.Дата_заезда) = @SelectedMonth
                                AND YEAR(Гость.Дата_заезда) = YEAR(GETDATE())
                            GROUP BY Персонал.id, Персонал.ФИО
                            HAVING COUNT(Заказ.id) >= @КоличествоЗаказов;";
                }
                else if (WithoutDetalizationRadioButton.Checked)
                {
                    query = @"SELECT Персонал.id, Персонал.ФИО,
                            COUNT(Заказ.id) AS [Количество оформленных заказов]
                            FROM Персонал
                            JOIN Заказ
                            ON Персонал.id = Заказ.id_персонала
                            GROUP BY Персонал.id, Персонал.ФИО
                            HAVING COUNT(Заказ.id) >= @КоличествоЗаказов;";
                }

                SqlConnection connection = new SqlConnection(Settings.Default.HotelConnectionString);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@КоличествоЗаказов", orderCount);
                command.Parameters.AddWithValue("@SelectedMonth", selectedMonth);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                SelectDataGridView.DataSource = table;
            }

            else
            {
                MessageBox.Show("Выберите тип детализации", "Тип детализации", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectDataGridView.DataSource = null;
        }

        private void WithoutDetalizationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MonthComboBox.SelectedIndex = -1;
        }

        // 3 вкладка с подзапросами
        private void SubqueryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NumberTextBox.Text))
            {
                MessageBox.Show("Укажите номер необходимой продажи", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId;

            if (!int.TryParse(NumberTextBox.Text, out orderId))
            {
                MessageBox.Show("Номер заказа должен быть числом", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "";

            if (CorrelatedRadioButton.Checked)
            {
                query = @"SELECT Персонал.ФИО,
                        (SELECT COUNT(*) FROM Заказ WHERE Заказ.id_персонала = Персонал.id) AS Количество_заказов
                        FROM Персонал
                        WHERE Персонал.id = (SELECT id_персонала FROM Заказ WHERE id = @OrderId);";
            }
            else if (NoCorrelatedRadioButton.Checked)
            {
                query = @"SELECT 
                Персонал.ФИО,
                Количество_заказов.Количество_заказов
                FROM Персонал
                JOIN 
                    (SELECT id_персонала, COUNT(*) AS Количество_заказов FROM Заказ GROUP BY id_персонала) AS Количество_заказов
                    ON Персонал.id = Количество_заказов.id_персонала
                WHERE Персонал.id = (SELECT id_персонала FROM Заказ WHERE id = @OrderId);";
            }
            else
            {
                MessageBox.Show("Вы не выбрали вид подзапроса", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = new SqlConnection(Settings.Default.HotelConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            try
            {
                command.Parameters.Add("@orderId", SqlDbType.Int).Value = int.Parse(NumberTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            SubQueryDataGridView.DataSource = table;

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubQueryDataGridView.DataSource = null;
            }
        }

        // 4 вкладка с INSERT, UPDATE, REMOVE
        private void DMLExecuteButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(TypeRoomTextBox.Text) 
                || string.IsNullOrEmpty(StatusRoomTextBox.Text) 
                || string.IsNullOrEmpty(ServiceNameTextBox.Text) 
                || string.IsNullOrEmpty(CleaningFrequencyTextBox.Text))
                && (InsertRadioButton.Checked || UpdateRadioButton.Checked))
            {
                MessageBox.Show("Обязательно введите номер комнаты, тип комнаты, " +
                    "статус комнаты, название обслуживающей организации, частоту уборки",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var actions = new Dictionary<RadioButton, Action>
            {
                { InsertRadioButton, InsertRoom },
                { UpdateRadioButton, UpdateRoom },
                { DeleteRadioButton, DeleteRoom }
            };

            foreach (var action in actions)
            {
                if (action.Key.Checked)
                {
                    action.Value();
                    return;
                }
            }

            MessageBox.Show("Вы не выбрали оператор", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void InsertRoom()
        {
            string query = @"INSERT INTO Комната (id_гостя, ФИО_арендатора, Изображение, 
                                                Тип_комнаты, Статус_комнаты, Название_обслуживающей_организации, 
                                                Частота_уборки, Услуга_все_включено)
                            VALUES (@id_гостя, @ФИО_арендатора, @Изображение, 
                                    @Тип_комнаты, @Статус_комнаты, @Название_обслуживающей_организации, 
                                    @Частота_уборки, @Услуга_все_включено);";
            ExecuteNonQuery(query);
        }

        private void UpdateRoom()
        {
            string query = @"UPDATE Комната
                            SET 
                            id_гостя = @id_гостя,
                            ФИО_арендатора = @ФИО_арендатора,
                            Изображение = @Изображение,
                            Тип_комнаты = @Тип_комнаты,
                            Статус_комнаты = @Статус_комнаты,
                            Название_обслуживающей_организации = @Название_обслуживающей_организации,
                            Частота_уборки = @Частота_уборки,
                            Услуга_все_включено = @Услуга_все_включено
                            WHERE Номер_комнаты = @Номер_комнаты;";
            ExecuteNonQuery(query);
        }

        private void DeleteRoom()
        {
            string query = @"DELETE FROM Комната
                            WHERE Номер_комнаты = @Номер_комнаты;";
            ExecuteNonQuery(query);
        }

        /// <summary>
        /// Метод, который выполняет SQL запрос по работе с таблицей "Комната".
        /// </summary>
        /// <param name="query">SQL запрос.</param>
        private void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.HotelConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                if (!string.IsNullOrEmpty(IdTextBox.Text))
                {
                    command.Parameters.AddWithValue("@Номер_комнаты", IdTextBox.Text);
                }

                if (string.IsNullOrEmpty(IdGuestTextBox.Text))
                {
                    command.Parameters.AddWithValue("@id_гостя", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@id_гостя", IdGuestTextBox.Text);
                }

                if (string.IsNullOrEmpty(NameRenterTextBox.Text))
                {
                    command.Parameters.AddWithValue("@ФИО_арендатора", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@ФИО_арендатора", NameRenterTextBox.Text);
                }

                if (PhotoPictureBox.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        PhotoPictureBox.Image.Save(ms, PhotoPictureBox.Image.RawFormat);
                        byte[] imageBytes = ms.ToArray();
                        command.Parameters.AddWithValue("@Изображение", imageBytes);
                    }
                }
                else
                {
                    command.Parameters.AddWithValue("@Изображение", DBNull.Value);
                }

                command.Parameters.AddWithValue("@Тип_комнаты", TypeRoomTextBox.Text);
                command.Parameters.AddWithValue("@Статус_комнаты", StatusRoomTextBox.Text);
                command.Parameters.AddWithValue("@Название_обслуживающей_организации", ServiceNameTextBox.Text);
                command.Parameters.AddWithValue("@Частота_уборки", CleaningFrequencyTextBox.Text);
                command.Parameters.AddWithValue("@Услуга_все_включено", AllInclusiveCheckBox.Checked);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    TurnOffRadioButtons();
                    MessageBox.Show("Операция выполнена", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            RoomDataGridView.DataSource = FillDataGridView(@"SELECT * FROM Комната");
            RoomDataGridView.Columns[1].Width = 60;
            RoomDataGridView.Columns[2].Width = 170;
        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            string fileImage = "";
            PhotoOpenFileDialog.Title = "Укажите файл для фото";
            if (PhotoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileImage = PhotoOpenFileDialog.FileName;
                try
                {
                    PhotoPictureBox.Load(PhotoOpenFileDialog.FileName);
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

        private void InsertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRoomInputBoxes(true);
            IdTextBox.Text = null;
            IdTextBox.ReadOnly = true;
            FindButton.Visible = false;
        }

        private void UpdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRoomInputBoxes(true);
            IdTextBox.ReadOnly = false;
            ClearInputBoxes();
            FindButton.Visible = true;
        }

        private void DeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRoomInputBoxes(false);
            IdTextBox.ReadOnly = false;
            ClearInputBoxes();
            FindButton.Visible = false;
        }

        private void ToggleRoomInputBoxes(bool value)
        {
            IdTextBox.ReadOnly = !value;
            IdGuestTextBox.ReadOnly = !value;
            NameRenterTextBox.ReadOnly = !value;
            TypeRoomTextBox.ReadOnly = !value;
            StatusRoomTextBox.ReadOnly = !value;
            ServiceNameTextBox.ReadOnly = !value;
            CleaningFrequencyTextBox.ReadOnly = !value;
            AllInclusiveCheckBox.Enabled = value;
            OpenPhotoButton.Enabled = value;
        }

        private void ClearInputBoxes()
        {
            IdGuestTextBox.Text = string.Empty;
            NameRenterTextBox.Text = string.Empty;
            TypeRoomTextBox.Text = string.Empty;
            StatusRoomTextBox.Text = string.Empty;
            ServiceNameTextBox.Text = string.Empty;
            CleaningFrequencyTextBox.Text = string.Empty;
            AllInclusiveCheckBox.Checked = false;
            PhotoPictureBox.Image = null;
        }

        private void TurnOffRadioButtons()
        {
            InsertRadioButton.Checked = false;
            UpdateRadioButton.Checked = false;
            DeleteRadioButton.Checked = false;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int roomId;

            if (!int.TryParse(IdTextBox.Text, out roomId))
            {
                MessageBox.Show("В поле Номер комнаты должно быть число", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool roomExists = CheckRoomExists(roomId);

            if (roomExists)
            {
                foreach (DataGridViewRow row in RoomDataGridView.Rows)
                {
                    if (row.Cells["Номер_комнаты"].Value != null 
                        && row.Cells["Номер_комнаты"].Value.ToString() == roomId.ToString())
                    {
                        row.Selected = true;
                        RoomDataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                        IdGuestTextBox.Text = row.Cells["id_гостя"].Value?.ToString();
                        NameRenterTextBox.Text = row.Cells["ФИО_арендатора"].Value?.ToString();
                        TypeRoomTextBox.Text = row.Cells["Тип_комнаты"].Value?.ToString();
                        StatusRoomTextBox.Text = row.Cells["Статус_комнаты"].Value?.ToString();
                        ServiceNameTextBox.Text = row.Cells["Название_обслуживающей_организации"].Value?.ToString();
                        CleaningFrequencyTextBox.Text = row.Cells["Частота_уборки"].Value?.ToString();
                        AllInclusiveCheckBox.Checked = row.Cells["Услуга_все_включено"].Value != DBNull.Value && (bool)row.Cells["Услуга_все_включено"].Value;

                        if (row.Cells["Изображение"].Value != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])row.Cells["Изображение"].Value;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                PhotoPictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            PhotoPictureBox.Image = null;
                        }

                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Комната с указанным номером не найдена", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckRoomExists(int roomId)
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.HotelConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Комната WHERE Номер_комнаты = @Номер_комнаты";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Номер_комнаты", roomId);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при проверке номера комнаты: " + ex.Message, 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}