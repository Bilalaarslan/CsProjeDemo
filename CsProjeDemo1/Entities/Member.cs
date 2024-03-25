using CsProjeDemo1.DbSet;
using CsProjeDemo1.Interface;


namespace CsProjeDemo1.Entities;

public class Member : IMember
{
    public Member()
    {
        Books = new List<Book>();
    }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public int MemberNo { get; set; }
    public List<Book> Books { get; set; }

    public void Borrow(Book book)
    {
        Books.Add(book);
    }

    public void Deliver(Book book)
    {
        Books.Remove(book);
    }
}
