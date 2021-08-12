namespace Strategy
{
    interface IWalkingAnimal : IAnimal
    {
        int Legs { get; }
        void Walk();
    }
}
