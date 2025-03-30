using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Demo1
{
    public partial class EditPartnerForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=12345;Database=postgres";

        public EditPartnerForm()
        {
            InitializeComponent();
            LoadPartners();
        }

        private void LoadPartners()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT partner_id, partner_type, company_name, company_address, \"company_INN\", director_name, phone_number, email, company_rating FROM master_floor.partner", connection);
                var adapter = new NpgsqlDataAdapter(command);
                DataTable partnersTable = new DataTable();
                adapter.Fill(partnersTable);
                editpartnersDataGridView.DataSource = partnersTable;
            }
        }
        private List<(int rowIndex, int columnIndex, object newValue)> changedCells = new List<(int, int, object)>();

        private void editpartnersDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Получаем новое значение
                object newValue = editpartnersDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Добавляем в список измененных ячеек
                changedCells.Add((e.RowIndex, e.ColumnIndex, newValue));
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                foreach (var (rowIndex, columnIndex, newValue) in changedCells)
                {
                    int partnerId = Convert.ToInt32(editpartnersDataGridView.Rows[rowIndex].Cells["partner_id"].Value);
                    string columnName = editpartnersDataGridView.Columns[columnIndex].Name;

                    // Обновляем данные в базе
                    var command = new NpgsqlCommand($"UPDATE master_floor.partner SET {columnName} = @newValue WHERE partner_id = @partner_id", connection);
                    command.Parameters.AddWithValue("newValue", newValue);
                    command.Parameters.AddWithValue("partner_id", partnerId);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Все изменения успешно сохранены.");
            changedCells.Clear(); // Очищаем список после сохранения
        }



    }
}