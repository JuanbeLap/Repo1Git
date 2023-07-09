using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace _14_6_23_Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Persona> lista = new List<Persona>();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            per.Nombre = txtNombre.Text;
            per.Legajo= int.Parse(txtLegajo.Text);
            per.Edad= int.Parse(txtEdad.Text);
            lista.Add(per);
            Cargar();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lista.Sort();
            dgOrdenado.DataSource = null;
            dgOrdenado.DataSource = lista;
        }
        public void Cargar()
        {
            dg1.DataSource = null;
            dg1.DataSource = lista;
        }
    }
}
