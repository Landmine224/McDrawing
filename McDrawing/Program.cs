// File/Project Prolog
// Name:     Landon Tolman
// Period:   A4
// Username: Tolmalan000
// Project:  McDrawing
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using System.Drawing;

namespace McDrawing
{
    static class Program
    {

        // EXAMPLE
        public static void DrawTree(int x, int y)
        {
            McRectangle trunk = new McRectangle(x + 10, y + 20, 20, 60, "brown");
            McCircle leftLeaves = new McCircle(x, y + 20, 20, "green");
            McCircle middleLeaves = new McCircle(x + 20, y + 10, 20, "green");
            McCircle rightLeaves = new McCircle(x + 40, y + 20, 20, "green");
        }

        // EDIT THIS ONE
        
        static Random rnd = new Random();
        public static string RandomColor()
        {
            string[] colors = { "red", "orange", "yellow", "green", "blue", "indigo", "violet", "purple", "white", "grey", "black", "brown" };
            int choice = rnd.Next(colors.Length);
            return colors[choice];
        }

        // Edit this method!
        // This runs once before anything starts
        private static void DrawStuff()
        {
            // EXAMPLE



            // USE THE METHOD YOU WROTE HERE

        }

        static DrawTriangle t;

        // ADVANCED HERE

        // If you want to have variables that stay for every tick event, add 
        // them here (Just add "static" beforehand).
        static McRectangle rect1;

        // Here is the stuff that happens before everything (just like the 
        // DrawStuff method)
        private static void UserSetupCode()
        {
            // Uncomment this and the code in "TickCode" to see something cool!
            DrawTriangle b = new DrawTriangle(50, 80, 100, "green");
            b.changeColor("blue");
            
        }

        // Edit this method if you want to make things move
        // This runs 100 times a second
        private static void UserTickCode(object sender, EventArgs e)
        {
            // Uncomment this and the code in UserSetupCode if you want to see 
            // something cool!
            //if (t.x > 200)
            //{
            //    t.x = 0;
            //}
            //else
            //{
            //    t.x += 1;
            //}
        }


        // DO NOT EDIT HERE

        #region Do not edit

        // Don't edit anything below this line ///////////////////////////////
        static Timer timer1;

        // Do not edit this method
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            DrawStuff();
            UserSetupCode();
            SetupTimer();
            Application.Run(form1);
        }

        // Don't edit this method
        private static void SetupTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(UserTickCode);
            timer1.Interval = 10;
            timer1.Start();
        }

        #endregion

    }
}
