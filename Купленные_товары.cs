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
    public partial class Купленные_товары : Form
    {
        private string cn;
        private DataGridView DataGridView_fk;
        public Купленные_товары(string con, DataGridView DataGridView1)
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
                string sql = $"CALL Insert_kuplen_products('{name.Text}', {int.Parse(quantity.Text)}); SELECT k.id, ch.number_chek, p.nazvanie, k.quantity, k.price_products FROM kuplen_products k JOIN cheki ch ON k.check_id = ch.id JOIN products p ON k.product_id = p.id ORDER BY ch.number_chek;";
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
                MessageBox.Show("Товар не существует");
            }
        }
    }
}
