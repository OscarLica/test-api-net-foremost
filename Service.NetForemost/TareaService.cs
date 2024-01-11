using Common.NetForemost;
using Microsoft.EntityFrameworkCore;
using Persistence.NetForemost;

namespace Service.NetForemost
{
    public interface ITareaService {

        Task<List<Tareas>> Get();
        Task<List<Tareas>> GetbyUser(int userId);
        Task<Tareas> GetById(int id);
        Task<bool> Delete(int id);
        Task<TareaRequest> Crteate(TareaRequest tarea);
        Task<Tareas> Update(int id, Tareas tarea);
    }
    public class TareaService : ITareaService
    {
        private readonly ApplicationContext _context;
        public TareaService(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<TareaRequest> Crteate(TareaRequest tarea)
        {
            var record = new Tareas { 
                Titulo = tarea.Titulo,
                Descripcion = tarea.Descripcion,
                FechaVencimiento= tarea.FechaVencimiento,
                Finalizado= tarea.Finalizado,
                Eliminado= tarea.Eliminado,
                Tags= tarea.Tags,
                PrioridadId= tarea.PrioridadId,
                CreatedAt= tarea.CreatedAt,
                UsuarioId = tarea.UsuarioId,
                UpdateAt = null
            };
            await _context.Tareas.AddAsync(record);
            await _context.SaveChangesAsync();
            return tarea;
        }

        public async Task<bool> Delete(int id)
        {
            var record = await  _context.Tareas.FindAsync(id);
            _context.Tareas.Remove(record);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Tareas>> Get()
            => await _context.Tareas.ToListAsync();

        public async Task<Tareas> GetById(int id)
         => await _context.Tareas.FindAsync(id);

        public async Task<List<Tareas>> GetbyUser(int userId)
            => await _context.Tareas.Where(ta => ta.UsuarioId == userId).ToListAsync();

        public async Task<Tareas> Update(int id, Tareas tarea)
        {
            _context.Tareas.Update(tarea);
            await _context.SaveChangesAsync();
            return tarea;
        }
    }
}
