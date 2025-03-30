using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Demo1
{
    public partial class HistoryForm : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=12345;Database=postgres";

        public HistoryForm()
        {
            InitializeComponent();
            this.Text = "История Реализации Продукции";
            LoadHistory();
        }

        private void LoadHistory()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT \r\n    pp.partner_products_id,\r\n    p.company_name AS partner_name,\r\n    pt.partner_type AS partner_type_name,\r\n    pr.product_name AS product_name,\r\n    pty.product_type AS product_type_name,\r\n    pp.produce_amount,\r\n    pp.employee_id,\r\n    pp.date_sold\r\nFROM \r\n    master_floor.partner_products pp\r\nJOIN \r\n    master_floor.partner p ON pp.partner_id = p.partner_id\r\nJOIN \r\n    master_floor.partner_type pt ON p.partner_type = pt.partner_type_id\r\nJOIN \r\n    master_floor.product pr ON pp.product_id = pr.product_id\r\nJOIN \r\n    master_floor.product_type pty ON pr.product_type = pty.product_type_id", connection); // Предположим, что у вас есть таблица sales_history
                var adapter = new NpgsqlDataAdapter(command);
                DataTable historyTable = new DataTable();
                adapter.Fill(historyTable);

                // Устанавливаем DataSource для вашего DataGridView
                historyGridView.DataSource = historyTable; // Не забудьте сохранить ссылку на DataGridView
            }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}