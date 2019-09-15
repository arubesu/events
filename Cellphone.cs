using System;

public class Cellphone
{
    public event EventHandler<CellphoneEventArgs> OnCellphoneCalls;

    public void Call(string phoneNumber)
    {
        if (OnCellphoneCalls != null)
            OnCellphoneCalls(this, new CellphoneEventArgs(phoneNumber));
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