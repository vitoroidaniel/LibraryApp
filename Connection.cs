using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public static class Connection
    {
        public static string ConnectionString { get; } = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True;";
    }
}
