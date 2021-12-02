using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Timerz {
    public class Watch {

        private Stopwatch stopWatch;
        private string userInput;

        public void StartTime() {
            Begin:
            Console.WriteLine("Type 'Start' to begin the timer.");
            userInput = Console.ReadLine();
            if (userInput  == "Start") 
            stopWatch = Stopwatch.StartNew();
            else {
                Console.WriteLine("Please type 'Start' in order to begin the timer.");
                goto Begin;
            }
        }
        public void StopTime() {
            
            Console.WriteLine("Press any key followed by enter to stop the stopwatch. Type 5 + enter to restart.");
            userInput = Console.ReadLine();
            stopWatch.Stop();
            Console.WriteLine("The Time elapsed was" + stopWatch.Elapsed);
            if (userInput == "5") {
                stopWatch.Reset();
                stopWatch.Restart();
                StartTime();
                StopTime();
            }
        }


    }
}
