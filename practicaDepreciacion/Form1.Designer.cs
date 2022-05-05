namespace practicaDepreciacion
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txutil = new System.Windows.Forms.TextBox();
            this.txvalorr = new System.Windows.Forms.TextBox();
            this.txvalor = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(18, 28);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(65, 20);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 296);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 255);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID para borrar o actualizar";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(407, 72);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(148, 26);
            this.numericUpDown1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txutil);
            this.panel1.Controls.Add(this.txvalorr);
            this.panel1.Controls.Add(this.txvalor);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(297, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 201);
            this.panel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "vida util";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "valor residual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "valor";
            // 
            // txutil
            // 
            this.txutil.Location = new System.Drawing.Point(129, 172);
            this.txutil.Name = "txutil";
            this.txutil.Size = new System.Drawing.Size(100, 26);
            this.txutil.TabIndex = 8;
            this.txutil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txutil_KeyPress);
            // 
            // txvalorr
            // 
            this.txvalorr.Location = new System.Drawing.Point(129, 124);
            this.txvalorr.Name = "txvalorr";
            this.txvalorr.Size = new System.Drawing.Size(100, 26);
            this.txvalorr.TabIndex = 7;
            this.txvalorr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txvalorr_KeyPress);
            // 
            // txvalor
            // 
            this.txvalor.Location = new System.Drawing.Point(129, 78);
            this.txvalor.Name = "txvalor";
            this.txvalor.Size = new System.Drawing.Size(100, 26);
            this.txvalor.TabIndex = 6;
            this.txvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txvalor_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoActivoToolStripMenuItem,
            this.borrarActivoToolStripMenuItem,
            this.actualizarActivoToolStripMenuItem,
            this.salirDeLaAplicacionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoActivoToolStripMenuItem
            // 
            this.nuevoActivoToolStripMenuItem.Name = "nuevoActivoToolStripMenuItem";
            this.nuevoActivoToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.nuevoActivoToolStripMenuItem.Text = "nuevo activo";
            this.nuevoActivoToolStripMenuItem.Click += new System.EventHandler(this.nuevoActivoToolStripMenuItem_Click);
            // 
            // borrarActivoToolStripMenuItem
            // 
            this.borrarActivoToolStripMenuItem.Name = "borrarActivoToolStripMenuItem";
            this.borrarActivoToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.borrarActivoToolStripMenuItem.Text = "borrar activo";
            this.borrarActivoToolStripMenuItem.Click += new System.EventHandler(this.borrarActivoToolStripMenuItem_Click);
            // 
            // actualizarActivoToolStripMenuItem
            // 
            this.actualizarActivoToolStripMenuItem.Name = "actualizarActivoToolStripMenuItem";
            this.actualizarActivoToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.actualizarActivoToolStripMenuItem.Text = "actualizar activo";
            this.actualizarActivoToolStripMenuItem.Click += new System.EventHandler(this.actualizarActivoToolStripMenuItem_Click);
            // 
            // salirDeLaAplicacionToolStripMenuItem
            // 
            this.salirDeLaAplicacionToolStripMenuItem.Name = "salirDeLaAplicacionToolStripMenuItem";
            this.salirDeLaAplicacionToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.salirDeLaAplicacionToolStripMenuItem.Text = "salir de la aplicacion";
            this.salirDeLaAplicacionToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicacionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "AcivoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txutil;
        private System.Windows.Forms.TextBox txvalorr;
        private System.Windows.Forms.TextBox txvalor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeLaAplicacionToolStripMenuItem;
    }
}

