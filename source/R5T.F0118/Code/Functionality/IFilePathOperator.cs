using System;

using R5T.T0132;
using R5T.T0180;
using R5T.T0181;
using R5T.T0181.Extensions;


namespace R5T.F0118
{
    [FunctionalityMarker]
    public partial interface IFilePathOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Gets the file path of the <inheritdoc cref="F0118.IFileNames.Instances" path="descendant::value"/> file in the given directory.
        /// </summary>
        public IJsonFilePath Get_InstancesFilePath(
            IDirectoryPath parentDirectoryPath)
        {
            var output = Instances.PathOperator.Get_FilePath(
                parentDirectoryPath.Value,
                Instances.FileNames.Instances.Value)
                .ToJsonFilePath();

            return output;
        }

        /// <summary>
        /// Gets the instance file path:
        /// <para><value><inheritdoc cref="Z0026.IDirectoryPaths.CloudSharedDataDirectoryPath" path="descendant::value"/><inheritdoc cref="F0118.IFileNames.Instances" path="descendant::value"/></value></para>
        /// </summary>
        public IJsonFilePath Get_InstancesFilePath()
        {
            return this.Get_InstancesFilePath(
                Instances.DirectoryPaths.CloudSharedDataDirectoryPath);
        }
    }
}
