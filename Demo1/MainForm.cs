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
            
                partnersGridView.DataSource = partnersTable; 
            }
        }

        private void AddPartnerButton_Click(object sender, EventArgs e)
        {
            
            PartnerForm partnerForm = new PartnerForm();
            partnerForm.ShowDialog();
            LoadPartners(); 
        }

        private void ViewHistoryButton_Click(object sender, EventArgs e)
        {
           
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
            EditPartnerForm editForm = new EditPartnerForm(); 
            editForm.ShowDialog();
        }
    }
}
