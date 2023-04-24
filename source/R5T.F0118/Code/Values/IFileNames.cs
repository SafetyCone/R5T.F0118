using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.F0118
{
    [ValuesMarker]
    public partial interface IFileNames : IValuesMarker
    {
        public IFileName Instances => "Instances.json".ToFileName();
    }
}
