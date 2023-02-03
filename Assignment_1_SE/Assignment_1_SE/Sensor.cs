using System;

namespace Assignment_1_SE
{
    class Sensor
    {
        private int id;
        private double value;
        private Random random;
        private const double MIN_VOLTAGE = -1;
        private const double MAX_VOLTAGE = 1;
        private const int DAQ_RESOLUTION = 18;
        private const int SAMPLING_TIME = 4;
        private const int LOGGING_TIME = 42;
        private const int NUM_ANALOG_SENSORS = 9;
        private const int NUM_DIGITAL_SENSORS = 4;

        public Sensor(int id)
        {
            this.id = id;
            random = new Random(id);
            value = 0.0;
        }

        /// <summary>
        /// Gets the current value of the sensor after applying a MA low pass filter and converting it to the correct voltage range
        /// </summary>
        /// <returns>The current value of the sensor</returns>
        public double GetValue()
        {
            // Apply MA low pass filter and convert the value to the correct voltage range
            value += random.NextDouble();
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
