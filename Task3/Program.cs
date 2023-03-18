void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{String.Join(", ", array)}]");
}

System.Console.Clear();
int[] array = new int[8];
int index = 0;

while (true)
{

    System.Console.WriteLine("Press Enter for quit or enter number: ");
    string a = Console.ReadLine();

    if (a == String.Empty)
    {
        break;
    }

    array[index] = Convert.ToInt32(a);
    index++;
    PrintArray(array);

    if (index == array.Length)
    {
        index = 0;
    }
}

System.Console.WriteLine("Finish");