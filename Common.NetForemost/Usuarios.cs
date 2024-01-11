namespace Common.NetForemost
{
    public class Usuarios
    {
        /// <summary>
        ///     primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     nombre de usaurio
        /// </summary>  
        public string Nombre { get; set; }

        /// <summary>
        ///     apellido del usuario
        /// </summary>
        public string Apellido{ get; set; }

        /// <summary>
        ///     Correo electronico
        /// </summary>
        public string Correo{ get; set; }

        /// <summary>
        ///     Telefono
        /// </summary>
        public string Telefono{ get; set; }

        /// <summary>
        ///     Fecha de creación del usuario
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     fecha de actualización
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}
