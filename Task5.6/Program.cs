using System;
using static System.Net.Mime.MediaTypeNames;

class MainClass
{
    static void Main()
    {       
        GetUserData(out (string, string, int, int, string[], int, string[]) userdata);
        ShowUserData(userdata);
        Console.ReadKey();
    }
    static void GetUserData(out (string name, string surname, int age, int petsnum, string[] petsnames, int colorsnum, string[] colors) userdata)
    {
        Console.Write("Ваше имя: ");
        userdata.name = Console.ReadLine();

        Console.Write("Фамилия: ");
        userdata.surname = Console.ReadLine();

        Console.Write("Сколько вам полных лет? ");
        string text = Console.ReadLine();
        while (CheckInt(text) == false)
        {
            Console.Write("Не можем распознать ответ. Уточните еще раз, сколько вам полных лет? ");
            text = Console.ReadLine();
        }
        userdata.age = Convert.ToInt32(text);

        userdata.petsnames = Array.Empty<string>();

        Console.Write("У вас есть питомцы? (да/нет): ");
        if (Console.ReadLine() == "да")
        {
            Console.Write("Сколько их? ");
            text = Console.ReadLine();
            while (CheckInt(text) == false)
            {
                Console.Write("Не можем распознать ответ. Уточните еще раз, сколько их? ");
                text = Console.ReadLine();
            }
            userdata.petsnum = Convert.ToInt32(text);
            userdata.petsnames = GetPets(userdata.petsnum);
        }
        else userdata.petsnum = 0;

        userdata.colors = Array.Empty<string>();

        Console.Write("Сколько у вас любимых цветов? ");
        text = Console.ReadLine();
        while (CheckInt(text) == false)
        {
            Console.Write("Не можем распознать ответ. Уточните еще раз, сколько у вас любимых цветов? ");
            text = Console.ReadLine();
        }
        userdata.colorsnum = Convert.ToInt32(text);
        userdata.colors = GetColors(userdata.colorsnum);
    }

    static void ShowUserData((string name, string surname, int age, int petsnum, string[] petsnames, int colorsnum, string[] colors) userdata)
    {
        Console.WriteLine("\nВот что мы запомнили:");
        Console.WriteLine("Ваше имя - {0}", userdata.name);
        Console.WriteLine("Ваша фамилия - {0}", userdata.surname);
        Console.WriteLine("Ваш возраст (полных лет) - {0}", userdata.age);
        if (userdata.petsnum == 0) Console.WriteLine("У вас нет питомцев");
        else
        {
            Console.WriteLine("Количество ваших питомцев - {0}:",userdata.petsnum);
            for (int i = 0; i < userdata.petsnames.Length; i++) Console.WriteLine(userdata.petsnames[i]);
        }
        Console.WriteLine("Количество любимых цветов - {0}:", userdata.colorsnum);
        for (int i = 0; i < userdata.colors.Length; i++) Console.WriteLine(userdata.colors[i]);
    }
    static bool CheckInt(string text)
    {
        return int.TryParse(text, out int number) && number > 0;
    }
    static string[] GetPets(int petsnum)
    {
        string[] petsnames = new string[petsnum];
        for (int i = 0; i < petsnames.Length; i++)
        {
            Console.Write("Введите кличку питомца {0}: ", i + 1);
            petsnames[i] = Console.ReadLine();
        }
        return petsnames;
    }
    static string[] GetColors(int colorsnum)
    {
        string[] colors = new string[colorsnum];
        for (int i = 0; i < colors.Length; i++)
        {
            Console.Write("Введите свой любимый цвет номер {0}: ", i + 1);
            colors[i] = Console.ReadLine();
        }
        return colors;
    }
}