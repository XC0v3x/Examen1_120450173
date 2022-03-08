using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Examen1_120450173.Model;

namespace Examen1_120450173.Controller
{
    public static class DB
    {
        public static SQLiteAsyncConnection dbconexion;

        public static void conexion(string dbpath)
        {
            dbconexion = new SQLiteAsyncConnection(dbpath);
            dbconexion.CreateTableAsync<Contactos>();
        }

    }
}
