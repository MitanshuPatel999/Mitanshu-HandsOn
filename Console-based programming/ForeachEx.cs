using System;


namespace ForeachEx
{
    public class Program
    {
        public static void Main()
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;


            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            // Student names
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            foreach (string name in studentNames)
            {
                int sum = 0;
                string gr = new("");
                int[] cs;
                if (name == "Sophia")
                {
                    cs = sophiaScores;
                }
                else if (name == "Andrew")
                {
                    cs = andrewScores;
                }
                else if (name == "Emma")
                {
                    cs = emmaScores;
                }
                else
                {
                    cs = loganScores;
                }

                foreach (var i in cs)
                {
                    sum += i;
                }

                decimal avg = (decimal)sum / currentAssignments;

                if (avg >= 97)
                { gr = "A+"; }

                else if (avg >= 93)
                { gr = "A"; }

                else if (avg >= 90)
                { gr = "A-"; }

                else if (avg >= 87)
                { gr = "B+"; }

                else if (avg >= 83)
                { gr = "B"; }

                else if (avg >= 80)
                { gr = "B-"; }

                else if (avg >= 77)
                { gr = "C+"; }

                else if (avg >= 73)
                { gr = "C"; }

                else if (avg >= 70)
                { gr = "C-"; }

                else if (avg >= 67)
                { gr = "D+"; }

                else if (avg >= 63)
                { gr = "D"; }

                else if (avg >= 60)
                { gr = "D-"; }
                else
                { gr = "F"; }

                Console.WriteLine($"{name} -----> Average Marks:{avg} ; Grade{gr}");


            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }
    }
}