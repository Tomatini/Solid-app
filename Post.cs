using System;

public class Post : IDelivery
{
    public void TakeDelivery()
    {
        Console.WriteLine("post");
    }
}
