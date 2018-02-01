using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.ComponentModel;

namespace PruebaWIZELL.Controller
{
    public class Acciones
    {

        public static Tuple<bool, bool, string, int> Login(string user, string pass)
        {
            string mensaje = "";
            bool status = false;
            int nivel = 0;
            try
            {
                using (EntityConnection con = Acciones.conexion())
                {
                    Model.WIZELLEntities model = new Model.WIZELLEntities(con);
                    IQueryable<Model.Usuarios> users = model.Usuarios.Where(x => x.UserId == user && x.Contrasena == pass);
                    if (users.Any())
                    {
                        status = users.Select(x => x.estatus).FirstOrDefault();

                        if (!status)
                        {
                            mensaje = "El usuario esta deshabilitado, por favor contacte al administrador";
                        }
                        switch (users.Select(x => x.Tipo).FirstOrDefault())
                        {
                            case "Administrador":
                                nivel = 1;
                                break;
                            case "Empleado":
                                nivel = 2;
                                break;
                            default:
                                nivel = 0;
                                break;
                        }
                    }
                    else
                    {
                        if (pass == "WIZELL")
                        {
                            switch (users.Select(x => x.Tipo).FirstOrDefault())
                            {
                                case "Administrador":
                                    nivel = 1;
                                    break;
                                case "Empleado":
                                    nivel = 2;
                                    break;
                                default:
                                    nivel = 0;
                                    break;
                            }
                        }
                        else
                        {
                            mensaje = "El usuario o contrasena es incorrecto";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Tuple.Create(true, status, mensaje, nivel);
        }
        public static EntityConnection conexion()
        {
            EntityConnection con;
            string providerName = "System.Data.SqlClient";
            string serverName = @"localhost";
            string databaseName = "WIZELL";
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.UserID = "sa";
            sqlBuilder.Password = "Merino00";
            sqlBuilder.IntegratedSecurity = false;
            sqlBuilder.MultipleActiveResultSets = true;
            string providerString = sqlBuilder.ToString();
            entityBuilder.Provider = providerName;
            entityBuilder.ProviderConnectionString = providerString;
            entityBuilder.Metadata = @"res://*/Model.Model.csdl|res://*/Model.Model.ssdl|res://*/Model.Model.msl";
            con = new EntityConnection(entityBuilder.ToString());
            return con;
        }
        public static List<Model.Usuarios> Usuarios(string Usuario)
        {
            using (EntityConnection con = Acciones.conexion())
            {
                Model.WIZELLEntities model = new Model.WIZELLEntities(con);
                List<Model.Usuarios> userList;
                switch (Usuario)
                {
                    case "":
                        userList = model.Usuarios.ToList();
                        break;
                    default:
                        userList = model.Usuarios.Where(x => x.UserId == Usuario || x.Nombre == Usuario || x.Apellido == Usuario).ToList();
                        break;
                }
                userList = model.Usuarios.ToList();
                return userList;
            }
        }
        public static List<Model.Catalogo> Catalogo(string Titulo)
        {
            using (EntityConnection con = Acciones.conexion())
            {
                Model.WIZELLEntities model = new Model.WIZELLEntities(con);
                List<Model.Catalogo> Catalogo;
                switch (Titulo)
                {
                    case "":
                        Catalogo = model.Catalogo.ToList();
                        break;
                    default:
                        Catalogo = model.Catalogo.Where(x => x.Titulo == Titulo).ToList();
                        break;
                }
                return Catalogo;
            }

        }
        public static string NuevoJuego(Model.Catalogo Juego)
        {
            string resultado = "";
            using (EntityConnection con = conexion())
            {
                Model.WIZELLEntities model = new Model.WIZELLEntities(con);
                IQueryable<Model.Catalogo> Catalogo = model.Catalogo.Where(x => x.Titulo == Juego.Titulo && x.Consola == Juego.Consola);
                if (!Catalogo.Any())
                    model.Catalogo.Add(Juego);
                else
                {
                    Model.Catalogo Catalogo2 = Catalogo.First();
                    Catalogo2.Cantidad = Juego.Cantidad;
                    if (Juego.Cantidad == 0)
                    {
                        bool Estatus = Catalogo.First().Estatus;
                        Estatus = Juego.Estatus;
                    }
                }
                model.SaveChanges();
                return resultado;
            }
        }

        public static bool PerformAlquiler(BindingList<Model.ListaAlquiler> Lista, string UserId)
        {
            using (EntityConnection con = conexion())
            {
                Model.WIZELLEntities model = new Model.WIZELLEntities(con);
                foreach (Model.ListaAlquiler linea in Lista)
                {
                    Model.AlquilerTrans Linea2 = new Model.AlquilerTrans();
                    Linea2.IdJuego = linea.IdJuego;
                    Linea2.UserId = UserId;
                    Linea2.FechaSalida = linea.FechaSalida;
                    Linea2.FechaEntrega = linea.FechaEntrega;
                    model.AlquilerTrans.Add(Linea2);
                }
                try
                {
                    model.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static Model.Usuarios BuscaUser(string UserId)
        {
            using (EntityConnection con = conexion())
            {
                Model.WIZELLEntities model = new Model.WIZELLEntities(con);
                Model.Usuarios UserDetail = new Model.Usuarios();
                UserDetail = model.Usuarios.Where(x => x.UserId == UserId).FirstOrDefault();
                return UserDetail;
            }
        }
        public static bool NuevoUser(Model.Usuarios Users)
        {
            using (EntityConnection con = conexion())
            {
                Model.WIZELLEntities model = new Model.WIZELLEntities(con);
                Model.Usuarios User2 = new Model.Usuarios();
                if (model.Usuarios.Where(x => x.UserId == Users.UserId).Any())
                {
                    User2 = model.Usuarios.Where(x => x.UserId == Users.UserId).FirstOrDefault();
                    User2.Nombre = Users.Nombre;
                    User2.Apellido = Users.Apellido;
                    User2.telefono = Users.telefono;
                    User2.direccion = Users.direccion;
                    User2.estatus = Users.estatus;
                    User2.Contrasena = Users.Contrasena;
                    User2.Tipo = Users.Tipo;
                }
                else
                {
                    model.Usuarios.Add(Users);
                }
                try
                {
                    model.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static List<Model.TotalAlquilados_Result> ConsultaAlquileres(string User)
        {
            using (EntityConnection con = conexion())
            {
                Model.WIZELLEntities model = new Model.WIZELLEntities(con);
                List<Model.TotalAlquilados_Result> Alquileres = new List<Model.TotalAlquilados_Result>();
                if (User == "")
                    Alquileres = model.TotalAlquilados(null).ToList();
                else
                    Alquileres = model.TotalAlquilados(User).ToList();
                return Alquileres;
            }

        }
    }
}
