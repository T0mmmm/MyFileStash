
namespace MyFileStash.Menu.Forms
{
    partial class Main
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
            this.pSettings = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIV = new System.Windows.Forms.Label();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSalt = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pSettings.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSettings
            // 
            this.pSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pSettings.Controls.Add(this.panel2);
            this.pSettings.Controls.Add(this.btnGen);
            this.pSettings.Controls.Add(this.panel4);
            this.pSettings.Controls.Add(this.lblIV);
            this.pSettings.Controls.Add(this.txtIV);
            this.pSettings.Controls.Add(this.btnSave);
            this.pSettings.Controls.Add(this.lblSalt);
            this.pSettings.Controls.Add(this.txtSalt);
            this.pSettings.Controls.Add(this.label2);
            this.pSettings.Controls.Add(this.txtKey);
            this.pSettings.Location = new System.Drawing.Point(123, 97);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(268, 196);
            this.pSettings.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 196);
            this.panel2.TabIndex = 13;
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGen.Location = new System.Drawing.Point(7, 135);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(255, 25);
            this.btnGen.TabIndex = 12;
            this.btnGen.Text = "Gen";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel4.Location = new System.Drawing.Point(0, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 1);
            this.panel4.TabIndex = 10;
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblIV.Location = new System.Drawing.Point(4, 86);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(17, 13);
            this.lblIV.TabIndex = 7;
            this.lblIV.Text = "IV";
            // 
            // txtIV
            // 
            this.txtIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIV.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIV.Location = new System.Drawing.Point(7, 102);
            this.txtIV.MaxLength = 16;
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(255, 22);
            this.txtIV.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Location = new System.Drawing.Point(7, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(255, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSalt.Location = new System.Drawing.Point(4, 45);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(25, 13);
            this.lblSalt.TabIndex = 5;
            this.lblSalt.Text = "Salt";
            // 
            // txtSalt
            // 
            this.txtSalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtSalt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSalt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSalt.Location = new System.Drawing.Point(7, 61);
            this.txtSalt.MaxLength = 16;
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(255, 22);
            this.txtSalt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKey.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKey.Location = new System.Drawing.Point(7, 20);
            this.txtKey.MaxLength = 25;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(255, 22);
            this.txtKey.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel3.Location = new System.Drawing.Point(123, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 1);
            this.panel3.TabIndex = 9;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Controls.Add(this.panel3);
            this.pMain.Controls.Add(this.pSettings);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(514, 391);
            this.pMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Location = new System.Drawing.Point(123, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 196);
            this.panel1.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mian";
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

