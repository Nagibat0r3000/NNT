namespace _1
{
    partial class Form
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
            this.BNEW = new System.Windows.Forms.Label();
            this.BCONT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BNEW
            // 
            this.BNEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BNEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNEW.Location = new System.Drawing.Point(1250, 175);
            this.BNEW.Name = "BNEW";
            this.BNEW.Size = new System.Drawing.Size(250, 50);
            this.BNEW.TabIndex = 0;
            this.BNEW.Text = "Новая игра";
            this.BNEW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BNEW.Click += new System.EventHandler(this.NewGame);
            // 
            // BCONT
            // 
            this.BCONT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BCONT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCONT.Location = new System.Drawing.Point(1250, 230);
            this.BCONT.Name = "BCONT";
            this.BCONT.Size = new System.Drawing.Size(250, 50);
            this.BCONT.TabIndex = 1;
            this.BCONT.Text = "Продолжить игру";
            this.BCONT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BCONT.Click += new System.EventHandler(this.ContinueGame);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::_1.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.BCONT);
            this.Controls.Add(this.BNEW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BNEW;
        private System.Windows.Forms.Label BCONT;
    }
}

