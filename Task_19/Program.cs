// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int number = Prompt("Input number");

int Prompt (string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    int numN = Convert.ToInt32(value);
    return numN;
}

if (IsPalinrome(number))
{
    Console.WriteLine("Number is palindrome");
}
else
{
    Console.WriteLine("Number is not palindrome");
}
bool IsPalinrome(int number)
{
    //Console.WriteLine(ReverseNumber(number)); отладочный вывод
    //Console.WriteLine(number); отладочный вывод

    //int reversedNumber = ReverseNumber(number);
    
    if (number == ReverseNumber(number))
    {
        return true;
        }
    return false;
}
//return true;

int ReverseNumber(int number)// переворот числа в обратную сторону
{
    int reversedNumber = 0;
    while (number>0)
    {
        int remainder = number%10;
        reversedNumber = reversedNumber*10+remainder;
        number = number/10;
    }
    return reversedNumber;
}