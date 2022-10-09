// See https://aka.ms/new-console-template for more information

/* Palindromas-(gr. palindromos-bėgantis atgal, grįžtantis): 
 * 1. žodis, eilėraštis arba frazė, skaitomi iš kairės į dešinę ir iš dešinės į kairę, išlaikantys tą pačią prasmę, pvz.,
 * lietuvių k. žodis savas, sakinys Abu gaišo po šia guba */



// string line = Console.ReadLine();

string line = "penktadienis";
char[]? word = line.ToCharArray();

string reverseWord = "";
for(int i = word.Length - 1; i >= 0; i--)
{
    reverseWord = reverseWord + word[i];
}

Console.WriteLine(reverseWord);















