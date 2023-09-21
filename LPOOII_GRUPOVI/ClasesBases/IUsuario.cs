using System;
namespace ClasesBases
{
    interface IUsuario
    {
        string Apellido { get; set; }
        string Nombre { get; set; }
        string Password { get; set; }
        string Rol { get; set; }
        string UserName { get; set; }
    }
}
