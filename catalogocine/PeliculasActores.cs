using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace catalogocine
{
    public partial class PeliculasActores : Form
    {
        public PeliculasActores()
        {
            InitializeComponent();
        }

        private void PeliculasActores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'catalogocineDataSet.actores' Puede moverla o quitarla según sea necesario.
            this.actoresTableAdapter.Fill(this.catalogocineDataSet.actores);
            // TODO: esta línea de código carga datos en la tabla 'catalogocineDataSet.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.catalogocineDataSet.peliculas);
            // TODO: esta línea de código carga datos en la tabla 'catalogocineDataSet.peliculas_actores' Puede moverla o quitarla según sea necesario.
            this.peliculas_actoresTableAdapter.Fill(this.catalogocineDataSet.peliculas_actores);

        }

        private void dataGridPeliculasActores_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.peliculasactoresBindingSource.EndEdit();
                    //antes de actualizar tengo que comprobar varios campos
                    this.peliculas_actoresTableAdapter.Update(this.catalogocineDataSet.peliculas_actores);
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message);
                }
                

            }
            else
                MessageBox.Show(this, "Errores de validación", "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            btAceptar.DialogResult = DialogResult.OK;
        }

    }
} //final de la clase PeliculasActores

