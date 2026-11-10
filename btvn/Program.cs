public interface IAnimal
{
    void Speak();
}
public class Cho : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cho:Gau Gau");
    }
}
public class Meo : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meo:Meo Meo");
    }
}
public class Ga : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Ga: Cuc Tac");
    }
}
public class AnimalView
{
    public void HienThiTieuDe()
    {
        Console.WriteLine("He Thong Dong VAt");
    }

    public void HienThi(IAnimal animal)
    {
        animal.Speak();
    }
}
public class AnimalController
{
    private IAnimal[] ds = new IAnimal[]
    {
        new Cho(),
        new Meo(),
        new Ga()
    };
    private AnimalView view = new AnimalView();
    public void Chay()
    {
        view.HienThiTieuDe();
        foreach (IAnimal a in ds)
        {
            view.HienThi(a);
        }
    }
}
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        new AnimalController().Chay();
    }
}