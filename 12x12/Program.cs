// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("this is a 12x12 table");
int n1 = 1;
int n2 = 2;
int n3 = 3;
int n4 = 4;
int n5 = 5;
int n6 = 6;
int n7 = 7;
int n8 = 8;
int n9 = 9;
int n10 = 10;
int n11 = 11;
int n12 = 12;
int n1r2 = 1;
Console.WriteLine($"   |{n1}|{n2}|{n3}|{n4}|{n5}|{n6}|{n7}|{n8}|{n9}|{n10}|{n11}|{n12}|");
Console.WriteLine("");
for (int i = 0; i < 12; i++)
{
    Console.WriteLine($"==============================================");
    Console.WriteLine($"{n1r2}  |{n1}|{n2}|{n3}|{n4}|{n5}|{n6}|{n7}|{n8}|{n9}|{n10}|{n11}|{n12}|");
    n1r2 = n1r2 + 1;
    n1 = 1 * n1r2;
    n2 = 2 * n1r2;
    n3 = 3 * n1r2;
    n4 = 4 * n1r2;
    n5 = 5 * n1r2;
    n6 = 6 * n1r2;
    n7 = 7 * n1r2;
    n8 = 8 * n1r2;
    n9 = 9 * n1r2;
    n10 = 10 * n1r2;
    n11 = 11 * n1r2;
    n12 = 12 * n1r2;
    n1r2 = 1 * n1r2;
}
*/
for (int i = 1; i < 13; i++)
{
    Console.WriteLine("");
    for (int t = 1; t < 13; t++)
    {
        int tx = t * i;
        switch (tx)
        {
            case < 10:
                Console.Write($"00{tx}|");
                break;
            case < 100:
                Console.Write($"0{tx}|");
                break;
            case >= 100:
                Console.Write($"{tx}|");
                break;
        }
    }
}