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

namespace kassa
{
    public partial class my_view : Form
    {
        private string cn;
        private DataGridView DataGridView_fk;
        public my_view(string con, DataGridView DataGridView1)
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
                string sql = $"CALL Insert_my_view('{name.Text}', '{job.Text}'); SELECT * FROM my_view;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                con.Close();
                DataGridView_fk.DataSource = dt;
                DataGridView_fk.Columns["id"].Visible = false;
                DataGridView_fk.Columns["kas_id"].Visible = false;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Кассира не существует");
            }
        }
    }
}
