// To show creativity and exceed core requirements, I've implemented a leveling up system into my program. In the beginning of the program, 
// the user is asked the number of points needed for each level up.

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}