using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WordCountName
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}




















// using System;
//
//
// namespace WordCountName
// {
//
//   public class Program
//   {
//     static void Main()
//     {
//       Console.WriteLine("enter a word");
//       string userWord = Console.ReadLine();
//       // var array1 = userWord.ToCharArray();
//
//       Console.WriteLine("enter a sentence");
//       string userSentence = Console.ReadLine();
//
// int Count = WordCounter.ReturnCount(userWord,userSentence);
// Console.WriteLine(Count);
//   }
//   }
// }
