﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview__HumansPandasRobots
{
    class Human : LivingThing, IGreeter
    {
        public void DisplayGreeting()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
         

    }
}
