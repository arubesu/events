using System.Collections.Generic;
using System;

public class Cellphone
{
    public event EventHandler<CellphoneEventArgs> OnCellphoneCalls;

    public void Call(string phoneNumber)
    {
        var errors = new List<Exception>();
        foreach (var handler in OnCellphoneCalls.GetInvocationList())
        {
            try
            {
                handler.DynamicInvoke(this, new CellphoneEventArgs(phoneNumber));
            }
            catch (System.Exception ex)
            {
                errors.Add(ex);
            }
        }
        throw new AggregateException(errors);
    }
}

public class CellphoneEventArgs : EventArgs
{
    public string PhoneNumber { get; set; }

    public CellphoneEventArgs(string phoneNumber)
    {
        this.PhoneNumber = phoneNumber;
    }
}