public class Curso
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    
    private readonly string id;
    public string ID
    {
        get { return id; }
    }
    
    private TipoJornada tipo;
    public TipoJornada Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }
    
    public Curso()
    {
        id = Guid.NewGuid().ToString();
    }
}