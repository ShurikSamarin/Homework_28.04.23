// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int n = Prompt("Input N");
NumTable(n);

int Prompt (string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    int numN = Convert.ToInt32(value);
    return numN;
}
void NumTable(int n)
{
int currentNum = 1;
while (currentNum <= Math.Abs(n))
{
    if(n>0)
    {
    int cube = currentNum*currentNum*currentNum;
    Console.Write(" ");
    Console.Write(cube);
    currentNum++;
    }
    else
    {
    int cube = -1*currentNum*currentNum*currentNum;
    Console.Write(" ");
    Console.Write(cube);
    currentNum++;
    }
}
}
Console.WriteLine(" ");
