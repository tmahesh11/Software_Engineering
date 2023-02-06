using System.Text;

namespace SE_258971_Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSampling_Click(object sender, EventArgs e)
        {
            // Check for valid sampling time interval
            int nextSamplingTime = 0;
            if (!int.TryParse(textBoxNextSamplingTime.Text, out nextSamplingTime))
            {
                MessageBox.Show("Invalid Sampling Time Interval!");
                return;
            }

            // Create an array of sensors
            Sensor[] sensors = new Sensor[13];
            for (int i = 0; i < 9; i++)
            {
                sensors[i] = new Sensor(i, false);
            }
            for (int i = 9; i < 13; i++)
            {
                sensors[i] = new Sensor(i, true);
            }

            // Read all the sensor values
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                sb.AppendFormat("Sensor {0}: {1}\r\n", sensors[i].GetSensId(), sensors[i].GetValue());
            }

            // Display the sensor values in the textbox show field
            textBoxShow.Text = sb.ToString();

            // Update the Next Sampling Time
            textBoxNextSamplingTime.Text = (nextSamplingTime + 4).ToString();
        }


        private void buttonLogging_Click(object sender, EventArgs e)
        {
            // Check for valid logging time interval
            int nextLoggingTime = 0;
            if (!int.TryParse(textBoxNextLoggingTime.Text, out nextLoggingTime))
            {
                MessageBox.Show("Invalid Logging Time Interval!");
                return;
            }

            // Write the last read sensor values to a text file in CSV Type
            string fileName = string.Format("SensorData_{0}.csv", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Time,Sensor 0,Sensor 1,Sensor 2,Sensor 3,Sensor 4,Sensor 5,Sensor 6,Sensor 7,Sensor 8,Sensor 9,Sensor 10,Sensor 11,Sensor 12");
                var sensorValues = textBoxShow.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                sw.WriteLine("{0}\n {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13}",
                              DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                              sensorValues[0], sensorValues[1], sensorValues[2], sensorValues[3],
                              sensorValues[4], sensorValues[5], sensorValues[6], sensorValues[7],
                              sensorValues[8], sensorValues[9], sensorValues[10], sensorValues[11],
                              sensorValues[12]);
            }


            // Update the Next Logging Time
            textBoxNextLoggingTime.Text = (nextLoggingTime + 42).ToString();
        }

        private void textBoxNextSamplingTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNextLoggingTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSampling_Click(object sender, EventArgs e)
        {

        }

        private void labelLogging_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxSampling_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxLogging_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxShow_Enter(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please input text in all input fields (use your own text here!!!).",
                               "Input Information", System.Windows.Forms.MessageBoxButtons.OK);

        }
        
    }
}