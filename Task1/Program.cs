int PowNum(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res *= a;
    }
    return res;
}


System.Console.WriteLine("Endter number A");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Endter number B");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(PowNum(a, b));