namespace Common.NetForemost
{
    public class TareaRequest
    {
        /// <summary>
        ///     Primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Id del usuario
        /// </summary>
        public int UsuarioId { get; set; }

        /// <summary>
        ///      titulo de la tarea
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        ///     descripcion de la tarea
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        ///      fecha vencimiento de la tarea
        /// </summary>
        public DateTime FechaVencimiento { get; set; }

        /// <summary>
        ///     indicador de finalizado
        /// </summary>
        public bool Finalizado { get; set; }

        /// <summary>
        ///     indicador de eliminado
        /// </summary>
        public bool Eliminado { get; set; }

        /// <summary>
        ///      tags de la tarea
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        ///      id de la prioridad
        /// </summary>
        public int PrioridadId { get; set; }

        /// <summary>
        ///      fecha de creación
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///      fecha de actualización
        /// </summary>
        public DateTime? UpdateAt { get; set; }
    }
}
