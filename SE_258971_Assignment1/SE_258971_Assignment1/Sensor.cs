using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_258971_Assignment1
{
    internal class Sensor
    {
        private int id;
        private double value;
        private Random random;
        private double[] previousValues;
        private int currentIndex;
        private const double MIN_VOLTAGE = -1;
        private const double MAX_VOLTAGE = 1;
        private const int DAQ_RESOLUTION = 18;
        private const int SAMPLING_TIME = 4;
        private const int LOGGING_TIME = 42;
        private const int NUM_ANALOG_SENSORS = 9;
        private const int NUM_DIGITAL_SENSORS = 4;
        private const int MOVING_AVERAGE_WINDOW = 10;

        public Sensor(int id)
        {
            this.id = id;
            random = new Random(id);
            value = 0.0;
            previousValues = new double[MOVING_AVERAGE_WINDOW];
            currentIndex = 0;
        }

        /// <summary>
        /// Gets the current value of the sensor after applying a MA low pass filter and converting it to the correct voltage range
        /// </summary>
        /// <returns>The current value of the sensor</returns>
        public double GetValue()
        {
            // Get the next value from the random number generator
            double newValue = random.NextDouble();

            // Update the current value based on a moving average of the previous values and the current value
            value = value - previousValues[currentIndex] / MOVING_AVERAGE_WINDOW;
            value = value + newValue / MOVING_AVERAGE_WINDOW;
            previousValues[currentIndex] = newValue;
            currentIndex = (currentIndex + 1) % MOVING_AVERAGE_WINDOW;

            // Convert the value to the correct voltage range
            value = MIN_VOLTAGE + (value * (MAX_VOLTAGE - MIN_VOLTAGE)) / Math.Pow(2, DAQ_RESOLUTION);
            return value;
        }

        /// <summary>
        /// Gets the ID of the sensor
        /// </summary>
        /// <returns>The ID of the sensor</returns>
        public int GetId()
        {
            return id;
        }
    }
}
