
namespace MyFileStash.Menu.UserControls
{
    partial class MainControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pSettings = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtbOutPut = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSettings
            // 
            this.pSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pSettings.Controls.Add(this.btnRun);
            this.pSettings.Controls.Add(this.cbOptions);
            this.pSettings.Controls.Add(this.btnAdd);
            this.pSettings.Controls.Add(this.rtbOutPut);
            this.pSettings.Location = new System.Drawing.Point(98, 81);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(319, 229);
            this.pSettings.TabIndex = 7;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRun.Location = new System.Drawing.Point(5, 199);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(139, 25);
            this.btnRun.TabIndex = 17;
            this.btnRun.Text = "Encrypt";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cbOptions
            // 
            this.cbOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOptions.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.cbOptions.Location = new System.Drawing.Point(5, 5);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(139, 21);
            this.cbOptions.TabIndex = 3;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdd.Location = new System.Drawing.Point(5, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Files";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtbOutPut
            // 
            this.rtbOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.rtbOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOutPut.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbOutPut.Location = new System.Drawing.Point(150, 5);
            this.rtbOutPut.Name = "rtbOutPut";
            this.rtbOutPut.ReadOnly = true;
            this.rtbOutPut.Size = new System.Drawing.Size(163, 219);
            this.rtbOutPut.TabIndex = 0;
            this.rtbOutPut.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Location = new System.Drawing.Point(416, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 229);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel2.Location = new System.Drawing.Point(98, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 229);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel3.Location = new System.Drawing.Point(98, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel4.Location = new System.Drawing.Point(98, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 1);
            this.panel4.TabIndex = 16;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pSettings);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(514, 391);
            this.pSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.RichTextBox rtbOutPut;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRun;
    }
}
