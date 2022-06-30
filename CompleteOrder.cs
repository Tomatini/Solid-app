using System;

public class CompleteOrder
{
    private IDelivery _delivery;
    
    public CompleteOrder(IDelivery delivery)
    {
        this._delivery = delivery;
    }

    public void TakeDelivery()
    {
        _delivery.TakeDelivery();
    }
}
