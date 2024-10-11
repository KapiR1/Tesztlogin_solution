using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Tesztlogin_szerver.Models;

namespace Tesztlogin_szerver.Interfaces
{
    [ServiceContract]
   public interface IJogosultsag
    {
        [OperationContract]
        List<IJogosultsag> JogosultsagLista();

        [OperationContract]
        string UjJogosultsag(Jogosultsag jogosultsag);

        [OperationContract]
        string ModositJogosultsag(Jogosultsag jogosultsag);

        [OperationContract]
        string TorolJogosultsag(int id);
    }
}
