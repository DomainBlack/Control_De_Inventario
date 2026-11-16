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


    private int _precio;
    public int Precio
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











}



