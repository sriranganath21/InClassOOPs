using System;
using System.Collections.Generic;
using System.Text;

namespace InClassOOPs
{
    class car

    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }
}
