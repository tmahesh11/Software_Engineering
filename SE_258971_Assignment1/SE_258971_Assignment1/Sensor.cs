using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE_258971_Assignment1
{
    class Sensor
    {
        double dVal;
        int sId;
        Random rSenVal;
        bool isDigital;

        public Sensor(int id, bool digital)
        {
            sId = id;
            isDigital = digital;
            rSenVal = new Random(id);
            dVal = 0.0F;
        }

        public double GetValue()
        {
            if (isDigital)
            {
                dVal = rSenVal.Next(0, 2);
            }
            else
            {
                dVal = (rSenVal.NextDouble() * 2) - 1;
            }
            return dVal;
        }

        public int GetSensId()
        {
            return sId;
        }
    }
}
