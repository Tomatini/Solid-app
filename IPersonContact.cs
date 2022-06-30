using System;

public interface IPersonContact : IBasicContacts
{
	public string name { get; set; }
	public string lastName { get; set; }
}
