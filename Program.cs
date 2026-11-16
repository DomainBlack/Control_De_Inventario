//CREACION DE CLASES, CAMPOS Y CONFIGURACION DE GET Y SET//
class Producto
{

    private string _codigo;
    public string Codigo
    {

        get;
        set;


    }



    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }

        set
        {

            if (string.IsNullOrWhiteSpace(value))
            {

                Console.WriteLine("Error Campo Invalido");

            }

            else
            {

                _nombre = value;

            }

        }

    }


    private double _precio;
    public double Precio
    {

        get { return _precio; }
        set
        {


            if (value < 0)
            {

                Console.WriteLine("Error: Campo Invalido");

            }

            else
            {
                _precio = value;
            }
        }


    }

    private double _cantidad;
    public double Cantidad
    {


        get { return _cantidad; }
        set
        {


            if (value < 0)
            {

                Console.WriteLine("Error: Valor Invalido");


            }

            else
            {

                _cantidad = value;


            }

        }


    }


    //Propiedad de Solo Lectura//
    public double ValorTotal 
    {
        get { return Precio * Cantidad;  }
    }

    //CONSTRUCTOR(RECIBE LOS DATOS E INICIA EL OBJETO//
    public Producto(string Codigo, string Nombre, double Precio, double Cantidad) 
    {
    
        this.Codigo = Codigo;
        this.Nombre = Nombre;
        this.Precio = Precio;
        this.Cantidad = Cantidad; 
    
    }

    //Metodo MostrarInfo()
    public void MostrarInfo() 
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Codigo: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Precio: " + Precio);
        Console.WriteLine("Cantidad: " + Cantidad);
        Console.WriteLine("Valor Total: " + ValorTotal);
        Console.WriteLine("-----------------------------");
    }

}

//Metodo Main Para Interactuar con el usuario y crear objetos//
class program
{

    static void Main(string[] args)
    {

        Console.WriteLine("---Control De Inventario De TecnoPunto---");

        Console.WriteLine("Ingrese Codigo del producto: ");
        string CodigoAgregado = Console.ReadLine();

        Console.WriteLine("Ingrese Nombre del Producto: ");
        string NombreAgregado = Console.ReadLine();

        Console.WriteLine("Ingrese Precio del Producto: ");
        double PrecioAgregado = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese Cantidad del Producto: ");
        double CantidadAgregada = Convert.ToDouble(Console.ReadLine());

    

    Producto p = new Producto(CodigoAgregado, NombreAgregado, PrecioAgregado, CantidadAgregada);
        p.MostrarInfo();


    }


}

