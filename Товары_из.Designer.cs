namespace kassa
{
    partial class Товары_из
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
            price = new TextBox();
            knopka = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            quantity = new TextBox();
            name = new TextBox();
            SuspendLayout();
            // 
            // price
            // 
            price.BackColor = SystemColors.Control;
            price.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            price.ForeColor = SystemColors.ControlText;
            price.Location = new Point(126, 186);
            price.Margin = new Padding(3, 4, 3, 4);
            price.Name = "price";
            price.Size = new Size(187, 32);
            price.TabIndex = 19;
            // 
            // knopka
            // 
            knopka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            knopka.ForeColor = SystemColors.ControlText;
            knopka.Location = new Point(148, 350);
            knopka.Margin = new Padding(3, 4, 3, 4);
            knopka.Name = "knopka";
            knopka.Size = new Size(135, 45);
            knopka.TabIndex = 18;
            knopka.Text = "Изменить";
            knopka.UseVisualStyleBackColor = true;
            knopka.Click += knopka_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(119, 240);
            label4.Name = "label4";
            label4.Size = new Size(207, 29);
            label4.TabIndex = 17;
            label4.Text = "Кол-во на складе";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(188, 143);
            label2.Name = "label2";
            label2.Size = new Size(71, 29);
            label2.TabIndex = 16;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(161, 52);
            label1.Name = "label1";
            label1.Size = new Size(122, 29);
            label1.TabIndex = 15;
            label1.Text = "Название";
            // 
            // quantity
            // 
            quantity.BackColor = SystemColors.Control;
            quantity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            quantity.ForeColor = SystemColors.ControlText;
            quantity.Location = new Point(126, 278);
            quantity.Name = "quantity";
            quantity.Size = new Size(187, 32);
            quantity.TabIndex = 14;
            // 
            // name
            // 
            name.BackColor = SystemColors.Control;
            name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = SystemColors.ControlText;
            name.Location = new Point(126, 94);
            name.Name = "name";
            name.Size = new Size(187, 32);
            name.TabIndex = 13;
            // 
            // Товары_из
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 463);
            Controls.Add(price);
            Controls.Add(knopka);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quantity);
            Controls.Add(name);
            ForeColor = SystemColors.ControlLightLight;
            MaximumSize = new Size(455, 510);
            MinimumSize = new Size(455, 510);
            Name = "Товары_из";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товары_из";
            Load += Товары_из_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox price;
        private Button knopka;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox quantity;
        private TextBox name;
    }
}