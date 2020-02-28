using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFitnessApp
{
    public class Excercise
    {
        private double _pal;
        private double _time;

        public double PAL
        {
            get
            {
                return _pal;
            }
            set
            {
                _pal = value;
            }
        }
        public double Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

    }
}
