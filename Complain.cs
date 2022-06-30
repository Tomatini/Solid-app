using System;

public class Complain : BasicDataSHop
{
    public override string Description()
    {
        return "I got broken equipment";
    }

    public override string GetOrder()
    {
        throw new NotImplementedException();
    }

    public override String GetPersonName(IPersonContact name)
    {
        return name.name;
    }
}
