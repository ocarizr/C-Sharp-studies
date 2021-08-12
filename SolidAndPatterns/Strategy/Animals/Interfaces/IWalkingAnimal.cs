namespace Strategy
{
    interface IWalkingAnimal : IAnimal
    {
        int Legs { get; }
        IBehaviour Walk { get; }
    }
}
