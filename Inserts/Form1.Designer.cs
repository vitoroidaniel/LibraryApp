namespace LibraryApp
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cititorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.impumutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cititorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(51, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(232, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Numele/Prenumele Cititorului:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdress.Location = new System.Drawing.Point(51, 183);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(143, 20);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Adresa Cititorului:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefonul CItitorului:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(55, 224);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(228, 22);
            this.txtAdress.TabIndex = 4;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(55, 326);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(228, 22);
            this.txtTelephone.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(38, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(129, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(222, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteToolStripMenuItem,
            this.imprumutToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carteToolStripMenuItem
            // 
            this.carteToolStripMenuItem.Name = "carteToolStripMenuItem";
            this.carteToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.carteToolStripMenuItem.Text = "Carte";
            this.carteToolStripMenuItem.Click += new System.EventHandler(this.carteToolStripMenuItem_Click);
            // 
            // imprumutToolStripMenuItem
            // 
            this.imprumutToolStripMenuItem.Name = "imprumutToolStripMenuItem";
            this.imprumutToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.imprumutToolStripMenuItem.Text = "Imprumut";
            this.imprumutToolStripMenuItem.Click += new System.EventHandler(this.imprumutToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteToolStripMenuItem1,
            this.imprumutToolStripMenuItem1,
            this.cititorToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.updateToolStripMenuItem.Text = "Update ";
            // 
            // carteToolStripMenuItem1
            // 
            this.carteToolStripMenuItem1.Name = "carteToolStripMenuItem1";
            this.carteToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.carteToolStripMenuItem1.Text = "Carte";
            this.carteToolStripMenuItem1.Click += new System.EventHandler(this.carteToolStripMenuItem1_Click);
            // 
            // imprumutToolStripMenuItem1
            // 
            this.imprumutToolStripMenuItem1.Name = "imprumutToolStripMenuItem1";
            this.imprumutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.imprumutToolStripMenuItem1.Text = "Imprumut";
            this.imprumutToolStripMenuItem1.Click += new System.EventHandler(this.imprumutToolStripMenuItem1_Click);
            // 
            // cititorToolStripMenuItem
            // 
            this.cititorToolStripMenuItem.Name = "cititorToolStripMenuItem";
            this.cititorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cititorToolStripMenuItem.Text = "Cititor";
            this.cititorToolStripMenuItem.Click += new System.EventHandler(this.cititorToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteToolStripMenuItem2,
            this.impumutToolStripMenuItem,
            this.cititorToolStripMenuItem1});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // carteToolStripMenuItem2
            // 
            this.carteToolStripMenuItem2.Name = "carteToolStripMenuItem2";
            this.carteToolStripMenuItem2.Size = new System.Drawing.Size(152, 26);
            this.carteToolStripMenuItem2.Text = "Carte";
            // 
            // impumutToolStripMenuItem
            // 
            this.impumutToolStripMenuItem.Name = "impumutToolStripMenuItem";
            this.impumutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.impumutToolStripMenuItem.Text = "Impumut";
            // 
            // cititorToolStripMenuItem1
            // 
            this.cititorToolStripMenuItem1.Name = "cititorToolStripMenuItem1";
            this.cititorToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.cititorToolStripMenuItem1.Text = "Cititor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Adaugarea Informatie Cititor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprumutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprumutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cititorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem impumutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cititorToolStripMenuItem1;
    }
}

