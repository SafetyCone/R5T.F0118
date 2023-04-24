using System;


namespace R5T.F0118
{
    public class InstancesOperator : IInstancesOperator
    {
        #region Infrastructure

        public static IInstancesOperator Instance { get; } = new InstancesOperator();


        private InstancesOperator()
        {
        }

        #endregion
    }
}
