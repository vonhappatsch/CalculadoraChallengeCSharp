namespace Codenation.Challenge
{
    public interface ICalculateField
    {
        // cada método receberá a instância de uma classe (object) e irá retornar um decimal

        decimal Addition(object obj);

        decimal Subtraction(object obj);

        decimal Total(object obj);
    }

}
