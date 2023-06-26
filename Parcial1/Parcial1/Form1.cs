using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa empresa = new Empresa();
        
        private void AltaPersonal_Click(object sender, EventArgs e)
        {
            


            //Auxi empleado;
            switch (cbTiposPersonal.SelectedItem.ToString())
            {
                case "Auxiliar": 
                     Auxi empleado = new Auxi();

                    empleado.Nombre = txtNombre.Text;
                    empleado.Tipo = cbTiposPersonal.SelectedItem.ToString();
                    empleado.Horas = int.Parse(txtHoras.Text);
                    empleado.Sueldo = 78.500f;
                    empresa.listaAux.Add(empleado);
                    MessageBox.Show($"{empleado.Nombre}, {empleado.Tipo} {empleado.Horas},{empleado.Sueldo}");
                    break;

                case "Modelo":
                    Modelo empMod = new Modelo();

                    empMod.Nombre = txtNombre.Text;
                    empMod.Tipo = cbTiposPersonal.SelectedItem.ToString();
                    empMod.Horas = int.Parse(txtHoras.Text);
                    empMod.Sueldo = 78.500f;
                    empresa.listaMod.Add(empMod);
                    break;

                case "Publicitario":
                    Pub empPub = new Pub();
                    empPub.Nombre = txtNombre.Text;
                    empPub.Tipo= cbTiposPersonal.SelectedItem.ToString();
                    empPub.Horas = int.Parse(txtHoras.Text);
                    //empPub.Sueldo = 
                    empresa.listaPub.Add(empPub);
                    break;

                case "Presentador":
                    Pres empPres = new Pres();
                    empPres.Nombre = txtNombre.Text;
                    empPres.Tipo = cbTiposPersonal.SelectedItem.ToString();
                    empPres.Horas = int.Parse(txtHoras.Text);
                    //empPres.Suedo =;
                    empresa.listaPres.Add(empPres);
                    
                    break;




            }

            CargarList();
        }

        void CargarList()
        {
            List<Personal> listaEmpleados = new List<Personal>();
            listaEmpleados.AddRange(empresa.listaAux);
            listaEmpleados.AddRange(empresa.listaMod);
            listaEmpleados.AddRange(empresa.listaPub);
            listaEmpleados.AddRange(empresa.listaPres);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaEmpleados;
            
        }
    }
}
