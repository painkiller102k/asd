namespace Sõidukite_liidese_ul;

class StartClass
{
    static void Main()
    {
        List<ISõiduk> sõidukid = new List<ISõiduk>(); // nimekiri ( auto / buss / skateboard / jalgratas)

        while (true)
        {
            Console.WriteLine("Vali sõiduk: 1=Auto, 2=Jalgratas, 3=Buss, 4=Skateboard, 0=Välju"); // menu valik
            string valik = Console.ReadLine();

            if (valik == "0") break;

            switch (valik)
            {
                case "1": // Auto
                    Console.Write("Sisesta kütusekulu l/100km: ");
                    if (!double.TryParse(Console.ReadLine(), out double kulu)) // veakontroll number double
                    {
                        Console.WriteLine("Viga!");
                        continue;
                    }

                    Console.Write("Sisesta vahemaa km: ");
                    if (!double.TryParse(Console.ReadLine(), out double vahemaa)) // veakontroll number double
                    {
                        Console.WriteLine("Viga");
                        continue;
                    }

                    sõidukid.Add(new Auto(kulu, vahemaa));
                    break;

                case "2": // Jalgratas
                    Console.Write("Sisesta vahemaa km: ");
                    if (!double.TryParse(Console.ReadLine(), out vahemaa)) // veakontroll number double
                    {
                        Console.WriteLine("Viga");
                        continue;
                    }
                    sõidukid.Add(new Jalgratas(vahemaa));
                    break;

                case "3": // Buss
                    Console.Write("Sisesta kütusekulu l/100km: ");
                    if (!double.TryParse(Console.ReadLine(), out kulu)) // veakontroll number double
                    {
                        Console.WriteLine("Viga");
                        continue;
                    }

                    Console.Write("Sisesta vahemaa km: ");
                    if (!double.TryParse(Console.ReadLine(), out vahemaa)) // veakontroll number double
                    {
                        Console.WriteLine("Viga");
                        continue;
                    }

                    Console.Write("Sisesta reisijate arv: ");
                    if (!int.TryParse(Console.ReadLine(), out int reisijad)) // veakontroll number double
                    {
                        Console.WriteLine("Viga");
                        continue;
                    }

                    sõidukid.Add(new Buss(kulu, vahemaa, reisijad));
                    break;

                case "4": // Skateboard
                    Console.Write("Sisesta vahemaa km: "); 
                    if (!double.TryParse(Console.ReadLine(), out vahemaa)) // veakontroll number double
                    {
                        Console.WriteLine("Viga");
                        continue;
                    }
                    sõidukid.Add(new Skateboard(vahemaa));
                    break;

                default:
                    Console.WriteLine("Tundmatu valik ");
                    break;
            }
        }

        Console.WriteLine("Sõidukite tulemused :"); // kõik tulemused
        foreach (var s in sõidukid)
        {
            Console.WriteLine(s);
        }
    }
}
