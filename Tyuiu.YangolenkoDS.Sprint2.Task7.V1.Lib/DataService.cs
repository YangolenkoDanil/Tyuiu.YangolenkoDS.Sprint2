﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YangolenkoDS.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= x) && (y <= 1) && (y >= 0))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
