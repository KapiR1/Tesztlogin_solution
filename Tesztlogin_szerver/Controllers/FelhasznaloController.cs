using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.ServiceModel.Security;
using System.Web;
using Tesztlogin_szerver.DataBaseManager;
using Tesztlogin_szerver.Models;

namespace Tesztlogin_szerver.Controllers
{
    public class FelhasznaloController : BaseDataBaseManager, ISGL
    {
        public string Delete(int id)
        {
            return "delete";
        }

        public string Insert(Rekord rekord)
        {
            return "insert";
        }

        public List<Rekord> Select()
        {
            List<Rekord> list = new List<Rekord>();
            MySqlCommand cmd = new MySqlCommand() {
                CommandType = System.Data.CommandType.Text,
                CommandText ="SELECT * FROM felhasznalok;"
            };
            try
            {
                MySqlConnection conn = BaseDataBaseManager.Connection;
                conn.Open();
                cmd.Connection = conn;
                //Eddignaz sql parancs futtatasanak elokeszitese tortent
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Felhasznalo ujFelhasznalo = new Felhasznalo()
                    {
                            Id = reader.GetInt32("Id"),
                            LoginNev = reader.GetString("LoginNev"),
                            HASH = reader.GetString("HASH"),
                            SALT = reader.GetString("SALT"),
                            Nev = reader.GetString("Nev"),
                            Jog = reader.GetInt32("Jog"),
                            Aktiv = reader.GetBoolean("Aktiv"),
                            Email = reader.GetString("Email"),
                            ProfilKep = reader.GetString("Profilkep")
                    };
                    list.Add(ujFelhasznalo);
                }
            }
            catch (Exception ex)
            {
                Felhasznalo ujFelhasznalo = new Felhasznalo()
                {
                    Id = -1,
                    HASH = ex.Message
                };
                list.Add(ujFelhasznalo);
              
            }
            finally
            {
                Connection.Close();
            }
            return list;
        }

        public string Update(Rekord rekord)
        {
            return "";
        }
    }
}