using System;
using System.Collections.Generic;
using System.Text;

namespace Laba.SQLite
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
