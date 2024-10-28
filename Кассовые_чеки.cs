using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kassa
{
    public partial class Кассовые_чеки : Form
    {
        private string cn;
        private DataGridView DataGridView_fk;
        public Кассовые_чеки(string con, DataGridView DataGridView1)
        {
            cn = con;
            DataGridView_fk = DataGridView1;
            InitializeComponent();
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection(cn);
                con.Open();
                string sql = $"CALL Insert_cheki('{name.Text}', '{job.Text}'); SELECT ch.id, ch.number_chek, k.fio_kassira, k.job, ch.date_create FROM cheki ch JOIN kassiri k ON ch.kas_id = k.id ORDER BY ch.number_chek;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                con.Close();
                DataGridView_fk.DataSource = dt;
                DataGridView_fk.Columns["id"].Visible = false;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Кассира не существует");
            }
        }
    }
}