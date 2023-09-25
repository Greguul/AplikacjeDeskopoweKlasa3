Console.WriteLine("Podaj  liczbe a");
uint a = uint.Parse(Console.ReadLine());
/*    if(a < 0)
    {
        Console.WriteLine("Niepoprawna dana");
        return;
    }
    */

Console.WriteLine("Podaj liczbe b");
uint b = uint.Parse(Console.ReadLine());



Console.WriteLine("NWD=" + a);

/*
 ***********************************************
nazwa funkcji: NWD
opis funkcji: najwiekszy wspolny dzielnik
parametry: a - pierwsza liczba 
           b- druga liczba
zwracany typ i opis: uint- najwiekszy wspolny dzielnik
autor: NR pesel 
**********************************************
*/
uint NWD(uint a, uint b)
{
    while (a != b)
    {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}



