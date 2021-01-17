using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbientLightControl
{
    public class SavedSettings
    {
        string portNumber;
       int minthreshold;
        int threshold;
        int fileCount;

        public SavedSettings()
        {
            portNumber = "";
            minthreshold = 0;
            threshold = 0;
            fileCount = 0;
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
    }
}
