namespace Dbank.Models;

public class BalancesClass
{
    static public decimal Balance { get; set; } = 1838830M;
    static public string Writeoffs { get; set; } =
                    "��������: \n28.12.24 -18.101�" +
                    "\n23.12.24 -601� \n18.12.24 -38.363�" +
                    "\n����������: \n23.12.24 +2.800�" +
                    "\n20.12.24 +7.900� \n19.12.24 +8.000�";

    const decimal InterestRate = 0.19M;
    const decimal Dollar = 100.53M;
    
    static public string Format()
    {
        return String.Format("{0:#,##0.00}�", Balance);
    }
    
    static public string CalcAmount(uint period, decimal depositAmount)
    {
        decimal amount = (depositAmount * InterestRate * period) + depositAmount;
        return String.Format("�������� ����� �� {0} ��� � ����������" +
                             " ������� 19%: {1:#,###}�", period, amount);     
    }

    static public string CurrencyConverter()
    {
        decimal convert = Balance / Dollar; 
        return String.Format("��� ������ � ������: {0:#,##}�" +
                             "\n������ � ��������: {1:#,##}$", Balance, convert);
    }
}
