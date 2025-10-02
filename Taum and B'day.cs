using System;

class Result
{
    public static long taumBday(int b, int w, int bc, int wc, int z)
    {
        long black = b;
        long white = w;
        long costBlack = bc;
        long costWhite = wc;
        long convert = z;
        
        
        long strategy1 = (black * costBlack) + (white * costWhite);
        
        
        long strategy2 = (black * (costWhite + convert)) + (white * costWhite);
        
        
        long strategy3 = (black * costBlack) + (white * (costBlack + convert));
        
        return Math.Min(strategy1, Math.Min(strategy2, strategy3));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int b = Convert.ToInt32(firstMultipleInput[0]);
            int w = Convert.ToInt32(firstMultipleInput[1]);
            
            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int bc = Convert.ToInt32(secondMultipleInput[0]);
            int wc = Convert.ToInt32(secondMultipleInput[1]);
            int z = Convert.ToInt32(secondMultipleInput[2]);
            
            long result = Result.taumBday(b, w, bc, wc, z);
            Console.WriteLine(result);
        }
    }
}
