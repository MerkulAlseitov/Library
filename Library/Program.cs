using Library;
using System.Reflection;

List<Book> books = new List<Book>();
Book LoTR = new Book("LoTR", "Tolkien", "7777", true);
Book HarryPotter = new Book("HarryPotter", "J.K. Rowling", "6969", true);
Book MainCamp = new Book("MainCamp", "A. Hitler", "666", true);
books.Add( LoTR );
books.Add( HarryPotter );
books.Add( MainCamp );

foreach (var item in books)
{
    Console.WriteLine(item.Title + ' ' + item.ISBN + ' ' + item.Author + ' ' + item.CheckedOut);
    Console.WriteLine("Do You want to Check Out this book?");
    string yes = "yes";
    string no = "no";   
    string answer = Console.ReadLine();
    if (answer == yes)
    {
        if (item.CheckedOut == true)
        {
            Console.WriteLine("already Checked out");
        }
        else
        {
            item.CheckOut();
           
        }
    }
    Console.WriteLine("Do You want to Check In this book?");
    string answer2 = Console.ReadLine();

    if (answer2 == yes) 
    {
        if (item.CheckedOut == false)
        {
            Console.WriteLine("already Checked in");
        }
        else
        {
            item.CheckIn();
        }
    }
}

foreach (var item in books)
{
    Console.WriteLine(item.Title + ' ' + item.ISBN + ' ' + item.Author + ' ' + item.CheckedOut);
}


//while(true)
//{
//    Console.WriteLine(LoTR.Title+' '+LoTR.ISBN + ' ' +LoTR.Author + ' ' +LoTR.CheckedOut);
//    Console.WriteLine(HarryPotter.Title + ' ' + HarryPotter.ISBN + ' ' + HarryPotter.Author + ' ' + HarryPotter.CheckedOut);
//    Console.WriteLine(MainCamp.Title + ' ' +MainCamp.ISBN + ' ' +MainCamp.Author + ' ' +MainCamp.CheckedOut);
//    Console.ReadKey();
//}