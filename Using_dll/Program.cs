using Rahunok_class;
internal class Program
{
    private static void Main(string[] args)
    {
        Rahunok rah = new Rahunok(0, 0, 0, 0, 0,"");
        rah.info();
        rah.cash_app(1000);
        rah.info();
        rah.cash_down(900);
        rah.info();
    }
}