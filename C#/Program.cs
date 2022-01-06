using System;
using System.Globalization;


namespace Bee
{
    class URI
    {

        static void Main(string[] args)
        {
            //Raio do circulo
            double n, raio, area;
            n = 3.14159;
            raio = double.Parse(Console.ReadLine());
            raio = Math.Pow(raio, 2);
            area = n * raio;
            Console.WriteLine($"A={Math.Round(area, 4):0}");

            //Soma de numeros
            int A_soma, B_soma;
            A_soma = int.Parse(Console.ReadLine());
            B_soma = int.Parse(Console.ReadLine());
            var SOMA = A_soma + B_soma;
            Console.WriteLine("SOMA ={0}", SOMA);

            //Multiplicação
            int A_mutiplicao, B_mutiplicao;
            A_mutiplicao = int.Parse(Console.ReadLine());
            B_mutiplicao = int.Parse(Console.ReadLine());
            var PROD = A_mutiplicao * B_mutiplicao;
            Console.WriteLine($"PROD = {PROD}");

            //Media 1
            double A_media, B_media, MEDIA;
            A_media = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B_media = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            MEDIA = (double)(A_media * 3.5 + B_media * 7.5) / 11;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"), CultureInfo.InvariantCulture);
            Console.ReadLine();


            //Media 2
            double A_media_two, B_media_two, C_media_two, MEDIA_media_two;
            A_media_two = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B_media_two = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C_media_two = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            MEDIA_media_two = (double)(A_media_two * 2 + B_media_two * 3 + C_media_two * 5) / 10;
            Console.WriteLine("MEDIA = " + MEDIA_media_two.ToString("F1"), CultureInfo.InvariantCulture);

            //Diferença
            int A_dif, B_dif, C_dif, D_dif;
            A_dif = int.Parse(Console.ReadLine());
            B_dif = int.Parse(Console.ReadLine());
            C_dif = int.Parse(Console.ReadLine());
            D_dif = int.Parse(Console.ReadLine());
            Console.WriteLine($"DIFERENCA = {A_dif * B_dif - C_dif * D_dif}");

            //Sálario
            int Vhrs, numero;
            double SPhrs;

            numero = int.Parse(Console.ReadLine());
            Vhrs = int.Parse(Console.ReadLine());
            SPhrs = double.Parse(Console.ReadLine());

            var salario = (Vhrs * SPhrs).ToString("F2");
            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {salario}");
        }

    }

}