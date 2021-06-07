using System;
using Xunit;
using GradeBook;

namespace GradeBookTests
{
  /*
  // class is reference
  public class Person {

  }

  //  struct is variable (not reference)
  public struct Point
  {

  }
  */


  public class TypeTests
  {
    /*
      [Fact]
      public void StringsBehaveLikeValueTypes()
      {
        string name = "Scott";
        MakeUpperCase(name);

        Assert.Equal("SCOTT", name);

      }

      private void MakeUpperCase(string parameter)
      {
        parameter.ToUpper();
      }
     */
    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
      string name = "Scott";
      var upper = MakeUpperCase(name);

      Assert.Equal("SCOTT", upper);

    }

    private string MakeUpperCase(string parameter)
    {
      return parameter.ToUpper();
    }


    [Fact]

    public void Test1()
    {
      var x = GetInt();
      SetInt(x);
      Assert.Equal(3, x);
    }
    private void SetInt(int x)
    {
      x = 42;
    }

    private int GetInt()
    {
      return 3;

    }

    /*
    public void Test1() {
      var x = GetInt();
      SetInt(ref x);

      Assert.Equal(3,x);
    }
    private void SetInt(ref int x)
    {
      x = 42;
    }

    private int GetInt()
    {
      return 3;

    }
    */
    [Fact]
    public void CSharpIsPassByRef()
    {
      var book1 = GetBook("Book1");
      GetBookSetName(out book1, "New Same");

      Assert.Equal("New Same", book1.Name);
    }

    private void GetBookSetName(out Book book, string name)
    {
      book = new Book(name);
    }
    // out igual ref, exceto que out indica que não foi inicializado

    /* [Fact]
    public void CSharpIsPassByRef()
    {
      var book1 = GetBook("Book1");
      GetBookSetName(ref book1, "New Same");

      Assert.Equal("New Same", book1.Name);
    }

    private void GetBookSetName(ref Book book, string name)
    {
      book = new Book(name);
    }*/

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
