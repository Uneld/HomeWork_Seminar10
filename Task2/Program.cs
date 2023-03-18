int SumDigitNum(string a)
{
    int res = 0;
    for (int i = 0; i < a.Length; i++)
    {
        res += Convert.ToInt32(Char.GetNumericValue(a[i]));
    }
    return res;
}

System.Console.Clear();
System.Console.WriteLine("Enter number");
string a = Console.ReadLine();
System.Console.WriteLine(SumDigitNum(a));