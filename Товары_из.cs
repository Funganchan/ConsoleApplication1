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
using System.Xml.Linq;

namespace kassa
{
    public partial class Товары_из : Form
    {
        private string cn;
        private DataGridView DataGridView_fk;
        string[] izmen_t;
        string id_udal;
        public Товары_из(string con, DataGridView DataGridView1, string[] izmen, string id_udalen)
        {
            cn = con;
            DataGridView_fk = DataGridView1;
            izmen_t = izmen;
            id_udal = id_udalen;
            InitializeComponent();
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection(cn);
            con.Open();
            string sql = $"CALL Update_products({int.Parse(id_udal)},'{name.Text}', {float.Parse(price.Text, System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, {int.Parse(quantity.Text)}); SELECT id, nazvanie, price, quantity_stock FROM products ORDER BY nazvanie;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            con.Close();
            DataGridView_fk.DataSource = dt;
            DataGridView_fk.Columns["id"].Visible = false;
            Close();
        }

        private void Товары_из_Load(object sender, EventArgs e)
        {
            name.Text = izmen_t[1];
            price.Text = izmen_t[2];
            quantity.Text = izmen_t[3];
        }
    }
}
