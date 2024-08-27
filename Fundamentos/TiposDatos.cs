using system;

class Program
{
  static void Main(string[] args)
  {
    // Datos de tipo Entero
    // Este tipo de datos es bastante complejo ya que podemos encontrar una cantidad de datos considerables
    short numeroUno;
    int numeroDos;

    // Datos decimales
    // Recordemos que que este tipo de datos si nosotros los inicializamos debemos
    // tener en cuenta que para float hay que colocar una f al final del dato
    // y en decimal es de poner una m al final de mi valor.
    // Dentro de la estos tipos de datos es bastante comun sobretodo utilizar double
    float decimalUno = 15.64f;
    double decimalDos = 16.54;
    decimal decimalTres = 15.65m;

    // Datos Booleanos
    bool isTrue = true;
    bool isFalse = false;

    // Tipos de datos string 
    // Este tipo de dato se diferencia por ser una cadena de texto que se encuentra 
    // envuelto entre comillas dobles "" este cuenta con 2 o mas caracteres.
    string cadena = "Soy un string";

    // Tipos de datos char
    // Este tipo de datos solo permite un caracter y se envuelve en comillas simples ''\
    // Cabe recalcar que si colocas dos caracteres entre comillas simples este dara un error
    // ya que es mas de uno aun este este entre comillas simples ej: 'gh' => marcara error
    char caracter = 'k'

  }
}