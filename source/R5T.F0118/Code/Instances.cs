using System;


namespace R5T.F0118
{
    public static class Instances
    {
        public static F0109.IAssemblyInstancesDescriptorOperator AssemblyInstancesDescriptorOperator => F0109.AssemblyInstancesDescriptorOperator.Instance;
        public static Z0026.IDirectoryPaths DirectoryPaths => Z0026.DirectoryPaths.Instance;
        public static IFileNames FileNames => F0118.FileNames.Instance;
        public static IFilePathOperator FilePathOperator => F0118.FilePathOperator.Instance;
        public static IFilePaths FilePaths => F0118.FilePaths.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
    }
}