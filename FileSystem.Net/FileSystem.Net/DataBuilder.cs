namespace FileSystem.Net
{
    public static class DataBuilder
    {
        public static FolderData GetFolderData(string RequiredPath)
        {

            //get the FolderPathData
            FolderPathData Path = Reader.CreateFolderPathData(RequiredPath);

            return new FolderData
            {
                Files = Reader.GetFiles(Path),
                Folders = Reader.GetDirectories(Path)
            };

        }

    }
}
