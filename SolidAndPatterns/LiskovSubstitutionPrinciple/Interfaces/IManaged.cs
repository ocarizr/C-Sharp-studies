namespace LiskovSubstitutionPrinciple
{
    interface IManaged : IEmployee
    {
        IManager? MyManager { get; }
        void AssignManager(IManager manager);
    }
}