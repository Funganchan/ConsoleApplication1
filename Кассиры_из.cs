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
    public partial class Кассиры_из : Form
    {
        private string cn;
        private DataGridView DataGridView_fk;
        string[] izmen_t;
        string id_udal;
        public Кассиры_из(string con, DataGridView DataGridView1, string[] izmen, string id_udalen)
        {
            cn = con;
            DataGridView_fk = DataGridView1;
            izmen_t = izmen;
            id_udal = id_udalen;
            InitializeComponent();
        }

        private void Кассиры_из_Load(object sender, EventArgs e)
        {
            name.Text = izmen_t[1];
            age.Text = izmen_t[2];
            job.Text = izmen_t[3];
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection(cn);
            con.Open();
            string sql = $"CALL Update_kassiri({int.Parse(id_udal)},'{name.Text}', {int.Parse(age.Text)}, '{job.Text}'); SELECT * FROM kassiri ORDER BY fio_kassira;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            con.Close();
            DataGridView_fk.DataSource = dt;
            DataGridView_fk.Columns["id"].Visible = false;
            Close();
        }
    }
}
