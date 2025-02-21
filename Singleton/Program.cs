// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//public class Singleton
//{
//    private static Singleton instance;

//    private Singleton() { } // Private constructor prevents instantiation

//    public static Singleton GetInstance()
//    {
//        if (instance == null)
//        {
//            instance = new Singleton();
//        }
//        return instance;
//    }
//}
//public class Singleton
//{
//    private static Singleton instance;
//    private static readonly object lockObj = new object();

//    private Singleton() { }

//    public static Singleton GetInstance()
//    {
//        lock (lockObj)  // Ensures only one thread enters
//        {
//            if (instance == null)
//            {
//                instance = new Singleton();
//            }
//        }
//        return instance;
//    }
//}
public class Singleton
{
    private static readonly Lazy<Singleton> instance =
        new Lazy<Singleton>(() => new Singleton());

    private Singleton() { }

    public static Singleton Instance => instance.Value;
}


