
namespace lr15
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
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.panelChooseColor = new System.Windows.Forms.Panel();
            this.txtChooseFont = new System.Windows.Forms.TextBox();
            this.txtChooseFile = new System.Windows.Forms.TextBox();
            this.txtChooseFolder = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.AutoSize = true;
            this.btnChooseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseColor.Location = new System.Drawing.Point(126, 35);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(176, 28);
            this.btnChooseColor.TabIndex = 0;
            this.btnChooseColor.Text = "Выбор цвета";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.AutoSize = true;
            this.btnChooseFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFont.Location = new System.Drawing.Point(126, 137);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(176, 28);
            this.btnChooseFont.TabIndex = 1;
            this.btnChooseFont.Text = "Выбор шрифта";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.AutoSize = true;
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFile.Location = new System.Drawing.Point(126, 69);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(176, 28);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Выбор файла";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.AutoSize = true;
            this.btnChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFolder.Location = new System.Drawing.Point(126, 103);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(176, 28);
            this.btnChooseFolder.TabIndex = 3;
            this.btnChooseFolder.Text = "Выбор каталога";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // panelChooseColor
            // 
            this.panelChooseColor.Location = new System.Drawing.Point(308, 37);
            this.panelChooseColor.Name = "panelChooseColor";
            this.panelChooseColor.Size = new System.Drawing.Size(142, 28);
            this.panelChooseColor.TabIndex = 4;
            // 
            // txtChooseFont
            // 
            this.txtChooseFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChooseFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtChooseFont.Location = new System.Drawing.Point(308, 134);
            this.txtChooseFont.Name = "txtChooseFont";
            this.txtChooseFont.Size = new System.Drawing.Size(481, 32);
            this.txtChooseFont.TabIndex = 5;
            // 
            // txtChooseFile
            // 
            this.txtChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtChooseFile.Location = new System.Drawing.Point(308, 71);
            this.txtChooseFile.Name = "txtChooseFile";
            this.txtChooseFile.Size = new System.Drawing.Size(481, 24);
            this.txtChooseFile.TabIndex = 6;
            // 
            // txtChooseFolder
            // 
            this.txtChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtChooseFolder.Location = new System.Drawing.Point(308, 105);
            this.txtChooseFolder.Name = "txtChooseFolder";
            this.txtChooseFolder.Size = new System.Drawing.Size(481, 24);
            this.txtChooseFolder.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\retak\\source\\repos\\lr12-21\\lr15\\Screenshot_15.png";
            this.pictureBox1.Location = new System.Drawing.Point(126, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnSolve
            // 
            this.btnSolve.AutoSize = true;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSolve.Location = new System.Drawing.Point(369, 444);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(176, 28);
            this.btnSolve.TabIndex = 9;
            this.btnSolve.Text = "Вычислить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 494);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtChooseFolder);
            this.Controls.Add(this.txtChooseFile);
            this.Controls.Add(this.txtChooseFont);
            this.Controls.Add(this.panelChooseColor);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.btnChooseColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Panel panelChooseColor;
        private System.Windows.Forms.TextBox txtChooseFont;
        private System.Windows.Forms.TextBox txtChooseFile;
        private System.Windows.Forms.TextBox txtChooseFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSolve;
    }
}

