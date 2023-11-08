using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace lsta_de_peliculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            string titulo = TituloTextBox.Text;
            string director = directorTextBox.Text;
            string genero = generoTextBox.Text;

            if (int.TryParse(añoTextBox.Text, out int anio))
            {
                
                dataGridPelicula.Rows.Add(titulo, director, anio, genero);

                
                TituloTextBox.Clear();
                directorTextBox.Clear();
                añoTextBox.Clear();
                generoTextBox.Clear();
            }
            else
            {
                MessageBox.Show("El año debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridPelicula.SelectedRows.Count > 0)
    {
        
        DataGridViewRow filaSeleccionada = dataGridPelicula.SelectedRows[0];

       
        string titulo = filaSeleccionada.Cells["Titulo"].Value.ToString();
        string director = filaSeleccionada.Cells["Director"].Value.ToString();
        int anio = Convert.ToInt32(filaSeleccionada.Cells["Año"].Value);
        string genero = filaSeleccionada.Cells["Género"].Value.ToString();

        
        TituloTextBox.Text = titulo;
        directorTextBox.Text = director;
        añoTextBox.Text = anio.ToString();
        generoTextBox.Text = genero;

       
        dataGridPelicula.Rows.Remove(filaSeleccionada);
    }
}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridPelicula.SelectedRows.Count > 0) ;
        }
    } 
 
}
    
    
