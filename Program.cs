﻿using System;

namespace Task_2_week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string answer = "тень";
            string option = "";
            do
            {
                Console.WriteLine("Ты предстал перед могучим сфинксом. Внимай моим загадкам - говорит он.");
                Console.WriteLine($"Его не потрогаешь и не увидишь " +
                    $"\nФормы нет у него." +
                    $"\nНет вообще ничего – только имя." +
                    $"\nОно коротким бывает, то длинным," +
                    $"\nИ оно всегда с нами," +
                    $"\nВо всех разговорах, забавах и играх.");

                option = Console.ReadLine();

            }
            while (option != answer);


                




            
            
        }
    }
}
