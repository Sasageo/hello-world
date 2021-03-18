namespace Task4
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
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.saveValue = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbColors
            // 
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Items.AddRange(new object[] {
            "Черный",
            "Синий",
            "Белый",
            "Красный"});
            this.cbColors.Location = new System.Drawing.Point(12, 12);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(236, 21);
            this.cbColors.TabIndex = 0;
            this.cbColors.Text = "Выберите цвет";
            this.cbColors.SelectedIndexChanged += new System.EventHandler(this.cbColors_SelectedIndexChanged);
            // 
            // saveValue
            // 
            this.saveValue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveValue.Location = new System.Drawing.Point(534, 325);
            this.saveValue.Name = "saveValue";
            this.saveValue.Size = new System.Drawing.Size(242, 113);
            this.saveValue.TabIndex = 1;
            this.saveValue.Text = "Сохранить значения)))";
            this.saveValue.UseVisualStyleBackColor = false;
            this.saveValue.Click += new System.EventHandler(this.saveValue_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            // 
            // DeleteSave
            // 
            this.DeleteSave.BackColor = System.Drawing.Color.LightSalmon;
            this.DeleteSave.Location = new System.Drawing.Point(387, 363);
            this.DeleteSave.Name = "DeleteSave";
            this.DeleteSave.Size = new System.Drawing.Size(141, 75);
            this.DeleteSave.TabIndex = 3;
            this.DeleteSave.Text = "Очистить сохранение";
            this.DeleteSave.UseVisualStyleBackColor = false;
            this.DeleteSave.Click += new System.EventHandler(this.DeleteSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveValue);
            this.Controls.Add(this.cbColors);
            this.Name = "Form1";
            this.Text = "Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.Button saveValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteSave;
    }
}

