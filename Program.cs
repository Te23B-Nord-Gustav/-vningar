// 1
// if(6 >= 3)
// {
//     Console.WriteLine("Hello world");
// }

// 2
// string user = Console.ReadLine();
// if(user == "noname")
// {
//     Console.WriteLine("Welcome!");
// }

// 3
// Console.WriteLine("username-");
// string user = Console.ReadLine();
// Console.WriteLine("password");
// string pass = Console.ReadLine();
// if(user == "noname" && pass == "nopass")
// {
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("Wrong username or password");
// }

// 4
// int i = 0;
// while(i < 32)
// {
//     Console.WriteLine("Hello World!");
//     i++;
// }
// for(int a = 0; a < 32; a++)
// {
//     Console.WriteLine("Hello World!(1)");
// }

// 5
// string lös = "123";
// int a = 1;
// while(a > 0)
// {
//     Console.WriteLine("skriv lösenordet!");
//     string svar = Console.ReadLine();
//     if(svar == lös)
//     {
//         Console.WriteLine("Korekt");
//         a--;
//     }
// }

// 6
// for(int i = 4; i>0; i--)
// {
//     Console.WriteLine("skriv ett tal");
//     string svar = Console.ReadLine();
//     int.TryParse(svar, out int svarnmr);

//     if(svarnmr > 5)
//     {
//         Console.WriteLine("Det är högre än fem");
//     }
// }

// 7
// int a = 1;
// while(a > 0)
// {
//     Console.WriteLine("Skriv ett heltal");
//     string input = Console.ReadLine();

//     if (int.TryParse(input, out int number))
//     {
//         Console.WriteLine("Du angav ett giltigt heltal");
//         a--;
//     }
//     else
//     {
//         Console.WriteLine("Fel skriv ett heltal");
//     }
// }

// 8 gissa siffran spel
int talet = Random.Shared.Next(1, 6);
int a = 1;
while(a > 0)
{
    Console.WriteLine("GISSA SIFFRAN");
    Console.WriteLine("skriv din gissning");

    string input = Console.ReadLine();
    int.TryParse(input, out int gissning);

    if (gissning == talet)
    {
        Console.WriteLine("Du hadde rätt grattis");
        a--;
    }
    else
    {
        Console.WriteLine("du hadde fel!!!!!");
        if(gissning > talet)
        {
            Console.WriteLine("Ditt tal är större än det rätta");
        }
        else if(gissning < talet)
        {
            Console.WriteLine("ditt tal är mindre än det rätta");
        }
    }


    

}














Console.ReadLine();