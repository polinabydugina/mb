string[,] mb =
{
    {"  ", " А ", " Б ", " В ", " Г ", " Д ", " Е ", " Ж ", " З ", " И ", " К ", "   "},
    {" 1", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {" 2", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {" 3", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {" 4", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {" 5", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {" 6", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {" 7", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {" 8", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {" 9", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {"10", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", " ~ ", "   "},
    {"  ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   "},
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

        if (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x, y - 1] == " # " || mb[x + 1, y] == " # " || mb[x, y + 1] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y + 1] == " # " || mb[x + 1, y - 1] == " # ")
        {
            Console.WriteLine("Низя!");
        }
        else
        {
            mb[x, y] = " # ";
            t++;
            Console.Clear();
            vivod(mb);
        }
        
    }

    t = 0;
    while (t < 3)
    {
        Console.WriteLine("введите индексы первой клетки двупалубного корабля");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите индексы второй клетки двупалубного корабля");
        int p = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        bool vertical2 = false;

        if (y == l)
        {
            vertical2 = true;
        }

        if (vertical2 && (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x, y - 1] == " # " || mb[x + 1, y] == " # " || mb[x, y + 2] == " # " || mb[x - 1, y + 1] == " # " || mb[x + 1, y + 1] == " # " || mb[x, y + 2] == " # " || mb[x - 1, y - 1] == " # " || mb[x - 1, y + 2] == " # " || mb[x + 1, y + 2] == " # " || mb[x + 1, y - 1] == " # ") &&
            (mb[p, l] == " # "|| mb[p - 1, l] == " # " || mb[p + 1, l] == " # " || mb[p, l + 1] == " # " || mb[p - 1, l - 1] == " # " || mb[p + 1, l + 1] == " # " || mb[p + 1, l - 1] == " # "))
        {
            Console.WriteLine("Низя!");
        }
        else if (!vertical2 && (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x, y - 1] == " # " || mb[x, y + 1] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y + 1] == " # " || mb[x + 1, y - 1] == " # ") &&
            (mb[p, l] == " # " || mb[p, l - 1] == " # " || mb[p + 1, l] == " # " || mb[p, l + 1] == " # " || mb[p - 1, l - 1] == " # " || mb[p + 1, l + 1] == " # " || mb[p + 1, l - 1] == " # "))
        {
            Console.WriteLine("Низя!");
        }
        else
        {
            mb[x, y] = " # ";
            mb[p, l] = " # ";
            t++;
            Console.Clear();
            vivod(mb);
        }
        
    }

    t = 0;
    while (t < 2)
    {
        Console.WriteLine("введите индексы первой клетки трехпалубного корабля");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите индексы третьей клетки трехпалубного корабля");
        int p = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        int m1 = x;
        int m2 = y + 1;
        bool vertical3 = false;
        if (y == l)
        {
            vertical3 = true;
            m1 = x + 1;
            m2 = y;
        }

        if (vertical3 && (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x - 1, y - 1] == " # " || mb[x - 1, y + 1] == " # " || mb[x, y - 1] == " # " || mb[x, y + 1] == " # ") &&
            (mb[m1, m2] == " # " || mb[m1, m2 - 1] == " # " || mb[m1, m2 + 1] == " # ") &&
            (mb[p, l] == " # " || mb[p + 1, l] == " # " || mb[p + 1, l + 1] == " # " || mb[p + 1, l - 1] == " # ") || mb[p, l + 1] == " # " || mb[p, l - 1] == " # ")
        {
            Console.WriteLine("Низя!");
        }
        else if (!vertical3 &&
            (mb[x, y] == " # " || mb[x, y - 1] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y - 1] == " # " || mb[x + 1, y] == " # " || mb[x - 1, y] == " # ") &&
            (mb[m1, m2] == " # " || mb[m1 - 1, m2] == " # " || mb[m1 + 1, m2] == " # ") &
            (mb[p, l] == " # " || mb[p, l + 1] == " # " || mb[p + 1, l + 1] == " # " || mb[p - 1, l + 1] == " # " || mb[p - 1, l] == " # " || mb[p + 1, l] == " # "))
        {
            Console.WriteLine("Низя!");
        }
        else
        {
            mb[x, y] = " # ";
            mb[p, l] = " # ";
            mb[m1, m2] = " # ";
            t++;
            Console.Clear();
            vivod(mb);
        }
    }

    t = 0;
    while (t < 1)
    {
        Console.WriteLine("введите индексы первой клетки четырехпалубного корабля");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите индексы четвертой клетки четырехпалубного корабля");
        int p = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        int m1 = x;
        int m2 = y + 1;
        int d1 = x;
        int d2 = y + 2;
        bool vertical4 = false;
        if (y == l)
        {
            vertical4 = true;
            m1 = x + 1;
            m2 = y;
            d1 = x + 2;
            d2 = y;
        }

        if (vertical4 &&
            (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x - 1, y - 1] == " # " || mb[x - 1, y + 1] == " # " || mb[x, y - 1] == " # " || mb[x, y + 1] == " # ") &&
            (mb[m1, m2] == " # " || mb[m1, m2 + 1] == " # " || mb[m1, m2 - 1] == " # ") &&
            (mb[d1, d2] == " # " || mb[d1, d2 + 1] == " # " || mb[d1, d2 - 1] == " # ") &&
            (mb[p, l] == " # " || mb[p + 1, l] == " # " || mb[p + 1, l + 1] == " # " || mb[p + 1, l - 1] == " # ") || mb[p, l + 1] == " # " || mb[p, l - 1] == " # ")
        {
            Console.WriteLine("Низя!");
        }
        else if (!vertical4 &&
            (mb[x, y] == " # " || mb[x, y - 1] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y - 1] == " # " || mb[x + 1, y] == " # " || mb[x - 1, y] == " # ") &&
            (mb[m1, m2] == " # " || mb[m1 + 1, m2] == " # " || mb[m1 - 1, m2] == " # ") &&
            (mb[d1, d2] == " # " || mb[d1 + 1, d2] == " # " || mb[d1 - 1, d2] == " # ") &&
            (mb[p, l] == " # " || mb[p, l + 1] == " # " || mb[p + 1, l + 1] == " # " || mb[p - 1, l + 1] == " # " || mb[p - 1, l] == " # " || mb[p + 1, l] == " # "))
        {
            Console.WriteLine("Низя!");
        }
        else
        {
            mb[x, y] = " # ";
            mb[p, l] = " # ";
            mb[m1, m2] = " # ";
            mb[d1, d2] = " # ";
            t++;
            Console.Clear();
            vivod(mb);
        }
    }
}