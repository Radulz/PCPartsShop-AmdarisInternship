﻿using System;
using PCPartsShop.Models;
using PCPartsShop.Repositories;
using System.Collections.Generic;

namespace PCPartsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCpu = new CPU
            {
                UniqueId = Guid.NewGuid(),
                Make = "make",
                Cores = 2
            };

            Component a, b, c, d, e;
            CPU aux, aux1;
            GPU aux2, aux3;
            MOBO aux4, aux5;
            PSU aux6, aux7;
            RAM aux8, aux9;

            CPURepository proc = new CPURepository();
            GPURepository gproc = new GPURepository();
            MOBORepository boards = new MOBORepository();
            PSURepository punits = new PSURepository();
            RAMRepository sticks = new RAMRepository();
            List<int> f = new List<int>();
            f.Add(2133);
            f.Add(2400);
            f.Add(2666);
            f.Add(3000);
            f.Add(3200);
            
            aux = new CPU("intel", "i7", 2.5, "LGA1200", 14, 2666, 125, 6);
            a = new CPU();
            b = new GPU();
            aux2 = new GPU("Nvidia", "GTX1060", 1833, 6, "GDDR5", 8, 150, 223);
            c = new MOBO();
            aux4 = new MOBO("MSI", "MPG", "AM4", "ATX", "B550", f, "DDR4");
            d = new PSU();
            aux6 = new PSU("Corsair", "TX750", 750, "Non-Modular");
            e = new RAM();
            aux8 = new RAM("HyperX", "Fury", "DDR4", 16, 2400, 1.2);
       
            proc.Add(aux);
            proc.Add((CPU)a);
            gproc.Add(aux2);
            gproc.Add((GPU)b);
            boards.Add(aux4);
            boards.Add((MOBO)c);
            punits.Add(aux6);
            punits.Add((PSU)d);
            sticks.Add(aux8);
            sticks.Add((RAM)e);
            foreach (CPU i in proc.GetAll())
            {
                Console.WriteLine(i.ID + " " + i.Make + " " + i.Model);
            }
            foreach (GPU i in gproc.GPUs)
            {
                Console.WriteLine(i.ID + " " + i.Make + " " + i.Model);
            }
            foreach (MOBO i in boards.MOBOs)
            {
                Console.WriteLine(i.ID + " " + i.Make + " " + i.Model);
            }
            foreach (PSU i in punits.PSUs)
            {
                Console.WriteLine(i.ID + " " + i.Make + " " + i.Model);
            }
            foreach (RAM i in sticks.RAMs)
            {
                Console.WriteLine(i.ID + " " + i.Make + " " + i.Model);
            }
            aux1 = proc.GetItem(5);
            aux3 = gproc.GetItem(2);
            aux5 = boards.GetItem(1);
            aux7 = punits.GetItem(2);
            aux9 = sticks.GetItem(2);
            if (aux1 != null)
            {
                Console.WriteLine(aux1.ID);
            }
            else
            {
                Console.WriteLine("This CPU doesn\'t exist");
            }
            Console.WriteLine(aux3.ID);
            Console.WriteLine(aux5.ID);
            Console.WriteLine(aux7.ID);
            Console.WriteLine(aux9.ID);



        }
    }
}
