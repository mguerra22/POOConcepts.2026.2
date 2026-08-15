namespace Backend;

public class Date
{
    // Fields
    private int _year;
    private int _month;
    private int _day;

    // Constructors
    public Date()
    {
        Year = 1900;
        Month = 1;
        Day = 1;
    }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    // Properties
    public int Year
    {
        get => _year;
        set => _year = ValidateYear(value);
    }

    public int Month
    {
        get => _month;
        set => _month = ValidateMonth(value);
    }

    public int Day
    {
        get => _day;
        set => _day = ValidateDay(value);
    }


    // Public Methods 
    public override string ToString()
    {
        return $"{Year:D4}/{Month:D2}/{Day:D2}";
    }

    // Private Methods 
    private int ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new Exception($"The year: {year} is not valid.");
        }
        return year;
    }

    private int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new Exception($"The month: {month} is not valid.");
        }
        return month;
    }

    private int ValidateDay(int day)
    {
        if (Month == 2 && day == 29 && IsLeapYear(Year))
        {
            return day;
        }

        if ((day >= 1 && day <= 28 && Month == 2) ||
            (day >= 1 && day <= 30 && (Month == 4 || Month == 6 || Month == 9 || Month == 11)) ||
            (day >= 1 && day <= 31 && (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)))
        {
            return day;
        }

        throw new Exception($"The day: {day} is not valid in the year: {Year}, month: {Month}.");
    }

    private bool IsLeapYear(int year) => year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
}