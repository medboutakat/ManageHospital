using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ManageHospitalApi
{
    public class FolderCreator
    {


        public static string AppPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), _appPath);  
            }
        } 
        const string _appPath = "ManageHospital";
        const string FilePath = "images";
        public static string ImagePath
        {
            get
            {
                return Path.Combine(AppPath, FilePath);
            }
        }


        public static void CreateIfNotExist()
        {
            if (!Directory.Exists(AppPath))
            {
                Directory.CreateDirectory(AppPath);
            }
             
            if (!Directory.Exists(ImagePath))
            {
                Directory.CreateDirectory(ImagePath);
            }
        }
    }
}
