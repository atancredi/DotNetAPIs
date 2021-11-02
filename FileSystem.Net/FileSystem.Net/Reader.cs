using System.Collections.Generic;
using System.IO;

namespace FileSystem.Net
{
    public static class Reader
    {

        //Get files in the specified folder path
        public static List<FilePathData> GetFiles(FolderPathData Path)
        {

            List<FilePathData> Data = new List<FilePathData>();

            string[] RawData = Directory.GetFiles(Path.Path);

            foreach(string File in RawData)
            {
                Data.Add(new FilePathData
                {
                    Path = File
                });
            }

            return Data;

        }

        //Get folders in the specified folder path
        public static List<FolderPathData> GetDirectories(FolderPathData Path)
        {
            List<FolderPathData> Data = new List<FolderPathData>();

            string[] RawData = Directory.GetDirectories(Path.Path);

            foreach (string Folder in RawData)
            {
                if (Directory.Exists(Folder))
                {
                    Data.Add(new FolderPathData
                    {
                        Path = Folder
                    });
                }
            }

            return Data;
        }

        //From the raw string path create the FolderPathData object
        public static FolderPathData CreateFolderPathData(string Path)
        {
            FolderPathData ReturnData = new FolderPathData();

            if (Directory.Exists(Path))
            {
                ReturnData.Path = Path;
            }

            return ReturnData;

        }

    }
}
