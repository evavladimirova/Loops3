int n1 = 0;
int n2 = 1;
int n3, i, num;

Console.Write("Input number of terms to display:  ");
num = int.Parse(Console.ReadLine());
Console.Write(n1 + " " + n2 + " ");

for (i = 2; i < num; ++i)
{
    n3 = n1 + n2;
    Console.Write(n3 + " ");
    n1 = n2;
    n2 = n3;
}
