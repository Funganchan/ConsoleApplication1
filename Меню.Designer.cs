namespace kassa
{
    partial class Меню
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            kassiri = new Button();
            kuplen_prod = new Button();
            cheki = new Button();
            products = new Button();
            change = new Button();
            delete = new Button();
            add = new Button();
            any = new Button();
            group = new Button();
            button1 = new Button();
            case1 = new Button();
            select = new Button();
            kor_3 = new Button();
            kor_2 = new Button();
            kor_1 = new Button();
            kursor = new Button();
            scal = new Button();
            exit = new Button();
            s_where = new Button();
            s_from = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(238, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(682, 315);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // kassiri
            // 
            kassiri.BackColor = SystemColors.Control;
            kassiri.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kassiri.Location = new Point(24, 191);
            kassiri.Name = "kassiri";
            kassiri.Size = new Size(184, 44);
            kassiri.TabIndex = 2;
            kassiri.Text = "Кассиры";
            kassiri.UseVisualStyleBackColor = false;
            kassiri.Click += kassiri_Click_1;
            // 
            // kuplen_prod
            // 
            kuplen_prod.BackColor = SystemColors.Control;
            kuplen_prod.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kuplen_prod.Location = new Point(24, 141);
            kuplen_prod.Name = "kuplen_prod";
            kuplen_prod.Size = new Size(184, 44);
            kuplen_prod.TabIndex = 3;
            kuplen_prod.Text = "Купленные товары";
            kuplen_prod.UseVisualStyleBackColor = false;
            kuplen_prod.Click += kuplen_prod_Click;
            // 
            // cheki
            // 
            cheki.BackColor = SystemColors.Control;
            cheki.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cheki.Location = new Point(24, 91);
            cheki.Name = "cheki";
            cheki.Size = new Size(184, 44);
            cheki.TabIndex = 4;
            cheki.Text = "Кассовые чеки";
            cheki.UseVisualStyleBackColor = false;
            cheki.Click += cheki_Click;
            // 
            // products
            // 
            products.BackColor = SystemColors.Control;
            products.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            products.Location = new Point(24, 41);
            products.Name = "products";
            products.Size = new Size(184, 44);
            products.TabIndex = 5;
            products.Text = "Товары";
            products.UseVisualStyleBackColor = false;
            products.Click += products_Click;
            // 
            // change
            // 
            change.BackColor = SystemColors.Control;
            change.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            change.Location = new Point(24, 387);
            change.Name = "change";
            change.Size = new Size(184, 44);
            change.TabIndex = 6;
            change.Text = "Изменить";
            change.UseVisualStyleBackColor = false;
            change.Click += change_Click;
            // 
            // delete
            // 
            delete.BackColor = SystemColors.Control;
            delete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(24, 437);
            delete.Name = "delete";
            delete.Size = new Size(184, 44);
            delete.TabIndex = 7;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.Control;
            add.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(24, 337);
            add.Name = "add";
            add.Size = new Size(184, 44);
            add.TabIndex = 8;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // any
            // 
            any.BackColor = SystemColors.Control;
            any.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            any.Location = new Point(736, 366);
            any.Name = "any";
            any.Size = new Size(184, 44);
            any.TabIndex = 9;
            any.Text = "Запрос ANY";
            any.UseVisualStyleBackColor = false;
            any.Click += any_Click;
            // 
            // group
            // 
            group.BackColor = SystemColors.Control;
            group.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            group.Location = new Point(356, 464);
            group.Name = "group";
            group.Size = new Size(184, 44);
            group.TabIndex = 10;
            group.Text = "Группировка";
            group.UseVisualStyleBackColor = false;
            group.Click += group_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(356, 366);
            button1.Name = "button1";
            button1.Size = new Size(184, 44);
            button1.TabIndex = 11;
            button1.Text = "Запрос View";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // case1
            // 
            case1.BackColor = SystemColors.Control;
            case1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            case1.Location = new Point(736, 464);
            case1.Name = "case1";
            case1.Size = new Size(184, 44);
            case1.TabIndex = 12;
            case1.Text = "Запрос CASE";
            case1.UseVisualStyleBackColor = false;
            case1.Click += case1_Click;
            // 
            // select
            // 
            select.BackColor = SystemColors.Control;
            select.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            select.Location = new Point(736, 414);
            select.Name = "select";
            select.Size = new Size(184, 44);
            select.TabIndex = 13;
            select.Text = "Подзапрос SELECT";
            select.UseVisualStyleBackColor = false;
            select.Click += select_Click;
            // 
            // kor_3
            // 
            kor_3.BackColor = SystemColors.Control;
            kor_3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kor_3.Location = new Point(546, 464);
            kor_3.Name = "kor_3";
            kor_3.Size = new Size(184, 44);
            kor_3.TabIndex = 14;
            kor_3.Text = "Кор. запрос 3";
            kor_3.UseVisualStyleBackColor = false;
            kor_3.Click += kor_3_Click;
            // 
            // kor_2
            // 
            kor_2.BackColor = SystemColors.Control;
            kor_2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kor_2.Location = new Point(546, 414);
            kor_2.Name = "kor_2";
            kor_2.Size = new Size(184, 44);
            kor_2.TabIndex = 15;
            kor_2.Text = "Кор. запрос 2";
            kor_2.UseVisualStyleBackColor = false;
            kor_2.Click += kor_2_Click;
            // 
            // kor_1
            // 
            kor_1.BackColor = SystemColors.Control;
            kor_1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kor_1.Location = new Point(546, 364);
            kor_1.Name = "kor_1";
            kor_1.Size = new Size(184, 44);
            kor_1.TabIndex = 16;
            kor_1.Text = "Кор. запрос 1";
            kor_1.UseVisualStyleBackColor = false;
            kor_1.Click += kor_1_Click;
            // 
            // kursor
            // 
            kursor.BackColor = SystemColors.Control;
            kursor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kursor.Location = new Point(736, 514);
            kursor.Name = "kursor";
            kursor.Size = new Size(184, 44);
            kursor.TabIndex = 17;
            kursor.Text = "Курсор";
            kursor.UseVisualStyleBackColor = false;
            kursor.Click += kursor_Click;
            // 
            // scal
            // 
            scal.BackColor = SystemColors.Control;
            scal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            scal.Location = new Point(356, 414);
            scal.Name = "scal";
            scal.Size = new Size(184, 44);
            scal.TabIndex = 18;
            scal.Text = "Скаляр. зарос";
            scal.UseVisualStyleBackColor = false;
            scal.Click += scal_Click;
            // 
            // exit
            // 
            exit.BackColor = SystemColors.Control;
            exit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exit.Location = new Point(24, 514);
            exit.Name = "exit";
            exit.Size = new Size(184, 44);
            exit.TabIndex = 19;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // s_where
            // 
            s_where.BackColor = SystemColors.Control;
            s_where.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            s_where.Location = new Point(356, 514);
            s_where.Name = "s_where";
            s_where.Size = new Size(184, 44);
            s_where.TabIndex = 20;
            s_where.Text = "Подзапрос WHERE";
            s_where.UseVisualStyleBackColor = false;
            s_where.Click += s_where_Click;
            // 
            // s_from
            // 
            s_from.BackColor = SystemColors.Control;
            s_from.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            s_from.Location = new Point(546, 514);
            s_from.Name = "s_from";
            s_from.Size = new Size(184, 44);
            s_from.TabIndex = 21;
            s_from.Text = "Подзапрос FROM";
            s_from.UseVisualStyleBackColor = false;
            s_from.Click += s_from_Click;
            // 
            // Меню
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 1000);
            Controls.Add(s_from);
            Controls.Add(s_where);
            Controls.Add(exit);
            Controls.Add(scal);
            Controls.Add(kursor);
            Controls.Add(kor_1);
            Controls.Add(kor_2);
            Controls.Add(kor_3);
            Controls.Add(select);
            Controls.Add(case1);
            Controls.Add(button1);
            Controls.Add(group);
            Controls.Add(any);
            Controls.Add(add);
            Controls.Add(delete);
            Controls.Add(change);
            Controls.Add(products);
            Controls.Add(cheki);
            Controls.Add(kuplen_prod);
            Controls.Add(kassiri);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(1200, 1000);
            MinimumSize = new Size(1200, 1000);
            Name = "Меню";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            Load += Меню_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            
        }

        #endregion
        private DataGridView dataGridView1;
        private Button kassiri;
        private Button kuplen_prod;
        private Button cheki;
        private Button products;
        private Button change;
        private Button delete;
        private Button add;
        private Button any;
        private Button group;
        private Button button1;
        private Button case1;
        private Button select;
        private Button kor_3;
        private Button kor_2;
        private Button kor_1;
        private Button kursor;
        private Button scal;
        private Button exit;
        private Button s_where;
        private Button s_from;
    }
}