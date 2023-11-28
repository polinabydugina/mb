string[,] mb =
    {
    {"  ", " А ", " Б ", " В ", " Г ", " Д ", " Е ", " Ж ", " З ", " И ", " К "},
    {" 1", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {" 2", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {" 3", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {" 4", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {" 5", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {" 6", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {" 7", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {" 8", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {" 9", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "},
    {"10", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ "}
};
while (true)
{
    void vivod(string[,] array)
    {
        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]}");
            }
            Console.WriteLine();
        }
    }
    int t = 0;
    while (t < 4)
    {
        Console.WriteLine("введите индексы однопалубного корабля");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
  
        if (mb[x - 1, y] == " # " || mb[x, y - 1] == " # " || mb[x + 1, y] == " # " || mb[x, y + 1] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y + 1] == " # " || mb[x + 1, y - 1] == " # ")
        {
            Console.WriteLine("Низя!");
        }
        else
        {
            mb[x, y] = " # ";
            t++;
            Console.Clear();
        }
        vivod(mb);
    }

    int n = 0;
    while (t < 3)
    {
        Console.WriteLine("введите индексы первой клетки двупалубного корабля");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите индексы второй клетки двупалубного корабля");
        int p = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        if ()
        {

        }
        n++;
    }
}