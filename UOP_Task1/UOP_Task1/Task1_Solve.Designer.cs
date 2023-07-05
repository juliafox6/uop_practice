namespace UOP_Task1
{
    partial class Task1_Solve
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
            this.prevForm = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vvodX = new System.Windows.Forms.TextBox();
            this.vvodY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vivodD = new System.Windows.Forms.TextBox();
            this.solveThis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openOutFile = new System.Windows.Forms.Button();
            this.outFilePath = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.vivodE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vivodF = new System.Windows.Forms.TextBox();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Решение выражения";
            // 
            // prevForm
            // 
            this.prevForm.Location = new System.Drawing.Point(80, 375);
            this.prevForm.Name = "prevForm";
            this.prevForm.Size = new System.Drawing.Size(150, 50);
            this.prevForm.TabIndex = 1;
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
            this.closeForm.TabIndex = 2;
            this.closeForm.Text = "Завершить";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите Y:";
            // 
            // vvodX
            // 
            this.vvodX.Location = new System.Drawing.Point(200, 76);
            this.vvodX.Name = "vvodX";
            this.vvodX.Size = new System.Drawing.Size(100, 32);
            this.vvodX.TabIndex = 5;
            this.vvodX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodX_KeyPress);
            // 
            // vvodY
            // 
            this.vvodY.Location = new System.Drawing.Point(200, 116);
            this.vvodY.Name = "vvodY";
            this.vvodY.Size = new System.Drawing.Size(100, 32);
            this.vvodY.TabIndex = 6;
            this.vvodY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodY_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат с return:";
            // 
            // vivodD
            // 
            this.vivodD.Location = new System.Drawing.Point(551, 76);
            this.vivodD.Name = "vivodD";
            this.vivodD.ReadOnly = true;
            this.vivodD.Size = new System.Drawing.Size(169, 32);
            this.vivodD.TabIndex = 8;
            // 
            // solveThis
            // 
            this.solveThis.Location = new System.Drawing.Point(325, 280);
            this.solveThis.Name = "solveThis";
            this.solveThis.Size = new System.Drawing.Size(150, 50);
            this.solveThis.TabIndex = 9;
            this.solveThis.Text = "Решение";
            this.solveThis.UseVisualStyleBackColor = true;
            this.solveThis.Click += new System.EventHandler(this.solveThis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(567, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Выберите путь к выходному файлу для вывода результатов работы:";
            // 
            // openOutFile
            // 
            this.openOutFile.Location = new System.Drawing.Point(80, 240);
            this.openOutFile.Name = "openOutFile";
            this.openOutFile.Size = new System.Drawing.Size(100, 32);
            this.openOutFile.TabIndex = 11;
            this.openOutFile.Text = "Открыть";
            this.openOutFile.UseVisualStyleBackColor = true;
            this.openOutFile.Click += new System.EventHandler(this.openOutFile_Click);
            // 
            // outFilePath
            // 
            this.outFilePath.Location = new System.Drawing.Point(200, 240);
            this.outFilePath.Name = "outFilePath";
            this.outFilePath.ReadOnly = true;
            this.outFilePath.Size = new System.Drawing.Size(520, 32);
            this.outFilePath.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Результат с out:";
            // 
            // vivodE
            // 
            this.vivodE.Location = new System.Drawing.Point(551, 116);
            this.vivodE.Name = "vivodE";
            this.vivodE.ReadOnly = true;
            this.vivodE.Size = new System.Drawing.Size(169, 32);
            this.vivodE.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Результат с ref:";
            // 
            // vivodF
            // 
            this.vivodF.Location = new System.Drawing.Point(551, 156);
            this.vivodF.Name = "vivodF";
            this.vivodF.ReadOnly = true;
            this.vivodF.Size = new System.Drawing.Size(169, 32);
            this.vivodF.TabIndex = 16;
            // 
            // Task1_Solve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.vivodF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vivodE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outFilePath);
            this.Controls.Add(this.openOutFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.solveThis);
            this.Controls.Add(this.vivodD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vvodY);
            this.Controls.Add(this.vvodX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.prevForm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Task1_Solve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для вычисления значений неизвестной от вводимых значений переменных";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prevForm;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vvodX;
        private System.Windows.Forms.TextBox vvodY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vivodD;
        private System.Windows.Forms.Button solveThis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openOutFile;
        private System.Windows.Forms.TextBox outFilePath;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox vivodE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vivodF;
        private System.Windows.Forms.Label label7;
    }
}