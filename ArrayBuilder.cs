using System.Transactions;

int[] arr = new int[3];

System.Console.WriteLine("Enter an array elements.");


for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write($"Enter number for index [{i}]: ");
    
    string input = Console.ReadLine();

    var isValid = int.TryParse(input, out int userChoice);

    if(isValid)
    {
        arr[i] = userChoice;

    } else
    {
        System.Console.WriteLine("Get Lost!");
        
        break;
    }
}

foreach (var item in arr)
{
    Console.WriteLine(item);
}