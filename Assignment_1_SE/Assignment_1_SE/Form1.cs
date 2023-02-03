namespace Assignment_1_SE
{
    public partial class Form1 : Form
    {
        private Sensor[] sensors;
        private int numberOfSensors;
        private int counter = 0;
        private string fileName;

        public Form1()
        {
            InitializeComponent();
            numberOfSensors = 9 + 4; // Total number of sensors (9 analog + 4 digital)
            sensors = new Sensor[numberOfSensors];
            for (int i = 0; i < numberOfSensors; i++)
            {
                sensors[i] = new Sensor(i);
            }
            fileName = "SensorData.csv";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Check for a valid sampling time interval
            double samplingTime = Convert.ToDouble(txtsmp.Text);
            double nextSamplingTime = Convert.ToDouble(txtsmp.Text);
            if (DateTime.Now.TimeOfDay.TotalSeconds >= nextSamplingTime)
            {
                // Read all the sensor values
                double[] sensorValues = new double[numberOfSensors];
                for (int i = 0; i < numberOfSensors; i++)
                {
                    sensorValues[i] = sensors[i].GetValue();
                }

                // Display the sensor values in the sensor Values group window
                txtshow.Text = "";
                for (int i = 0; i < numberOfSensors; i++)
                {
                    txtshow.Text += "Sensor " + (i + 1) + ": " + sensorValues[i].ToString() + Environment.NewLine;
                }

                // Update the Next Sampling Time field
                txtsmp.Text = (nextSamplingTime + samplingTime).ToString();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            // Check for a valid logging time interval
            double loggingTime = Convert.ToDouble(txtlog.Text);
            double nextLoggingTime = Convert.ToDouble(txtlog.Text);
            if (DateTime.Now.TimeOfDay.TotalSeconds >= nextLoggingTime)
            {
                // Write the last read sensor values to a text file
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    for (int i = 0; i < numberOfSensors; i++)
                    {
                        writer.Write(sensors[i].GetValue().ToString() + ",");
                    }
                    writer.WriteLine(DateTime.Now.ToString());
                }

                // Update the field showing the file name and number of writings
                txtfilenum.Text = fileName + " (Written " + ++counter + " times)";

                // Update the Next Logging Time field
                txtlog.Text = (nextLoggingTime + loggingTime).ToString();
            }
        }
    }
}

        private void txtsmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlog_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtshow_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please input text in all input fields (use your own text here!!!)");

        }
    }
}