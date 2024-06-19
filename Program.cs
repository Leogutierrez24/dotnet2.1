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

Console.WriteLine(escuela);
Console.WriteLine("==============");
Console.WriteLine($"{curso01.Nombre} | {curso01.ID}");
Console.WriteLine($"{curso02.Nombre} | {curso02.ID}");
Console.WriteLine(curso03.Nombre + " | " + curso03.ID);