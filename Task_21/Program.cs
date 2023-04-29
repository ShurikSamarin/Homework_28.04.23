// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
double x1 = Prompt("Input coordinate X1");
double x2 = Prompt("Input coordinate X2");
double y1 = Prompt("Input coordinate Y1");
double y2 = Prompt("Input coordinate Y2");
double z1 = Prompt("Input coordinate Z1");
double z2 = Prompt("Input coordinate Z2");


double d = FindLenght(x1, x2, y1, y2, z1, z2);
//Console.WriteLine(d);
double FindLenght(double xa, double xb, double ya, double yb, double za, double zb)
{
    double result = Convert.ToDouble(Math.Round(Math.Sqrt(((xa-xb)*(xa-xb) + (ya-yb)*(ya-yb) + (za-zb)*(za-zb))),3));
    Console.WriteLine(result);
    return result;
}

double Prompt (string message)
{
    Console.WriteLine(message);
    double value = double.Parse(Console.ReadLine());
    double coord = Convert.ToDouble(value);
    return coord;
}
