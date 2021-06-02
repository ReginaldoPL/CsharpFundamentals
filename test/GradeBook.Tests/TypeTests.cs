using System;
using Xunit;
using GradeBook;

namespace GradeBookTests
{
  public class TypeTests
  {

    [Fact]
    public void CSharpIsPassByValue()
    {
      var book1 = GetBook("Book1");
      GetBookSetName(book1, "New Same");

      Assert.Equal("Book1", book1.Name);
    }

    private void GetBookSetName(Book book, string name)
    {
      book = new Book(name);
      book.Name = name;
    }
    [Fact]
    public void CanSetNameFromReference()
    {
      var book1 = GetBook("Book1");
      SetName(book1, "New Same");

      Assert.Equal("New Same", book1.Name);
    }

    private void SetName(Book book, string name)
    {
      book.Name = name;
    }


    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
      var book1 = GetBook("Book1");
      var book2 = GetBook("Book2");

      Assert.Equal("Book1", book1.Name);
      Assert.Equal("Book2", book2.Name);

      Assert.NotSame(book1, book2);
    }

    public void TwoVarsCanReferenceSameObject()
    {
      var book1 = GetBook("Book1");
      var book2 = book1;

      Assert.Same(book1, book2);
      Assert.True(Object.ReferenceEquals(book1, book2));

    }

    Book GetBook(string name)
    {
      return new Book(name);
    }
  }
}
