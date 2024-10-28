namespace kassa
{
    partial class Товары
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
            name = new TextBox();
            quantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            knopka = new Button();
            price = new TextBox();
            SuspendLayout();
            // 
            // name
            // 
            name.BackColor = SystemColors.Control;
            name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(125, 95);
            name.Name = "name";
            name.Size = new Size(187, 32);
            name.TabIndex = 0;
            // 
            // quantity
            // 
            quantity.BackColor = SystemColors.Control;
            quantity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            quantity.Location = new Point(125, 279);
            quantity.Name = "quantity";
            quantity.Size = new Size(187, 32);
            quantity.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 53);
            label1.Name = "label1";
            label1.Size = new Size(122, 29);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 144);
            label2.Name = "label2";
            label2.Size = new Size(71, 29);
            label2.TabIndex = 5;
            label2.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(118, 241);
            label4.Name = "label4";
            label4.Size = new Size(207, 29);
            label4.TabIndex = 7;
            label4.Text = "Кол-во на складе";
            // 
            // knopka
            // 
            knopka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            knopka.Location = new Point(147, 351);
            knopka.Margin = new Padding(3, 4, 3, 4);
            knopka.Name = "knopka";
            knopka.Size = new Size(135, 45);
            knopka.TabIndex = 11;
            knopka.Text = "Добавить";
            knopka.UseVisualStyleBackColor = true;
            knopka.Click += knopka_Click;
            // 
            // price
            // 
            price.BackColor = SystemColors.Control;
            price.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(125, 187);
            price.Margin = new Padding(3, 4, 3, 4);
            price.Name = "price";
            price.Size = new Size(187, 32);
            price.TabIndex = 12;
            // 
            // Товары
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
            MaximumSize = new Size(455, 510);
            MinimumSize = new Size(455, 510);
            Name = "Товары";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox quantity;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button knopka;
        private TextBox price;
    }
}