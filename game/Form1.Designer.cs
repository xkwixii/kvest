
namespace game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Label();
            this.rule = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(373, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(373, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("LT Wave UI Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(156, 59);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(773, 58);
            this.menu.TabIndex = 2;
            this.menu.Text = "Ошибка 404: Потерянный код";
            // 
            // rule
            // 
            this.rule.AutoSize = true;
            this.rule.Font = new System.Drawing.Font("Merriweather", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rule.Location = new System.Drawing.Point(266, 511);
            this.rule.Name = "rule";
            this.rule.Size = new System.Drawing.Size(495, 20);
            this.rule.TabIndex = 3;
            this.rule.Text = "ПОМНИТЕ, что от Вашего выбора зависит исход событий :)";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.Location = new System.Drawing.Point(818, 602);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(223, 16);
            this.fio.TabIndex = 4;
            this.fio.Text = "Автор: Петрова Мария Олеговна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1053, 627);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.rule);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "kvestgame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label rule;
        private System.Windows.Forms.Label fio;
    }
}

