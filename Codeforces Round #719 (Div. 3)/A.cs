namespace cp_with_cs.Codeforces_Round__719__Div._3_;

public static class A
{
    static void Main()
    {
        var T = Convert.ToInt32(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            var _ = Convert.ToInt32(Console.ReadLine());
            var str = Console.ReadLine();
            var ans = "YES";
            Boolean[] arr = new Boolean[128];
            arr[str![0]] = true;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] != str[i])
                {
                    if (arr[str[i]])
                    {
                        ans = "No";
                        break;
                    }

                    arr[str[i]] = true;
                }
            }

            Console.WriteLine(ans);
            
        }
    }
}