namespace kassa
{
    partial class Кассиры
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
            age = new TextBox();
            knopka = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            job = new TextBox();
            name = new TextBox();
            SuspendLayout();
            // 
            // age
            // 
            age.BackColor = SystemColors.Control;
            age.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            age.Location = new Point(125, 198);
            age.Margin = new Padding(3, 4, 3, 4);
            age.Name = "age";
            age.Size = new Size(187, 32);
            age.TabIndex = 20;
            // 
            // knopka
            // 
            knopka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            knopka.Location = new Point(147, 362);
            knopka.Margin = new Padding(3, 4, 3, 4);
            knopka.Name = "knopka";
            knopka.Size = new Size(135, 45);
            knopka.TabIndex = 19;
            knopka.Text = "Добавить";
            knopka.UseVisualStyleBackColor = true;
            knopka.Click += knopka_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 51);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(147, 253);
            label4.Name = "label4";
            label4.Size = new Size(143, 29);
            label4.TabIndex = 17;
            label4.Text = "Должность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(165, 160);
            label2.Name = "label2";
            label2.Size = new Size(106, 29);
            label2.TabIndex = 16;
            label2.Text = "Возраст";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(133, 66);
            label1.Name = "label1";
            label1.Size = new Size(170, 29);
            label1.TabIndex = 15;
            label1.Text = "ФИО кассира";
            // 
            // job
            // 
            job.BackColor = SystemColors.Control;
            job.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            job.Location = new Point(125, 290);
            job.Name = "job";
            job.Size = new Size(187, 32);
            job.TabIndex = 14;
            // 
            // name
            // 
            name.BackColor = SystemColors.Control;
            name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(125, 106);
            name.Name = "name";
            name.Size = new Size(187, 32);
            name.TabIndex = 13;
            // 
            // Кассиры
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 463);
            Controls.Add(age);
            Controls.Add(knopka);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(job);
            Controls.Add(name);
            MaximumSize = new Size(455, 510);
            MinimumSize = new Size(455, 510);
            Name = "Кассиры";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кассиры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox age;
        private Button knopka;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox job;
        private TextBox name;
    }
}