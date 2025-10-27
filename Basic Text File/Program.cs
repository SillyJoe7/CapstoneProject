using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
namespace Basic_Text_File;

class Program
{
    static void Main(string[] args)
    {

        LineReader guy = new LineReader("data.txt");
        LineReader girl = new LineReader("idek.txt");
        guy.Display();
        guy.DisplayInt(10);
        guy.DisplayRev();
        LineReader.Copy("data.txt", "idek.txt");
        
    }
}

