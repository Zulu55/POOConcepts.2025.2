namespace POO.Concepts.Core;

public class HourlyEmployee : Employee
{
    private decimal _hourValue;
    private float _workingHours;

    public decimal HourValue
    {
        get => _hourValue;
        set => _hourValue = ValidateHourValue(value);
    }

    public float WorkingHours
    {
        get => _workingHours;
        set => _workingHours = ValidateWorkingHours(value);
    }

    public override decimal GetValueToPay() => HourValue * (decimal)WorkingHours;

    public override string ToString() => $"{base.ToString()}\n\t" +
        $"Working hours.: {WorkingHours,20:N2}\n\t" +
        $"Hour Value....: {HourValue,20:C2}\n\t" +
        $"Salary........: {GetValueToPay(),20:C2}";

    private float ValidateWorkingHours(float workingHours)
    {
        if (workingHours <= 0)
        {
            throw new Exception($"The working hours: {workingHours:N2}, is less or equals than zero");
        }
        return workingHours;
    }

    private decimal ValidateHourValue(decimal hourValue)
    {
        if (hourValue <= 0)
        {
            throw new Exception($"The hour vallue: {hourValue:C2}, is less or equals than the zero.");
        }
        return hourValue;
    }
}