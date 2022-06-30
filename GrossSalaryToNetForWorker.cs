using System;

public class GrossSalaryToNetForWorker : CalculatePercen
{
    private double medicalInsurance = 2.45 ;
    private double disabilityInsurance = 1.5;
    private double pensionInsurance = 9;
    private double costOfGettingIncome = 250;
    private double amonutForWorker = 3200;
    private double amountNet = 0;
    public override double Percent( double amount)
    {
        amountNet = ((amount / 100) * disabilityInsurance)+((amount / 100)*medicalInsurance);
        amountNet += ((amount / 100)*pensionInsurance ) +costOfGettingIncome;
        return amount -= amountNet;
    }
}
