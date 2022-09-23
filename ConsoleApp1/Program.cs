using System.Text;
 
 
static String getBinaryString(int d)
{
    int[] arr = new int[20];
    int i = 0;

    StringBuilder binaryBuilder = new StringBuilder();

    while (d > 0)
    {
        arr[i] = d % 2;
        d = d / 2;
        i++;

    }
    i--;
    while (i >= 0)
    {
        binaryBuilder.Append(arr[i]);
        i--;
    }
    return binaryBuilder.ToString();
}

int no;
Console.WriteLine("enter the decimal number: ");
no = int.Parse(Console.ReadLine());

Console.WriteLine("Binary " + getBinaryString(no));

