class Result
{

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCounter = 0;
        int orangeCounter = 0;

        //I'm trying to solve the problem in a single loop
        for (int i = 0; i < Math.Max(apples.Count, oranges.Count); i++)
        {
            if(i < apples.Count)
            {
                if (apples[i]+a >= s && apples[i]+a <= t)
                {
                    appleCounter++;
                }

            }
            if (i < oranges.Count)
            {
                if (oranges[i]+b >= s && oranges[i]+b <= t )
                {
                    orangeCounter++;
                }

            }

        }
        Console.WriteLine(appleCounter);
        Console.WriteLine(orangeCounter);
    }

}


class Solution
{
    public static void Main(string[] args)
    {
        Result.countApplesAndOranges(s: 2, t: 8, a: 1, b: 10, apples: [3, -2, 5], oranges: [2,2]);

    }
}
