namespace kassa
{
    partial class Кассовые_чеки_из
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
            job = new TextBox();
            knopka = new Button();
            label2 = new Label();
            label1 = new Label();
            name = new TextBox();
            SuspendLayout();
            // 
            // job
            // 
            job.BackColor = SystemColors.Control;
            job.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            job.Location = new Point(109, 194);
            job.Margin = new Padding(3, 4, 3, 4);
            job.Name = "job";
            job.Size = new Size(187, 32);
            job.TabIndex = 24;
            job.TextChanged += job_TextChanged;
            // 
            // knopka
            // 
            knopka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            knopka.Location = new Point(135, 258);
            knopka.Margin = new Padding(3, 4, 3, 4);
            knopka.Name = "knopka";
            knopka.Size = new Size(135, 45);
            knopka.TabIndex = 23;
            knopka.Text = "Изменить";
            knopka.UseVisualStyleBackColor = true;
            knopka.Click += knopka_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 161);
            label2.Name = "label2";
            label2.Size = new Size(143, 29);
            label2.TabIndex = 22;
            label2.Text = "Должность";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 65);
            label1.Name = "label1";
            label1.Size = new Size(170, 29);
            label1.TabIndex = 21;
            label1.Text = "ФИО кассира";
            label1.Click += label1_Click;
            // 
            // name
            // 
            name.BackColor = SystemColors.Control;
            name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(109, 102);
            name.Name = "name";
            name.Size = new Size(187, 32);
            name.TabIndex = 20;
            name.TextChanged += name_TextChanged;
            // 
            // Кассовые_чеки_из
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(406, 355);
            Controls.Add(job);
            Controls.Add(knopka);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name);
            ForeColor = SystemColors.ControlText;
            MaximumSize = new Size(424, 402);
            MinimumSize = new Size(424, 402);
            Name = "Кассовые_чеки_из";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кассовые чеки";
            Load += Кассовые_чеки_из_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox job;
        private Button knopka;
        private Label label2;
        private Label label1;
        private TextBox name;
    }
}