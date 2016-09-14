namespace KalkulatorBMI
{
    partial class Form1
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
            this.lbl_waga = new System.Windows.Forms.Label();
            this.lbl_wzrost = new System.Windows.Forms.Label();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.lbl_twojebmi = new System.Windows.Forms.Label();
            this.btn_oblicz = new System.Windows.Forms.Button();
            this.textBoxWaga = new System.Windows.Forms.TextBox();
            this.textBoxWzrost = new System.Windows.Forms.TextBox();
            this.comboWaga = new System.Windows.Forms.ComboBox();
            this.comboWzrost = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_waga
            // 
            this.lbl_waga.AutoSize = true;
            this.lbl_waga.Location = new System.Drawing.Point(13, 25);
            this.lbl_waga.Name = "lbl_waga";
            this.lbl_waga.Size = new System.Drawing.Size(36, 13);
            this.lbl_waga.TabIndex = 0;
            this.lbl_waga.Text = "Waga";
            // 
            // lbl_wzrost
            // 
            this.lbl_wzrost.AutoSize = true;
            this.lbl_wzrost.Location = new System.Drawing.Point(13, 55);
            this.lbl_wzrost.Name = "lbl_wzrost";
            this.lbl_wzrost.Size = new System.Drawing.Size(40, 13);
            this.lbl_wzrost.TabIndex = 1;
            this.lbl_wzrost.Text = "Wzrost";
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_copyright.Location = new System.Drawing.Point(34, 168);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(276, 17);
            this.lbl_copyright.TabIndex = 2;
            this.lbl_copyright.Text = "© 2016 Oskar Jasiński. All rights reserved.";
            // 
            // lbl_twojebmi
            // 
            this.lbl_twojebmi.AutoSize = true;
            this.lbl_twojebmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_twojebmi.Location = new System.Drawing.Point(16, 95);
            this.lbl_twojebmi.Name = "lbl_twojebmi";
            this.lbl_twojebmi.Size = new System.Drawing.Size(76, 17);
            this.lbl_twojebmi.TabIndex = 3;
            this.lbl_twojebmi.Text = "Twoje BMI:";
            this.lbl_twojebmi.Visible = false;
            // 
            // btn_oblicz
            // 
            this.btn_oblicz.Location = new System.Drawing.Point(16, 132);
            this.btn_oblicz.Name = "btn_oblicz";
            this.btn_oblicz.Size = new System.Drawing.Size(318, 23);
            this.btn_oblicz.TabIndex = 4;
            this.btn_oblicz.Text = "OBLICZ";
            this.btn_oblicz.UseVisualStyleBackColor = true;
            this.btn_oblicz.Click += new System.EventHandler(this.btn_oblicz_Click);
            // 
            // textBoxWaga
            // 
            this.textBoxWaga.Location = new System.Drawing.Point(66, 22);
            this.textBoxWaga.Name = "textBoxWaga";
            this.textBoxWaga.Size = new System.Drawing.Size(100, 20);
            this.textBoxWaga.TabIndex = 5;
            // 
            // textBoxWzrost
            // 
            this.textBoxWzrost.Location = new System.Drawing.Point(66, 52);
            this.textBoxWzrost.Name = "textBoxWzrost";
            this.textBoxWzrost.Size = new System.Drawing.Size(100, 20);
            this.textBoxWzrost.TabIndex = 6;
            // 
            // comboWaga
            // 
            this.comboWaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWaga.FormattingEnabled = true;
            this.comboWaga.Items.AddRange(new object[] {
            "Kilogramy",
            "Funty"});
            this.comboWaga.Location = new System.Drawing.Point(191, 22);
            this.comboWaga.Name = "comboWaga";
            this.comboWaga.Size = new System.Drawing.Size(121, 21);
            this.comboWaga.TabIndex = 7;
            // 
            // comboWzrost
            // 
            this.comboWzrost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWzrost.FormattingEnabled = true;
            this.comboWzrost.Items.AddRange(new object[] {
            "Centymetry",
            "Cale"});
            this.comboWzrost.Location = new System.Drawing.Point(191, 51);
            this.comboWzrost.Name = "comboWzrost";
            this.comboWzrost.Size = new System.Drawing.Size(121, 21);
            this.comboWzrost.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(346, 195);
            this.Controls.Add(this.comboWzrost);
            this.Controls.Add(this.comboWaga);
            this.Controls.Add(this.textBoxWzrost);
            this.Controls.Add(this.textBoxWaga);
            this.Controls.Add(this.btn_oblicz);
            this.Controls.Add(this.lbl_twojebmi);
            this.Controls.Add(this.lbl_copyright);
            this.Controls.Add(this.lbl_wzrost);
            this.Controls.Add(this.lbl_waga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kalkulator BMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_waga;
        private System.Windows.Forms.Label lbl_wzrost;
        private System.Windows.Forms.Label lbl_copyright;
        private System.Windows.Forms.Label lbl_twojebmi;
        private System.Windows.Forms.Button btn_oblicz;
        private System.Windows.Forms.TextBox textBoxWaga;
        private System.Windows.Forms.TextBox textBoxWzrost;
        private System.Windows.Forms.ComboBox comboWaga;
        private System.Windows.Forms.ComboBox comboWzrost;
    }
}

