namespace Library.Models
{
  public class Book
  {

    public string Title { get; set; }
    // public int field // DONT USE FIELDS!! !important;
    public void ChangeTitle(string newTitle, string password)
    {
      if(password == "shhh its a library"){
        Title = newTitle;
      }
    }

    public Book(string title)
    {
      Title = title;
    }

    //  WHAT IS A BOOK????
    //         title {type:String}
    //         author string
    //         pages number 
    //         summary string
    //         available bool tinyint 0 1
    //         MODELS

  }
}