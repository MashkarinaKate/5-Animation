namespace Практика_5
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Стереть = new System.Windows.Forms.Button();
            this.Нарисовать = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Стереть
            // 
            this.Стереть.Location = new System.Drawing.Point(315, 0);
            this.Стереть.Name = "Стереть";
            this.Стереть.Size = new System.Drawing.Size(88, 35);
            this.Стереть.TabIndex = 1;
            this.Стереть.Text = "Стереть";
            this.Стереть.UseVisualStyleBackColor = true;
            this.Стереть.Click += new System.EventHandler(this.Стереть_Click);
            // 
            // Нарисовать
            // 
            this.Нарисовать.Location = new System.Drawing.Point(218, 0);
            this.Нарисовать.Name = "Нарисовать";
            this.Нарисовать.Size = new System.Drawing.Size(103, 35);
            this.Нарисовать.TabIndex = 0;
            this.Нарисовать.Text = "Нарисовать";
            this.Нарисовать.UseVisualStyleBackColor = true;
            this.Нарисовать.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Оживить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Стереть);
            this.Controls.Add(this.Нарисовать);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Стереть;
        private System.Windows.Forms.Button Нарисовать;
        private System.Windows.Forms.Button button3;
    }
}

