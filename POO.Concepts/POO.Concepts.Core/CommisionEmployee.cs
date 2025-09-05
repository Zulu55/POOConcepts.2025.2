namespace POO.Concepts.Core;

public class CommisionEmployee : Employee
{
    private float _commisionPercentaje;
    private decimal _sales;

    public float CommisionPercentaje
    {
        get => _commisionPercentaje;
        set => _commisionPercentaje = ValidateCommisionPercentaje(value);
    }

    public decimal Sales
    {
        get => _sales;
        set => _sales = ValidateSales(value);
    }

    public override decimal GetValueToPay() => Sales * (decimal)CommisionPercentaje;

    public override string ToString() => $"{base.ToString()}\n\t" +
        $"Commision %...: {CommisionPercentaje,20:P2}\n\t" +
        $"Sales.........: {Sales,20:C2}\n\t" +
        $"Salary........: {GetValueToPay(),20:C2}";

    private decimal ValidateSales(decimal sales)
    {
        if (sales <= 0)
        {
            throw new Exception($"The sales: {sales:C2}, is less or equals than the zero.");
        }
        return sales;
    }

    private float ValidateCommisionPercentaje(float commisionPercentaje)
    {
        if (commisionPercentaje < 0 || commisionPercentaje > 100)
        {
            throw new Exception($"The commision percentaje: {commisionPercentaje:P2}, is invalid.");
        }
        return commisionPercentaje;
    }
}