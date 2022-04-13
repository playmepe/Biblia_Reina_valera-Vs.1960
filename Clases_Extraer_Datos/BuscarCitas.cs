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
    class BuscarCitas
    {

        public static String [] BuscarVersiculo(string libro,int Capitulo,string Versiculo,string siguienteLibro)
        {

            string miarray = "";
            bool Cbol = false, cbol2 = false;

            
            using (StreamReader ArchivoTxt = new StreamReader("BIBLIA COMPLETA.txt"))
            {


                while (ArchivoTxt.Peek() > -1)
                {

                    var linea = ArchivoTxt.ReadLine().Trim();

                    if (!string.IsNullOrEmpty(linea))
                    {

                        if (linea == siguienteLibro) break;
                        if (linea == libro) Cbol = true;

                        if (Cbol)
                        {

                            if (linea == "Capítulo " + (Capitulo + 1)) break;

                            if ("Capítulo " + Capitulo == linea) cbol2 = true;
                            if (cbol2 && !linea.Contains("Epístola "))
                            {

                                //if (linea.Contains(":") && Regex.IsMatch(linea.Substring(0, 1), @"^[0-9]+$")) 
                                //    {

                                //    var cita = Capitulo + ":" + Versiculo + " ";
                                if (Regex.IsMatch(linea.Substring(0, 1), @"^[0-9]+$"))
                                    miarray += "\n" + linea + "\n" ;
                                else miarray += linea + "\n";
                                //    if (Capitulo.ToString() == linea.Substring(0, linea.IndexOf(":"))) miarray += linea + "\n";
                                //    //if (cita == linea.Substring(0, linea.IndexOf(" ")+1)) miarray += linea + "\n";

                                    //}
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
