//Вариант 14 уровень сложности средний
Knegr knegr = new Knegr();
try
{


    Console.Write("Введите название:");
    knegr.Name = Console.ReadLine();
    Console.Write("Введите название:");
    knegr.Author = Console.ReadLine();
    Console.Write("Введите название:");
    knegr.YearPublication = Convert.ToInt32(Console.ReadLine());
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

Console.WriteLine(knegr.Name);
Console.WriteLine(knegr.Author);
Console.WriteLine(knegr.YearPublication);
Console.WriteLine(knegr.SkolkoLetKnegr());

public class Knegr
{
    private string name;
    private string author;
    private int yearPublication;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public int YearPublication
    {
        get { return yearPublication; }
        set
        {
            if (yearPublication >= 0) yearPublication = value;
            else yearPublication = 0;
        }
    }
    public Knegr()
    {
        this.name = "";
        this.author = "";
        this.yearPublication = 0;
    }

    public Knegr(string name, string author, int yearPublication)
    {
        this.name = name;
        this.author = author;
        this.yearPublication = yearPublication;
    }

    public int SkolkoLetKnegr()
    {
        DateOnly date = new DateOnly();
        return date.Year - YearPublication;
    }
}