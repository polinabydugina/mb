Random random = new Random();
string[,] mb =
{
    {"  ", " 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 ", " 10", "   "},
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
string[,] mb1 = 
{
    {"  ", " 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 ", " 10", "   "},
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
        bool can = p == x ^ l == y;
        if (y == l)
        {
            vertical2 = true;
        }

        if (!can || vertical2 && (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x, y - 1] == " # " || mb[x + 1, y] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y + 1] == " # " || mb[x + 1, y - 1] == " # ") ||
            (mb[p, l] == " # " || mb[p - 1, l] == " # " || mb[p + 1, l] == " # " || mb[p, l + 1] == " # " || mb[p - 1, l - 1] == " # " || mb[p + 1, l + 1] == " # " || mb[p + 1, l - 1] == " # "))
        {
            Console.WriteLine("Низя!");
        }
        else if (!can || !vertical2 && (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x, y - 1] == " # " || mb[x, y + 1] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y + 1] == " # " || mb[x + 1, y - 1] == " # ") ||
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
        bool can = p == x ^ l == y;
        if (y == l)
        {
            vertical3 = true;
            m1 = x + 1;
            m2 = y;
        }

        if (!can || vertical3 && (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x - 1, y - 1] == " # " || mb[x - 1, y + 1] == " # " || mb[x, y - 1] == " # " || mb[x, y + 1] == " # ") ||
            (mb[m1, m2] == " # " || mb[m1, m2 - 1] == " # " || mb[m1, m2 + 1] == " # ") ||
            (mb[p, l] == " # " || mb[p + 1, l] == " # " || mb[p + 1, l + 1] == " # " || mb[p + 1, l - 1] == " # ") || mb[p, l + 1] == " # " || mb[p, l - 1] == " # ")
        {
            Console.WriteLine("Низя!");
        }
        else if (!can || !vertical3 &&
            (mb[x, y] == " # " || mb[x, y - 1] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y - 1] == " # " || mb[x + 1, y] == " # " || mb[x - 1, y] == " # ") ||
            (mb[m1, m2] == " # " || mb[m1 - 1, m2] == " # " || mb[m1 + 1, m2] == " # ") ||
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
        bool can = p == x ^ l == y;
        if (y == l)
        {
            vertical4 = true;
            m1 = x + 1;
            m2 = y;
            d1 = x + 2;
            d2 = y;
        }

        if (!can || vertical4 &&
            (mb[x, y] == " # " || mb[x - 1, y] == " # " || mb[x - 1, y - 1] == " # " || mb[x - 1, y + 1] == " # " || mb[x, y - 1] == " # " || mb[x, y + 1] == " # ") ||
            (mb[m1, m2] == " # " || mb[m1, m2 + 1] == " # " || mb[m1, m2 - 1] == " # ") ||
            (mb[d1, d2] == " # " || mb[d1, d2 + 1] == " # " || mb[d1, d2 - 1] == " # ") ||
            (mb[p, l] == " # " || mb[p + 1, l] == " # " || mb[p + 1, l + 1] == " # " || mb[p + 1, l - 1] == " # ") || mb[p, l + 1] == " # " || mb[p, l - 1] == " # ")
        {
            Console.WriteLine("Низя!");
        }
        else if (!can || !vertical4 &&
            (mb[x, y] == " # " || mb[x, y - 1] == " # " || mb[x - 1, y - 1] == " # " || mb[x + 1, y - 1] == " # " || mb[x + 1, y] == " # " || mb[x - 1, y] == " # ") ||
            (mb[m1, m2] == " # " || mb[m1 + 1, m2] == " # " || mb[m1 - 1, m2] == " # ") ||
            (mb[d1, d2] == " # " || mb[d1 + 1, d2] == " # " || mb[d1 - 1, d2] == " # ") ||
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

    t = 0;
    while (t < 4)
    {     
        int x = random.Next(1, 11);
        int y = random.Next(1, 11);

        if (mb1[x, y] == " # " || mb1[x - 1, y] == " # " || mb1[x, y - 1] == " # " || mb1[x + 1, y] == " # " || mb1[x, y + 1] == " # " || mb1[x - 1, y - 1] == " # " || mb1[x + 1, y + 1] == " # " || mb1[x + 1, y - 1] == " # ")
        {
            continue;
        }
        else
        {
            mb1[x, y] = " # ";
            t++;            
        }

    }

    t = 0;
    while (t < 3)
    {
        again:
        int x = 0;
        int y = 0;
        int p = 0;
        int l = 0;
        switch (random.Next(2))
        {
            case 0:
                x = random.Next(1, 11);
                y = random.Next(1, 11);
                p = x + 1;
                l = y;
                break;
            case 1:
                x = random.Next(1, 11);
                y = random.Next(1, 11);
                p = x;
                l = y+1;
                break;
        }
        bool vertical2 = false;
        if(p > 10 || l > 10)
        {
            goto again;
        }
        if (y == l)
        {
            vertical2 = true;
        }

        if (vertical2 && (mb1[x, y] == " # " || mb1[x - 1, y] == " # " || mb1[x, y - 1] == " # " || mb1[x + 1, y] == " # " || mb1[x - 1, y - 1] == " # " || mb1[x + 1, y + 1] == " # " || mb1[x + 1, y - 1] == " # ") ||
            (mb1[p, l] == " # " || mb1[p - 1, l] == " # " || mb1[p + 1, l] == " # " || mb1[p, l + 1] == " # " || mb1[p - 1, l - 1] == " # " || mb1[p + 1, l + 1] == " # " || mb1[p + 1, l - 1] == " # "))
        {
            continue;
        }
        else if (!vertical2 && (mb1[x, y] == " # " || mb1[x - 1, y] == " # " || mb1[x, y - 1] == " # " || mb1[x, y + 1] == " # " || mb1[x - 1, y - 1] == " # " || mb1[x + 1, y + 1] == " # " || mb1[x + 1, y - 1] == " # ") ||
            (mb1[p, l] == " # " || mb1[p, l - 1] == " # " || mb1[p + 1, l] == " # " || mb1[p, l + 1] == " # " || mb1[p - 1, l - 1] == " # " || mb1[p + 1, l + 1] == " # " || mb1[p + 1, l - 1] == " # "))
        {
            continue;
        }
        else
        {
            mb1[x, y] = " # ";
            mb1[p, l] = " # ";
            t++;
        }

    }

    t = 0;
    while (t < 2)
    {
        again:
        int x = 0;
        int y = 0;
        int p = 0;
        int l = 0;
        switch (random.Next(2))
        {
            case 0:
                x = random.Next(1, 11);
                y = random.Next(1, 11);
                p = x + 2;
                l = y;
                break;
            case 1:
                x = random.Next(1, 11);
                y = random.Next(1, 11);
                p = x;
                l = y + 2;
                break;
        }
        if (p > 10 || l > 10)
        {
            goto again;
        }
        int m1 = x;
        int m2 = y + 1;
        bool vertical3 = false;
        if (y == l)
        {
            vertical3 = true;
            m1 = x + 1;
            m2 = y;
        }

        if (vertical3 && (mb1[x, y] == " # " || mb1[x - 1, y] == " # " || mb1[x - 1, y - 1] == " # " || mb1[x - 1, y + 1] == " # " || mb1[x, y - 1] == " # " || mb1[x, y + 1] == " # ") ||
            (mb1[m1, m2] == " # " || mb1[m1, m2 - 1] == " # " || mb1[m1, m2 + 1] == " # ") ||
            (mb1[p, l] == " # " || mb1[p + 1, l] == " # " || mb1[p + 1, l + 1] == " # " || mb1[p + 1, l - 1] == " # ") || mb1[p, l + 1] == " # " || mb1[p, l - 1] == " # ")
        {
            continue;
        }
        else if (!vertical3 &&
            (mb1[x, y] == " # " || mb1[x, y - 1] == " # " || mb1[x - 1, y - 1] == " # " || mb1[x + 1, y - 1] == " # " || mb1[x + 1, y] == " # " || mb1[x - 1, y] == " # ") ||
            (mb1[m1, m2] == " # " || mb1[m1 - 1, m2] == " # " || mb1[m1 + 1, m2] == " # ") ||
            (mb1[p, l] == " # " || mb1[p, l + 1] == " # " || mb1[p + 1, l + 1] == " # " || mb1[p - 1, l + 1] == " # " || mb1[p - 1, l] == " # " || mb1[p + 1, l] == " # "))
        {
            continue;
        }
        else
        {
            mb1[x, y] = " # ";
            mb1[p, l] = " # ";
            mb1[m1, m2] = " # ";
            t++;
        }
    }

    t = 0;
    while (t < 1)
    {
        again:
        int x = 0;
        int y = 0;
        int p = 0;
        int l = 0;
        switch (random.Next(2))
        {
            case 0:
                x = random.Next(1, 11);
                y = random.Next(1, 11);
                p = x + 3;
                l = y;
                break;
            case 1:
                x = random.Next(1, 11);
                y = random.Next(1, 11);
                p = x;
                l = y + 3;
                break;
        }
        if (p > 10 || l > 10)
        {
            goto again;
        }
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
            (mb1[x, y] == " # " || mb1[x - 1, y] == " # " || mb1[x - 1, y - 1] == " # " || mb1[x - 1, y + 1] == " # " || mb1[x, y - 1] == " # " || mb1[x, y + 1] == " # ") ||
            (mb1[m1, m2] == " # " || mb1[m1, m2 + 1] == " # " || mb1[m1, m2 - 1] == " # ") ||
            (mb1[d1, d2] == " # " || mb1[d1, d2 + 1] == " # " || mb1[d1, d2 - 1] == " # ") ||
            (mb1[p, l] == " # " || mb1[p + 1, l] == " # " || mb1[p + 1, l + 1] == " # " || mb1[p + 1, l - 1] == " # ") || mb1[p, l + 1] == " # " || mb1[p, l - 1] == " # ")
        {
            continue;
        }
        else if (!vertical4 &&
            (mb1[x, y] == " # " || mb1[x, y - 1] == " # " || mb1[x - 1, y - 1] == " # " || mb1[x + 1, y - 1] == " # " || mb1[x + 1, y] == " # " || mb1[x - 1, y] == " # ") ||
            (mb1[m1, m2] == " # " || mb1[m1 + 1, m2] == " # " || mb1[m1 - 1, m2] == " # ") ||
            (mb1[d1, d2] == " # " || mb1[d1 + 1, d2] == " # " || mb1[d1 - 1, d2] == " # ") ||
            (mb1[p, l] == " # " || mb1[p, l + 1] == " # " || mb1[p + 1, l + 1] == " # " || mb1[p - 1, l + 1] == " # " || mb1[p - 1, l] == " # " || mb1[p + 1, l] == " # "))
        {
            continue;
        }
        else
        {
            mb1[x, y] = " # ";
            mb1[p, l] = " # ";
            mb1[m1, m2] = " # ";
            mb1[d1, d2] = " # ";
            t++;
        }
    }
    vivod(mb1);

    while (win())
    {
        int k = 0;
        while (k == 0)
        {
            Console.WriteLine("Введите первый индекс выстрела");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй индекс выстрела");
            int y = Convert.ToInt32(Console.ReadLine());
            if (mb1[x, y] == " # " || mb1[x, y] == " ~ ")
            {
                if (mb1[x, y] == " # ")
                {
                    mb1[x, y] = " X ";
                    Console.Clear();
                    vivod(mb);
                    vivod(mb1);
                }
                else
                {
                    mb1[x, y] = " O ";
                    k++;
                }
            }
            else
            {
                Console.WriteLine("Низя!");
            }
        }
        k = 0;
        while (k == 0)
        {
            int x = random.Next(1, 11);
            int y = random.Next(1, 11);
            if (mb[x, y] == " # " || mb[x, y] == " ~ ")
            {
                if (mb[x, y] == " # ")
                {
                    mb[x, y] = " X ";
                }
                else
                {
                    mb[x, y] = " O ";
                    k++;
                }
            }
            else
            {
                Console.WriteLine("Низя!");
            }
        }
        Console.Clear();
        vivod(mb);
        vivod(mb1);
    }

    bool win()
    {
        bool flag = false;
        foreach(var i in mb)
        {
            if(i == " # ")
            {
                flag = true;
            }
        }
        foreach(var i in mb1)
        {
            if(i == " # ")
            {
                flag = true;
            }
        }
        return flag;
    }
}