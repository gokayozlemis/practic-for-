
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}


for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}


for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}


int toplam = 0;

for (int i = 50; i <= 150; i++)
{
    toplam += i;
}

Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);


int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)  
    {
        ciftToplam += i;
    }
    else  
    {
        tekToplam += i;
    }
}
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);
    