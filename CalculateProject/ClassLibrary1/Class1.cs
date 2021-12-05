using System;

namespace ClassLibrary1
{
    public class Calculator
    {
        public void Calcutlate()
        {
            Console.WriteLine("Toplama ucun + secin");
            Console.WriteLine("Cixma ucun - secin");
            Console.WriteLine("Vurma ucun * secin");
            Console.WriteLine("Bolme ucun / secin");
            Console.WriteLine("1-ci ededi daxil edin");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Edeceyiniz emeliyyati secin");
            string emel = Console.ReadLine();
            Console.WriteLine("2-ci ededi daxil edin");
            int m = Convert.ToInt32(Console.ReadLine());
            int netice = 0;
            switch (emel)
            {
                case "+":
                    {
                        netice = n + m;
                        Console.WriteLine($"Netice = {netice}");
                        return;
                    }
                case "-":
                    {
                        netice = n - m;
                        Console.WriteLine($"Netice = {netice}");
                        return;
                    }
                case "*":
                    {
                        netice = n * m;
                        Console.WriteLine($"Netice = {netice}");
                        return;
                    }
                case "/":
                    {
                        netice = n / m;
                        Console.WriteLine($"Netice = {netice}");
                        return;
                    }


            }
            

        }
    }
}
