using System.Text.RegularExpressions;

namespace CuentaPalabras.Models
{
    public class Conteo
    {
        public Dictionary<String, int> contar(string texto)
        {  
            Dictionary<String, int> diccionario = new Dictionary<string, int>();
            if(!String.IsNullOrEmpty(texto))
            {
                String[] palabras = Regex.Split(texto, @"[^A-zÀ-ú]+");
                foreach (String palabra in palabras)
                {
                    if(!String.IsNullOrEmpty(palabra))
                    {
                        String palabraMinus = palabra.ToLower();
                        if(!diccionario.ContainsKey(palabraMinus))
                        {
                            diccionario.Add(palabraMinus, 1);
                        }
                        else
                        {
                            diccionario[palabraMinus] = diccionario[palabraMinus] + 1;
                        }
                    }
                }
            }
            return diccionario;
        }
    }
}