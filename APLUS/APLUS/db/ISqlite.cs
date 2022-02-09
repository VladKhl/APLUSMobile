using System;
using System.Collections.Generic;
using System.Text;

namespace APLUS.db
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}
