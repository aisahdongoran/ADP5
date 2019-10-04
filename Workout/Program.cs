using System;
using System.Collections.Generic;
using System.Linq;

namespace Workout
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Workout> workouts = new List<Workout>();
            workouts.AddRange(new List<Workout>{
            new Workout('A', "Jumping Jacks", 50),
            new Workout('B', "Crunches", 20),
            new Workout('C', "Squats", 30),
            new Workout('D', "Push Ups", 15),
            new Workout('E', "Wall Sit", 1),
            new Workout('F', "Burpees", 10),
            new Workout('G', "Arms Circle", 20),
            new Workout('H', "Squats", 20),
            new Workout('I', "Jumping Jacks", 30),
            new Workout('J', "Crunches", 15),
            new Workout('K', "Push Ups", 10),
            new Workout('L', "Wall Sit", 2),
            new Workout('M', "Burpees", 20),
            new Workout('N', "Burpess", 25),
            new Workout('O', "Jumping Jacks", 40),
            new Workout('P', "Arms Circle", 15),
            new Workout('Q', "Crunches", 30),
            new Workout('R', "Push Ups", 15),
            new Workout('S', "Burpess", 30),
            new Workout('T', "Squats", 15),
            new Workout('U', "Arms Circle", 30),
            new Workout('V', "Wall Sit", 3),
            new Workout('W', "Burpees", 20),
            new Workout('X', "Jumping Jacks", 60),
            new Workout('Y', "Crunches", 10),
            new Workout('Z', "Push Ups", 20)
        });
            Console.Write("Masukkan nama: ");
            string name = Console.ReadLine();

            List<Workout> userWorkouts = new List<Workout>();
            foreach (char c in name)
            {
                if (c == ' ') continue;
                var value = workouts.Find(item => item.getCode() == Char.ToUpper(c));
                userWorkouts.Add(value);
            }

            printWorkoutsResult(userWorkouts);
            printCountResult(userWorkouts);
        }

        private static void printWorkoutsResult(List<Workout> workouts)
        {
            foreach (Workout workout in workouts)
            {
                Console.WriteLine(workout.getString());
            }
        }

        private static void printCountResult(List<Workout> workouts)
        {
            var list_collapsed = workouts
            .GroupBy(p => p.name)
            .Select(g => new Workout('x', g.Key, g.Sum(p => p.count)))
            .ToList();

            foreach (Workout wk in list_collapsed)
            {
                Console.WriteLine(wk.name + ": " + wk.count);
            }
        }
    }

    class Workout
    {
        public char code;
        public string name;
        public int count;

        public Workout(char code, string name, int count)
        {
            this.code = code;
            this.name = name;
            this.count = count;
        }
        public char getCode()
        {
            return code;
        }

        public string getName()
        {
            return name;
        }

        public int getCount()
        {
            return count;
        }

        public string getString()
        {
            return code + " : " + count + " " + name;
        }
    }
}