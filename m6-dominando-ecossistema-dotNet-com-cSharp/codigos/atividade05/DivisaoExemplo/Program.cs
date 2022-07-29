using DivisaoExemplo;
public class Program
{
    public static void Main()
    {

        int a = 100, b = 0;
        double resultado = 0;

        try
        {
            resultado = Dividir(a, b);
            System.Console.WriteLine($"\n{a} / {b} = {resultado}\n");

        } 
        catch(DivideByZeroException ex) //when (a < 0) 
        {
            System.Console.WriteLine($"\n1. {ex.Message}\n");

        } 
        catch(Exception ex)
        {
            System.Console.WriteLine($"\n2. {ex.Message}\n");
            //throw; // relançar a exceção ela n será tratada
        } 
        finally 
        {
            System.Console.WriteLine("\nFinalmente a divisão chegou aqui!\n");
        }

    }

    static double Dividir(int x, int y)
    {
        if(y == 0)
        {
            //throw new DivideByZeroException();
            throw new MyClassException("\nMinha mensagem customizada\n");
            
            
            //throw new ArithmeticException();
        }

        return (x / y);
    }
}