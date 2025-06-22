using GestorPersonasEF.Data;
using GestorPersonasEF.Models;
using System.Windows.Forms;

namespace GestorPersonasEF
{
    public partial class MainForm : Form
    {
        bool barraVerticalVisible;

        public MainForm()
        {
            InitializeComponent();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscar.Text.Trim();

            using (var context = new AppDbContext())
            {
                var personasFiltradas = context.Personas
                    .Where(p => p.Nombre.Contains(textoBusqueda))
                    .ToList();

                dataGridView1.DataSource = personasFiltradas;
            }

            AjustarTamañoTotalDataGridView();
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscar.PerformClick();
            }
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var query = db.Personas.AsQueryable();


            if (comboBoxOrden.SelectedItem != null)
            {
                string ordenSeleccionado = comboBoxOrden.SelectedItem.ToString();
                if (ordenSeleccionado == "Nombre")
                {
                    query = checkBoxDescendente.Checked ? query.OrderByDescending(p => p.Nombre) : query.OrderBy(p => p.Nombre);
                }
                else if (ordenSeleccionado == "Edad")
                {
                    query = checkBoxDescendente.Checked ? query.OrderByDescending(p => p.Edad) : query.OrderBy(p => p.Edad);
                }
                else if (ordenSeleccionado == "Id")
                {
                    query = checkBoxDescendente.Checked ? query.OrderByDescending(p => p.Id) : query.OrderBy(p => p.Id);
                }
            }
            dataGridView1.DataSource = query.ToList();
            // Ajustar tamaño del DataGridView al contenido
            AjustarTamañoTotalDataGridView();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            dataGridView1.DataSource = db.Personas.ToList();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Ajustar columnas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Ajustar tamaño del DataGridView al contenido
            AjustarTamañoTotalDataGridView();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var persona = new Persona { Nombre = "Nuevo", Edad = 30 };
            db.Personas.Add(persona);
            db.SaveChanges();
            buttonCargar.PerformClick();

            // Ajustar tamaño del DataGridView al contenido
            AjustarTamañoTotalDataGridView();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    string nombre = row.Cells["Nombre"].Value?.ToString();
                    int edad = Convert.ToInt32(row.Cells["Edad"].Value);

                    var personaExistente = context.Personas.Find(id);
                    if (personaExistente != null)
                    {
                        // Actualizar
                        personaExistente.Nombre = nombre;
                        personaExistente.Edad = edad;
                    }
                    else
                    {
                        // Nueva fila agregada manualmente
                        context.Personas.Add(new Persona { Nombre = nombre, Edad = edad });
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Cambios guardados correctamente");
                this.buttonCargar_Click(sender, e);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Persona persona)
            {
                var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar a {persona.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    using var db = new AppDbContext();
                    db.Personas.Remove(persona);
                    db.SaveChanges();
                    buttonCargar.PerformClick();

                    // Ajustar tamaño del DataGridView al contenido
                    AjustarTamañoTotalDataGridView();
                }            
            }
        }

        private void AjustarTamañoTotalDataGridView()
        {
            AjustarTamañoAnchoDataGridView();
            AjustarTamañoVerticalDataGridView();
        }

        private void AjustarTamañoAnchoDataGridView()
        {
            int totalAncho = 0;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                totalAncho += col.Width;
            }

            // Ajustar el ancho del DataGridView
            dataGridView1.Width = totalAncho + dataGridView1.RowHeadersWidth + 20; // +2 para margen

            AjustarAnchoSegunNumFilas();
        }

        private void AjustarTamañoVerticalDataGridView()
        {
            int totalAlto = dataGridView1.ColumnHeadersHeight;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                totalAlto += fila.Height;
            }

            // Ajustar el alto del DataGridView
            dataGridView1.Height = totalAlto + 2; // +2 para margen

            
        }

        private void AjustarAnchoSegunNumFilas()
        {
            int totalFilas = dataGridView1.Rows.Count;
            if (totalFilas < 9)
            {
                dataGridView1.Width -= 18; // Reducir ancho si hay pocas filas
            }
        }
    }
}
