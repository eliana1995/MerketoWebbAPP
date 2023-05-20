using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebbAPP.Contexts;

namespace WebbAPP.Helpers.Repositories;


    public abstract class Repo <Entity> where Entity : class
    {
    #region constructors  
    private readonly DataContext _context;

    protected Repo(DataContext context)
    {
        _context = context;
    }
    #endregion

    public virtual async Task<Entity> AddAsync(Entity entity) 
    {
        await _context.Set<Entity>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }


    public virtual async Task<Entity> GetAsync(Expression<Func<Entity,bool>> expression)
    {
        var entity = await _context.Set<Entity>().FirstOrDefaultAsync(expression);
        return entity!;

    }

    public virtual async Task<IEnumerable<Entity>> GetAllAsync()
    {
        return await _context.Set<Entity>().ToListAsync();
        

    }
    public virtual async Task<IEnumerable<Entity>> GetAllAsync(Expression<Func<Entity, bool>> expression)
    {
        return await _context.Set<Entity>().Where(expression).ToListAsync();


    }

    public virtual async Task<Entity> UppdateAsync(Entity entity)
    {
        _context.Set<Entity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task RemoveAsync(Entity entity)
    {
        _context.Set<Entity>().Remove(entity);
        await _context.SaveChangesAsync();
        
    }
}

