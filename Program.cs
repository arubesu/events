using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var cellphone = new Cellphone();
                cellphone.OnCellphoneCalls += Call;
                cellphone.OnCellphoneCalls += Call2;

                cellphone.Call("12345-1234");
            }
            catch (AggregateException exceptions)
            {
                foreach (var ex in exceptions.InnerExceptions)
                {
                    System.Console.WriteLine(ex.InnerException);
                }
            }
        }

        static void Call(object sender, CellphoneEventArgs args)
        {
            System.Console.WriteLine($"CALLING (1) {args.PhoneNumber}!");
            throw new Exception("Dial Error");
        }
        static void Call2(object sender, CellphoneEventArgs args)
        {
            System.Console.WriteLine($"CALLING (2) {args.PhoneNumber}!");
            throw new Exception("Dial Error");
        }
    }
}
