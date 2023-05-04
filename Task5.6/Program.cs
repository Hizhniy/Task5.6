using System;

class MainClass
{
    static void Main(string[] args)
    {
        //ShowData((string, string, byte) datatoshow);




        ShowArray(array);
        Console.ReadKey();
    }

    static int[] GetArrayFromConsole(int num)
    {
        var array = new int[num];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void GetUserDataFromConsole(out (string name, string surname, byte age, byte petsnumber, string[] array, byte colorsnum, string[] array) userdata)
    {



    }

}
static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
{
    sorteddesc = SortArrayDesc(array);
    sortedasc = SortArrayAsc(array);
}
static void ShowArray(int[] array)
{
    SortArray(in array, out int[] sortedar_d, out int[] sortedar_a);
    foreach (int i in sortedar_d)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    foreach (int i in sortedar_a)
    {
        Console.Write(i + " ");
    }
}
   
}