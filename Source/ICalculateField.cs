namespace Codenation.Challenge
{
    public interface ICalculateField
    {
        // cada m�todo receber� a inst�ncia de uma classe (object) e ir� retornar um decimal

        decimal Addition(object obj);

        decimal Subtraction(object obj);

        decimal Total(object obj);
    }

}
