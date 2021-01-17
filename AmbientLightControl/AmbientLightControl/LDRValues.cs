using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbientLightControl
{
    /// <summary>
    /// Class that stores information regarding one particular incoming value from the LDR
    /// </summary>
    public class LDRValues
    {
        int intensityValue;
        string currentTime;
        int minimumIntensity;
        int maximumIntensity;
        bool overThreshold;
        public int IntensityValue
        {
            get
            { return intensityValue; }
            set
            { intensityValue = value; }
        }

        public string CurrentTime
        {
            get
            { return currentTime; }
            set
            { currentTime = value; }
        }

        public int MaximumIntensity
        {
            get { return maximumIntensity; }
            set { maximumIntensity = value; }
        }

        public int MinimumIntensity
        {
            get { return minimumIntensity; }
            set { minimumIntensity = value; }
        }
        public bool AlarmRaised
        {
            get { return overThreshold; }
            set { overThreshold = value; }
        }

    }
}
