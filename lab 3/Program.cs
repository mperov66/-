using System;
using System.Diagnostics;
class Program
{
    static void Vvod(out double a, out double b)
    {
        a= 0;
        b = 0;
        bool cer = true;
        bool ce = true;
        while (ce)
        {
            Console.WriteLine("Введите a в градусах:");
            if (double.TryParse(Console.ReadLine(), out a))
            { 
                ce = false;
            }
            else
            {
                Console.WriteLine("Введите корректное a в градусах:");
            }
        }
        while (cer)
        {
            const double PI = Math.PI;
            Console.WriteLine("Введите b в градусах:");
            if (double.TryParse(Console.ReadLine(), out b))
            {
                if ((Math.Pow(Math.Sin(a * PI / 180), 3)) - (Math.Pow(Math.Cos(b * PI / 180), 2)) == 0)
                {
                    Console.WriteLine("Деление на 0!");
                }
                else if (((Math.Pow(Math.Sin(a * PI / 180), 2)) + (Math.Pow(Math.Cos(b * PI / 180), 3))) / ((Math.Pow(Math.Sin(a * PI / 180), 3)) - (Math.Pow(Math.Cos(b * PI / 180), 2))) < 0)
                {
                    Console.WriteLine("Подкоренное выражение меньше 0");
                }
                else
                {
                    cer = false;
                }
            }
            else
            {
                Console.WriteLine("Введите корректное b в градусах:");
            }
        }
    }
    static double Function( double a,  double b)
    {
        double v = 0;
        double n = 0;
        const double PI = Math.PI;
        double rada = a * PI / 180;
        double radb = b * PI / 180;
        v = (Math.Pow(Math.Sin(rada), 2)) + (Math.Pow(Math.Cos(radb), 3));
        n = (Math.Pow(Math.Sin(rada), 3)) - (Math.Pow(Math.Cos(radb), 2));
        double l = Math.Round(Math.Sqrt(v / n), 2);

        return l;
    }
    static void Ugadai(double l)
    {
        int i = 0;
        double c = -1;
        while ( i < 3 ^ c == l)
        {
            Console.WriteLine($"Введите предпологаемое значение функции:         {i + 1}/3");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Введите корректное предпологаемое значение функции:");
            }
            i++;
        }
        if (c == l)
        {
            Console.WriteLine("Верно!");
            Console.WriteLine("Значение функции:" + l);
        }
        else
        {
            Console.WriteLine("Не верно!");
            Console.WriteLine("Значение функции:" + l);
        }
    }
    static void Autor()
    {
       Console.WriteLine("Перов Максим Константинович\n6106-09.03.01D");
    }
    static bool Exit( )
    {
        bool vihod =true;
        bool exi =true;
        while (exi)
        {
            Console.WriteLine("Вы действительно хотите покинуть программу?\nДа  Нет");
            string exit = Console.ReadLine();
            if (exit == "Да")
            {
                
                exi = false;
            }
            else if (exit == "Нет")
            {
                vihod= false;
                exi = false;
            }
            else
            {
                Console.WriteLine("Введите 'Да' или 'Нет'!");
            }
        }
        return vihod;
    }
    static int LenMass()
    {
        bool dl = true;
        int len=0;
        while (dl)
        {
            Console.WriteLine("Введите желаемую длину массива от 1 до 10");
            if (!int.TryParse(Console.ReadLine(), out len))
            {
                Console.WriteLine("Введите корректное значение длины массива!");
            }
            else if (len <= 0)
            {
                Console.WriteLine("Длина массива должна быть больше нуля!");
            }
            else if(len > 10)
            {
                Console.WriteLine("Длина массива должна быть меньше 10!");
            }
            else
            {
                dl = false;
            }
        }
        return len;
    }
     static int [] Mass(int len)
    {
        Random rand = new Random();
        int [] mass = new int[len];
        for(int i = 0; i < len; i++)
        {
            mass[i] = rand.Next(-100,101);
        }
        return mass;
    }

    static int [] Copymass(int[] mass,int len)
    {
        int [] copymass = new int[len];
        Array.Copy(mass,copymass,mass.Length);
        return copymass;
    }
    static void Outmass(int[] mass)
    {
        if (mass.Length > 10)
        {
            Console.WriteLine("Вывести массив невозможно.");
        }
        foreach(int n in mass)
        {
            Console.WriteLine(n);
        }
    }
    static void Outsortmass(int[] mass)
    {
        if (mass.Length > 10)
        {
            Console.WriteLine("Вывести массив невозможно.");
        }
        foreach (int n in mass)
        {
            Console.WriteLine(n);
        }
    } 
    static void Outsortcopymass(int[] copymass)
    {
        if (copymass.Length > 10)
        {
            Console.WriteLine("Вывести массив невозможно.");
        }
        foreach (int n in copymass)
        {
            Console.WriteLine(n);
        }
    }
    public static void ShellSort(int[] mass)
    {
        int j;
        int step = mass.Length / 2;
        while (step > 0)
        {
            for (int i = 0; i < (mass.Length - step); i++)      //6,2,5|3,1,5
            {                                                   //3,1,5,6,2,5
                j = i;                                          //1,2,3,5,5,6
                while (j >= 0 && (mass[j] > mass[j + step]))
                {
                    int tmp = mass[j];
                    mass[j] = mass[j + step];
                    mass[j + step] = tmp;
                    j -= step;
                }
            }
            step = step / 2;
        }
    }
    public static void Sortvstav(int[] copymass)
    {

        for (int i = 1; i < copymass.Length; i++)
        {
            int cur = copymass[i];
            int j = i;
            while (j > 0 && cur < copymass[j - 1])              //1,9,5,8,3,8,91,4,9
            {
                copymass[j] = copymass[j - 1];
                j--;
            }
            copymass[j] = cur;
        }

    }
    public static void Main()
    {
        bool ex = true;
        
        while (ex)
        {
            int menu;
            Console.WriteLine("Меню:\n1.Отгадай ответ\n2.Об авторе\n3.Сортировка массива\n4.Выход");
            while (!int.TryParse(Console.ReadLine(), out menu))
            {
                Console.WriteLine("Введите чило от 1 до 4!\nМеню:\n1.Отгадай ответ\n2.Об авторе\n3.Сортировка массива\n4.Выход");
            }
            switch (menu)
            {
                case 1:
                    Vvod(out double a, out double b);
                    double l = Function(a, b);
                    Ugadai(l);
                    break;
                case 2:
                    Autor();
                    break;
                case 3:
                    Stopwatch sw = new Stopwatch();
                    int len = LenMass();
                    int[] mass = Mass(len);
                    int [] copymass = Copymass(mass,len);
                    Console.WriteLine("Массив:");
                    Outmass(mass);
                    sw.Start();
                    Sortvstav(copymass);
                    sw.Stop();
                    double timevstav=sw.Elapsed.TotalMilliseconds;
                    sw.Restart();
                    ShellSort(mass);
                    sw.Stop();
                    double timeshell = sw.Elapsed.TotalMilliseconds;
                    Console.WriteLine("Сортированный массив Shell:");
                    Outsortmass(mass);
                    Console.WriteLine($"{timeshell}мс");
                    Console.WriteLine("Сортированный массив вставкой:");
                    Outsortcopymass(copymass);
                    Console.WriteLine($"{timevstav}мс");
                    if (timeshell > timevstav)
                    {
                        Console.WriteLine("Сортировка вставкой быстрее");
                    }
                    else if (timeshell < timevstav)
                    {
                        Console.WriteLine("Сортировка Шелла быстрее");
                    }
                    else
                    {
                        Console.WriteLine("Время одинаково");
                    }
                    break; 
                case 4:
                    bool vihod  = Exit();
                    if (vihod == true)
                    {
                        ex = false;
                    }
                    else
                    {
                        ex = true;
                    }
                    break;
                default:
                    Console.WriteLine("Введите значение от 1 до 4!");
                    break;
            }
        }
    }
}