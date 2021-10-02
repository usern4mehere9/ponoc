using System;

namespace ponoc
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s, pp, sph, spm, sps, aux; 

            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());

            pp = (h * 3600) + (m * 60) + s;
   
            aux = 86400 - pp;
            sph = aux / 3600;
            spm = (aux - sph*3600)/60;
            sps = (aux - sph * 3600 - spm * 60);



             Console.WriteLine(pp);
             Console.WriteLine("{0}:{1}:{2}", sph, spm, sps);
        }
    }
}
