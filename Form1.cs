using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblia_Reina_valera_Vs._1960.Clases_Extraer_Datos;

namespace Biblia_Reina_valera_Vs._1960
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var lista = ExtraerLibrosCapitulosVersiculos.ExtraerContenido();

            this.CBoxLibro.DataSource = lista.ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          

        }

        private void CBoxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var libro = this.CBoxLibro.Text;

           this.CBoxCapitulo.DataSource = ExtraerLibrosCapitulosVersiculos.TotalCapitulos(libro);

        }

        private void CBoxCapitulo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            var libro = CBoxLibro.Text;
            var capitulo = CBoxCapitulo.Text;
            string siguienteLibro = null;

            if (libro != "APOCALIPSIS") {
                siguienteLibro = Convert.ToString(CBoxLibro.Items[CBoxLibro.Items.IndexOf(libro) + 1]);
             }
                  
            this.CBoxVersiculo.DataSource = ExtraerLibrosCapitulosVersiculos.Totalversiculos(libro, capitulo,siguienteLibro);

        }

        private void CBoxVersiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SiguienteLibro = null;
            RichTxt.Clear();

            if (CBoxLibro.Text != "APOCALIPSIS")
            {
                SiguienteLibro = Convert.ToString(CBoxLibro.Items[CBoxLibro.Items.IndexOf(CBoxLibro.Text) + 1]);
            }
              RichTxt.Lines = BuscarCitas.BuscarVersiculo(CBoxLibro.Text, Convert.ToInt32(CBoxCapitulo.Text), CBoxVersiculo.Text, SiguienteLibro);

        }


    }
}
