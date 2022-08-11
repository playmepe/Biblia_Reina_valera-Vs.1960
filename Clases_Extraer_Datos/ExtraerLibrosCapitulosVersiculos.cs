using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Biblia_Reina_valera_Vs._1960.Properties;

namespace Biblia_Reina_valera_Vs._1960.Clases_Extraer_Datos
{
   public class ExtraerLibrosCapitulosVersiculos
    {
        public static List<string> ExtraerContenido()
        {
            var lista = new List<string>();
        

            //try
            //{
                //using (StreamReader ArchivoTxt = new StreamReader("Biblia_Capitulos.txt"))
                //{
                
                var aray = Resources.Biblia_Capitulos.Split('\n', '\r').ToArray().Where(h => !string.IsNullOrEmpty(h)).ToArray();

                foreach (string value in aray) lista.Add(value.Substring(0, value.IndexOf("[")));

                //while (ArchivoTxt.Peek() > -1)
                //    {

                //        line = ArchivoTxt.ReadLine();

                //        if (!string.IsNullOrEmpty(line))
                //        {
                //            lista.Add(line.Substring(0, line.IndexOf("[")));
                //        }
                //    }

                //    ArchivoTxt.Close();

                    return lista;
                }
            
            //catch (Exception e)
            //{
            //    return lista;
            //    //var H = "Exception: " + e.Message;
            //}

        //}

        public static string[] TotalCapitulos(string libro)
        {
            string [] miarray = new string[0];


            //using (StreamReader ArchivoTxt = new StreamReader("Biblia_Capitulos.txt"))
            //{
                char[] delimiterChars1 = { ',', ' ', '.', ':', '\t', '['};

                var Array = Resources.Biblia_Capitulos.Split('\n', '\r').ToArray().Where(h => !string.IsNullOrEmpty(h)).Where(j=> libro == j.Substring(0, j.IndexOf("[")));

                foreach (var J in Array)
                {
                    miarray = J.Substring(J.IndexOf("[") + 1).Split(delimiterChars1).ToArray();
                    break;
                }


                //while (ArchivoTxt.Peek() > -1)
                //{

                //    var linea = ArchivoTxt.ReadLine();

                //    if (!string.IsNullOrEmpty(linea))
                //    {
                //        if (libro == linea.Substring(0, linea.IndexOf("[")))
                //        {

                //            char[] delimiterChars = { ',', ' ', '.', ':', '\t', '[' };

                //            miarray = linea.Substring(linea.IndexOf("[") + 1).Split(delimiterChars).ToArray();


                //            break;

                //        }
                //    }
                //}

                //ArchivoTxt.Close();


            //}
            return miarray;

        }


        public static string[] Totalversiculos(string libro, string Capitulo,string siguienteLibro = null)
        {
            string miarray = "";
            bool Cbol = false;
            int Numeric = 1;

            using (StreamReader ArchivoTxt = new StreamReader("BIBLIA COMPLETA.txt"))
            {


                while (ArchivoTxt.Peek() > -1)
                {

                    var linea = ArchivoTxt.ReadLine();

                    if (!string.IsNullOrEmpty(linea.Trim()))
                        {

                        if (linea == siguienteLibro) break;
                        if(linea == libro) Cbol = true;

                        if (Cbol)
                        {

                            if (linea.Contains(":"))
                            {
                          
                               if(Capitulo == linea.Substring(0, linea.IndexOf(":"))) miarray += (Numeric++) + "\n";

                            }

                        }
                    }
                }

                ArchivoTxt.Close();

            }
                  
            return miarray.Trim().Split('\n').ToArray();

        }



    }
}

