using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            listBox1.Visible = false;
            numericUpDown1.Value = (int)RichTxt.Font.Size;
            radioButton2.Checked = true;
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
                  
            CBoxVersiculo.DataSource = ExtraerLibrosCapitulosVersiculos.Totalversiculos(libro, capitulo,siguienteLibro);
            listBox1.DataSource = CBoxVersiculo.Items;
            //listBox1.Height = 200;
        }

        private void CBoxVersiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string SiguienteLibro = null;
            RichTxt.Clear();

            if (CBoxLibro.Text != "APOCALIPSIS")
            {
                SiguienteLibro = Convert.ToString(CBoxLibro.Items[CBoxLibro.Items.IndexOf(CBoxLibro.Text) + 1]);
            }
              RichTxt.Lines = BuscarCitas.BuscarVersiculo(CBoxLibro.Text, Convert.ToInt32(CBoxCapitulo.Text), CBoxVersiculo.Text.Split('\n').ToArray(), SiguienteLibro);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string SiguienteLibro = null;
                if (ModifierKeys != Keys.Control)
                {
                    RichTxt.Clear();

                    if (CBoxLibro.Text != "APOCALIPSIS")
                    {
                        SiguienteLibro = Convert.ToString(CBoxLibro.Items[CBoxLibro.Items.IndexOf(CBoxLibro.Text) + 1]);
                    }

                    RichTxt.Lines = BuscarCitas.BuscarVersiculo(CBoxLibro.Text, Convert.ToInt32(CBoxCapitulo.Text), listBox1.SelectedItems.Cast<string>().ToArray(), SiguienteLibro);
                    checkBox1.Checked = false; 
                }
           
        }
           
       

        private void CBoxVersiculo_DropDown(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
          
            string SiguienteLibro = null;

                RichTxt.Clear();

                if (CBoxLibro.Text != "APOCALIPSIS")
                {
                    SiguienteLibro = Convert.ToString(CBoxLibro.Items[CBoxLibro.Items.IndexOf(CBoxLibro.Text) + 1]);
                }

                RichTxt.Lines = BuscarCitas.BuscarVersiculo(CBoxLibro.Text, Convert.ToInt32(CBoxCapitulo.Text), listBox1.SelectedItems.Cast<string>().ToArray(), SiguienteLibro);
                checkBox1.Checked = false;
         }

        private void RichTxt_TextChanged(object sender, EventArgs e)
        {
            
        }    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

                if (checkBox1.Checked)
                {

                    listBox1.Visible = true;
                }
                else
                {
                    listBox1.Visible = false;

                }
          

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

                if (RichTxt.Text != null)
                {
                    var c = new Font(RichTxt.Font.FontFamily, Convert.ToInt32(numericUpDown1.Value));

                    RichTxt.Font = c;
                    c.Dispose();
                }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                RichTxt.BackColor = Color.White;
                RichTxt.ForeColor = Color.Black;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                RichTxt.BackColor = Color.Black;
                RichTxt.ForeColor = Color.White;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
