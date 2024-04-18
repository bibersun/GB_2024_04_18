namespace labirinth;

public class labirinth
{
    int[,] labirynth1 = new int[,]
    {
        {1, 1, 1, 1, 1, 1, 1 },
        {1, 0, 0, 0, 0, 0, 1 },
        {1, 0, 1, 1, 1, 0, 1 },
        {0, 0, 0, 0, 1, 0, 2 },
        {1, 1, 0, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 }
    };

    public int GetCountExit(int i, int j, int[,] l1)
    {
        int[,] l = l1;
        int counter = 0;
        switch (l[i, j])
        {
            case 1:
                Console.WriteLine("В стене старт");
                return counter;
            case 2:
                Console.WriteLine("Начальная точка в конце");
                return ++counter;
        }

        var stack = new Stack<Tuple<int, int>>();
        stack.Push(new (i, j));
        
        while (stack.Count > 0)
        {
            var tmp = stack.Pop();

            if (l[tmp.Item1, tmp.Item2] == 2) counter++;
            l[tmp.Item1, tmp.Item2] = 1;
            
            if (tmp.Item2 > 0 && l[tmp.Item1, tmp.Item2 - 1] != 1)
                stack.Push(new (tmp.Item1, tmp.Item2 - 1));
            
            if (tmp.Item2 + 1 < l.GetLength(1) && l[tmp.Item1, tmp.Item2 + 1] != 1)
                stack.Push(new (tmp.Item1, tmp.Item2 + 1));
            
            if (tmp.Item1 > 0 && l[tmp.Item1 - 1, tmp.Item2] != 1)
                stack.Push(new (tmp.Item1 -  1, tmp.Item2));
            
            if (tmp.Item1 + 1 < l.GetLength(0) && l[tmp.Item1 + 1, tmp.Item2] != 1)
                stack.Push(new (tmp.Item1 + 1, tmp.Item2));
        }
        return counter;
    }
}