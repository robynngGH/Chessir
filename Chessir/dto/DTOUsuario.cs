using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessir.dto
{
    internal class DTOUsuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Es_admin { get; set; }
        public int Creado_por_ID { get; set; }
        public int Ultima_modificacion_ID { get; set; }
        public string Fecha_creacion { get; set; }
        public string Fecha_actualizacion { get; set; }
        public bool Activo { get; set; }

        //constructor vacío
        public DTOUsuario() { }

        //constructor completo
        public DTOUsuario(int id, string username, string password, bool es_admin, int creado_por_ID, int ultima_modificacion_ID, string fecha_creacion, string fecha_actualizacion, bool activo)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Es_admin = es_admin;
            this.Creado_por_ID = creado_por_ID;
            this.Ultima_modificacion_ID = ultima_modificacion_ID;
            this.Fecha_creacion = fecha_creacion;
            this.Fecha_actualizacion = fecha_actualizacion;
            this.Activo = activo;
        }

        //constructor de creación de usuario
        public DTOUsuario(string username, string password, bool es_admin, int creado_por_ID, bool activo)
        {
            this.Username = username;
            this.Password = password;
            this.Es_admin = es_admin;
            this.Creado_por_ID = creado_por_ID;
            this.Activo = activo;
        }

        //constructor de modificación de usuario
        public DTOUsuario(int ultima_modificacion_ID, string username, string password, bool es_admin)
        {
            this.Username = username;
            this.Password = password;
            this.Es_admin = es_admin;
            this.Ultima_modificacion_ID = ultima_modificacion_ID;
        }
    }
}
