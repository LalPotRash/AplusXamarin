using System;
using System.Collections.Generic;
using System.Text;

namespace Aplus.db
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}