
//ejercicio 1
//static void suma()
//{ 
//int num1, num2, resultado = 0;
//Console.WriteLine("ingrese n1");
//num1= Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("ingrese n2");
//num2 = Convert.ToInt32(Console.ReadLine());
//resultado = num1 + num2;
//}

////ejercicio 2
//static string datos()
//{
//    Console.WriteLine("ingrese nombre: ");
//    string nombre = Console.ReadLine();
//    return nombre;
//}

////ejercicio 3
//static void edades()
//{ 
//Console.WriteLine("ingrese su ano de nacimiento");
//int ano= Convert.ToInt32(Console.ReadLine());   
//int edad = 2024-ano;
//Console.WriteLine("su edad es: " + edad);
//}

//int opc=0;
//do
//{
//    Console.WriteLine("1. suma");
//    Console.WriteLine("2. Edades");
//    Console.WriteLine("3. Nombre");
//    Console.WriteLine("4. salida");
//    opc = Convert.ToInt32(Console.ReadLine());
//    switch (opc)
//    {
//        case 1:
//            suma();
//            break;
//        case 2:
//            edades();
//            break;
//        case 3:
//            datos();
//            break;
//        default:
//            Console.WriteLine("esa no existe pa");
//            break;
//    }
//}
//edades();
//datos();
//suma();

    //static int sumatoria(int n1, int n2, int n3)
    //{
    //    int resultado =0;
    //    resultado = n1 + n2 + n3;
    //    return resultado;
    //}
    
    //string nombre=datos();
    //int promedio = sumatoria(20, 30, 50) / 3;

    //Console.WriteLine("Hola "+nombre+" tu promedio es de " + promedio);


int num, max, min,mayor, menor;
max = 0;
min = int.MaxValue;
do
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num< min && num!=0)
    {
        min = num;
    }
    if (num > max)
    {
        max = num;
    }

} while (num != 0);
Console.WriteLine(min);
Console.WriteLine(max);

Console.WriteLine("");    