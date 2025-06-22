namespace GestorPersonasEF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            buttonCargar = new Button();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonGuardar = new Button();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            comboBoxOrden = new ComboBox();
            checkBoxDescendente = new CheckBox();
            buttonOrdenar = new Button();
            buttonExportarCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 79);
            dataGridView1.MaximumSize = new Size(421, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(421, 226);
            dataGridView1.TabIndex = 0;
            // 
            // buttonCargar
            // 
            buttonCargar.Location = new Point(37, 332);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(75, 23);
            buttonCargar.TabIndex = 1;
            buttonCargar.Text = "Cargar";
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(133, 370);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(230, 370);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(36, 370);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(193, 21);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(54, 23);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(37, 21);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(130, 23);
            textBoxBuscar.TabIndex = 7;
            textBoxBuscar.KeyDown += textBoxBuscar_KeyDown;
            // 
            // comboBoxOrden
            // 
            comboBoxOrden.FormattingEnabled = true;
            comboBoxOrden.Items.AddRange(new object[] { "Nombre", "Edad", "Id" });
            comboBoxOrden.Location = new Point(269, 21);
            comboBoxOrden.Name = "comboBoxOrden";
            comboBoxOrden.Size = new Size(107, 23);
            comboBoxOrden.TabIndex = 8;
            // 
            // checkBoxDescendente
            // 
            checkBoxDescendente.AutoSize = true;
            checkBoxDescendente.Location = new Point(391, 24);
            checkBoxDescendente.Name = "checkBoxDescendente";
            checkBoxDescendente.Size = new Size(100, 19);
            checkBoxDescendente.TabIndex = 9;
            checkBoxDescendente.Text = "Orden inverso";
            checkBoxDescendente.UseVisualStyleBackColor = true;
            // 
            // buttonOrdenar
            // 
            buttonOrdenar.Location = new Point(337, 50);
            buttonOrdenar.Name = "buttonOrdenar";
            buttonOrdenar.Size = new Size(75, 23);
            buttonOrdenar.TabIndex = 10;
            buttonOrdenar.Text = "Ordenar";
            buttonOrdenar.UseVisualStyleBackColor = true;
            buttonOrdenar.Click += buttonOrdenar_Click;
            // 
            // buttonExportarCSV
            // 
            buttonExportarCSV.Location = new Point(133, 332);
            buttonExportarCSV.Name = "buttonExportarCSV";
            buttonExportarCSV.Size = new Size(104, 23);
            buttonExportarCSV.TabIndex = 11;
            buttonExportarCSV.Text = "Exportar a CSV";
            buttonExportarCSV.UseVisualStyleBackColor = true;
            buttonExportarCSV.Click += this.buttonExportarCSV_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(484, 427);
            Controls.Add(buttonExportarCSV);
            Controls.Add(buttonOrdenar);
            Controls.Add(checkBoxDescendente);
            Controls.Add(comboBoxOrden);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonCargar);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(500, 380);
            Name = "MainForm";
            Text = "Gestion de personas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonCargar;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonGuardar;
        private Button buttonBuscar;
        private TextBox textBoxBuscar;
        private ComboBox comboBoxOrden;
        private CheckBox checkBoxDescendente;
        private Button buttonOrdenar;
        private Button buttonExportarCSV;
    }
}
