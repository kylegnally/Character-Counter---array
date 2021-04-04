namespace Character_Counter___array     
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            //  use the args below to specify output text filename once that's implemented
            //args = new[] { "wap.txt", "out.txt" };
            args = new[] { "test.txt" };
            #endif
            CounterManager capp = new CounterManager(args);
        }
    }
}
