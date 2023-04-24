using System;

using R5T.F0109;
using R5T.T0132;
using R5T.T0170;


namespace R5T.F0118
{
    [FunctionalityMarker]
    public partial interface IInstancesOperator : IFunctionalityMarker
    {
        //public InstanceDescriptor[] Filter_Instances(
        //    )

        public AssemblyInstancesDescriptor Get_Instances()
        {
            var instancesFilePath = Instances.FilePaths.Instances;

            var output = Instances.AssemblyInstancesDescriptorOperator.Deserialize_Synchronous(
                instancesFilePath);

            return output;
        }

        public void In_InstanceDescriptorsContext(
            Action<InstanceDescriptor[]> instanceDescriptorsAction)
        {
            var instances = this.Get_Instances();

            instanceDescriptorsAction(instances.Instances);
        }

        public TOutput In_InstanceDescriptorsContext<TOutput>(
            Func<InstanceDescriptor[], TOutput> instanceDescriptorsFunction)
        {
            var instances = this.Get_Instances();

            var output = instanceDescriptorsFunction(instances.Instances);
            return output;
        }
    }
}
