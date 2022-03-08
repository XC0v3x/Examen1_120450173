using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen1_120450173.Model
{
    public class Contactos
    {
        [AutoIncrement , PrimaryKey]
        public int Id { get; set; }
        [MaxLength (50)]
        public string Nombres { get; set; }
        [MaxLength (50)]
        public string Apellidos { get; set; }
        [MaxLength (50)]
        public int Edad { get; set; }
        public string Pais { get; set; }
        public string Nota { get; set; }
        [MaxLength (200)]
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
