using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kassa
{
    public partial class Кассовые_чеки_из : Form
    {
        private string cn;
        private DataGridView DataGridView_fk;
        string[] izmen_t;
        string id_udal;
        public Кассовые_чеки_из(string con, DataGridView DataGridView1, string[] izmen, string id_udalen)
        {
            cn = con;
            DataGridView_fk = DataGridView1;
            izmen_t = izmen;
            id_udal = id_udalen;
            InitializeComponent();
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection(cn);
                con.Open();
                string sql = $"CALL Update_cheki({int.Parse(id_udal)} ,'{name.Text}', '{job.Text}'); SELECT ch.id, ch.number_chek, k.fio_kassira, k.job, ch.date_create FROM cheki ch JOIN kassiri k ON ch.kas_id = k.id ORDER BY ch.number_chek;";
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

        private void Кассовые_чеки_из_Load(object sender, EventArgs e)
        {
            name.Text = izmen_t[2];
            job.Text = izmen_t[3];
        }

        private void job_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
