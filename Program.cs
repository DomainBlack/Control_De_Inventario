Console.WriteLine("---Control De Inventario De TecnoPunto---");


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
        get;

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

    private int _cantidad;
    public int Cantidad
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
    public Producto(string Codigo, string Nombre, double Precio, int Cantidad) 
    {
    
        this.Codigo = Codigo;
        this.Nombre = Nombre;
        this.Precio = Precio;
        this.Cantidad = Cantidad; 
    
    }





}



