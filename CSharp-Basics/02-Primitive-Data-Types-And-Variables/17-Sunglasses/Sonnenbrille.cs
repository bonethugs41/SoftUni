//100 / 100
//Memory: 8.56 MB
//Time: 0.030 s

using System;

class Sonenbrille
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //top 
        string asterisk;
        string spaces;
        int topAsterisk = 2 * n;
        asterisk = new string('*', topAsterisk);
        int topSpaces = n;
        spaces = new string(' ', topSpaces);
        Console.WriteLine("{0}{1}{0}", asterisk, spaces);

        //middle
        string diago;
        int middleDiago = (2 * n) - 2;
        diago = new string('/', middleDiago);
        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", diago, spaces);
        }
        
        //bridge
        string line;
        int bridge = n;
        line = new string('|', bridge);
        Console.WriteLine("*{0}*{1}*{0}*", diago, line);

        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", diago, spaces);
        }

        Console.WriteLine("{0}{1}{0}", asterisk, spaces);
    }
}