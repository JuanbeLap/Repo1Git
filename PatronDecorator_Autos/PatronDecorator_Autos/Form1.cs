using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Patrones;  
namespace PatronDecorator_Autos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List <object> TipoModelo = new List<object>();
        private void btnCargar_Click(object sender, EventArgs e)
        {
           switch (cbModelo.SelectedItem)
            {
                case "Ka": 
                    Ka ka = new Ka();
                    txtResult.Text = $"Auto: {ka.Descripcion} \tCosto: {ka.Costo}";
                    TipoModelo.Add(ka);
                    break;
                    case "Fiesta":
                    Fiesta fiesta = new Fiesta();
                    txtResult.Text = $"Auto:{fiesta.Descripcion} \tCosto: {fiesta.Costo}";
                    TipoModelo.Add(fiesta);
                    break;
                    case "Focus":
                    Focus focus = new Focus();
                    txtResult.Text = $"Auto: {focus.Descripcion} \tCosto: {focus.Costo}";
                    TipoModelo.Add(focus);
                    break;
                    case "Ranger":
                    Ranger ranger = new Ranger();
                    txtResult.Text = $"Auto: {ranger.Descripcion} \tCosto: {ranger.Costo}";
                    TipoModelo.Add(ranger);
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                {
                    ListCheckBox.Visible= true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            List <object> funcionalidades = new List<object>();
            foreach (object item in ListCheckBox.CheckedItems)
            {
                funcionalidades.Add(item);
            }
            foreach (object funcionalidad in funcionalidades )
            {
                switch (funcionalidad)
                {
                    case "Llantas":

                        Llantas llantas = new Llantas((Biblioteca_Patrones.AutoComponent)TipoModelo[0]);
                        txtResult.Text = $"Auto: {llantas.Descripcion} \tCosto: {llantas.Costo}";

                        break;
                    case "Levanta vidrios":

                        Levanta_vidrios lv = new Levanta_vidrios((Biblioteca_Patrones.AutoComponent)TipoModelo[0]);
                        txtResult.Text = $"Auto: {lv.Descripcion} \tCosto: {lv.Costo}";

                        break;

                    case "Stereo tactil":
                        Stereo_tactil st = new Stereo_tactil((Biblioteca_Patrones.AutoComponent)TipoModelo[0]);
                            txtResult.Text = $"Auto: {st.Descripcion} \tCosto: {st.Costo}";
    
                            break;
                }
            }

        }
    }
}
