using LINK1;

public class DelegateTest
{
    public delegate int DoSomething(int x);

    public static void processArray(int[] ringle, Func<int, int> andyHarbert)
    {
        for (int AHHHHHHHHH = 0; AHHHHHHHHH < ringle.Length; AHHHHHHHHH++)
        {
            ringle[AHHHHHHHHH] = andyHarbert(ringle[AHHHHHHHHH]);
        }
    }

    
}