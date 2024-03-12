//1.NUMERO MAYOR Y MENOR
//int num, max, min, mayor, menor;
//max = 0;
//min = int.MaxValue;
//Console.WriteLine("Hola amigo, porfavor agrega numeros positivos");
//Console.WriteLine("Presiona 0 para terminar");
//do
//{
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num < min && num != 0)
//    {
//        min = num;
//    }
//    if (num > max)
//    {
//        max = num;
//    }

//} while (num != 0);
//Console.WriteLine("El numero menor es: "+min);
//Console.WriteLine("El numero mayor es: "+max);


//2.ADIVINAR EL NUMERO EN EL QUE PIENSA
//Console.WriteLine("Piensa un numero porfa");
//Console.WriteLine("Muy bien, cuando termines, multiplica ese numero por 2");
//Console.WriteLine("Muy bien, cuando termines, a ese resultado sumale 8");
//Console.WriteLine("Muy bien, cuando termines, ese resultado multiplicalo por 5");
//Console.WriteLine("Muy bien, Ahora por favor dime tu resultado final :)");
//string num = Console.ReadLine();
//int ult = 1;
//num = num.Remove(num.Length - ult);
//int numm = Convert.ToInt32(num);
//numm = numm - 4;
//Console.WriteLine("Mmmm...");
//Console.WriteLine("El numero en el que pensaste es... " + numm + " Verdad?");
//Console.WriteLine("Yo lo se todo amigo ;)");


//3.CONTADOR DE PALABRAS
//Console.WriteLine("Hola amigo, Porfavor ingresa una frase: ");
//Console.WriteLine("(Solamente agregar un espacio entre cada palabra para evitar errores)");
//string frase = Console.ReadLine();
//string[] palabra = frase.Split();
//int contador = frase.Split().Length;
//int indice = 0;
//int contador2 = 0;

//while (indice < palabra.Length)
//{
//    char[] letra = palabra[indice].ToCharArray();
//    int incremento = 0;
//    while (incremento < letra.Length)
//    {
//        if (letra[incremento] == 'a')
//        {
//            contador2++;
//        }
//        if (letra[incremento] == 'e')
//        {
//            contador2++;

//        }
//        if (letra[incremento] == 'i')
//        {
//            contador2++;

//        }
//        if (letra[incremento] == 'o')
//        {
//            contador2++;
//        }
//        if (letra[incremento] == 'u')
//        {
//            contador2++;
//        }
//        incremento++;
//    }
//    indice++;
//}
//Console.WriteLine("El numero de palabras de la frase es de: " + contador);
//Console.WriteLine("el numero de vocales que tiene la frase es de: " + contador2);

//4.PALINDROMOS
//Console.WriteLine("Hola amigo, ingresa una palabra o una frase porfavor");
//string plbr= Console.ReadLine();
//plbr = plbr.ToLower(); 
//plbr = plbr.Replace(" ", "");
//plbr=tildes(plbr);
//string rblp = "";
//for (int i=plbr.Count()-1;i>=0;i--)
//{
//    rblp += plbr[i];
//}
//if (plbr == rblp)
//{
//    Console.WriteLine("En efecto, la palabra es un palindromo");
//}
//else
//{
//    Console.WriteLine("No amigo, no es un palindromo...");
//}

//static string tildes(string plbr)
//{
//    if (plbr.Contains('á'))
//    {
//        plbr = plbr.Replace("á", "a");
//    }
//    if (plbr.Contains('é'))
//    {
//        plbr = plbr.Replace("é", "e");
//    }
//    if (plbr.Contains('í'))
//    {
//        plbr = plbr.Replace("í", "i");
//    }
//    if (plbr.Contains('ó'))
//    {
//        plbr = plbr.Replace("ó", "o");
//    }
//    if (plbr.Contains('ú'))
//    {
//        plbr = plbr.Replace("ú", "u");
//    }
//    return plbr;
//}