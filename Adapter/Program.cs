public class OldPrinter
{
    public void PrintOld(string text)
    {
        Console.WriteLine($"Printing (Old System): {text}");
    }
}
public interface IPrinter
{
    void Print(string text);
}
public class PrinterAdapter : IPrinter
{
    private readonly OldPrinter oldPrinter;

    public PrinterAdapter(OldPrinter oldPrinter)
    {
        this.oldPrinter = oldPrinter;
    }

    public void Print(string text)
    {
        oldPrinter.PrintOld(text);
    }
}


