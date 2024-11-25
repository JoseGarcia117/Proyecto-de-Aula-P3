namespace MediaPlayerJose
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaReproduccion = new System.Windows.Forms.ListBox();
            this.nombreArchivo = new System.Windows.Forms.Label();
            this.etiquetaDuracion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VetanaReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.agregarVideoLista = new System.Windows.Forms.Button();
            this.crearListaReproduccion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VetanaReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCarpetaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirCarpetaToolStripMenuItem
            // 
            this.abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
            this.abrirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.abrirCarpetaToolStripMenuItem.Text = "Abrir carpeta";
            this.abrirCarpetaToolStripMenuItem.Click += new System.EventHandler(this.AbrirCarpetaEvento);
            // 
            // ListaReproduccion
            // 
            this.ListaReproduccion.FormattingEnabled = true;
            this.ListaReproduccion.Location = new System.Drawing.Point(462, 27);
            this.ListaReproduccion.Name = "ListaReproduccion";
            this.ListaReproduccion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListaReproduccion.Size = new System.Drawing.Size(120, 394);
            this.ListaReproduccion.TabIndex = 2;
            this.ListaReproduccion.SelectedIndexChanged += new System.EventHandler(this.ListaReproduccionCambiadaEvento);
            // 
            // nombreArchivo
            // 
            this.nombreArchivo.AutoSize = true;
            this.nombreArchivo.Location = new System.Drawing.Point(12, 428);
            this.nombreArchivo.Name = "nombreArchivo";
            this.nombreArchivo.Size = new System.Drawing.Size(80, 13);
            this.nombreArchivo.TabIndex = 3;
            this.nombreArchivo.Text = "NombreArchivo";
            this.nombreArchivo.Click += new System.EventHandler(this.label1_Click);
            // 
            // etiquetaDuracion
            // 
            this.etiquetaDuracion.AutoSize = true;
            this.etiquetaDuracion.Location = new System.Drawing.Point(459, 428);
            this.etiquetaDuracion.Name = "etiquetaDuracion";
            this.etiquetaDuracion.Size = new System.Drawing.Size(59, 13);
            this.etiquetaDuracion.TabIndex = 4;
            this.etiquetaDuracion.Text = "Duración 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TemporizadorEvento);
            // 
            // VetanaReproductor
            // 
            this.VetanaReproductor.Enabled = true;
            this.VetanaReproductor.Location = new System.Drawing.Point(0, 27);
            this.VetanaReproductor.Name = "VetanaReproductor";
            this.VetanaReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VetanaReproductor.OcxState")));
            this.VetanaReproductor.Size = new System.Drawing.Size(456, 287);
            this.VetanaReproductor.TabIndex = 1;
            this.VetanaReproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.PlayStateChangeEvento);
            this.VetanaReproductor.Enter += new System.EventHandler(this.VetanaReproductor_Enter);
            // 
            // agregarVideoLista
            // 
            this.agregarVideoLista.Location = new System.Drawing.Point(598, 55);
            this.agregarVideoLista.Name = "agregarVideoLista";
            this.agregarVideoLista.Size = new System.Drawing.Size(190, 23);
            this.agregarVideoLista.TabIndex = 5;
            this.agregarVideoLista.Text = "Agregar a lista de reproducción";
            this.agregarVideoLista.UseVisualStyleBackColor = true;
            this.agregarVideoLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // crearListaReproduccion
            // 
            this.crearListaReproduccion.Location = new System.Drawing.Point(598, 84);
            this.crearListaReproduccion.Name = "crearListaReproduccion";
            this.crearListaReproduccion.Size = new System.Drawing.Size(190, 23);
            this.crearListaReproduccion.TabIndex = 6;
            this.crearListaReproduccion.Text = "Crear lista de reproducción";
            this.crearListaReproduccion.UseVisualStyleBackColor = true;
            this.crearListaReproduccion.Click += new System.EventHandler(this.agregarVideoListaEvento);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crearListaReproduccion);
            this.Controls.Add(this.agregarVideoLista);
            this.Controls.Add(this.etiquetaDuracion);
            this.Controls.Add(this.nombreArchivo);
            this.Controls.Add(this.ListaReproduccion);
            this.Controls.Add(this.VetanaReproductor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VetanaReproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer VetanaReproductor;
        private System.Windows.Forms.ListBox ListaReproduccion;
        private System.Windows.Forms.Label nombreArchivo;
        private System.Windows.Forms.Label etiquetaDuracion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button agregarVideoLista;
        private System.Windows.Forms.Button crearListaReproduccion;
    }
}

