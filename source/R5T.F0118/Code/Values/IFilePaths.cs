using System;

using R5T.T0131;
using R5T.T0181;


namespace R5T.F0118
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        public IJsonFilePath Instances => F0118.Instances.FilePathOperator.Get_InstancesFilePath();
    }
}
