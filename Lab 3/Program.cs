namespace Lab03_A2_Ana_Fuentes
{
    internal class Program
    {
        static void Main()
        {
            // Solicitar datos
            Console.WriteLine("Ingrese el nombre del estudiante:");
            string? nombreEstudiante = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del curso:");
            string? nombreCurso = Console.ReadLine();

            // Mostrar los datos
            Console.WriteLine();
            Console.WriteLine(nombreCurso);
            Console.WriteLine(
                (nombreEstudiante ?? "Estudiante") +
                ", espero que te esté gustando el curso de " +
                (nombreCurso ?? "el curso") +
                " tanto como a mí."
            );

            Console.WriteLine("Nunca dejes de practicar, ya que veo que vas por buen camino.");
            Console.WriteLine("Ya puedes continuar con tu día. Adiós");

            // Finalizar programa
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}