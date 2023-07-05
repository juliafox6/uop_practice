namespace UOP_Task1
{
    partial class Task1_Intro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nextForm = new System.Windows.Forms.Button();
            this.nextForm2 = new System.Windows.Forms.Button();
            this.nextForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("PT Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(341, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "МТУСИ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(270, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Практические задания №1, №2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(347, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "ВАРИАНТ 22";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(80, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 74);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выполнила: студентка\r\nгруппы БЭИ2201\r\nЛюбиева Ю.Д.";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(80, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 74);
            this.label5.TabIndex = 4;
            this.label5.Text = "Проверил: доцент\r\nкаф. \"Информатика\"\r\nГуриков С.Р.";
            // 
            // nextForm
            // 
            this.nextForm.Location = new System.Drawing.Point(80, 375);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(150, 50);
            this.nextForm.TabIndex = 5;
            this.nextForm.Text = "Задание №1";
            this.nextForm.UseVisualStyleBackColor = true;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // nextForm2
            // 
            this.nextForm2.Location = new System.Drawing.Point(325, 375);
            this.nextForm2.Name = "nextForm2";
            this.nextForm2.Size = new System.Drawing.Size(150, 50);
            this.nextForm2.TabIndex = 6;
            this.nextForm2.Text = "Задание №2";
            this.nextForm2.UseVisualStyleBackColor = true;
            this.nextForm2.Click += new System.EventHandler(this.nextForm2_Click);
            // 
            // nextForm3
            // 
            this.nextForm3.Location = new System.Drawing.Point(570, 375);
            this.nextForm3.Name = "nextForm3";
            this.nextForm3.Size = new System.Drawing.Size(150, 50);
            this.nextForm3.TabIndex = 7;
            this.nextForm3.Text = "Задание №3";
            this.nextForm3.UseVisualStyleBackColor = true;
            this.nextForm3.Click += new System.EventHandler(this.nextForm3_Click);
            // 
            // Task1_Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::UOP_Task1.Properties.Resources.котикучится21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.nextForm3);
            this.Controls.Add(this.nextForm2);
            this.Controls.Add(this.nextForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Task1_Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практические задания №1, №2 | УОП - БЭИ2201 - Любиева";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nextForm;
        private System.Windows.Forms.Button nextForm2;
        private System.Windows.Forms.Button nextForm3;
    }
}

