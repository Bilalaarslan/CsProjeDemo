using CsProjeDemo1.Enums;

namespace CsProjeDemo1.DbSet;

public abstract class Book
{
    public string IsbnNo { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public short YearReleased { get; set; }

    public Status StatusOfBook { get; set; }

    public BookTypes Types { get; set; }

}
