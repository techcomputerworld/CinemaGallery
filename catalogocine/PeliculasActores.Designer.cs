namespace catalogocine
{
    partial class PeliculasActores
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
            this.dataGridPeliculasActores = new System.Windows.Forms.DataGridView();
            this.idpeliculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogocineDataSet = new catalogocine.catalogocineDataSet();
            this.idactorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.actoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasactoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculas_actoresTableAdapter = new catalogocine.catalogocineDataSetTableAdapters.peliculas_actoresTableAdapter();
            this.peliculasTableAdapter = new catalogocine.catalogocineDataSetTableAdapters.peliculasTableAdapter();
            this.actoresTableAdapter = new catalogocine.catalogocineDataSetTableAdapters.actoresTableAdapter();
            this.btAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeliculasActores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogocineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasactoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPeliculasActores
            // 
            this.dataGridPeliculasActores.AllowUserToOrderColumns = true;
            this.dataGridPeliculasActores.AutoGenerateColumns = false;
            this.dataGridPeliculasActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPeliculasActores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeliculaDataGridViewTextBoxColumn,
            this.idactorDataGridViewTextBoxColumn});
            this.dataGridPeliculasActores.DataSource = this.peliculasactoresBindingSource;
            this.dataGridPeliculasActores.Location = new System.Drawing.Point(42, 40);
            this.dataGridPeliculasActores.Name = "dataGridPeliculasActores";
            this.dataGridPeliculasActores.Size = new System.Drawing.Size(303, 162);
            this.dataGridPeliculasActores.TabIndex = 0;
            this.dataGridPeliculasActores.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPeliculasActores_RowLeave);
            // 
            // idpeliculaDataGridViewTextBoxColumn
            // 
            this.idpeliculaDataGridViewTextBoxColumn.DataPropertyName = "id_pelicula";
            this.idpeliculaDataGridViewTextBoxColumn.DataSource = this.peliculasBindingSource;
            this.idpeliculaDataGridViewTextBoxColumn.DisplayMember = "titulo_original";
            this.idpeliculaDataGridViewTextBoxColumn.HeaderText = "id_pelicula";
            this.idpeliculaDataGridViewTextBoxColumn.Name = "idpeliculaDataGridViewTextBoxColumn";
            this.idpeliculaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpeliculaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpeliculaDataGridViewTextBoxColumn.ValueMember = "id_pelicula";
            this.idpeliculaDataGridViewTextBoxColumn.Width = 130;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.catalogocineDataSet;
            // 
            // catalogocineDataSet
            // 
            this.catalogocineDataSet.DataSetName = "catalogocineDataSet";
            this.catalogocineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idactorDataGridViewTextBoxColumn
            // 
            this.idactorDataGridViewTextBoxColumn.DataPropertyName = "id_actor";
            this.idactorDataGridViewTextBoxColumn.DataSource = this.actoresBindingSource;
            this.idactorDataGridViewTextBoxColumn.DisplayMember = "nombre_apellidos";
            this.idactorDataGridViewTextBoxColumn.HeaderText = "id_actor";
            this.idactorDataGridViewTextBoxColumn.Name = "idactorDataGridViewTextBoxColumn";
            this.idactorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idactorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idactorDataGridViewTextBoxColumn.ValueMember = "id_actor";
            this.idactorDataGridViewTextBoxColumn.Width = 130;
            // 
            // actoresBindingSource
            // 
            this.actoresBindingSource.DataMember = "actores";
            this.actoresBindingSource.DataSource = this.catalogocineDataSet;
            // 
            // peliculasactoresBindingSource
            // 
            this.peliculasactoresBindingSource.DataMember = "peliculas_actores";
            this.peliculasactoresBindingSource.DataSource = this.catalogocineDataSet;
            // 
            // peliculas_actoresTableAdapter
            // 
            this.peliculas_actoresTableAdapter.ClearBeforeFill = true;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // actoresTableAdapter
            // 
            this.actoresTableAdapter.ClearBeforeFill = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(156, 233);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // PeliculasActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 288);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dataGridPeliculasActores);
            this.Name = "PeliculasActores";
            this.Text = "PeliculasActores";
            this.Load += new System.EventHandler(this.PeliculasActores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeliculasActores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogocineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasactoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPeliculasActores;
        private catalogocineDataSet catalogocineDataSet;
        private System.Windows.Forms.BindingSource peliculasactoresBindingSource;
        private catalogocine.catalogocineDataSetTableAdapters.peliculas_actoresTableAdapter peliculas_actoresTableAdapter;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private catalogocine.catalogocineDataSetTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private System.Windows.Forms.BindingSource actoresBindingSource;
        private catalogocine.catalogocineDataSetTableAdapters.actoresTableAdapter actoresTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpeliculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idactorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btAceptar;
    }
}