namespace UOP_Task1
{
    partial class Task3_Solve
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
            this.vvodY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vvodA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vvodB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vvodC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vivodRet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outFilePath = new System.Windows.Forms.TextBox();
            this.openOutFile = new System.Windows.Forms.Button();
            this.prevForm = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.solveThis = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Решение выражения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите X:";
            // 
            // vvodX
            // 
            this.vvodX.Location = new System.Drawing.Point(200, 76);
            this.vvodX.Name = "vvodX";
            this.vvodX.Size = new System.Drawing.Size(100, 32);
            this.vvodX.TabIndex = 6;
            this.vvodX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodX_KeyPress);
            // 
            // vvodY
            // 
            this.vvodY.Location = new System.Drawing.Point(200, 116);
            this.vvodY.Name = "vvodY";
            this.vvodY.Size = new System.Drawing.Size(100, 32);
            this.vvodY.TabIndex = 8;
            this.vvodY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodY_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите Y:";
            // 
            // vvodA
            // 
            this.vvodA.Location = new System.Drawing.Point(200, 156);
            this.vvodA.Name = "vvodA";
            this.vvodA.Size = new System.Drawing.Size(100, 32);
            this.vvodA.TabIndex = 10;
            this.vvodA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите A:";
            // 
            // vvodB
            // 
            this.vvodB.Location = new System.Drawing.Point(200, 196);
            this.vvodB.Name = "vvodB";
            this.vvodB.Size = new System.Drawing.Size(100, 32);
            this.vvodB.TabIndex = 12;
            this.vvodB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите B:";
            // 
            // vvodC
            // 
            this.vvodC.Location = new System.Drawing.Point(200, 236);
            this.vvodC.Name = "vvodC";
            this.vvodC.Size = new System.Drawing.Size(100, 32);
            this.vvodC.TabIndex = 14;
            this.vvodC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vvodC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введите C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Результат с return:";
            // 
            // vivodRet
            // 
            this.vivodRet.Location = new System.Drawing.Point(551, 76);
            this.vivodRet.Name = "vivodRet";
            this.vivodRet.ReadOnly = true;
            this.vivodRet.Size = new System.Drawing.Size(169, 32);
            this.vivodRet.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(567, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Выберите путь к выходному файлу для вывода результатов работы:";
            // 
            // outFilePath
            // 
            this.outFilePath.Location = new System.Drawing.Point(200, 320);
            this.outFilePath.Name = "outFilePath";
            this.outFilePath.ReadOnly = true;
            this.outFilePath.Size = new System.Drawing.Size(520, 32);
            this.outFilePath.TabIndex = 19;
            // 
            // openOutFile
            // 
            this.openOutFile.Location = new System.Drawing.Point(80, 320);
            this.openOutFile.Name = "openOutFile";
            this.openOutFile.Size = new System.Drawing.Size(100, 32);
            this.openOutFile.TabIndex = 18;
            this.openOutFile.Text = "Открыть";
            this.openOutFile.UseVisualStyleBackColor = true;
            this.openOutFile.Click += new System.EventHandler(this.openOutFile_Click);
            // 
            // prevForm
            // 
            this.prevForm.Location = new System.Drawing.Point(80, 375);
            this.prevForm.Name = "prevForm";
            this.prevForm.Size = new System.Drawing.Size(150, 50);
            this.prevForm.TabIndex = 20;
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
            this.closeForm.TabIndex = 21;
            this.closeForm.Text = "Завершить";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // solveThis
            // 
            this.solveThis.Location = new System.Drawing.Point(325, 375);
            this.solveThis.Name = "solveThis";
            this.solveThis.Size = new System.Drawing.Size(150, 50);
            this.solveThis.TabIndex = 22;
            this.solveThis.Text = "Решение";
            this.solveThis.UseVisualStyleBackColor = true;
            this.solveThis.Click += new System.EventHandler(this.solveThis_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Task3_Solve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.solveThis);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.prevForm);
            this.Controls.Add(this.outFilePath);
            this.Controls.Add(this.openOutFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vivodRet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vvodC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vvodB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vvodA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vvodY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vvodX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Task3_Solve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для вычисления выражения по ветвящемуся алгоритму";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vvodX;
        private System.Windows.Forms.TextBox vvodY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vvodA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vvodB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vvodC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vivodRet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outFilePath;
        private System.Windows.Forms.Button openOutFile;
        private System.Windows.Forms.Button prevForm;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Button solveThis;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}