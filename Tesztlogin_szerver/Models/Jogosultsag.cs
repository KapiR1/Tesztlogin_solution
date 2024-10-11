using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Tesztlogin_szerver.Models
{
    [DataContract]

    public class Jogosultsag: Rekord
    {
        [DataMember]
        public int JogosultsagokId { get; set; }

        [DataMember]
        public byte JogosultsagokSzint { get; set; }

        [DataMember]
        public string JogosultsagokNev { get; set; }

        [DataMember]
        public string JogosultsagokLeiras { get; set; }

    }
}