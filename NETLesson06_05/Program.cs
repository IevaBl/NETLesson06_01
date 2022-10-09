// See https://aka.ms/new-console-template for more information
/* Parašyti funkciją, kuri suskaičiuoja ir gražina, kiek yra tarpų eilutėje */

Console.WriteLine(Skaiciuok("As einu misko keliu su lengvu vejeliu ir saule danguje."));


static int Skaiciuok(string tekstas)
{
    int spcctr = 0;
    string str1;
    for (int i = 0; i < tekstas.Length; i++)
    {
        str1 = tekstas.Substring(i, 1);
        if (str1 == " ")
            spcctr++;
    }
    return spcctr;
    
}
