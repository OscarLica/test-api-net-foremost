using Common.NetForemost;
using Microsoft.EntityFrameworkCore;
using Persistence.NetForemost;

namespace Service.NetForemost
{
    public interface IUserService
    {
        Task<List<Usuarios>> Get();
        Task<Usuarios> Get(int id);
        Task<Usuarios> Create(Usuarios usuarios);
    }
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;
        public UserService(ApplicationContext context)
        {
                _context = context;
        }

        /// <summary>
        ///     crea un nuevo usuario
        /// </summary>
        /// <param name="usuarios"></param>
        /// <returns></returns>
        public async Task<Usuarios> Create(Usuarios usuarios)
        {
            await _context.Usuarios.AddAsync(usuarios);
            await _context.SaveChangesAsync();
            return usuarios;
        }

        /// <summary>
        ///  obtiene lista de usuarios
        /// </summary>
        /// <returns></returns>
        public async Task<List<Usuarios>> Get()
        => await _context.Usuarios.ToListAsync();

        /// <summary>
        ///     consulta usuario por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Usuarios> Get(int id)
            => await _context.Usuarios.FindAsync(id);
    }
}
