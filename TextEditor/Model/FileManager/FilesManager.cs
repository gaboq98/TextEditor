using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.FileManager
{
    class FilesManager
    {
        public static string GetFileType(int type)
        {
            string fileType;
            switch(type)
            {
                case 0:
                    fileType = "";
                    break;
                case 1:
                    fileType = "";
                    break;
                case 2:
                    fileType = "";
                    break;
                case 3:
                    fileType = "";
                    break;
                case 4:
                    fileType = "";
                    break;
                case 5:
                    fileType = "";
                    break;
                case 6:
                    fileType = "";
                    break;
                default:
                    fileType = "";
                    break;
            }
            return fileType;
        }
    }
}
