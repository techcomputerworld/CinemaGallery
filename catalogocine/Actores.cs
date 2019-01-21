using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
using System.IO;

namespace catalogocine
{
    public partial class FormActores : Form
    {
        private int valorListBoxActor;

        public FormActores()
        {
            InitializeComponent();
        }

        private void Actores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'catalogocineDataSet.actores' Puede moverla o quitarla según sea necesario.
            this.actoresTableAdapter.Fill(this.catalogocineDataSet.actores);

        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    //estableciendo la propiedad de updatecommand del DataAdapter 
                    //sin utilizar la generacion automatica de comandos


                    this.actoresBindingSource.EndEdit();
                    //catalogocineDataSet.peliculas.AcceptChanges();
                    //antes de actualizar tengo que comprobar varios campos
                    this.actoresTableAdapter.Update(this.catalogocineDataSet.actores);
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

        private void listBoxActor_SelectedValueChanged(object sender, EventArgs e)
        {
            object valorSeleccionado;
            valorSeleccionado = listBoxActor.SelectedValue;
            int valor = Convert.ToInt32(valorSeleccionado);
            valorListBoxActor = valor;
        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    /*estableciendo la propiedad de updatecommand del DataAdapter 
                     * sin utilizar la generacion automatica de comandos
                    */

                    this.actoresBindingSource.EndEdit();
                    //antes de actualizar tengo que comprobar varios campos
                    this.actoresTableAdapter.Update(this.catalogocineDataSet.actores);
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

        private void pictureBoxActor_DoubleClick(object sender, EventArgs e)
        {
            Stream imagenStream; //fichero en bytes.
            String sImagen; //la cadena de texto del fichero con su directorioi y todo.


            //Environment.GetFolderPath(Environment.SpecialFolder.System)
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "ficheros jpg (*.jpg)|*.jpg|All files (*.*)|*.*";
            //saveFileDialog1.Filter = "ficheros jpg (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((imagenStream = openFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    sImagen = openFileDialog1.FileName;
                    try
                    {
                        //ruta de la localizacion de la imagen
                        pictureBoxActor.ImageLocation = sImagen;
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    imagenStream.Close();


                }


            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            /* Antes de preguntar al usuario verificamos que el actor no este en mas de
             * una pelicula y si lo esta no permitimos que se borre.
             * 
             */
            
            DialogResult respuesta;

            /* instanciando un objeto TableAdapter para que podamos ver el TableAdapter peliculas_actores
             * que es el que nos interesa a la hora de poder utilizar consultas
             * dentro del TableAdapter peliculas_actores
             * 
             */
            catalogocineDataSetTableAdapters.peliculas_actoresTableAdapter peliculas_actoresTableAdapter = new catalogocineDataSetTableAdapters.peliculas_actoresTableAdapter();


            try
            {
                /* valorListBox recoge el valor que devuelve el metodo de los actores, 
                 * para saber en cuantas peliculas aparece y si aparece en mas de 1, te
                 * da un mensaje de que tienes que quitarle las asociaciones de las
                 * peliculas para poder borrarlo al actor.
                 * 
                 */
                int valorListBox = (int)peliculas_actoresTableAdapter.ScalarQuery(valorListBoxActor);
                //int valor = Convert.ToInt32(valorListBox);
                if (valorListBox > 1)
                {
                    MessageBox.Show("El actor esta asociado a mas de una pelicula debe eliminar las asociaciones para poder eliminar el actor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            respuesta = MessageBox.Show("desea borrar el registro", "pregunta de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                actoresBindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tbNombre.Focus();
            //numero += 1; // este problema lo intentare solucionar sin usar variables dentro de la clase
            tbNombre.Text = "Introduzca un actor "; //+ numero;
            tbNombre.SelectAll();
        }

        private void tbNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbNombre.Text.Length == 0 | tbNombre.Text == "Introduzca un actor ")
            {
                errorProvider1.SetError(tbNombre, "El campo no puede estar vacio");
                tbNombre.Focus();
                tbNombre.SelectAll();
                e.Cancel = true;

            }
        }

        private void tbNombre_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void pictureBoxActor_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Haz doble click para elegir una imagen", pictureBoxActor, 2000);
        }
    }
}
