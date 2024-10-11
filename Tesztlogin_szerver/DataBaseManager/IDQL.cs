using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesztlogin_szerver.Models;

namespace Tesztlogin_szerver.DataBaseManager
{
    internal interface IDQL
    {
        List<Rekord> Select();
    }
}
