
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
            this.startgame = new System.Windows.Forms.Button();
            this.exitgame = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Label();
            this.rule = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // startgame
            // 
            this.startgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startgame.Font = new System.Drawing.Font("Marske", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startgame.ForeColor = System.Drawing.Color.OliveDrab;
            this.startgame.Location = new System.Drawing.Point(364, 292);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(283, 48);
            this.startgame.TabIndex = 0;
            this.startgame.Text = "Начать";
            this.startgame.UseVisualStyleBackColor = false;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // exitgame
            // 
            this.exitgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitgame.Font = new System.Drawing.Font("Marske", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitgame.ForeColor = System.Drawing.Color.White;
            this.exitgame.Location = new System.Drawing.Point(364, 356);
            this.exitgame.Name = "exitgame";
            this.exitgame.Size = new System.Drawing.Size(283, 48);
            this.exitgame.TabIndex = 1;
            this.exitgame.Text = "Выход";
            this.exitgame.UseVisualStyleBackColor = false;
            this.exitgame.Click += new System.EventHandler(this.exitgame_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu.Location = new System.Drawing.Point(34, 15);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(273, 59);
            this.menu.TabIndex = 2;
            this.menu.Text = "Error";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // rule
            // 
            this.rule.AutoSize = true;
            this.rule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rule.Font = new System.Drawing.Font("Arturito Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rule.ForeColor = System.Drawing.Color.White;
            this.rule.Location = new System.Drawing.Point(292, 481);
            this.rule.Name = "rule";
            this.rule.Size = new System.Drawing.Size(448, 27);
            this.rule.TabIndex = 3;
            this.rule.Text = "ПОМНИТЕ, что от Вашего выбора зависит исход событий :)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(324, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 68);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "404";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(8, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 55);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Metal Lord", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Потерянный код";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.menu);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(236, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 147);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(818, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Автор: Петрова Мария Олеговна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1053, 627);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rule);
            this.Controls.Add(this.exitgame);
            this.Controls.Add(this.startgame);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "kvestgame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startgame;
        private System.Windows.Forms.Button exitgame;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label rule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}

