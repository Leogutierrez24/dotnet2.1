Escuela escuela = new Escuela("Escuela n° 24", 1990, TipoEscuela.Primaria, "Argentina", "Buenos Aires");

Curso curso01 = new Curso
{
    Nombre = "1A",
};

Curso curso02 = new Curso
{
    Nombre = "2A",
};

Curso curso03 = new Curso
{
    Nombre = "3A",
};

Curso[] cursos = [curso01, curso02, curso03];
escuela.Cursos = cursos;

static void ImprimirCursos(Curso[] cursos)
{
    /*for (int i = 0; i < cursos.Length; i++)
    {
        Console.WriteLine($"Curso: {cursos[i].Nombre}");
    }*/

    if (cursos.Length != 0)
    {
        foreach (Curso curso in cursos)
        {
            Console.WriteLine($"Curso: {curso.Nombre}");
        }
    } else
    {
        Console.WriteLine("No hay cursos.");
    }
}

Console.WriteLine(escuela);
Console.WriteLine("==============");
ImprimirCursos(cursos);