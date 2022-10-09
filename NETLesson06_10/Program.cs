// See https://aka.ms/new-console-template for more information

/* Padaryti funkciją, kuri parodo x Fibonačio skaičių. Seka prasideda šiais skaičiais:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233. 
 * kiekvienas šios sekos skaičius lygus dviejų prieš jį einančių skaičių sumai. */


//int twoBefore = 0;
//int oneBefore = 1;
//for (int i = 0; i <= 10; i++)
//{
//    int current = oneBefore + twoBefore;
//    twoBefore = oneBefore;
//    oneBefore = current;

//    Console.WriteLine(current);
//}



calc(1, 0);

void calc(int oneBefore, int twoBefore)
{

    int current = oneBefore + twoBefore;
    Console.WriteLine(current);

    if (current > 999)
    {
        Environment.Exit(0);
    }


    calc(twoBefore, current);  //rekursija
}