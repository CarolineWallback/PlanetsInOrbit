using System;
using System.Runtime.CompilerServices;

namespace PlanetsInOrbit
{
    //Earth makes a complete run around the Sun in 365 days.
    //Mars does the same thing in 687 days.
    //The problem we need to solve is to find out when these two planets is once
    //again "in phase" with one another given some starting positions.
    //For instance, if both planets are already in phase, they will hava a starting position of 0.
    //If Earth is 5 days in it's orbit around the Sun, then the starting position will be 5
    internal class Program
    {
        static void Main(string[] args)
        {
            //days to orbit around the sun
            int EarthOrbit = 365; 
            int MarsOrbit = 687;

            Console.Write("insert starting day for earth: ");
            var startEarth = int.Parse(Console.ReadLine());
            Console.Write("insert starting day for mars: ");
            var starthMars = int.Parse(Console.ReadLine());

            int daysToPhase = 0;

            bool inPhase = false;

            if (EarthOrbit - startEarth == MarsOrbit - starthMars)
            {
                daysToPhase = EarthOrbit - startEarth;
                if (daysToPhase > 0)
                    inPhase = true;
            }

            while (inPhase == false)
            {
                int earthRest = (daysToPhase + startEarth) % EarthOrbit;
                int marsRest = (daysToPhase + starthMars) % MarsOrbit;

                if (earthRest == marsRest)
                {
                    //days to next phase can't be negative
                    //therefore we add mars orbit days
                    //which is minimum of days until next right phase
                    if (daysToPhase < 0)
                        daysToPhase += MarsOrbit;
                    else
                        inPhase = true;
                }

                else  
                    daysToPhase++;

            }
            Console.WriteLine($"They will be in phase after {daysToPhase} days.");
        }
    }
}