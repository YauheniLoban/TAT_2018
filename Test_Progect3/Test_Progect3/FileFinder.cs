using System;
using System.IO;

namespace Test_Progect3
{
    class FileFinder
    {
        string pathToFolder { get; set; }
        string fileExtension { get; set; }

        public FileFinder(string pathToFolder, string fileExtension)
        {
            if (pathToFolder != string.Empty && fileExtension != string.Empty)
            {
                this.fileExtension = fileExtension;
                this.pathToFolder = pathToFolder;
            }
            else
            {
                throw new ArgumentException("The folder path and extension must be specified");
            }
        }

        public string[] AllFilesInFolder()
        {
            return Directory.GetFiles(pathToFolder, fileExtension, SearchOption.AllDirectories);
        }

    }
}
