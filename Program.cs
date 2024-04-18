
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
Console.Write("Найдено вариантов выхода: ");
Console.WriteLine(new labirinth.labirinth().GetCountExit(4,2,labirynth1));
labirynth1 = new int[,]
{
    {1, 1, 1, 2, 1, 1, 1 },
    {1, 0, 0, 0, 0, 0, 1 },
    {1, 0, 1, 1, 1, 0, 1 },
    {0, 0, 0, 0, 1, 0, 2 },
    {1, 1, 0, 0, 1, 1, 1 },
    {1, 1, 1, 0, 1, 1, 1 },
    {1, 1, 1, 0, 1, 1, 1 }
};
Console.Write("Найдено вариантов выхода: ");
Console.WriteLine(new labirinth.labirinth().GetCountExit(3,1,labirynth1));