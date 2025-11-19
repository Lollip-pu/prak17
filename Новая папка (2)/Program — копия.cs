using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{

  public enum FileAccess {None = 1, Read=2, Write=3, Execute =4};
    public struct File
    {
        public FileAccess Permissions;

        public bool CanRead()
        {
            return (Permissions & FileAccess.Read) == FileAccess.Read;
        }

        public bool CanWrite()
        {
            return (Permissions & FileAccess.Write) == FileAccess.Write;
        }

        public bool CanExecute()
        {
            return (Permissions & FileAccess.Execute) == FileAccess.Execute;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = new File { Permissions = FileAccess.Read | FileAccess.Write };
            Console.WriteLine(f.CanRead()); 
            Console.WriteLine(f.CanWrite());

        }
    }
}
