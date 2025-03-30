using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Demo1
{
    public partial class MainForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=12345;Database=postgres";

        public MainForm()
        {
            InitializeComponent();
            LoadPartners();
        }

       

        private void LoadPartners()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT master_floor.partner.company_name, master_floor.partner.company_address, master_floor.partner.director_name, master_floor.partner.phone_number, master_floor.partner.email FROM master_floor.partner", connection);
                var adapter = new NpgsqlDataAdapter(command);
                DataTable partnersTable = new DataTable();
                adapter.Fill(partnersTable);
                // Здесь вы должны установить DataSource для вашего DataGridView
                partnersGridView.DataSource = partnersTable; // Не забудьте сохранить ссылку на DataGridView
            }
        }

        private void AddPartnerButton_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления партнера
            PartnerForm partnerForm = new PartnerForm();
            partnerForm.ShowDialog();
            LoadPartners(); // Обновление списка после добавления
        }

        private void ViewHistoryButton_Click(object sender, EventArgs e)
        {
            // Открытие формы для просмотра истории
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //int selectedPartnerId = GetSelectedPartnerId(); // Получите ID выбранного партнера
            EditPartnerForm editForm = new EditPartnerForm(); //EditPartnerForm editForm = new EditPartnerForm(selectedPartnerId);
            editForm.ShowDialog();
        }
    }
}