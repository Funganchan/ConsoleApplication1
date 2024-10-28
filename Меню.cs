using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace kassa
{
    public partial class Меню : Form
    {
        private string con;
        public string test;
        public string user1;
        public Меню(string auto, string user)
        {
            con = auto;
            user1 = user;
            InitializeComponent();

        }

        private void kassiri_Click_1(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT * FROM kassiri ORDER BY fio_kassira;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
            test = "Кассиры";
            p = 0;
        }

        private void cheki_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT ch.id, ch.number_chek, k.fio_kassira, k.job, ch.date_create FROM cheki ch JOIN kassiri k ON ch.kas_id = k.id ORDER BY ch.number_chek;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
            test = "Чеки";
            p = 0;
        }

        private void kuplen_prod_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT k.id, ch.number_chek, p.nazvanie, k.quantity, k.price_products FROM kuplen_products k JOIN cheki ch ON k.check_id = ch.id JOIN products p ON k.product_id = p.id ORDER BY ch.number_chek;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
            test = "Купленные товары";
            p = 0;
        }

        private void products_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT id, nazvanie, price, quantity_stock FROM products ORDER BY nazvanie;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
            test = "Товары";
            p = 0;
        }

        string[] izmen = new string[5];
        string id_udalen = "";

        public void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            switch (p)
            {
                case 0:
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        id_udalen = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            izmen[i] = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                        }
                        MessageBox.Show("Строка выбрана");
                    }
                    break;
                case 1:
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        id_udalen = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        for (int i = 0; i < dataGridView1.ColumnCount - 2; i++)
                        {
                            izmen[i] = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                        }
                        MessageBox.Show("Строка выбрана");
                    }
                    break;
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            switch (test)
            {
                case "Товары":
                    Товары f = new Товары(con, dataGridView1);
                    f.ShowDialog();
                    break;
                case "Кассиры":
                    Кассиры m = new Кассиры(con, dataGridView1);
                    m.ShowDialog();
                    break;
                case "Чеки":
                    Кассовые_чеки w = new Кассовые_чеки(con, dataGridView1);
                    w.ShowDialog();
                    break;
                case "Купленные товары":
                    Купленные_товары h = new Купленные_товары(con, dataGridView1);
                    h.ShowDialog();
                    break;
                case "view":
                    my_view o = new my_view(con, dataGridView1);
                    o.ShowDialog();
                    break;
            }
        }
        public int p = 0;
        private void delete_Click(object sender, EventArgs e)
        {
            switch (test)
            {
                case "Товары":
                    if (id_udalen != "")
                    {
                        NpgsqlConnection cn = new NpgsqlConnection(con);
                        cn.Open();
                        string sql = $"CALL Delete_products({id_udalen}); SELECT id, nazvanie, price, quantity_stock FROM products ORDER BY nazvanie;";
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                        NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        cn.Close();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["id"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
                case "Кассиры":
                    if (id_udalen != "")
                    {
                        NpgsqlConnection cn = new NpgsqlConnection(con);
                        cn.Open();
                        string sql = $"CALL Delete_kassiri({int.Parse(id_udalen)}); SELECT * FROM kassiri ORDER BY fio_kassira;";
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                        NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        cn.Close();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["id"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
                case "Чеки":
                    if (id_udalen != "")
                    {
                        NpgsqlConnection cn = new NpgsqlConnection(con);
                        cn.Open();
                        string sql = $"CALL Delete_cheki({id_udalen}); SELECT ch.id, ch.number_chek, k.fio_kassira, k.job, ch.date_create FROM cheki ch JOIN kassiri k ON ch.kas_id = k.id ORDER BY ch.number_chek;";
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                        NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        cn.Close();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["id"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
                case "Купленные товары":
                    if (id_udalen != "")
                    {
                        NpgsqlConnection cn = new NpgsqlConnection(con);
                        cn.Open();
                        string sql = $"CALL Delete_kuplen_products({id_udalen}); SELECT k.id, ch.number_chek, p.nazvanie, k.quantity, k.price_products FROM kuplen_products k JOIN cheki ch ON k.check_id = ch.id JOIN products p ON k.product_id = p.id ORDER BY ch.number_chek;";
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                        NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        cn.Close();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["id"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
                case "view":
                    if (id_udalen != "")
                    {
                        NpgsqlConnection cn = new NpgsqlConnection(con);
                        cn.Open();
                        string sql = $"CALL Delete_my_view({id_udalen}); SELECT * FROM my_view;";
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                        NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        cn.Close();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["id"].Visible = false;
                        dataGridView1.Columns["kas_id"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
            }

        }



        private void change_Click(object sender, EventArgs e)
        {
            switch (test)
            {
                case "Товары":
                    if (id_udalen != "")
                    {
                        Товары_из f = new Товары_из(con, dataGridView1, izmen, id_udalen);
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
                case "Кассиры":
                    if (id_udalen != "")
                    {
                        Кассиры_из m = new Кассиры_из(con, dataGridView1, izmen, id_udalen);
                        m.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
                case "Чеки":
                    if (id_udalen != "")
                    {
                        Кассовые_чеки_из w = new Кассовые_чеки_из(con, dataGridView1, izmen, id_udalen);
                        w.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
                case "Купленные товары":
                    if (id_udalen != "")
                    {
                        Купленные_товары_из h = new Купленные_товары_из(con, dataGridView1, izmen, id_udalen);
                        h.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
                case "view":
                    if (id_udalen != "")
                    {
                        my_view_из o = new my_view_из(con, dataGridView1, izmen, id_udalen);
                        o.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Поле не выделено");
                    }
                    id_udalen = "";
                    break;
            }
        }

        private void any_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT number_chek, SUM(kuplen_products.price_products) AS Сумма FROM cheki JOIN kuplen_products ON cheki.id = kuplen_products.check_id WHERE cheki.id = ANY (SELECT id FROM cheki) GROUP BY cheki.id;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
        }

        private void group_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT k.id, k.fio_kassira, COUNT(cheki.id) AS quantity_check FROM kassiri k JOIN cheki ON k.id = cheki.kas_id GROUP BY k.id, k.fio_kassira HAVING COUNT(cheki.id) > 0;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT * FROM my_view;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["kas_id"].Visible = false;
            test = "view";
            p = 1;
        }

        private void case1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT CASE WHEN total_cost >= 0 AND total_cost <= 500 THEN 'От 0 до 500 рублей' WHEN total_cost >= 501 AND total_cost <= 1500 THEN 'От 501 до 1500 рублей' WHEN total_cost >= 1501 AND total_cost <= 3000 THEN 'От 1501 до 3000 рублей' WHEN total_cost >= 3001 THEN 'От 3001 рубля' END AS category, COUNT(*) AS quantity_chek FROM ( SELECT ch.id, SUM(kp.price_products) AS total_cost FROM cheki ch JOIN kuplen_products kp ON ch.id = kp.check_id GROUP BY ch.id ) AS subquery GROUP BY category;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
        }

        private void select_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT ch.id, ch.number_chek, (SELECT SUM(kuplen_products.quantity) FROM kuplen_products WHERE kuplen_products.check_id = ch.id) AS number_positions FROM cheki ch;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void kor_1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT * FROM kassiri k WHERE EXISTS ( SELECT 1 FROM cheki ch JOIN kuplen_products ON ch.id = kuplen_products.check_id WHERE k.id = ch.kas_id GROUP BY ch.kas_id HAVING SUM(kuplen_products.price_products) > 10000);";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;

        }

        private void kor_2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT products.nazvanie, ( SELECT COUNT(*) FROM kuplen_products kp WHERE kp.product_id = products.id) AS number_pokupok FROM products;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
        }

        private void kor_3_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT * FROM kassiri k WHERE NOT EXISTS ( SELECT ch.id FROM cheki ch WHERE ch.kas_id = k.id AND NOT EXISTS (SELECT 1 FROM kuplen_products kp WHERE kp.check_id = ch.id));";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void kursor_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT * FROM price_inc();";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
            MessageBox.Show("Стоимость товаров повышена на 10%");
        }

        private void scal_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT count_chek();";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
        }

        public void Меню_Load(object sender, EventArgs e)
        {
            if (user1 == "1")
            {

                add.Visible = false;
                delete.Visible = false;
                change.Visible = false;
                kursor.Visible = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация sistema = new Авторизация();
            sistema.ShowDialog();
            this.Close();
        }

        private void s_from_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT p.id, p.nazvanie, sub.total_quantity FROM products p JOIN ( SELECT product_id, SUM(quantity) AS total_quantity FROM kuplen_products GROUP BY product_id ) AS sub ON p.id = sub.product_id;";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void s_where_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = new NpgsqlConnection(con);
            cn.Open();
            string sql = "SELECT k.id, k.fio_kassira FROM kassiri k WHERE k.id IN ( SELECT c.kas_id FROM cheki c JOIN kuplen_products kp ON c.id = kp.check_id JOIN products p ON p.id = kp.product_id WHERE p.nazvanie = 'Батон');";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}