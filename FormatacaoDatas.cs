namespace FormatacaoDatas;

public class FormatandoDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2004, 10, 27, 19, 22, 23);
        var date2 = DateTime.Parse("2022/12/22 19:25:32");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        // Console.WriteLine(date1);
        // Console.WriteLine(date2);
        // Console.WriteLine(date3);
        // Console.WriteLine(date4);

        // Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

        var dateOffSet = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffSet.LocalDateTime);
        Console.WriteLine(dateOffSet.UtcDateTime);
    }

    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2024/02/14");

        //var diff = date1 - date2;
        var diff = date1.Subtract(date2);
        Console.WriteLine((int)diff.TotalDays);
        Console.WriteLine((int)diff.TotalSeconds);
    }

    public void AulaSomaData()
    {
        var date1 = DateTime.Now;

        //Console.WriteLine(date1.AddDays(15));
        //Console.WriteLine(date1.AddMonths(2));
        //Console.WriteLine(date1.AddYears(2));
        //Console.WriteLine(date1.AddYears(2312).AddMonths(21).AddDays(100));
        Console.WriteLine(date1.AddSeconds(180).AddMinutes(90));
    }

    public void AulaDiaSemana()
    {
        var date = DateTime.Now;
        var date1 = DateTime.Parse("2024/10/27");

        Console.WriteLine(date.DayOfYear);
        Console.WriteLine(date.DayOfWeek);

        Console.WriteLine(date1.DayOfYear);
        Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {

        var somenteData = new DateOnly(2022, 12, 20);
        var date1 = DateOnly.Parse("2022/12/20");

        Console.WriteLine(somenteData);
    }

    public void AulaTimeOnly()
    {
        var date = new TimeOnly(20, 20, 20);
        var date1 = TimeOnly.Parse("20:20:20");

        Console.WriteLine(date.ToString("HH:mm:ss"));
        Console.WriteLine(date1);
    }
}