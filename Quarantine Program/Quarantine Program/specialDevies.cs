using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Quarantine_Program
{
    class specialDevies
    {
        public static string getUniqueID(string drive)
        {

            string volumeSerial = getVolumeSerial(drive);
            string cpuID = getCPUID();
            string x1 = cpuID.Substring(3, 5);
            string x2 = volumeSerial.Substring(2, 4);
            string x3 = cpuID.Substring(5, 2);
            string x4 = volumeSerial.Substring(4, 2);
            string x5 = cpuID.Substring(8, 3);
            string no = x1 + x2 + x3 + x4 + x5;
            return no;
        }


        // -------------------------------------------------------------------------------------------------------------------------
        // دالة لاحضاء رقم السيريال الخاص بالهارديسك
        public static string getVolumeSerial(string drive)
        {
            if (drive == string.Empty)
            {
                foreach (DriveInfo compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady)
                    {
                        drive = compDrive.RootDirectory.ToString();
                        break;
                    }
                }
            }

            if (drive.EndsWith(":\\"))
            {
                drive = drive.Substring(0, drive.Length - 2);
            }


            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }


        // -------------------------------------------------------------------------------------------------------------------------

        // دالة لاحضاء رقم السيريال الخاص بالمعالج
        public static string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }

            return cpuInfo;
        }

    }
}
