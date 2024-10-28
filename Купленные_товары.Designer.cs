namespace kassa
{
    partial class Купленные_товары
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
            knopka = new Button();
            label4 = new Label();
            label2 = new Label();
            quantity = new TextBox();
            SuspendLayout();
            // 
            // name
            // 
            name.BackColor = SystemColors.Control;
            name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(109, 100);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(187, 32);
            name.TabIndex = 28;
            // 
            // knopka
            // 
            knopka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            knopka.Location = new Point(131, 264);
            knopka.Margin = new Padding(3, 4, 3, 4);
            knopka.Name = "knopka";
            knopka.Size = new Size(135, 45);
            knopka.TabIndex = 27;
            knopka.Text = "Добавить";
            knopka.UseVisualStyleBackColor = true;
            knopka.Click += knopka_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(128, 155);
            label4.Name = "label4";
            label4.Size = new Size(148, 29);
            label4.TabIndex = 25;
            label4.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(99, 62);
            label2.Name = "label2";
            label2.Size = new Size(207, 29);
            label2.TabIndex = 24;
            label2.Text = "Название товара";
            // 
            // quantity
            // 
            quantity.BackColor = SystemColors.Control;
            quantity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            quantity.Location = new Point(109, 192);
            quantity.Name = "quantity";
            quantity.Size = new Size(187, 32);
            quantity.TabIndex = 22;
            // 
            // Купленные_товары
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(406, 355);
            Controls.Add(name);
            Controls.Add(knopka);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(quantity);
            MaximumSize = new Size(424, 402);
            MinimumSize = new Size(424, 402);
            Name = "Купленные_товары";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Купленные товары";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Button knopka;
        private Label label4;
        private Label label2;
        private TextBox quantity;
    }
}