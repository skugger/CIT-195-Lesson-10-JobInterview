﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Assignment10Ex4
{
    // These classes are intentionally empty for the purpose of this example.
    internal class Alarm { }
    internal class Teeth { }
    internal class Shower { }
    internal class Dress { }
    internal class Drive { }

    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                TurnOffAlarm();
                Console.WriteLine("Out of bed and ready to go");

                BrushTeeth();
                Console.WriteLine("Teeth are clean");

                Shower shower = await TakeAShowerAsync();
                Console.WriteLine("Showering is done");

                GetDressed();
                Console.WriteLine("Dressed and ready to go");

                Drive drive = await DriveToWorkAsync(10);
                Console.WriteLine("Check your smile in rear-view mirror.");

                Console.WriteLine("Go knock 'em dead!");
                sw.Stop();
                Console.WriteLine("The program took " + sw.ElapsedMilliseconds + " milliseconds to run");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"An exception has occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TurnOffAlarm()
        {
            Console.WriteLine("Turned off alarm");
            return;
        }


        private static void BrushTeeth() => Console.WriteLine("Putting paste on the brush... Brushing");


        private static async Task <Shower> TakeAShowerAsync()
        {
            Console.WriteLine("Warming the water...");
            await Task.Delay(1000);
            Console.WriteLine($"Shampoo and Condition the hair");
            Console.WriteLine("Rinse off");
            // Console.WriteLine("That wasn't shampoo, that was upholstery dye!  You're an eggplant!");
            // throw new InvalidOperationException("You're hideous!");
            await Task.Delay(2000);
            Console.WriteLine("Dry off");
            return new Shower();
        }

        private static void GetDressed() => Console.WriteLine("Together and ready to go");

        private static async Task <Drive> DriveToWorkAsync(int time)
        {
            Console.WriteLine("Starting the car...");
            for (int i = 0; i < time; i++)
            {
                Console.WriteLine($"Driving...");
            }
            // Console.WriteLine("Oh wow - it turns out that the Earth really is flat, after all!");
            // throw new InvalidOperationException("Drove over the edge of the Earth.");
            await Task.Delay(1000);
            Console.WriteLine("Arrived at office complex.");
            return new Drive();
        }
    }
}
