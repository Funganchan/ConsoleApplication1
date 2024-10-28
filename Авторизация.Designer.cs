namespace kassa
{
    partial class Авторизация
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            connection = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            login = new TextBox();
            password = new TextBox();
            SuspendLayout();
            // 
            // connection
            // 
            connection.BackColor = SystemColors.Control;
            connection.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            connection.Location = new Point(135, 350);
            connection.Name = "connection";
            connection.Size = new Size(205, 54);
            connection.TabIndex = 0;
            connection.Text = "Соединиться";
            connection.UseVisualStyleBackColor = false;
            connection.Click += connection_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(187, 105);
            label3.Name = "label3";
            label3.Size = new Size(101, 41);
            label3.TabIndex = 2;
            label3.Text = "Логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(177, 217);
            label4.Name = "label4";
            label4.Size = new Size(121, 41);
            label4.TabIndex = 3;
            label4.Text = "Пароль";
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            login.Location = new Point(143, 166);
            login.Name = "login";
            login.Size = new Size(188, 32);
            login.TabIndex = 4;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(143, 272);
            password.Name = "password";
            password.Size = new Size(188, 32);
            password.TabIndex = 5;
            // 
            // Авторизация
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 503);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(connection);
            MaximumSize = new Size(500, 550);
            MinimumSize = new Size(500, 550);
            Name = "Авторизация";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox login;
        private TextBox password;
    }
}