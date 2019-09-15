using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            var cellphone = new Cellphone();
            cellphone.OnCellphoneCalls += Call;

            cellphone.Call("12345-1234");
        }

        static void Call(object sender, CellphoneEventArgs args) =>
                    System.Console.WriteLine($"CALLING {args.PhoneNumber}!");
    }
}
