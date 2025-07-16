using System;
using System.Collections.Generic;
using System.IO;

class Me
{
    static void Main(string[] args)
    {
        Kdramas k1 = new Kdramas();
        k1._name = "King the Land";
        k1._about = "A romantic comedy about a chaebol heir and a hotelier.";
        k1._score = 8;

        Kdramas k2 = new Kdramas();
        k2._name = "Crash Landing on You";
        k2._about = "A South Korean heiress accidentally lands in North Korea and meets a North Korean officer.";
        k2._score = 9;

        Kdramas k3 = new Kdramas();
        k3._name = "True Beauty";
        k3._about = "It's about a beautiful man called Suho, wich team are you? team Suho or Team seojun?";
        k3._score = 10;

        List<Kdramas> KdramasList = new List<Kdramas>();
        KdramasList.Add(k1);
        KdramasList.Add(k2);
        KdramasList.Add(k3);

        
    }

    public static void SaveToFile(List<Kdramas> kdramasList)
    {
        string filename = "kdramas.txt";
        using (StreamWriter outpuFile = new StreamWriter(filename))
        {
            foreach (Kdramas k in kdramasList)
            {
                outpuFile.WriteLine($"{k._name}|{k._about}|{k._score}");
            }
        }

    }
}
