using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
using System.IO;

namespace catalogocine
{
    public partial class Form1 : Form
    {
        //variable anio que la utilizo en el metodo AddNewItem y el de guardar
        int anio;
        //valor de la listbox de las peliculas 
        int valorListBox1;
        //valor del actor seleccionado en la combobox de los actores para añadirlos
        int valorcbActores; 

        public Form1()
        {
            InitializeComponent();
        }

        private void pegarbtBar_Click(object sender, EventArgs e)
        {
            /*
            tbTituloOriginal.Paste();
            tbTituloTraducido.Paste();
            tbDirector.Paste();
            tbDirector2.Paste();
           
            tbUrl.Paste();
            
            tbDescripcion.Paste();
            tbComentarios.Paste();
            */
        }

        private void cortarbtBar_Click(object sender, EventArgs e)
        {
           
            /*
            tbTituloOriginal.Cut();
            tbTituloTraducido.Cut();
            tbDirector.Cut();
            tbDirector2.Cut();
           
            tbUrl.Cut();
        
            tbDescripcion.Cut();
            tbComentarios.Cut();
            */
        }

        private void copiarbtBar_Click(object sender, EventArgs e)
        {
            
            
            /*
            tbTituloOriginal.Copy();
            tbTituloTraducido.Copy();
            tbDirector.Copy();
            tbDirector2.Copy();
          
            tbUrl.Copy();
            
            tbDescripcion.Copy();
            tbComentarios.Copy();
            */
        }

        private void salirMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cineDataSet.actores' Puede moverla o quitarla según sea necesario.
            this.actoresTableAdapter1.Fill(this.cineDataSet.actores);
            // TODO: esta línea de código carga datos en la tabla 'catalogocineDataSet.actores' Puede moverla o quitarla según sea necesario.
            this.actoresTableAdapter.Fill(this.catalogocineDataSet.actores);
            // TODO: esta línea de código carga datos en la tabla 'catalogocineDataSet.peliculas_actores' Puede moverla o quitarla según sea necesario.
            this.peliculas_actoresTableAdapter.Fill(this.catalogocineDataSet.peliculas_actores);
            // TODO: esta línea de código carga datos en la tabla 'catalogocineDataSet.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.catalogocineDataSet.peliculas);
            //asigno la variable textocbActores con un valor y la utilizo en la cbActores.Text
            string textocbActores = "Presione para elegir un actor";
            cbActores.Text = textocbActores;
            
        }

        private void tbDirector_Validating(object sender, CancelEventArgs e)
        {
            if (tbDirector.Text.Length == 0 | tbDirector.Text == "Introduzca un director")
            {
                errorProvider1.SetError(tbDirector, "No puede estar vacio este campo");
                //MessageBox.Show("Tiene que poner un director minimo", "Obligatorio poner un director", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbDirector.SelectAll();
                tbDirector.Focus();
                e.Cancel = true;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //variables que uso en este metodo solamente existen en este metodo


            //comprobar que todos los checkbox estan unchecked y los que no lo estan se pondran uncheked
            /*
            if (cbAccion.Checked && cbDrama.Checked && cbHistorica.Checked && cbSuspense.Checked &&
                cbRomance.Checked && cbOeste.Checked && cbFantasia.Checked &&
                cbHorror.Checked && cbCFiccion.Checked && cbBelica.Checked)
            {
            */
            cbAccion.Checked = false;
            cbDrama.Checked = false;
            cbHistorica.Checked = false;
            cbSuspense.Checked = false;
            cbRomance.Checked = false;
            cbOeste.Checked = false;
            cbFantasia.Checked = false;
            cbHorror.Checked = false;
            cbCFiccion.Checked = false;
            cbBelica.Checked = false;
            //}

            //estructura de datos date1 y obtengo la fecha actual
            DateTime date1 = DateTime.Now;
            //obtener de la fecha el año que es lo que necesito el dato es entero
            anio = date1.Year;
            //el numericUpDown1 obtiene el valor del año 
            numericUpDown1.Value = anio;
            //Convert.ToInt32(numericUpDown1.Value) = anio;
            //int numero = 0;
            // en el caso de que no ponga datos el usuario el boton nos pone eso

            
            
            tbTituloOriginal.Focus();
            //numero += 1; // este problema lo intentare solucionar sin usar variables dentro de la clase
            tbTituloOriginal.Text = "Introduzca un titulo "; //+ numero;
            tbTituloOriginal.SelectAll();
            
            
            
            tbDirector.Text = "Introduzca un director";
            
           
            
        }

        //delegate void EventHandler(object sender, EventArgs e);
        
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            /* preguntar al usuario si quiere o no borrar el registro de la pelicula,
             * y si dice que si se ejecuta el metodo peliculasBindingSource.RemoveCurrent();
             * 
             */
            DialogResult respuesta;
            respuesta = MessageBox.Show("desea borrar el registro", "pregunta de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                peliculasBindingSource.RemoveCurrent();
            }
            
            
           
        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.UpButton();
            numericUpDown1.DownButton();
            numericUpDown2.UpButton();
            numericUpDown2.DownButton();
            
            
            //numericUpDown1.Value = anio;
            
           
            
            if (! cbAccion.Checked && !cbDrama.Checked && !cbHistorica.Checked && !cbSuspense.Checked &&
                !cbRomance.Checked && !cbOeste.Checked && !cbFantasia.Checked &&
                !cbHorror.Checked && !cbCFiccion.Checked  && !cbBelica.Checked)
            {
                MessageBox.Show("Todas las peliculas tienen un genero hay que poner un genero como minimo",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            
            if (this.Validate())
            {
                try
                {
                    /*estableciendo la propiedad de updatecommand del DataAdapter 
                     * sin utilizar la generacion automatica de comandos
                    */
                    
                    this.peliculasBindingSource.EndEdit();
                    //antes de actualizar tengo que comprobar varios campos
                    this.peliculasTableAdapter.Update(this.catalogocineDataSet.peliculas);
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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
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
                        pictureBox1.ImageLocation = sImagen;
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(IOException ex) 
                    {
                        MessageBox.Show(ex.Message);
                    }
                      
                  
                    imagenStream.Close();
                 
                    
                }
                

            }


        }

      

        private void tbTituloOriginal_Validating(object sender, CancelEventArgs e)
        {
            // vamos a utilizar la propiedad CancelEventArgs.
            // yo quiero que si esas condiciones son ciertas que no se validen los datos basicamente 

            if (tbTituloOriginal.Text.Length == 0 | tbTituloOriginal.Text == "Introduzca un titulo ")
            {
                errorProvider1.SetError (tbTituloOriginal, "El título no puede estar vacio");
                tbTituloOriginal.Focus();
                tbTituloOriginal.SelectAll();
                e.Cancel = true;
                
            }
            
                    
        }

        private void tbTituloOriginal_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
        }

        private void acercaDeCinemaGalleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe AcercaDe = new AcercaDe();
            AcercaDe.ShowDialog();
            
        }

        private void tbDirector_Click(object sender, EventArgs e)
        {
            tbDirector.Select();
        }

        private void tbDirector_DoubleClick(object sender, EventArgs e)
        {
            tbDirector.SelectAll();
        }

        private void tbDirector_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // este toolTip1 se mostrara en el pictureBox1 durante 2000 milisegundos = 2 segundos 
            toolTip1.Show("doble Click para seleccionar una imagen",pictureBox1, 2000);
        }
        /*
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            /* este codigo si valida el formulario prueba a aplicar los cambios en 
             * actoresBindingSource y despues actualiza el origen de datosc con 
             * actoresBindingSource
             */
        /*
            if (this.Validate())
            {
                try
                {
                    
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
        */
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            /* El valor seleccionado lo meto en la variable Object valorSeleccionado
             * convierto valorSeleccionado a entero y lo meto en otra variable
             * y la variable valorListBox1 que es la que me interesa la tengo como int 
             * en la clase.
             * actoresTableAdapter.FillByidpelicula con ese metodo del TableAdapter 
             * cada vez que el usuario cambie de pelicula, se hara esa consulta a la
             * base de datos y se rellenran los actores que esten asociados a esa pelicula,
             * si no hay actores pues logicamente no mostrara actores.
             */
            object valorSeleccionado;
            valorSeleccionado = listBox1.SelectedValue;
            int valor = Convert.ToInt32(valorSeleccionado);
            valorListBox1 = valor;

            try
            {
                actoresTableAdapter.FillByidpelicula(catalogocineDataSet.actores, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "fallo al buscar pelicula");
            }
           
            /*string cityValue = "Seattle";
            customersTableAdapter.FillByCity(northwindDataSet.Customers, cityValue);
            */
        }
        
        private void peliculasConActoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // creacion del objeto y mostrar el objeto que en nuestro caso es un formulario
            PeliculasActores peliculasActores = new PeliculasActores();
            peliculasActores.Show();


        }


        private void toolStripBtBuscar_Click(object sender, EventArgs e)
        {
            /* Este metodo esta pensado para cuando se pulse el boton toolStripbtBuscar, 
             * evalue si estan las 2 expresiones Titulo o Actor que son las que se pueden 
             * elegir.
             * 
             */
            if (toolStripComboBoxBuscar.Text == "Título")
            {
                try
                {
                    if (toolStripTextBoxBuscar.Text != "")
                    {
                        peliculasTableAdapter.FillByTitulos(catalogocineDataSet.peliculas, "%" + toolStripTextBoxBuscar + "%");
                    }
                    else
                    {
                        peliculasTableAdapter.Fill(catalogocineDataSet.peliculas);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
            else if (toolStripComboBoxBuscar.Text == "Actor")
            {
                try
                {
                    if (toolStripTextBoxBuscar.Text != "")
                    {
                        actoresTableAdapter.FillByNombreApellidos(catalogocineDataSet.actores, "%" + toolStripTextBoxBuscar + "%");
                    }
                    else
                    {
                        actoresTableAdapter.Fill(catalogocineDataSet.actores);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
           
        }

      

        private void btActores_Click(object sender, EventArgs e)
        {
            FormActores Actores = new FormActores();
            Actores.Show();
        }

        private void tbDuraccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(tbDuraccion, "solo se admiten numeros enteros");
            }
            if (e.KeyChar == Convert.ToChar(8))
            {
                e.Handled = false;
            }
        }

        private void btAñadirActorPelicula_MouseEnter(object sender, EventArgs e)
        {
            //usamos tooltip para mostrar que el boton es para añadir actores a esa pelicula
            toolTip1.Show("Añadir actores para la pelicula seleccionada en la lista", btAñadirActorPelicula, 2000);
            
        }

        private void cbActores_SelectedValueChanged(object sender, EventArgs e)
        {
            /* obtener el valorSeleccionado de la listbo
             *
             * 
             */
            object valorSeleccionado;
            valorSeleccionado = cbActores.SelectedValue;
            int valor = Convert.ToInt32(valorSeleccionado);
            //variable que esta dentro de la clase           
            valorcbActores = valor;
        }

        private void btAñadirActorPelicula_Click(object sender, EventArgs e)
        {
            //boton que inserta un registro en la base de datos 
            try
            {
                peliculas_actoresTableAdapter.InsertQuery(valorcbActores, valorListBox1);
                //despues de insertarlo vamos a hacer un update en la base de datos
                
                peliculas_actoresTableAdapter.Update(catalogocineDataSet.peliculas_actores);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbActores_Leave(object sender, EventArgs e)
        {
            //cuando deje de ser el control activo del formulario se pondra de nuevo la cadena de texto
            string textocbActores = "Presione para elegir un actor";
            cbActores.Text = textocbActores;
        }

        private void cbActores_Click(object sender, EventArgs e)
        {
            //instanciar el objeto del actoresTableAdapter del cineDataSet
            catalogocine.cineDataSetTableAdapters.actoresTableAdapter actoresTableAdapter = new catalogocine.cineDataSetTableAdapters.actoresTableAdapter();
            try
            {
                actoresTableAdapter.Fill(cineDataSet.actores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActores Actores = new FormActores();
            Actores.ShowDialog();
        }

        private void ayudaDeCinemaGalleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.techcomputerworld.com/index.php?option=com_content&view=article&id=54:ayuda-cinema-gallery&catid=40:ayuda-net&Itemid=55");
        }
        /*
        private void btDelete_MouseEnter(object sender, EventArgs e)
        {
            //usamos tooltip para mostrar que el boton es para añadir actores a esa pelicula
            toolTip1.Show("Borrar actores para la pelicula seleccionada en la lista", btDelete, 2000);
        }
        */        
        private void actoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormActores Actores = new FormActores();
            Actores.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //metodo que usaremos para borrar los actores de las peliculas
            //this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
                
            try
            {
                peliculas_actoresTableAdapter.DeleteQuery(valorListBox1, valorcbActores);
                peliculas_actoresTableAdapter.Update(catalogocineDataSet.peliculas_actores);
                //dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /* sacamos el id_actor que de primeras es un objeto logicamente porque el metodo CurrentRow.Cells["id_actor"].Value 
             * devuelve un objeto y ahora procederemos a convertirlo en numero entero con la clase Convert
             * 
             * 
             */
            //DataGridViewRow dataGridViewRow = new DataGridViewRow();
            //object CurrectRow = dataGridView1.CurrentRow;
            //object DataGridViewRow = dataGridView1.CurrentRow;
            
            //DataGridViewRow row = dataGridView1.CurrentRow;

            //DataGridViewRow dataGridViewRow = new DataGridViewRow();
            DataGridViewRow valueid = new DataGridViewRow();

            if (valueid != null)

            valueid = dataGridView1.CurrentRow.Cells["id_actor"].Value;
            string valueidactor = valueid.ToString();
            int valorIdActor = Convert.ToInt32(valueidactor);
            
 

            //MessageBox.Show(dgvr.Cells("CompanyNameDataGridVie wTextBoxColumn").Value.ToString())

            
            //object listActores = actoresBindingSource.List;
            //object CurrentRow = actoresBindingSource.Current;
            //int idregistro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_actor"].Value);
            /* este codigo no funciona de ninguna de las formas posibles tengo que probar con otro codigo
            try
            {
                object valorId = (object)dataGridView1.CurrentRow.Cells["id_actor"].Value;
                int valorIdActores = Convert.ToInt32(valorId);
                valorcbActores = valorIdActores;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
            
            /*
            object filaActual = this.dataGridView1.CurrentRow;
            int valorFila = Convert.ToInt32(filaActual);
            valorcbActores = valorFila;
            */
        }

    } //fin de la clase Form1


        

       

       

     



        

        

      
        

      

       
        



  

      
    }

