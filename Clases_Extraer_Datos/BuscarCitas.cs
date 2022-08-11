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

        public static String[] BuscarVersiculo(string libro, int Capitulo, string[] Versiculo, string siguienteLibro)
        {

            string miarray = ""; string[] array; string H = null;
            bool Cbol = false, cbol2 = false;

            using (
                StreamReader ArchivoTxt = new StreamReader("BIBLIA COMPLETA.txt"))
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
                                if (linea.StartsWith(Capitulo + ":")) linea = linea.Substring(Capitulo.ToString().Length + 1);

                                if (Regex.IsMatch(linea.Substring(0, 1), @"^[0-9]+$"))
                                {
                                    miarray += "_" + linea + " ";
                                }
                                else{
                                    if(miarray.Trim().EndsWith(".")) miarray += "\n"+linea + " "; else  miarray += linea + " ";
                                }
                            }

                        }
                    }
                }

            
                ArchivoTxt.Close();
            }


            if (Versiculo.Length == 1)
            {
                array = miarray.Trim().Split('_').ToArray().Where(I => I.StartsWith(Versiculo.First() + " ")).ToArray();
            }
            else {
             
                foreach (var i in Versiculo)
                {
                    foreach (var j in miarray.Split('_').ToArray())
                    {
                        if (j.StartsWith(i + " ")) H += j + "\n"+"\n";
                    }

                }

                array = H.Split('\n').ToArray();
            }


            return array;

        }


    }
}
