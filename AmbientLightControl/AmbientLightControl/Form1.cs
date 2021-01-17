using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;

namespace AmbientLightControl
{
    /// <summary>
    /// The main application , Form1 is is initial form that loads on application start.
    /// </summary>
    public partial class Form1 : Form
    {
        public const int MAX_VAL = 99;
        public const int MIN_VAL = 0;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            timer1.Start();
            log.Info("Application started");

        }

        DateTime now;
        int val; string elapsedTime;
        int mininumReading, maximumReading, aboveThresholdCount = 0;
        int flag = 0;int offset = 200;
        LDRValueList listOfReadings = new LDRValueList();
        Stopwatch stopwatch = new Stopwatch();
        TimeSpan ts; 
        int fileNumber = 0;
        SavedSettings settings = new SavedSettings();
        string configurationPath = "../../Files/Configuration.xml";
        /// <summary>
        /// Displays the initial home screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Homebutton_Click(object sender, EventArgs e)
        {
            reloadHomePageSettings();
        }
        /// <summary>
        /// Panel from which the port can be selected and set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connectionsettings_Click(object sender, EventArgs e)
        {
            
            listOfReadings.clearList();
            loadSavedSettings();
            connectionsettings.Visible = false;
            settingspanel.Visible = true;
            generate.Visible = false;
            connect.Visible = true;
            portBox.Enabled = true;
            minimum.Text = "";
            maximum.Text = "";
            thresholdcount.Text = "";
            thresholdvalue.Text = "";
            currentValue.Text = "";
            sessionend.Text = "";
            sessionstart.Text = "";
            mininumReading = 0; maximumReading = 0; aboveThresholdCount = 0;flag = 0;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }


       /// <summary>
       /// Connect click opens the port for reading the values
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false;
                clientport.PortName = portBox.Text;
                clientport.Open();
                thresholdSettings.Visible = true;
                connectionsettings.Visible = false;
                connect.Visible = false;
                portBox.Enabled = false;
            }
            catch (UnauthorizedAccessException)
            {
                log.Info("Exception in connecting to port- Clear Screen Performed :case executed");
                errorLabel.Visible = true;
                errorLabel.Text = "Error:Unable to connect to port.Port occupied";
                reloadHomePageSettings();
                return;

            }
            catch (System.ArgumentException)
            {
                log.Info("Exception in connecting to port- Clear Screen Performed :case executed");
                errorLabel.Visible = true;
                errorLabel.Text = "Error:Port Name is empty:";
                reloadHomePageSettings();
                return;
            }
        }
        /// <summary>
        /// it calls the delegate for reading the values from the port as the values arrive  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EstablishConnection_Click(object sender, EventArgs e)
        {
            if (setCheckSettingsParameters() == 0)
            {
                view.Visible = false;
                errorLabel.Visible = false;
                settingsTablePanel.Visible = false;
                rightPanel.SetRowSpan(valuePanel, 1);
                valuePanel.SetRowSpan(dataGridView1, 1);
                dataGridView1.Visible = false;
                bunifuGauge1.Visible = true;
                valuesPanel2.Visible = true;
                generate.Visible = false;
                sessionstart.Text = now.ToString("hh:mm:ss");
                thresholdvalue.Text = minthreshold.Text + "-" + threshold.Text;
                manualStatus.Visible = true;
                homebutton.Visible = false;
                rightPanel.Visible = true;
                disconnect.Visible = true;
                stopwatch.Start();
                clientport.DataReceived += new SerialDataReceivedEventHandler(client_DataReceived);
            }
        }
       /// <summary>
       /// closes the serial port and stops the timestamp to get the entire elapsed time of the session
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Disconnect_Click(object sender, EventArgs e)
        {

            clientport.Close();
            view.Visible = true;
            homebutton.Visible = true;
            manualStatus.Visible = false;
            disconnect.Visible = false;
            generate.Enabled = true;
            generate.Visible = true;
            elapsedTime = now.ToString("hh:mm:ss");
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            sessionend.Text = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
         
        }


        /// <summary>
        /// Stores the parameter values of the last session into the configuration file and creates a new datafile and stores the values of the session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generate_Click_1(object sender, EventArgs e)
        {
            try
            {
                settings.FileCount = fileNumber;
                XmlSerializer settingSerializer = new XmlSerializer(typeof(SavedSettings));
                using (FileStream fs = new FileStream("../../Files/Configuration.xml", FileMode.Create))
                {
                    settingSerializer.Serialize(fs, settings);
                    fs.Close();
                }

                XmlSerializer dataSerializer = new XmlSerializer(typeof(LDRValueList));
                using (FileStream fs = new FileStream("../../Files/DataFile(" + fileNumber + ").xml", FileMode.Create))
                {
                    dataSerializer.Serialize(fs, listOfReadings);

                    fs.Close();
                }
                loadData("../../Files/DataFile(" + fileNumber + ").xml");
            }
            catch(Exception ex)
            {
                errorLabel.Text = ex.ToString();
                errorLabel.Visible = true;
                reloadHomePageSettings();
                return;

            }
           
        }
        /// <summary>
        /// Opens the dialog box to selecting the file and calls load file to display the contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void View_Click(object sender, EventArgs e)
        {
            
            string fileName = "";
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            loadData(fileName);
            
        }
        /// <summary>
        /// Extracts information from the XML file already generated
        /// </summary>
        /// <param name="fileName"></param>
        private void loadData(string fileName)
        {
            if (clientport.IsOpen)
            {
                clientport.Close();
            }
            Panel.Visible = false;
            displaySettingsPanel.Visible = false;
            string path = fileName;
            LDRValues lastReading = new LDRValues();
            LDRValueList listOfReadings = new LDRValueList();
            try
            {
                XmlSerializer dataSerializer = new XmlSerializer(typeof(LDRValueList));
                using (StreamReader reader = new StreamReader(path))
                {
                    listOfReadings = (LDRValueList)dataSerializer.Deserialize(reader);

                }
            }
            catch (System.InvalidOperationException)
            {
                errorLabel.Text = "Please select XML data-file for parsing";
                errorLabel.Visible = true;
                return;
            }
            catch (ArgumentException)
            {
                errorLabel.Text = "Error:File Not Selected";
                errorLabel.Visible = true;
                return;

            }
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            dataGridView1.DataSource = listOfReadings.AllReadings;
            try
            {
                lastReading = listOfReadings.AllReadings[listOfReadings.AllReadings.Count - 1];
                sessionstart.Text = listOfReadings.AllReadings[0].CurrentTime;

            }

            catch (ArgumentOutOfRangeException)
            {
                errorLabel.Text = "Error:No readings were obtained";
                errorLabel.Visible = true;
                return;
            }
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            int overThresholdCount = 0;
            try
            {
                foreach (LDRValues singleReading in listOfReadings.AllReadings)
                {
                    chart1.Series[0].Points.AddXY(singleReading.CurrentTime, singleReading.IntensityValue);
                    if (singleReading.AlarmRaised) overThresholdCount++;
                }
            }
            catch(ArgumentNullException)
            {
                errorLabel.Text = "Error:The file contains corrupt values";
                errorLabel.Visible = false;
                return;
            }
            
            
            try
            {
                minimum.Text = lastReading.MinimumIntensity.ToString();
                maximum.Text = lastReading.MaximumIntensity.ToString();
                thresholdcount.Text = overThresholdCount.ToString();
                displayPort.Text = listOfReadings.PortNumber.ToString();
                displayMinThreshold.Text = listOfReadings.Minthreshold.ToString() + "-" + listOfReadings.Threshold.ToString();
                displaySettingsPanel.Visible = true;
            }
            catch (NullReferenceException)
            {
                errorLabel.Text = "Error:The XML contains missing fields!";
                errorLabel.Visible = true;
                Panel.Visible = false;
                return;
            }
            generate.Visible = false;
            manualStatus.Visible = false;
            rightPanel.SetRowSpan(valuePanel, 2);
            valuesPanel2.Visible = false;
            valuePanel.SetRowSpan(dataGridView1, 2);
            bunifuGauge1.Visible = false;   
            dataGridView1.Visible = true;
            errorLabel.Visible = false;
            settingsTablePanel.Visible = false;
            rightPanel.Visible = true;
            Panel.Visible = true;
            
        }
        /// <summary>
        /// The function is used to index the elements in the datagrid and add serial number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        /// <summary>
        /// Timer is used to keep track of the correct time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
             now = DateTime.Now;
        }
        /// <summary>
        /// sets the parameters of the chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 99;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Title = "Light Intensity(lux)";
            chart1.ChartAreas[0].AxisX.Title = "Time (mm:ss)";
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.Name = "Time";
            chart1.ChartAreas[0].AxisY.Name = "Intensity";
            chart1.Series[0].Name = "Time-Intensity Plot";
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.InterlacedColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.InterlacedColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
         
        }
        /// <summary>
        /// sets the combobox values with the port values
        /// </summary>
        void getAvailablePorts()
        {

            String[] ports = SerialPort.GetPortNames();
            portBox.Items.AddRange(ports);

        }
        /// <summary>
        /// initialises all the parameters for the home page loading
        /// </summary>
        public void reloadHomePageSettings()
        {
            //errorLabel.Visible = false;
            settingsTablePanel.Visible = true;
            rightPanel.Visible = false;
            thresholdSettings.Visible = false;
            connectionsettings.Visible = true;
            settingspanel.Visible = false;
            if (clientport.IsOpen)
                clientport.Close();
            displaySettingsPanel.Visible = false;
            Panel.Visible = true;
            disconnect.Visible = false;
            manualStatus.Visible = false;
        }
        /// <summary>
        /// On application startup the configration file is loaded and the values are set. It holds the last setting paramenters.
        /// </summary>
        private void loadSavedSettings()
        {
            if (File.Exists(configurationPath))
            {
                XmlSerializer settingSerializer = new XmlSerializer(typeof(SavedSettings));
                using (Stream reader = new FileStream(configurationPath, FileMode.Open))
                {
                    settings = (SavedSettings)settingSerializer.Deserialize(reader);
                    reader.Close();
                }
                fileNumber = settings.FileCount;
                fileNumber = fileNumber + 1;
                portBox.SelectedIndex = portBox.FindString(settings.PortNumber);
                minthreshold.Text = settings.Minthreshold.ToString();
                threshold.Text = settings.Threshold.ToString();
               // settings.FileCount = fileNumber;
            }

        }
        /// <summary>
        /// The delegate being called when a value arrives at the port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void client_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    now = DateTime.Now;
                    val = int.Parse(clientport.ReadLine());
                    if (val >= offset)
                    {
                        manualStatus.Text = "Manual";
                        val = val - offset;
                    }
                    else
                    {
                        manualStatus.Text = "Automatic";
                    }

                    elapsedTime = now.ToString("hh:mm:ss");
                    currentValue.Text = val.ToString();
                    chart1.Series[0].Points.AddXY(elapsedTime, val);
                    setValues();
                    listOfReadings.PortNumber = settings.PortNumber;
                    listOfReadings.Minthreshold = settings.Minthreshold;
                    listOfReadings.Threshold = settings.Threshold;
                    listOfReadings.FileCount = settings.FileCount;
                });
            }
            catch
            {
                errorLabel.Text = "ObjectDisponsed: Reset Connection";
            }
            
        }
        /// <summary>
        /// Evaluates the threshold range and sets the values of the object
        /// </summary>
        /// <returns></returns>
        public int setCheckSettingsParameters()
        {
            int validThreshold = 0;
            try
            {
                if ((int.Parse(threshold.Text) <= int.Parse(minthreshold.Text)) || (int.Parse(threshold.Text) <= 0) || (int.Parse(minthreshold.Text) < 0))
                {
                    errorLabel.Text = "Enter a valid range";
                    errorLabel.Visible = true;
                    validThreshold = 1;

                }

                if (int.Parse(minthreshold.Text) > MIN_VAL && int.Parse(minthreshold.Text) < MAX_VAL )
                {
                    settings.Minthreshold = int.Parse(minthreshold.Text);

                    settings.Threshold = int.Parse(threshold.Text);
                }
                settings.PortNumber = portBox.Text;
                
            }
            catch (Exception)
            {
                validThreshold = 1;
                errorLabel.Visible = true;
                errorLabel.Text = "Threshold Limits not Enterted: Invalid Entry";

            }
            return validThreshold;

        }
        /// <summary>
        /// The function sets the minimum maximum and threshold count
        /// </summary>
        public void setValues()
        {
           
            bunifuGauge1.Value = val;
            LDRValues singleReading = new LDRValues();
            singleReading.IntensityValue = val;
            singleReading.CurrentTime = elapsedTime;
            sessionend.Text = elapsedTime;
            if (flag == 1)
            {
                if (val < mininumReading)
                {
                    minimum.Text = val.ToString();
                    mininumReading = val;

                }

                if (val > maximumReading)
                {
                    maximum.Text = val.ToString();
                    maximumReading = val;

                }

            }
            else
            {
                sessionstart.Visible = true;
                sessionstart.Text = elapsedTime;
                minimum.Text = val.ToString();
                minimum.Visible = true;
                mininumReading = val;
                maximum.Text = val.ToString();
                maximum.Visible = true;
                maximumReading = val;
                flag = 1;
            }
            try
            {
                if (val > int.Parse(threshold.Text) || val < int.Parse(minthreshold.Text))
                {
                    aboveThresholdCount++;
                    thresholdcount.Text = aboveThresholdCount.ToString();
                    thresholdcount.Visible = true;
                    singleReading.AlarmRaised = true;
                    pictureBox1.Image = Image.FromFile("../../Files/alert.png");
                }
                else
                {
                    pictureBox1.Image = null;
                    singleReading.AlarmRaised = false;
                }
               /* if((int.Parse(threshold.Text)<= int.Parse(minthreshold.Text))||(int.Parse(threshold.Text)<=0)|| (int.Parse(minthreshold.Text) < 0))
                {
                    errorLabel.Text = "Enter a valid range";
                    isThresholdValuesValid = 1;

                }*/
            }
            catch(Exception)
            {
                errorLabel.Text = "Invalid entry";
                errorLabel.Visible = true;
                return;
            }
           
            button7.Enabled = true;
            singleReading.MinimumIntensity = mininumReading;
            singleReading.MaximumIntensity = maximumReading;
            listOfReadings.AllReadings.Add(singleReading);


        }


    }
}
