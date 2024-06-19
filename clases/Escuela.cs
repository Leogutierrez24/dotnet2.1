public class Escuela
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value.ToUpper(); }
    }

    private string direccion;
    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }

    private string ciudad;
    public string Ciudad
    {
        get { return ciudad; }
        set { ciudad = value; }
    }

    private string pais;
    public string Pais
    {
        get { return pais; }
        set { pais = value; }
    }

    private int añoFundacion;
    public int AñoFundacion
    {
        get { return añoFundacion; }
        set { añoFundacion = value; }
    }

    private TipoEscuela tipo;
    public TipoEscuela Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    

    public Escuela(string nombre, int año, TipoEscuela tipo, string pais = "", string ciudad = "")
    {
        this.nombre = nombre;
        añoFundacion = año;
        this.tipo = tipo;
        this.pais = pais;
    }

    public Escuela(string nombre, int año) => (this.nombre, añoFundacion) = (nombre, año);

    public void Timbrar()
    {
        // todo
        Console.Beep(1000, 1000);
    }

    public override string ToString()
    {
        return $"Nombre: {nombre}, Tipo: {tipo}\nPais: {pais}, Ciudad: {ciudad}";
    }
}