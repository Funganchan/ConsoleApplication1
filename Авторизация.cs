using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace kassa
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();

        }
        public string auto;
        public string user = "0";

        public void connection_Click(object sender, EventArgs e)
        {
            auto = $"Server=localhost;Port=5432;Database=kassa;User Id={login.Text};Password={password.Text};";
            try
            {
                if (login.Text == "user1")
                {
                    user = "1";
                }
                NpgsqlConnection cn = new NpgsqlConnection(auto);
                cn.Open();
                this.Close();
                Thread th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

        }

        public void open(object obj)
        {
            Application.Run(new Меню(auto, user));
        }

    }
}