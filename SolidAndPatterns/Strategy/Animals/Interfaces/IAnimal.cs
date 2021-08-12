namespace Strategy
{
    interface IAnimal
    {
        IBehaviour Sleep { get; }
        IBehaviour Eat { get; }
    }
}