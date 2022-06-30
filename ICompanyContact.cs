using System;

public interface ICompanyContact: IBasicContacts
{
	public int nip { get; set; }
	public int regon { get; set; }
	public string companyName { get; set; }
	public string typeOfActivity { get; set; }

}
