using CsProjeDemo1.DbSet;


namespace CsProjeDemo1.Interface;

public interface IMember
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public int MemberNo { get; set; }
    public List<Book> Books { get; set; }
    public void Borrow(Book book);
    public void Deliver(Book book);
}
