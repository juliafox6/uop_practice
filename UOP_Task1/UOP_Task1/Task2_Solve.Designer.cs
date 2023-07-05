namespace UOP_Task1
{
    partial class Task2_Solve
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vvodX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vivodOut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vivodRef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outFilePath = new System.Windows.Forms.TextBox();
            this.solveThis = new System.Windows.Forms.Button();
            this.prevForm = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Решение выражения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите X:";
            // 
            // vvodX
            // 
            this.vvodX.Location = new System.Drawing.Point(200, 76);
            this.vvodX.Name = "vvodX";
            this.vvodX.Size = new System.Drawing.Size(100, 32);
            this.vvodX.TabIndex = 5;
            this.vvodX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodX_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Результат с out:";
            // 
            // vivodOut
            // 
            this.vivodOut.Location = new System.Drawing.Point(551, 76);
            this.vivodOut.Name = "vivodOut";
            this.vivodOut.ReadOnly = true;
            this.vivodOut.Size = new System.Drawing.Size(159, 32);
            this.vivodOut.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Результат с ref:";
            // 
            // vivodRef
            // 
            this.vivodRef.Location = new System.Drawing.Point(551, 116);
            this.vivodRef.Name = "vivodRef";
            this.vivodRef.ReadOnly = true;
            this.vivodRef.Size = new System.Drawing.Size(159, 32);
            this.vivodRef.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(567, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Выберите путь к выходному файлу для вывода результатов работы:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outFilePath
            // 
            this.outFilePath.Location = new System.Drawing.Point(200, 200);
            this.outFilePath.Name = "outFilePath";
            this.outFilePath.ReadOnly = true;
            this.outFilePath.Size = new System.Drawing.Size(510, 32);
            this.outFilePath.TabIndex = 20;
            // 
            // solveThis
            // 
            this.solveThis.Location = new System.Drawing.Point(325, 240);
            this.solveThis.Name = "solveThis";
            this.solveThis.Size = new System.Drawing.Size(150, 50);
            this.solveThis.TabIndex = 21;
            this.solveThis.Text = "Решение";
            this.solveThis.UseVisualStyleBackColor = true;
            this.solveThis.Click += new System.EventHandler(this.solveThis_Click);
            // 
            // prevForm
            // 
            this.prevForm.Location = new System.Drawing.Point(80, 375);
            this.prevForm.Name = "prevForm";
            this.prevForm.Size = new System.Drawing.Size(150, 50);
            this.prevForm.TabIndex = 22;
            this.prevForm.Text = "Назад";
            this.prevForm.UseVisualStyleBackColor = true;
            this.prevForm.Click += new System.EventHandler(this.prevForm_Click);
            // 
            // closeForm
            // 
            this.closeForm.BackColor = System.Drawing.Color.Salmon;
            this.closeForm.Location = new System.Drawing.Point(570, 375);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(150, 50);
            this.closeForm.TabIndex = 23;
            this.closeForm.Text = "Завершить";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Task2_Solve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.prevForm);
            this.Controls.Add(this.solveThis);
            this.Controls.Add(this.outFilePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vivodRef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vivodOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vvodX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Task2_Solve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для вычисления значения выражения с использованием вспомогательной функ" +
    "ции";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vvodX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vivodOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vivodRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outFilePath;
        private System.Windows.Forms.Button solveThis;
        private System.Windows.Forms.Button prevForm;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}