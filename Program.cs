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
        /// <remarks>
        /// <b>Nota:</b> El apartado 1, según enunciado no debe llevar espacios, pero según ejemplo tiene espacios internos.<br/>
        /// Incluyo ambas soluciones
        /// </remarks>
        /// <param name="args">
        /// Argumentos, si se ejecuta desde consola (sin uso)
        /// </param>
        public static void Main()
        {
            string original = "ilerna online programación a 2º semestre 2022";

            string upperTrim = original.Trim().ToUpper(); // para apartado 1a
            string upperNoSpaces = ""; // para apartado 1b
            int consTotal = 0; // para apartado 2
            int digitTotal = 0; // para apartado 3
            string consOnly = ""; // para apartado 4

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

            // Versión sin espacios iniciales y finales (como ejemplo)
            Console.WriteLine(upperTrim);

            // Versión sin ningún espacio (enunciado literal)
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
