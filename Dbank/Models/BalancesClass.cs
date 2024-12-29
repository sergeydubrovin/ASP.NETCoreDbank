namespace Dbank.Models;

public class BalancesClass
{
    static public decimal Balance { get; set; } = 1838830M;
    static public string Writeoffs { get; set; } =
                    "Списания: \n28.12.24 -18.101Р" +
                    "\n23.12.24 -601Р \n18.12.24 -38.363Р" +
                    "\nНачисления: \n23.12.24 +2.800Р" +
                    "\n20.12.24 +7.900Р \n19.12.24 +8.000Р";

    const decimal InterestRate = 0.19M;
    const decimal Dollar = 100.53M;
    
    static public string Format()
    {
        return String.Format("{0:#,##0.00}Р", Balance);
    }
    
    static public string CalcAmount(uint period, decimal depositAmount)
    {
        decimal amount = (depositAmount * InterestRate * period) + depositAmount;
        return String.Format("Конечная сумма за {0} год с процентной" +
                             " ставкой 19%: {1:#,###}Р", period, amount);     
    }

    static public string CurrencyConverter()
    {
        decimal convert = Balance / Dollar; 
        return String.Format("Ваш баланс в рублях: {0:#,##}Р" +
                             "\nбаланс в долларах: {1:#,##}$", Balance, convert);
    }
}
