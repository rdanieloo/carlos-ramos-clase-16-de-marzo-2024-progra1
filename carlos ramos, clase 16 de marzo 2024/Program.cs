

//Clase 16/03/2024 Carlos Ramos 
static void ejemplo()
{
    //Declaracion de un arreglo
    int[] calificaciones;


    //Creacion de un arrglo con valores iniciales
    calificaciones = new int[] { 85, 92, 77, 68, 94, 10, 20, 30, 40, 50 };
    foreach (int numero in calificaciones)

    {
        Console.WriteLine(numero);
    }


    //Acceso a un elemento del arreglo
    //Console.WriteLine(calificaciones[2]); //Imprime 77


    //int longitudArreglo = calificaciones.Length;
    //double promedio = calificaciones.Length /


    // Console.WriteLine(promedio);






}


//ejemplo 2

static void ejemplo2()
{

    int[] calificaciones = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

    for (int i = 0; i < calificaciones.Length; i++)
    {

        Console.WriteLine($"calificaiones {i + 1}: {calificaciones[i]}");

    }



}


static void despliegue() { 

static void ejemplo10()
{

    int[] elementos = new int[] { 50, 20, 80, 90, 60 };
    Console.WriteLine("original:");
    foreach (int item in elementos)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Ordenado");
    Array.Sort(elementos);
    foreach (int item in elementos)
    {
        Console.WriteLine(item);
    }
        Array.Reverse(elementos); 
            foreach(int item in elementos)
        {
            Console.WriteLine(item);
        }
}

}


//Array.IndexOf()

int[] edades = { 25, 30, 18, 42, 30 };
int indice = Array.IndexOf(edades, 30); //indice = 1




//Array.Exists()

{
    int[] calificaciones = { 85, 92, 77, 68, 94 };
    bool hayAprobados = Array.Exists(calificaciones, calif >= calif >= 60);

}

    //hayAprobados








