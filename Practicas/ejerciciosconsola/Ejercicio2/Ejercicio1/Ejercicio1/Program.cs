using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //   System.Console.WriteLine("Hola mundo"); //primer comando
        //Console.ReadLine();
        /*
         Comentario multilinea
         */

        //Ejemplo definición de variables y su uso.
        /*int c, d, f;

        int a = 89, b = 50;
        int suma = a + b;

        int numero1, numero2, total;

        Console.Write("Introduce numero1: ");
        numero1 = Convert.ToInt32(System.Console.ReadLine());

        Console.Write("Introduce numero2: ");
        numero2 = Convert.ToInt32(System.Console.ReadLine());

        total = numero1 + numero2;
        Console.WriteLine("El resultado de la suma {0} y {1} es {2}",numero1 ,numero2 ,total);
        Console.WriteLine("El resultado es: "+total);
        //Console.ReadLine();

        //Siguiente ejemplo: Utilizando if
        int numeroIntroducido;
        Console.Write("Introduce un número: ");
        numeroIntroducido = Convert.ToInt32(System.Console.ReadLine());*/

        /*if (numeroIntroducido > 0)
        {
            Console.Write("El número es positivo");
        }
        else {
            Console.Write("El número es negativo");                
        }
        Console.ReadLine();*/

        //Ejemplo Boolean
        /*bool positivo;
        positivo = (numeroIntroducido > 0) || (numeroIntroducido == 0);

        if (positivo)
        {
            Console.WriteLine("Es positivo el número: " + numeroIntroducido);
        }
        else {
            Console.WriteLine("El número es negativo");
        }
        Console.ReadLine();*/

        //Ejemplo condicional ternario

        /*int introducirNumeroMayor;

        introducirNumeroMayor = numeroIntroducido > numero1 ? numeroIntroducido : numero1;
        Console.WriteLine("El número mayor es: "+introducirNumeroMayor);
        */
        //Console.ReadLine();


        //Switch

        /*Console.Write("Introduce un número entre 1 y 3: ");
        int numIntroducido;
        numeroIntroducido = Convert.ToInt32(Console.ReadLine());
        switch(numeroIntroducido)
        {
            case 1: Console.WriteLine("Uno");
                break;
            case 2: Console.WriteLine("Dos");
                break;
            case 3: Console.WriteLine("El último manin");
                break;
           default: Console.WriteLine("Pon algo guay");
                break;
        }
        Console.ReadLine();*/

        /*Console.WriteLine("Dime un nombre entre estos (Jose, Pepe, Luis: )");
        String nombre;
        nombre = Console.ReadLine();

        switch (nombre) {
            case "Jose":Console.WriteLine("Ese soy yo");
                break;
            case "Pepe":Console.WriteLine("No me llames así");
                break;
            case "Luis":Console.WriteLine("Simmplemente Luis");
                break;
            default:Console.WriteLine("No has puesto algo válido");
                break;
        }
        Console.ReadLine();*/

        /*Console.WriteLine("Escribe un número: ");
        char numero;
        numero = Convert.ToChar(Console.ReadLine());

        switch (numero)
        {
            case ' ':Console.WriteLine("Espacio");
                break;
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':Console.WriteLine("Dígito");
                break;
            default: Console.WriteLine("No válido");
                break;
        }
        Console.ReadLine();*/

        //For

        /*for (int i=0; i <= 1000; i++){
            Console.WriteLine(i);
        }
        Console.ReadLine();*/

        //while

        /*int vuelta=0, tabla=5, resultado;
        while (vuelta < 10) {
            vuelta++;
            resultado = vuelta * tabla;
            Console.WriteLine("Vuelta: "+vuelta + " Resultado: " +resultado);
        }
        Console.ReadLine();*/

        /*int vuelta = 0, tabla = 0, resultado;
        while (vuelta <= 10)
        {
            //vuelta++;
            //while (tabla <= 10) {
                tabla++;
                resultado = vuelta * tabla;
                Console.WriteLine(vuelta + " x " + tabla + " " + resultado);
                if (tabla >= 10)
                {
                    tabla = 0;
                    vuelta++;
                }
            //}                
        }
        Console.ReadLine();*/

        /*for (int i=0; i<=10; i++) {
            for (int j = 0; j <= 10; j++) {
                int resultado;
                resultado = i * j;
                Console.WriteLine(i + " x " + j + " = " + resultado);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
        */

        /*char letra;

        for(letra='A';letra <= 'z'; letra++)
        {
            Console.Write(letra+" ");
        }
        Console.ReadLine();*/

        /*char letra;
        for(int i=30; i <= 255; i++)
        {
            if (i == 126)
                continue; //salta esa iteración la pasa de largo ej 124, 125, 126 no sale, 127, 128
                //break; corta la iteración
            letra = (char)i;
            Console.WriteLine("ASCII {0} es {1}", letra, i);
            if((i==80) || (i==120) || (i==180) || (i == 255))
            {
                Console.ReadLine();
            }
        }
        Console.ReadLine();*/

        /*String stNombre;
        Console.Write("Introduce un nombre: ");
        stNombre = Console.ReadLine();

        foreach(char letra in stNombre)
        {
            Console.WriteLine(letra);
        }
        Console.ReadLine();*/

        //Exception

        /*int intNumero = 0, total = 0;
        try {
            Console.Write("Introduce numero: ");
            intNumero = Convert.ToInt32(Console.ReadLine());
            total = intNumero / 0;
        }
        catch (Exception miError)
        {
            Console.WriteLine(miError.Message);
            //Console.WriteLine("Error Gordo");
        }
        Console.ReadLine();*/

        /*for (int tabla=1; tabla <= 5; tabla++) {
            for (int num = 0; num <= 10; num++) {
                Console.WriteLine(num + " x " + tabla + " = " + num * tabla);
            }
            Console.WriteLine();
        }
        Console.ReadLine();*/

        //Formateo de numeros para quitar decimales

        /*double numero;

        Console.Write("Ingresa un número: ");
        numero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(numero.ToString("N1"));
        Console.WriteLine(numero.ToString("N2"));
        Console.WriteLine(numero.ToString("N3"));
        Console.WriteLine(numero.ToString("0.0"));
        Console.WriteLine(numero.ToString("#.###"));
        Console.WriteLine(numero.ToString("#.#"));
        Console.WriteLine(numero.ToString("###,##0.00"));
        Console.WriteLine(numero.ToString("0,000,000.00"));

        Console.ReadLine();
        */

        /*Console.WriteLine("Uno\nDos\nTres");
        Console.WriteLine("Uno\tDos\tTres");
        Console.WriteLine("Hola \"Usuario\"");*/
        //Console.WriteLine("\a");//pitido de placa
        /*String frase1 = "Uno, dos, tres";
        String frase2 = ", cuatro, cinco, seis";
        Console.WriteLine(frase1 + frase2);*/

        /* String nombre, apellido;
         Console.Write("Introduce tu nombre: ");
         nombre = Convert.ToString(Console.ReadLine());
         Console.Write("Ahora tu apellido: ");
         apellido = Convert.ToString(Console.ReadLine());
         String usuario = nombre + " " + apellido;
         Console.WriteLine("Bienvenido " + usuario);

         int longitud = apellido.Length;
         Console.WriteLine(longitud);*/

        /*Console.WriteLine("La primera letra del apellido es: {0} y la última es: {1} y contiene: {2} letras", apellido[0], apellido[apellido.Length-1], longitud);
        Console.WriteLine("Las tres primeras letras son: {0}", apellido.Substring(0, 3));
        Console.WriteLine("Nombre en mayúscula y apellido en minúscula: {0} {1}", nombre.ToUpper(), apellido.ToLower());
        Console.WriteLine("Cambiamos letra: {0}", apellido.Replace("o", "0"));*/

        /*int posicion = apellido.IndexOf("p");
        if (posicion == -1)
        {
            Console.WriteLine("No existe el caracter p");
        }
        else
        {
            Console.WriteLine("El carácter p tiene la posición: {0}", posicion);
        }*/

        /* String correo;
         Console.Write("Introduce tu correo: ");
         correo = Convert.ToString(Console.ReadLine());*/

        /*while (!correo.Contains("@") && !correo.Contains("."))
        {
            Console.Write("Introduce tu correo: ");
            correo = Convert.ToString(Console.ReadLine());
            if (correo.Contains("@") && correo.Contains("."))
            {
                Console.WriteLine("El correo es correcto");
            }
            else
            {
                Console.WriteLine("El correo no es correcto");
            }
            Console.ReadLine();
        }*/

        /*String[] postArroba=correo.Split('@');

        if (postArroba[1].IndexOf(".") < 0)
        {
            Console.WriteLine("Correo inválido");
        }*/
        //ver página 133


        //Ejercicio de potencias static int Potencia(int exponente, int base)

        /*static void mostrar(string dato)
        {
            Console.WriteLine(dato);
        }

        static void Main()
        {
            mostrar("pepe");
            mostrar("Luis");
            mostrar("jose");
            Console.ReadLine();
        }
        Console.ReadLine();*/
        // Console.ReadLine();

        /*static void conValor(int para1)
        {
            para1++;
            Console.WriteLine("Desde la funcion vale: {0}", para1);
        }

        static void Main()
        {
            int para1 = 1;
            Console.WriteLine("Paso parametro por referencia ante de funcion valor: {0}", para1);
            Console.WriteLine(ref para1);
            Console.WriteLine("Paso parametro por referencia despue de funcion valor: {0}", para1);
        }*/


        /*  int[] numeros = new int[5];
          numeros[0] = 150;
          numeros[1] = 250;
          numeros[2] = 350;
          numeros[3] = 450;
          numeros[4] = 550;


          int suma=0;
          for (int i = 0; i < 5; i++)
          {
              suma += numeros[i];
              Console.WriteLine(suma);
          }
          Console.ReadLine();*/
        /* struct tipoPersona
         {
             string nombre;
             int edad;
             char inicial;
             double nota;
         }

         struct tipoFecha
         {
             public string dia;
             public string mes;
             public int anyo;
         }
         */

        /*int[] diasMes = { 31, 28, 31 };
        foreach (int n in diasMes)*/
    }
}
