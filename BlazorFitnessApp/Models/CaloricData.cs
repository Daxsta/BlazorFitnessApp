using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFitnessApp.Enums;

namespace BlazorFitnessApp.Models
{
    public class CaloricData
    {
        public CaloricData()
        {
            Excercises = new List<Excercise>();
        }


        public Gender Gender { get; set; } 

        public double Weight { get; set; }

        public double Height { get; set; }

        public int Age { get; set; }

        public List<Excercise> Excercises { get; set; }

        public double SleepDuration { get; set; }

        public const double SleepLevel = 0.95;

        public double WorkDuration { get; set; }

        public double WorkLevel { get; set; }

        public int Maintenance { get; set; }

        public int PAL { get; set; }
    }
}
