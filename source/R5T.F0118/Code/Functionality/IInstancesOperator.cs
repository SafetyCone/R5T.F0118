using System;
using System.Threading.Tasks;

using R5T.F0109;
using R5T.T0132;
using R5T.T0170;
using R5T.T0181;
using InstanceDescriptor = R5T.T0170.InstanceDescriptor;


namespace R5T.F0118
{
    [FunctionalityMarker]
    public partial interface IInstancesOperator : IFunctionalityMarker
    {
        public Task<AssemblyInstancesDescriptor> Get_Instances(string instancesJsonFilePath)
            => Instances.AssemblyInstancesDescriptorOperator.Deserialize(instancesJsonFilePath);

        public Task<AssemblyInstancesDescriptor> Get_Instances(IJsonFilePath instancesFilePath)
            => Instances.AssemblyInstancesDescriptorOperator.Deserialize(instancesFilePath);

        /// <summary>
        /// Gets instances from the file:
        /// <para><filepath><inheritdoc cref="IFilePaths.Instances" path="/summary"/></filepath></para>
        /// </summary>
        public Task<AssemblyInstancesDescriptor> Get_Instances()
            => this.Get_Instances(Instances.FilePaths.Instances);

        /// <inheritdoc cref="Get_Instances()"/>
        public AssemblyInstancesDescriptor Get_Instances_Synchronous()
        {
            var instancesFilePath = Instances.FilePaths.Instances;

            var output = Instances.AssemblyInstancesDescriptorOperator.Deserialize_Synchronous(
                instancesFilePath);

            return output;
        }

        /// <summary>
        /// Allows performing an action on all instances in the instance file:
        /// <para><inheritdoc cref="Get_Instances()" path="descendant::filepath"/></para>
        /// </summary>
        public async Task In_InstanceDescriptorsContext(
            Action<InstanceDescriptor[]> instanceDescriptorsAction)
        {
            var instances = await this.Get_Instances();

            instanceDescriptorsAction(instances.Instances);
        }

        /// <inheritdoc cref="In_InstanceDescriptorsContext(Action{InstanceDescriptor[]})"/>
        public void In_InstanceDescriptorsContext_Synchronous(
            Action<InstanceDescriptor[]> instanceDescriptorsAction)
        {
            var instances = this.Get_Instances_Synchronous();

            instanceDescriptorsAction(instances.Instances);
        }

        /// <summary>
        /// Allows evaluating a function on all instances in the instance file:
        /// <para><inheritdoc cref="Get_Instances()" path="descendant::filepath"/></para>
        /// </summary>
        public async Task<TOutput> In_InstanceDescriptorsContext<TOutput>(
            Func<InstanceDescriptor[], TOutput> instanceDescriptorsFunction)
        {
            var instances = await this.Get_Instances();

            var output = instanceDescriptorsFunction(instances.Instances);
            return output;
        }

        /// <inheritdoc cref="In_InstanceDescriptorsContext{TOutput}(Func{InstanceDescriptor[], TOutput})"/>
        public TOutput In_InstanceDescriptorsContext_Synchronous<TOutput>(
            Func<InstanceDescriptor[], TOutput> instanceDescriptorsFunction)
        {
            var instances = this.Get_Instances_Synchronous();

            var output = instanceDescriptorsFunction(instances.Instances);
            return output;
        }
    }
}
