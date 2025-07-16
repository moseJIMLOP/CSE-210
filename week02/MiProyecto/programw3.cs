using System;
class Programw3
{
    static void Main(string[] args)
    {
        Kdramas Kdrama1 = new Kdramas();
        Console.WriteLine(Kdrama1.GetKdramaInfo());

        Kdramas Kdrama2 = new Kdramas("Crash Landing on You", 9);
        Console.WriteLine(Kdrama2.GetKdramaInfo());
    }

}