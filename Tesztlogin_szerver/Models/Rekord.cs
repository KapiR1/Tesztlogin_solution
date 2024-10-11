using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Tesztlogin_szerver.Models
{
    [DataContract]
    public class Rekord
    {
        [DataMember]
        public int Id { get; set; }
    }
}