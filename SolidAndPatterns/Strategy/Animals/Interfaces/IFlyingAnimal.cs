namespace Strategy
{
    interface IFlyingAnimal : IAnimal
    {
        IBehaviour Fly { get; }
    }
}
