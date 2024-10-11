using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesztlogin_szerver.Models;

namespace Tesztlogin_szerver.DataBaseManager
{
    internal interface IDML
    {
        string Insert(Rekord rekord);
        string Update(Rekord rekord);
        string Delete(int id);
    }
}
