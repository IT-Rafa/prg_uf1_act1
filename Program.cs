using System;
namespace Act_1_UF_1
{
    /**
    <summary>
    Actividad 1 de desarrollo (UF1) - Esta clase contiene la solución del ejercicio planteado.
    </summary>
    <remarks>
        <b>Enunciado</b><br/>
         El programa consiste en trabajar con una variable que contiene la información:<br/>
         “ilerna online programacion a 2º semestre 2022”<br/>
         Se pide:
         <list type="number">
             <item>
             <description>Imprimir por consola la variable en mayúsculas sin espacios</description>
             </item>
             <item>
             <description>Imprimir por consola el total de consonantes de la variable</description>
             </item>
             <item>
             <description>Imprimir por consola el total de números que tiene la variable</description>
             </item>
             <item>
             <description>Imprimir por consola solo las consonantes y en el orden que las va encontrando</description>
             </item>
        </list>
    </remarks>
    */
    public class Program
    {
        /// <summary>
        /// Calcula y muestra el resultado del ejercicio
        /// </summary>
        /// <param name="args">
        /// Argumentos, si se ejecuta desde consola (sin uso)
        /// </param>
        public static void Main()
        {
            string original = "ilerna online programacion a 2º semestre 2022";

            // Variable ap1: mayúsculas sin espacios (ni siquiera intermedios)
            string upperNoSpaces = "";
            // Variable ap2: total de consonantes
            int consTotal = 0;
            // Variable ap3: total números
            int digitTotal = 0;
            // Variable ap4: consonantes en orden
            string consOnly = "";

            //trabajar con una variable que contiene la información: 
            // “ilerna online programacion a 2º semestre 2022”
            Console.WriteLine("variable = \"" + original + '\"');

            // Preparamos datos
            foreach (char l in original)
            {
                // Apartado 1b; (Sin NINGÚN espacio)
                if (l != ' ')
                {
                    upperNoSpaces += Char.ToUpper(l);
                }

                // Apartado 2, 3, 4
                if (Char.IsLetter(l))
                {
                    switch (l)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'á':// Incluimos tildes aunque no existan en el código
                        case 'é':
                        case 'í':
                        case 'ó':
                        case 'ú':
                        case 'º': // Según unicode º y ª son letras, pero no las contemplamos
                        case 'ª':
                            break;
                        default:
                            consTotal++; // Apartado  2
                            consOnly += l;  // Apartado 4
                            break;
                    }
                }
                else if (char.IsDigit(l))
                {
                    digitTotal++;  // Apartado  3
                }



            }

            Console.WriteLine();
            // APARTADO 1
            Console.WriteLine("1º) Imprimir por consola la variable en mayúsculas sin espacios");
            Console.WriteLine(upperNoSpaces);

            Console.WriteLine();
            // APARTADO 2
            Console.WriteLine("2º) Imprimir por consola el total de consonantes de la variable");
            Console.WriteLine("Tiene " + consTotal + " consonantes");

            Console.WriteLine();
            // APARTADO 3
            Console.WriteLine("3º) Imprimir por consola el total de números que tiene la variable");
            Console.WriteLine("Tiene " + digitTotal + " números");

            Console.WriteLine();
            // APARTADO 4
            Console.WriteLine("4º) Imprimir por consola solo las consonantes y en el orden que las va encontrando.");
            Console.WriteLine(consOnly);
        }
    }
}
