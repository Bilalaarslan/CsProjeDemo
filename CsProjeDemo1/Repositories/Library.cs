using CsProjeDemo1.DbSet;
using CsProjeDemo1.Entities;

namespace CsProjeDemo1.Repositories;

public class Library
{
    public List<Member> Members { get; set; }
    public List<Book> Books { get; set; }

    public string BookLendingToMember(int memberNo, string isbn)
    {
        Member member = new Member();

        foreach (Member item in Members)
        {
            if (item.MemberNo == memberNo)
            {
                member = item;
            }
        }

        foreach (Book item in Books)
        {
            if (item.IsbnNo == isbn)
            {
                if (item.StatusOfBook == Enums.Status.CanWood)
                {
                    member.Books.Add(item);
                    item.StatusOfBook = Enums.Status.WoodWasGiven;
                    return "Kitap ödünç verildi.";
                }
                else if (item.StatusOfBook == Enums.Status.WoodWasGiven)
                {
                    return "Kitap müsait değil.";
                }
                else if (item.StatusOfBook == Enums.Status.NotAvailable)
                {
                    return "Üzgünüm bu kitap kütüphanemizde mevcut değildir.";
                }
            }
        }
        return "Geçersiz işlem";
    }


    public string BookPickupFromMember(int memberNo, string isbn)
    {
        Member member = new Member();

        foreach (Member item in Members)
        {
            if (member.MemberNo == memberNo)
            {
                member = item;
            }
        }

        foreach (Book item in Books)
        {
            if (item.IsbnNo == isbn)
            {
                member.Books.Remove(item);
                item.StatusOfBook = Enums.Status.CanWood;
                return "Kitap teslim alınmıştır.";
            }
        }
        return "Geçersiz işlem";
    }
}
