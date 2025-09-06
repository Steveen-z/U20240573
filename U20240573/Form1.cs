using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Nombre: Steveen Antonio Portillo Gomez
//Carnet: U20240573
//Nota = 10

namespace U20240573
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();

            dgvReservas.Columns.Add("Nombre", "Nombre");
            dgvReservas.Columns.Add("DUI", "DUI");
            dgvReservas.Columns.Add("Categoria", "Categoria");
            dgvReservas.Columns.Add("Pelicula", "Pelicula");

            
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnAgregar.Enabled = false;

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPelicula.Items.Clear();

            if (cmbCategoria.SelectedItem == null)
                return; 

            switch (cmbCategoria.SelectedItem.ToString())
            {
                case "ACCIÓN":
                    cmbPelicula.Items.Add("John Wick");
                    cmbPelicula.Items.Add("Mad Max: Fury Road");
                    cmbPelicula.Items.Add("Misión Imposible");
                    cmbPelicula.Items.Add("Gladiador");
                    break;

                case "COMEDIA":
                    cmbPelicula.Items.Add("¿Qué pasó ayer?");
                    cmbPelicula.Items.Add("Son como niños");
                    cmbPelicula.Items.Add("Mi pobre angelito");
                    cmbPelicula.Items.Add("La máscara");
                    break;

                case "DRAMA":
                    cmbPelicula.Items.Add("En busca de la felicidad");
                    cmbPelicula.Items.Add("Titanic");
                    cmbPelicula.Items.Add("El padrino");
                    cmbPelicula.Items.Add("Cadena perpetua");
                    break;

                case "TERROR":
                    cmbPelicula.Items.Add("El conjuro");
                    cmbPelicula.Items.Add("Eso (IT)");
                    cmbPelicula.Items.Add("Actividad paranormal");
                    cmbPelicula.Items.Add("Pesadilla en Elm Street");
                    break;

                case "CIENCIA FICCIÓN":
                    cmbPelicula.Items.Add("Matrix");
                    cmbPelicula.Items.Add("Interestelar");
                    cmbPelicula.Items.Add("Inception");
                    cmbPelicula.Items.Add("Blade Runner 2049");
                    break;

            }
            ActualizarEstadoBoton();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombre.Text == " ")
            {
                MessageBox.Show("Debe ingresar su nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Reserva agregada:\nNombre: {txtNombre.Text}\nCategoria: {cmbCategoria.Text}\nPelicula: {cmbPelicula.Text}",
                            "exitp", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dgvReservas.Rows.Add(txtNombre.Text, mtxDUI.Text, cmbCategoria.SelectedItem.ToString(), cmbPelicula.SelectedItem.ToString());

        
            txtNombre.Clear();
            mtxDUI.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbPelicula.SelectedIndex = -1;
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
          
            cmbCategoria.Items.Clear();
            cmbPelicula.Items.Clear();

           
            cmbCategoria.Items.Add("ACCIÓN");
            cmbCategoria.Items.Add("COMEDIA");
            cmbCategoria.Items.Add("DRAMA");
            cmbCategoria.Items.Add("TERROR");
            cmbCategoria.Items.Add("CIENCIA FICCIÓN");

            cmbCategoria.SelectedIndex = -1;
            cmbPelicula.SelectedIndex = -1;
        }

        private void lblDUI_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            ActualizarEstadoBoton();

        }

        private void ActualizarEstadoBoton()
        {
            bool camposValidos = cmbCategoria.SelectedIndex != -1 &&
                                 cmbPelicula.SelectedIndex != -1 &&
                                 !string.IsNullOrWhiteSpace(txtNombre.Text);

            btnAgregar.Enabled = camposValidos;
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBoton();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
