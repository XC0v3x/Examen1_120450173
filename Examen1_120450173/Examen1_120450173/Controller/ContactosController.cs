using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Examen1_120450173.Model;
using Examen1_120450173.Controller;
using System.Threading.Tasks;


namespace Examen1_120450173.Controller
{
    public static class ContactosController
    {
        //Procedimientos del Examen

        //Return Value Contactos
        public static Task<List<Contactos>> ObtenerContactos()
        {
            return DB.dbconexion.Table<Contactos>().ToListAsync();
        }
        //Create / Update
        public static Task<int> AddRecord(Contactos cont)
        {
            if (cont.Id != 0)
            {
                return DB.dbconexion.UpdateAsync(cont);
            }
            else
            {
                return DB.dbconexion.InsertAsync(cont);
            }
        }
        //Search
        public static Task<Contactos> SearchCont(int pid)
        {
            return DB.dbconexion.Table<Contactos>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }
        //Delete
        public static Task<int> DeleteCont(Contactos cont)
        {
            return DB.dbconexion.DeleteAsync(cont);
        }
    }
}
