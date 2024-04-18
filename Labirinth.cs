namespace labirinth;

public class labirinth
{
    public int GetCountExit(int i, int j, int[,] l)
    {
        int counter = 0;
        if (l[i, j] == 1)
        {
            Console.Write("В стене старт ");
            return counter;
        }
        // if (l[i, j] == 1)
        // {
        //     Console.WriteLine("В выходе старт");
        //     ++counter;
        // } 

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