﻿namespace PCPartsShop.Models
{
    public class CPU : Component
    {
        public double Freq { get; set; } // ing GHz
        public string Socket { get; set; }
        public int Tech { get; set; } // in nm
        public int MFreq { get; set; } // MHz
        public int TDP { get; set; } // in W
        public int Cores { get; set; }

        private static int c = 0;
        private static void createID()
        {
            c++;
        }

        // contructors not needed anymore
        public CPU(string make, string model, double frequency, string socket, int tech, int mfreq, int tdp, int corenr) : base(make, model)
        {
            createID();
            ID = c;
            Freq = frequency;
            Socket = socket;
            Tech = tech;
            MFreq = mfreq;
            TDP = tdp;
            Cores = corenr;
        }
        public CPU() : base()
        {
            createID();
            ID = c;
        }
    }
}
