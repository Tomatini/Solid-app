using System;

public class OrderVat : CalculatePercen
{
    public double vat = 23;
    public double getOrderPrice = 2300;
    public override double Percent( double amount)
    {
       return amount+((vat* amount) / 100);
    }
}
