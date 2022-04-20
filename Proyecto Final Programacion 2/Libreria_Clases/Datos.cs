using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using Librerias_Clases;

namespace Librerias_Clases
{
    public static class Global
    {
        public static string userName;
    }
    public class Datos
    {
        // Metodo insertar datos para la tabla Entidades.
        public void InsertarDatos (string userName, string password, string direccion, string descripcion, string localidad, string tipoEntidad, string tipoDocumento, 
            int numeroDocumento, string telefono, string urlPaginaWeb, string urlFacebook, string urlInstagram, string urlTwitter, string urlTikTok, int idGrupoEntidad,
            int idTipoEntidad, int limiteCreditos, string rolUserEntidad, string comentario, string status, string noEliminable)
        {
            Conexion.GetConnection();
            string insertar = "insert into Entidades (UserNameEntidad,PasswordEntidad,Descripcion,Direccion,Localidad,TipoEntidad,TipoDocumento," +
                "NumeroDocumento,Teléfonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,RolUserEntidad,Comentario,Status,NoEliminable)" +
                "Values(@UserNameEntidad,@PassworEntidad,@Descripcion,@Direccion,@Localidad, @TipoEntidad, @TipoDocumento, @NumeroDocumento,@Telefono,@URLPaginaWeb,@URLFacebook," +
                "@URLInstagram,@URLTwitter,@URLTikTok,@IdGrupoEntidad,@IdTipoEntidad,@LimiteCredito,@RolUserEntidad,@Comentario,@Status,@NoEliminable)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.GetConnection());
            cmd1.Parameters.AddWithValue("@UserNameEntidad", userName);
            cmd1.Parameters.AddWithValue("@PassworEntidad", password);
            cmd1.Parameters.AddWithValue("@Direccion", direccion);
            cmd1.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd1.Parameters.AddWithValue("@Localidad", localidad);
            cmd1.Parameters.AddWithValue("@TipoEntidad", tipoEntidad);
            cmd1.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
            cmd1.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            cmd1.Parameters.AddWithValue("@Telefono", telefono);
            cmd1.Parameters.AddWithValue("@URLPaginaWeb", urlPaginaWeb);
            cmd1.Parameters.AddWithValue("@URLFacebook", urlFacebook);
            cmd1.Parameters.AddWithValue("@URLInstagram", urlInstagram);
            cmd1.Parameters.AddWithValue("@URLTwitter", urlTwitter);
            cmd1.Parameters.AddWithValue("@URLTikTok", urlTikTok);
            cmd1.Parameters.AddWithValue("@IdGrupoEntidad", idGrupoEntidad);
            cmd1.Parameters.AddWithValue("@IdTipoEntidad", idTipoEntidad);
            cmd1.Parameters.AddWithValue("@LimiteCredito", limiteCreditos);
            cmd1.Parameters.AddWithValue("@RolUserEntidad", rolUserEntidad);
            cmd1.Parameters.AddWithValue("@Comentario", comentario);
            cmd1.Parameters.AddWithValue("@Status", status);
            cmd1.Parameters.AddWithValue("@NoEliminable", noEliminable);

            
            cmd1.ExecuteNonQuery();
           
        }

        // Metodo insertar datos para la tabla Tipos Entidades 
        public void InsertarDatosTE(string descripcion, string idGrupoEntidad, string comentario, string status, string noEliminable)
        {
            Conexion.GetConnection();
            string insertar = "insert into TiposEntidades (Descripcion,IdGrupoEntidad,Comentario,Status,NoEliminable)" +
                "Values(@Descripcion,@IdGrupoEntidad,@Comentario,@Status,@NoEliminable)";
            SqlCommand cmd1TE = new SqlCommand(insertar, Conexion.GetConnection());
            cmd1TE.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd1TE.Parameters.AddWithValue("@IdGrupoEntidad", idGrupoEntidad);
            cmd1TE.Parameters.AddWithValue("@Comentario", comentario);
            cmd1TE.Parameters.AddWithValue("@Status", status);
            cmd1TE.Parameters.AddWithValue("@NoEliminable", noEliminable);

            cmd1TE.ExecuteNonQuery();
        }

        // Metodo insertar datos para la tabla Grupo Entidades 
        public void InsertarDatosGE(string descripcion,string comentario, string status, string noEliminable)
        {
            Conexion.GetConnection();
            string insertar = "insert into GruposEntidades (Descripcion,Comentario,Status,NoEliminable)" +
                "Values(@Descripcion,@Comentario,@Status,@NoEliminable)";
            SqlCommand cmd1GE = new SqlCommand(insertar, Conexion.GetConnection());
            cmd1GE.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd1GE.Parameters.AddWithValue("@Comentario", comentario);
            cmd1GE.Parameters.AddWithValue("@Status", status);
            cmd1GE.Parameters.AddWithValue("@NoEliminable", noEliminable);

            cmd1GE.ExecuteNonQuery();
        }

        // Metodo actualizar datos para la tabla Entidades
        public void actualizarDatos(int idEntidad,string userName, string password, string direccion, string descripcion, string localidad, string tipoEntidad, string tipoDocumento,
            int numeroDocumento, string telefono, string urlPaginaWeb, string urlFacebook, string urlInstagram, string urlTwitter, string urlTikTok, int idGrupoEntidad,
            int idTipoEntidad, int limiteCreditos, string rolUserEntidad, string comentario, string status, string noEliminable)
        {
            Conexion.GetConnection();
            string actualizar = "UPDATE Entidades SET UserNameEntidad=@UserNameEntidad,PasswordEntidad=@PassworEntidad,Descripcion=@Descripcion," +
                "Direccion=@Direccion,Localidad=@Localidad,TipoEntidad=@TipoEntidad,TipoDocumento=@TipoDocumento,NumeroDocumento=@NumeroDocumento,Teléfonos=@Telefono," +
                "URLPaginaWeb=@URLPaginaWeb,URLFacebook=@URLFacebook,URLInstagram=@URLInstagram,URLTwitter=@URLInstagram,URLTikTok=@URLTikTok,IdGrupoEntidad=@IdGrupoEntidad," +
                "IdTipoEntidad=@IdTipoEntidad,LimiteCredito=@LimiteCredito,RolUserEntidad=RolUserEntidad,Comentario=@Comentario,Status=@Status,NoEliminable=@NoEliminable Where IdEntidad=@IdEntidad";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.GetConnection());
            cmd2.Parameters.AddWithValue("@IdEntidad", idEntidad);
            cmd2.Parameters.AddWithValue("@UserNameEntidad", userName);
            cmd2.Parameters.AddWithValue("@PassworEntidad", password);
            cmd2.Parameters.AddWithValue("@Direccion", direccion);
            cmd2.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd2.Parameters.AddWithValue("@Localidad", localidad);
            cmd2.Parameters.AddWithValue("@TipoEntidad", tipoEntidad);
            cmd2.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
            cmd2.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            cmd2.Parameters.AddWithValue("@Telefono", telefono);
            cmd2.Parameters.AddWithValue("@URLPaginaWeb", urlPaginaWeb);
            cmd2.Parameters.AddWithValue("@URLFacebook", urlFacebook);
            cmd2.Parameters.AddWithValue("@URLInstagram", urlInstagram);
            cmd2.Parameters.AddWithValue("@URLTwitter", urlTwitter);
            cmd2.Parameters.AddWithValue("@URLTikTok", urlTikTok);
            cmd2.Parameters.AddWithValue("@IdGrupoEntidad", idGrupoEntidad);
            cmd2.Parameters.AddWithValue("@IdTipoEntidad", idTipoEntidad);
            cmd2.Parameters.AddWithValue("@LimiteCredito", limiteCreditos);
            cmd2.Parameters.AddWithValue("@RolUserEntidad", rolUserEntidad);
            cmd2.Parameters.AddWithValue("@Comentario", comentario);
            cmd2.Parameters.AddWithValue("@Status", status);
            cmd2.Parameters.AddWithValue("@NoEliminable", noEliminable);

            cmd2.ExecuteNonQuery();
        }

        // Metodo actualizar datos para la tabla Tipos Entidades
        public void actualizarDatosTE(int idTipoEntidad, string descripcion, string idGrupoEntidad, string comentario, string status, string noEliminable)
        {
            Conexion.GetConnection();
            string actualizar = "UPDATE TiposEntidades SET Descripcion=@descripcion,IdGrupoEntidad=@idGrupoEntidad,Comentario=@comentario,Status=@status," +
                "NoEliminable=@noEliminable WHERE IdTipoEntidad=@idTipoEntidad";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.GetConnection());
            cmd2.Parameters.AddWithValue("@idTipoEntidad", idTipoEntidad);
            cmd2.Parameters.AddWithValue("@descripcion", descripcion);
            cmd2.Parameters.AddWithValue("@IdGrupoEntidad", idGrupoEntidad);
            cmd2.Parameters.AddWithValue("@comentario", comentario);
            cmd2.Parameters.AddWithValue("@status", status);
            cmd2.Parameters.AddWithValue("@noEliminable", noEliminable);


            cmd2.ExecuteNonQuery();
        }

        // Metodo actualizar datos para la tabla Grupo Entidades
        public void actualizarDatosGE(int idGrupoEntidad, string descripcion, string comentario, string status, string noEliminable)
        {
            Conexion.GetConnection();
            string actualizar = "UPDATE GruposEntidades SET Descripcion=@descripcion,Comentario=@comentario,Status=@status,NoEliminable=@noEliminable WHERE IdGrupoEntidad=@idGrupoEntidad";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.GetConnection());
            cmd2.Parameters.AddWithValue("@idGrupoEntidad", idGrupoEntidad);
            cmd2.Parameters.AddWithValue("@descripcion", descripcion);
            cmd2.Parameters.AddWithValue("@comentario", comentario);
            cmd2.Parameters.AddWithValue("@status", status);
            cmd2.Parameters.AddWithValue("@noEliminable", noEliminable);

            cmd2.ExecuteNonQuery();
        }

        // Metodo eliminar datos para la tabla Entidades
        public void eliminarDatos(int idEntidad)
        {
            Conexion.GetConnection();
            string eliminar = "DELETE FROM Entidades WHERE IdEntidad=@IdEntidad";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.GetConnection());

            cmd3.Parameters.AddWithValue("@IdEntidad", idEntidad);

            cmd3.ExecuteNonQuery();

        }

        // Metodo eliminar datos para la tabla Tipos Entidades
        public void eliminarDatosTE(int idTipoEntidad)
        {
            Conexion.GetConnection();
            string eliminar = "DELETE FROM TiposEntidades WHERE IdTipoEntidad=@idTipoEntidad";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.GetConnection());

            cmd3.Parameters.AddWithValue("@idTipoEntidad", idTipoEntidad);

            cmd3.ExecuteNonQuery();

        }

        // Metodo eliminar datos para la tabla Grupo Entidades
        public void eliminarDatosGE(int idGrupoEntidad)
        {
            Conexion.GetConnection();
            string eliminar = "DELETE FROM GruposEntidades WHERE IdGrupoEntidad=@idGrupoEntidad";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.GetConnection());

            cmd3.Parameters.AddWithValue("@idGrupoEntidad", idGrupoEntidad);

            cmd3.ExecuteNonQuery();

        }
    }
}
