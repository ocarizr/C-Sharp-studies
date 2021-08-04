namespace LiskovSubstitutionPrinciple
{
    abstract class BaseManagedEmployee : BaseEmployee, IManaged
    {
        public IManager? MyManager { get; protected set; }
        public void AssignManager(IManager manager) => MyManager = manager;
    }
}
