using System;
using System.IO;
using Xamarin.Forms;
using Laba.SQLite;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Laba.SQLite
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFilename);
            return path;
        }

    }
}
