using System;


namespace R5T.F0118
{
    public class FileNames : IFileNames
    {
        #region Infrastructure

        public static IFileNames Instance { get; } = new FileNames();


        private FileNames()
        {
        }

        #endregion
    }
}
