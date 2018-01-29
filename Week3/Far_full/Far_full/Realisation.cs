using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Far_full{ 
enum FarMode
{
    Directory,
    File
}

class Realisation
{
    Stack<Dir> DirStory = new Stack<Dir>();
    Dir LastDir;
    FarMode mode = FarMode.Directory;

    public Realisation(string path)
    {
        this.LastDir = new Dir(path, 0);
    }

    public void Print()
    {
        switch (mode)
        {
            case FarMode.Directory:

                    PrintDirectory();

                break;
            case FarMode.File:

                PrintFile();

                break;
            default:
                break;
        }

        PrintStatusBar();
    }

    private void PrintStatusBar()
    {
        Console.SetCursorPosition(0, 45);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Welcome!");
        Console.WriteLine(mode);
        Console.WriteLine(DateTime.Now);
    }

    private void PrintFile()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        FileStream fs = null;
        StreamReader sr = null;
        try
        {
            fs = new FileStream(LastDir.GetSelectedElementInfo(), FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);

            Console.WriteLine(sr.ReadToEnd());

        }
        catch (Exception e)
        {
            Console.WriteLine("Why are you try?");

        }
        finally
        {
            if (sr != null)
            {
                sr.Close();
            }

            if (fs != null)
            {
                fs.Close();
            }
        }
    }

    private void PrintDirectory()
    {

        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("№"+" "+ "Name");
            Console.SetCursorPosition(30,0);
            Console.WriteLine("Creation time"+"      "+"Attributes");
        for (int i = 0; i < LastDir.elements.Count; ++i)
        {
            if (i == LastDir.index)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }

            if (LastDir.elements[i].GetType() == typeof(DirectoryInfo))
            {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(30,i+1);
                    Console.WriteLine(LastDir.elements[i].CreationTime+ " "+LastDir.elements[i].Attributes);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(30, i+1);
                Console.WriteLine(LastDir.elements[i].CreationTime+" "+LastDir.elements[i].Attributes);
            }
            Console.SetCursorPosition(0, i+1);
            Console.WriteLine((i+1)+"."+LastDir.elements[i].Name);
        }
    }

    public void Process(ConsoleKeyInfo pressedKey)
    {
        switch (pressedKey.Key)
        {
            case ConsoleKey.UpArrow:
                LastDir.Action(-1);
                break;
            case ConsoleKey.DownArrow:
                LastDir.Action(1);
                break;
            case ConsoleKey.Enter:
                try
                {
                    if (LastDir.elements[LastDir.index].GetType() == typeof(DirectoryInfo))
                    {
                        mode = FarMode.Directory;
                        DirStory.Push(LastDir);
                            LastDir = new Dir(LastDir.GetSelectedElementInfo(), 0);
                    }
                    else if (LastDir.elements[LastDir.index].GetType() == typeof(FileInfo))
                    {
                        mode = FarMode.File;
                    }
                }
                catch (Exception e)
                {
                        LastDir = DirStory.Pop();
                }
                break;
            case ConsoleKey.Backspace:
                if (mode == FarMode.Directory)
                {
                        if (DirStory.Count != 0)
                        {
                            LastDir = DirStory.Pop();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Nothing to see!");
                        }
                }
                else if (mode == FarMode.File)
                {
                    mode = FarMode.Directory;
                }

                break;
            default:
                break;
        }

    }
}
}