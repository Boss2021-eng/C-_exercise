// See https://aka.ms/new-console-template for more information

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The Prime numbers leading to this numbers are: ");

for(int i = 2; i <= num; i++)
{
    bool isPrime = true;

    for( int j=2 ; j<i; j++)
    {
        if( i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if(isPrime)
    {
        Console.Write( i + "-");
    }

}












