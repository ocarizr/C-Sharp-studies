namespace DontRepeatYourself
{
    abstract class AGenerator<TGenerated, TSource>
    {
        public abstract TGenerated Generate(TSource source);
    }
}