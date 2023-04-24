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
        public IJsonFilePath Get_InstancesFilePath(
            IDirectoryPath parentDirectoryPath)
        {
            var output = Instances.PathOperator.GetFilePath(
                parentDirectoryPath.Value,
                Instances.FileNames.Instances.Value)
                .ToJsonFilePath();

            return output;
        }

        public IJsonFilePath Get_InstancesFilePath()
        {
            return this.Get_InstancesFilePath(
                Instances.DirectoryPaths.CloudSharedData);
        }
    }
}
