namespace Strategy
{
    interface ISwimmingAnimal : IAnimal
    {
        IBehaviour Swim { get; }
    }
}
