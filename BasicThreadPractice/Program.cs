using System;
using System.Diagnostics;
using System.Threading;
using BasicThreadPratice;

namespace BasicThreadPratice
{

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            // Start two threads to print two strings
            program.ShowStrings();

            // Start a thread to simulate temperature readings and alarms
            program.Temperature();

            // Start two threads to read user input and display asterisks
            program.ShowKeys();

            Console.Read();
        }

        private void ShowStrings()
        {
            // Create an instance of ThreadProgram
            ThreadProgram threadProgram = new ThreadProgram();

            // Create a thread to execute the String method of ThreadProgram
            Thread thread = new Thread(new ThreadStart(threadProgram.String));
            thread.Name = "ShowStr";
            thread.Start();

            // Create another thread to execute the String2 method of ThreadProgram
            Thread thread2 = new Thread(new ThreadStart(threadProgram.String2));
            thread2.Name = "ShowStr2";
            thread2.Start();
        }

        private void Temperature()
        {
            // Create an instance of ThreadProgram
            ThreadProgram threadProgram = new ThreadProgram();

            // Create a thread to simulate temperature readings and alarms
            Thread temperatureThread = new Thread(new ThreadStart(threadProgram.TemperatureThread));
            temperatureThread.Name = "TemperatureThread";
            temperatureThread.Start();

            // Wait for the temperature thread to finish
            temperatureThread.Join();

            // Print a message to indicate that the temperature thread has terminated
            Console.WriteLine("Alarm-tråd termineret!");
        }

        private void ShowKeys()
        {
            // Create an instance of ThreadProgram
            ThreadProgram threadProgram = new ThreadProgram();

            // Create a thread to read user input
            Thread getKeys = new Thread(new ThreadStart(threadProgram.Read));
            getKeys.Name = "GetKeys";
            getKeys.Start();

            // Create another thread to display asterisks
            Thread showCharThread = new Thread(new ThreadStart(threadProgram.Print));
            showCharThread.Name = "ShowCharThread";
            showCharThread.Start();
        }
    }
}
