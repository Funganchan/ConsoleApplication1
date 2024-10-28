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
using static System.Net.Mime.MediaTypeNames;

namespace kassa
{
    public partial class Кассиры : Form
    {
        private string cn;
        private DataGridView DataGridView_fk;
        public Кассиры(string con, DataGridView DataGridView1)
        {
            cn = con;
            DataGridView_fk = DataGridView1;
            InitializeComponent();
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection(cn);
            con.Open();
            string sql = $"CALL Insert_kassiri('{name.Text}', {int.Parse(age.Text)}, '{job.Text}'); SELECT * FROM kassiri ORDER BY fio_kassira;";
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
