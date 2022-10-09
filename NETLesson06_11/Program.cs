// See https://aka.ms/new-console-template for more information

/* Parašyti funkciją, kuri suskaičiuoja atskirų bet kokio skaičiaus skaitmenų sumą */



int val = 50069;
int x = val;
int sum = 0;

while (x !=0)
{
    int y = x % 10;
    x = x / 10;
    
    sum += y;
}


Console.WriteLine(sum);
