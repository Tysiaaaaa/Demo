using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Demo1
{
    public partial class PartnerForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=12345;Database=postgres";

        public PartnerForm()
        {
            InitializeComponent();
            this.Text = "Добавить Партнера";
            LoadPartnerTypes();
        }
        private void LoadPartnerTypes()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT master_floor.partner_type.partner_type FROM master_floor.partner_type", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        List<string> partnerTypes = new List<string>();

                        while (reader.Read())
                        {
                            partnerTypes.Add(reader.GetString(0)); 
                        }

                       
                        partnerNameComboBox.DataSource = partnerTypes;
                    }
                }
            }
        }
        private int GetPartnerTypeId(string partnerType)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT partner_type_id FROM master_floor.partner_type WHERE partner_type = @partner_type", connection);
                command.Parameters.AddWithValue("partner_type", partnerType);

                var result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            string partnerType = partnerNameComboBox.SelectedItem.ToString(); 
            int partnerTypeId = GetPartnerTypeId(partnerType); 

            if (partnerTypeId == -1)
            {
                MessageBox.Show("Выбранный тип партнера не найден.");
                return; 
            }

            string companyName = companyNameTextBox.Text;
            string companyAddress = companyAddressTextBox.Text;
            string companyINN = companyINNTextBox.Text;
            string directorName = directorNameTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string companyEmail = companyEmailTextBox.Text;
            string companyRatingText = companyRatingTextBox.Text;
            string companyLogo = companyINNTextBox.Text; 
            
            int companyRating;
                if (!int.TryParse(companyRatingText, out companyRating))
                {
                MessageBox.Show("Рейтинг компании должен быть целым числом.");
                return; 
                }


            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("INSERT INTO master_floor.partner (partner_type, company_name, company_address, \"company_INN\", director_name, phone_number, email, company_rating) VALUES (@partner_type, @company_name, @company_address, @company_INN, @director_name, @phone_number, @company_email, @company_rating)", connection);

                command.Parameters.AddWithValue("partner_type", partnerTypeId);
                command.Parameters.AddWithValue("company_name", companyName);
                command.Parameters.AddWithValue("company_address", companyAddress);
                command.Parameters.AddWithValue("company_INN", companyINN); 
                command.Parameters.AddWithValue("director_name", directorName);
                command.Parameters.AddWithValue("phone_number", phoneNumber);
                command.Parameters.AddWithValue("company_email", companyEmail);
                command.Parameters.AddWithValue("company_rating", companyRating);

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Партнер успешно добавлен.");
            this.Close();
        }
    }
}
