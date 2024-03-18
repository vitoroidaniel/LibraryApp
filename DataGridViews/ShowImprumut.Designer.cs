namespace LibraryApp
{
    partial class ShowImprumut
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new LibraryApp.BibliotecaDataSet();
            this.bibliotecaDataSet1 = new LibraryApp.BibliotecaDataSet1();
            this.imprumutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imprumutTableAdapter = new LibraryApp.BibliotecaDataSet1TableAdapters.ImprumutTableAdapter();
            this.idcititorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataimprumutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datareturnariiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcititorDataGridViewTextBoxColumn,
            this.idcarteDataGridViewTextBoxColumn,
            this.dataimprumutDataGridViewTextBoxColumn,
            this.datareturnariiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.imprumutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // bibliotecaDataSetBindingSource
            // 
            this.bibliotecaDataSetBindingSource.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource.Position = 0;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaDataSet1
            // 
            this.bibliotecaDataSet1.DataSetName = "BibliotecaDataSet1";
            this.bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imprumutBindingSource
            // 
            this.imprumutBindingSource.DataMember = "Imprumut";
            this.imprumutBindingSource.DataSource = this.bibliotecaDataSet1;
            // 
            // imprumutTableAdapter
            // 
            this.imprumutTableAdapter.ClearBeforeFill = true;
            // 
            // idcititorDataGridViewTextBoxColumn
            // 
            this.idcititorDataGridViewTextBoxColumn.DataPropertyName = "Id_cititor";
            this.idcititorDataGridViewTextBoxColumn.HeaderText = "Id_cititor";
            this.idcititorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcititorDataGridViewTextBoxColumn.Name = "idcititorDataGridViewTextBoxColumn";
            this.idcititorDataGridViewTextBoxColumn.Width = 125;
            // 
            // idcarteDataGridViewTextBoxColumn
            // 
            this.idcarteDataGridViewTextBoxColumn.DataPropertyName = "Id_carte";
            this.idcarteDataGridViewTextBoxColumn.HeaderText = "Id_carte";
            this.idcarteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcarteDataGridViewTextBoxColumn.Name = "idcarteDataGridViewTextBoxColumn";
            this.idcarteDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataimprumutDataGridViewTextBoxColumn
            // 
            this.dataimprumutDataGridViewTextBoxColumn.DataPropertyName = "Data_imprumut";
            this.dataimprumutDataGridViewTextBoxColumn.HeaderText = "Data_imprumut";
            this.dataimprumutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataimprumutDataGridViewTextBoxColumn.Name = "dataimprumutDataGridViewTextBoxColumn";
            this.dataimprumutDataGridViewTextBoxColumn.Width = 125;
            // 
            // datareturnariiDataGridViewTextBoxColumn
            // 
            this.datareturnariiDataGridViewTextBoxColumn.DataPropertyName = "Data_returnarii";
            this.datareturnariiDataGridViewTextBoxColumn.HeaderText = "Data_returnarii";
            this.datareturnariiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datareturnariiDataGridViewTextBoxColumn.Name = "datareturnariiDataGridViewTextBoxColumn";
            this.datareturnariiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ShowImprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowImprumut";
            this.Text = "ShowImprumut";
            this.Load += new System.EventHandler(this.ShowImprumut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private BibliotecaDataSet bibliotecaDataSet;
        private BibliotecaDataSet1 bibliotecaDataSet1;
        private System.Windows.Forms.BindingSource imprumutBindingSource;
        private BibliotecaDataSet1TableAdapters.ImprumutTableAdapter imprumutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataimprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datareturnariiDataGridViewTextBoxColumn;
    }
}