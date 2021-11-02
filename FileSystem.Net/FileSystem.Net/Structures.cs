using System;
using System.Collections.Generic;

namespace FileSystem.Net
{
    public class FolderData
    {
        public List<FolderPathData> Folders { get; set; }
    
        public List<FilePathData> Files { get; set; }
    }

    public class FolderPathData
    {
        public string Name { get; set; } = String.Empty;
        public string Path { get; set; }

    }

    public class FilePathData
    {
        public string Name { get; set; } = String.Empty;
        public string Path { get; set; }

    }
}
