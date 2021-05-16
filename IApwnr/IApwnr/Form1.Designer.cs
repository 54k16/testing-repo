namespace lApwnr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.HelpBut = new System.Windows.Forms.Button();
            this.AboutBut = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PrvtIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.ImBut = new Guna.UI2.WinForms.Guna2Button();
            this.PrvtBut = new Guna.UI2.WinForms.Guna2Button();
            this.ExBut = new Guna.UI2.WinForms.Guna2Button();
            this.GenBut = new Guna.UI2.WinForms.Guna2Button();
            this.DecBut = new Guna.UI2.WinForms.Guna2Button();
            this.EncBut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "c:\\meow";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Encrypted files (*.enc) | *.enc|All files (*.*)|*.*";
            this.openFileDialog2.InitialDirectory = "c:\\encrypt";
            // 
            // HelpBut
            // 
            this.HelpBut.Location = new System.Drawing.Point(645, 25);
            this.HelpBut.Name = "HelpBut";
            this.HelpBut.Size = new System.Drawing.Size(75, 23);
            this.HelpBut.TabIndex = 7;
            this.HelpBut.Text = "Help";
            this.HelpBut.UseVisualStyleBackColor = true;
            this.HelpBut.Click += new System.EventHandler(this.HelpBut_Click);
            // 
            // AboutBut
            // 
            this.AboutBut.Location = new System.Drawing.Point(27, 25);
            this.AboutBut.Name = "AboutBut";
            this.AboutBut.Size = new System.Drawing.Size(75, 23);
            this.AboutBut.TabIndex = 8;
            this.AboutBut.Text = "About";
            this.AboutBut.UseVisualStyleBackColor = true;
            this.AboutBut.Click += new System.EventHandler(this.AboutBut_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.PrvtIn);
            this.guna2Panel1.Controls.Add(this.ImBut);
            this.guna2Panel1.Controls.Add(this.PrvtBut);
            this.guna2Panel1.Controls.Add(this.ExBut);
            this.guna2Panel1.Controls.Add(this.GenBut);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, 201);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(745, 353);
            this.guna2Panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(556, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Key not set";
            // 
            // PrvtIn
            // 
            this.PrvtIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrvtIn.DefaultText = "";
            this.PrvtIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrvtIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrvtIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrvtIn.DisabledState.Parent = this.PrvtIn;
            this.PrvtIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrvtIn.FillColor = System.Drawing.SystemColors.Control;
            this.PrvtIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrvtIn.FocusedState.Parent = this.PrvtIn;
            this.PrvtIn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrvtIn.ForeColor = System.Drawing.Color.Black;
            this.PrvtIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrvtIn.HoverState.Parent = this.PrvtIn;
            this.PrvtIn.Location = new System.Drawing.Point(272, 62);
            this.PrvtIn.Name = "PrvtIn";
            this.PrvtIn.PasswordChar = '\0';
            this.PrvtIn.PlaceholderText = "";
            this.PrvtIn.SelectedText = "";
            this.PrvtIn.ShadowDecoration.Parent = this.PrvtIn;
            this.PrvtIn.Size = new System.Drawing.Size(200, 36);
            this.PrvtIn.TabIndex = 13;
            this.PrvtIn.TextChanged += new System.EventHandler(this.PrvtIn_TextChanged_1);
            // 
            // ImBut
            // 
            this.ImBut.AutoRoundedCorners = true;
            this.ImBut.BackColor = System.Drawing.Color.Transparent;
            this.ImBut.BorderRadius = 19;
            this.ImBut.CheckedState.Parent = this.ImBut;
            this.ImBut.CustomImages.Parent = this.ImBut;
            this.ImBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(252)))));
            this.ImBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImBut.ForeColor = System.Drawing.Color.White;
            this.ImBut.HoverState.Parent = this.ImBut;
            this.ImBut.Location = new System.Drawing.Point(281, 265);
            this.ImBut.Name = "ImBut";
            this.ImBut.ShadowDecoration.BorderRadius = 26;
            this.ImBut.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.ImBut.ShadowDecoration.Enabled = true;
            this.ImBut.ShadowDecoration.Parent = this.ImBut;
            this.ImBut.Size = new System.Drawing.Size(183, 41);
            this.ImBut.TabIndex = 12;
            this.ImBut.Text = "Import Public Key";
            this.ImBut.Click += new System.EventHandler(this.ImBut_Click_1);
            // 
            // PrvtBut
            // 
            this.PrvtBut.AutoRoundedCorners = true;
            this.PrvtBut.BackColor = System.Drawing.Color.Transparent;
            this.PrvtBut.BorderRadius = 19;
            this.PrvtBut.CheckedState.Parent = this.PrvtBut;
            this.PrvtBut.CustomImages.Parent = this.PrvtBut;
            this.PrvtBut.FillColor = System.Drawing.Color.Crimson;
            this.PrvtBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrvtBut.ForeColor = System.Drawing.Color.White;
            this.PrvtBut.HoverState.Parent = this.PrvtBut;
            this.PrvtBut.Location = new System.Drawing.Point(504, 57);
            this.PrvtBut.Name = "PrvtBut";
            this.PrvtBut.ShadowDecoration.BorderRadius = 26;
            this.PrvtBut.ShadowDecoration.Color = System.Drawing.Color.Crimson;
            this.PrvtBut.ShadowDecoration.Enabled = true;
            this.PrvtBut.ShadowDecoration.Parent = this.PrvtBut;
            this.PrvtBut.Size = new System.Drawing.Size(183, 41);
            this.PrvtBut.TabIndex = 12;
            this.PrvtBut.Text = "Set Private Key";
            this.PrvtBut.Click += new System.EventHandler(this.PrvtBut_Click_1);
            // 
            // ExBut
            // 
            this.ExBut.AutoRoundedCorners = true;
            this.ExBut.BackColor = System.Drawing.Color.Transparent;
            this.ExBut.BorderRadius = 19;
            this.ExBut.CheckedState.Parent = this.ExBut;
            this.ExBut.CustomImages.Parent = this.ExBut;
            this.ExBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExBut.ForeColor = System.Drawing.Color.White;
            this.ExBut.HoverState.Parent = this.ExBut;
            this.ExBut.Location = new System.Drawing.Point(281, 199);
            this.ExBut.Name = "ExBut";
            this.ExBut.ShadowDecoration.BorderRadius = 26;
            this.ExBut.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.ExBut.ShadowDecoration.Enabled = true;
            this.ExBut.ShadowDecoration.Parent = this.ExBut;
            this.ExBut.Size = new System.Drawing.Size(183, 41);
            this.ExBut.TabIndex = 12;
            this.ExBut.Text = "Export Public Key";
            this.ExBut.Click += new System.EventHandler(this.ExBut_Click_1);
            // 
            // GenBut
            // 
            this.GenBut.AutoRoundedCorners = true;
            this.GenBut.BackColor = System.Drawing.Color.Transparent;
            this.GenBut.BorderRadius = 19;
            this.GenBut.CheckedState.Parent = this.GenBut;
            this.GenBut.CustomImages.Parent = this.GenBut;
            this.GenBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(252)))));
            this.GenBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenBut.ForeColor = System.Drawing.Color.White;
            this.GenBut.HoverState.Parent = this.GenBut;
            this.GenBut.Location = new System.Drawing.Point(281, 131);
            this.GenBut.Name = "GenBut";
            this.GenBut.ShadowDecoration.BorderRadius = 26;
            this.GenBut.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.GenBut.ShadowDecoration.Enabled = true;
            this.GenBut.ShadowDecoration.Parent = this.GenBut;
            this.GenBut.Size = new System.Drawing.Size(183, 41);
            this.GenBut.TabIndex = 12;
            this.GenBut.Text = "Generate Public Key";
            this.GenBut.Click += new System.EventHandler(this.GenBut_Click_1);
            // 
            // DecBut
            // 
            this.DecBut.AutoRoundedCorners = true;
            this.DecBut.BackColor = System.Drawing.Color.Transparent;
            this.DecBut.BorderRadius = 27;
            this.DecBut.CheckedState.Parent = this.DecBut;
            this.DecBut.CustomImages.Parent = this.DecBut;
            this.DecBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(252)))));
            this.DecBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecBut.ForeColor = System.Drawing.Color.White;
            this.DecBut.HoverState.Parent = this.DecBut;
            this.DecBut.Location = new System.Drawing.Point(478, 95);
            this.DecBut.Name = "DecBut";
            this.DecBut.ShadowDecoration.BorderRadius = 26;
            this.DecBut.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.DecBut.ShadowDecoration.Enabled = true;
            this.DecBut.ShadowDecoration.Parent = this.DecBut;
            this.DecBut.Size = new System.Drawing.Size(100, 56);
            this.DecBut.TabIndex = 12;
            this.DecBut.Text = "Decrypt";
            this.DecBut.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // EncBut
            // 
            this.EncBut.AutoRoundedCorners = true;
            this.EncBut.BackColor = System.Drawing.Color.Transparent;
            this.EncBut.BorderRadius = 27;
            this.EncBut.CheckedState.Parent = this.EncBut;
            this.EncBut.CustomImages.Parent = this.EncBut;
            this.EncBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(148)))), ((int)(((byte)(252)))));
            this.EncBut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncBut.ForeColor = System.Drawing.Color.White;
            this.EncBut.HoverState.Parent = this.EncBut;
            this.EncBut.Location = new System.Drawing.Point(183, 95);
            this.EncBut.Name = "EncBut";
            this.EncBut.ShadowDecoration.BorderRadius = 26;
            this.EncBut.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.EncBut.ShadowDecoration.Enabled = true;
            this.EncBut.ShadowDecoration.Parent = this.EncBut;
            this.EncBut.Size = new System.Drawing.Size(100, 56);
            this.EncBut.TabIndex = 12;
            this.EncBut.Text = "Encrypt";
            this.EncBut.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(742, 551);
            this.Controls.Add(this.EncBut);
            this.Controls.Add(this.DecBut);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.AboutBut);
            this.Controls.Add(this.HelpBut);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IApwnr File Encryption Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button HelpBut;
        private System.Windows.Forms.Button AboutBut;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button GenBut;
        private Guna.UI2.WinForms.Guna2TextBox PrvtIn;
        private Guna.UI2.WinForms.Guna2Button ImBut;
        private Guna.UI2.WinForms.Guna2Button ExBut;
        private Guna.UI2.WinForms.Guna2Button PrvtBut;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button DecBut;
        private Guna.UI2.WinForms.Guna2Button EncBut;
    }
}

