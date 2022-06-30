using System;

public class Invoice : BasicDataSHop
{
    public override string Description()
    {
        return "Order is complete";
    }

    public override string GetOrder()
    {
        throw new NotImplementedException();
    }

    public override string GetPersonName(IPersonContact name)
    {
        return name.name;
    }
}
