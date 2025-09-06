using System;

namespace U20240573
{
    partial class frmReservas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservas));
            this.tlpReserva = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelReserva = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblReserva = new System.Windows.Forms.Label();
            this.PicPromociones = new System.Windows.Forms.PictureBox();
            this.mtxDUI = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tlpReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPromociones)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpReserva
            // 
            this.tlpReserva.ColumnCount = 1;
            this.tlpReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReserva.Controls.Add(this.dgvReservas, 0, 2);
            this.tlpReserva.Controls.Add(this.panel1, 0, 0);
            this.tlpReserva.Controls.Add(this.panelReserva, 0, 1);
            this.tlpReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpReserva.Location = new System.Drawing.Point(0, 0);
            this.tlpReserva.Name = "tlpReserva";
            this.tlpReserva.RowCount = 3;
            this.tlpReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpReserva.Size = new System.Drawing.Size(949, 604);
            this.tlpReserva.TabIndex = 0;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.Location = new System.Drawing.Point(3, 425);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.Size = new System.Drawing.Size(943, 176);
            this.dgvReservas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 54);
            this.panel1.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogo.Location = new System.Drawing.Point(333, 14);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(266, 28);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "CINEMARK";
            this.lblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelReserva
            // 
            this.panelReserva.Controls.Add(this.btnAgregar);
            this.panelReserva.Controls.Add(this.lblReserva);
            this.panelReserva.Controls.Add(this.PicPromociones);
            this.panelReserva.Controls.Add(this.mtxDUI);
            this.panelReserva.Controls.Add(this.btnCancelar);
            this.panelReserva.Controls.Add(this.cmbPelicula);
            this.panelReserva.Controls.Add(this.cmbCategoria);
            this.panelReserva.Controls.Add(this.txtNombre);
            this.panelReserva.Controls.Add(this.lblPelicula);
            this.panelReserva.Controls.Add(this.lblCategoria);
            this.panelReserva.Controls.Add(this.lblDUI);
            this.panelReserva.Controls.Add(this.lblNombre);
            this.panelReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReserva.Location = new System.Drawing.Point(3, 63);
            this.panelReserva.Name = "panelReserva";
            this.panelReserva.Size = new System.Drawing.Size(943, 356);
            this.panelReserva.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(323, 278);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 34);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReserva.Location = new System.Drawing.Point(77, 13);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(146, 32);
            this.lblReserva.TabIndex = 12;
            this.lblReserva.Text = "RESERVA";
            this.lblReserva.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // PicPromociones
            // 
            this.PicPromociones.Image = global::U20240573.Properties.Resources.ComboMega;
            this.PicPromociones.Location = new System.Drawing.Point(625, 36);
            this.PicPromociones.Name = "PicPromociones";
            this.PicPromociones.Size = new System.Drawing.Size(292, 276);
            this.PicPromociones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPromociones.TabIndex = 11;
            this.PicPromociones.TabStop = false;
            this.PicPromociones.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mtxDUI
            // 
            this.mtxDUI.Location = new System.Drawing.Point(407, 74);
            this.mtxDUI.Mask = "00000000-0";
            this.mtxDUI.Name = "mtxDUI";
            this.mtxDUI.Size = new System.Drawing.Size(100, 22);
            this.mtxDUI.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(191, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(437, 184);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(121, 24);
            this.cmbPelicula.TabIndex = 7;
            this.cmbPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbPelicula_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(170, 184);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 6;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(355, 184);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(78, 20);
            this.lblPelicula.TabIndex = 3;
            this.lblPelicula.Text = "Pelicula: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(77, 184);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(87, 20);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(353, 74);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(53, 20);
            this.lblDUI.TabIndex = 1;
            this.lblDUI.Text = "DUI: ";
            this.lblDUI.Click += new System.EventHandler(this.lblDUI_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(78, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 604);
            this.Controls.Add(this.tlpReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Reservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.tlpReserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelReserva.ResumeLayout(false);
            this.panelReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPromociones)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelReserva;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.MaskedTextBox mtxDUI;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox PicPromociones;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Button btnAgregar;
    }
}

