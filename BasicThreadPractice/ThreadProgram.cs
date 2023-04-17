// This code defines a namespace named BasicThreadPratice that contains a class named ThreadProgram.
using System;
namespace BasicThreadPratice
{
    // This is the class ThreadProgram.
    public class ThreadProgram
    {
        // This field is used to hold the current character to be displayed.
        char asterisk = '*';

        // This method displays a string "C#-trådning er nemt!" 5 times with a 1-second delay between each output.
        public void String()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
                Thread.Sleep(1000);
            }
        }

        // This method displays a string "Også med flere tråde ..." 5 times with a 1-second delay between each output.
        public void String2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Også med flere tråde …");
                Thread.Sleep(1000);
            }
        }

        // This method generates a random temperature and displays it. If the temperature is greater than 100 or less than 0, an alarm message is displayed.
        public void TemperatureThread()
        {
            Random random = new Random();
            int alarmCount = 0;
            while (alarmCount < 3)
            {
                Thread.Sleep(2000);
                int temperature = random.Next(-20, 120);
                Console.Write($"Temperature: {temperature}°C");
                if (temperature > 100 || temperature < 0)
                {
                    Console.Write(" ALARM!");
                    alarmCount++;
                }
                Console.WriteLine();
            }
        }

        // This method reads a single character from the console input and stores it in the asterisk field.
        public void Read()
        {
            string strInput;
            bool allowedInputs;
            while (true)
            {
                strInput = Console.ReadLine();
                allowedInputs = char.TryParse(strInput, out this.asterisk);
                if (allowedInputs == false)
                    this.asterisk = '*';
            }
        }

        // This method displays the current value of the asterisk field on the console.
        public void Print()
        {
            while (true)
            {
                Console.Write(this.asterisk);
                Thread.Sleep(100);
            }
        }
    }
}
