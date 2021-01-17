using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbientLightControl
{
    /// <summary>
    /// Class with all the parameters pertaining to a particular session, including configuration parameters
    /// </summary>
    public class LDRValueList
    {
        List<LDRValues> allReadings = new List<LDRValues>();
        string portNumber;
        int minthreshold;
        int threshold;
        int fileCount;
        public void Add(LDRValues newValue)
        {
            allReadings.Add(newValue);
            portNumber = "";
            minthreshold = 0;
            threshold = 0;
            fileCount = 0;
        }

        public List<LDRValues> AllReadings
        {
            get { return allReadings; }
        }
        public string PortNumber
        {
            get { return portNumber; }
            set { portNumber = value; }
        }

        public int Minthreshold
        {
            get { return minthreshold; }
            set { minthreshold = value; }
        }
        public int Threshold
        {
            get { return threshold; }
            set { threshold = value; }
        }

        public int FileCount
        {
            get { return fileCount; }
            set { fileCount = value; }
        }

        public void clearList()
        {
            allReadings.Clear();
            this.portNumber = null;
            this.threshold = 0;
            this.minthreshold = 0;
            this.fileCount = 0;
        }
    }
}
