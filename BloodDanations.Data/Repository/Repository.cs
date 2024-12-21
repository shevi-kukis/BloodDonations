using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbSet<T> _dbSet;

    public Repository(DataContext context)
    {
        _dbSet = context.Set<T>();
    }
    public T PostServies(T entity)
    {
        _dbSet.Add(entity);
        return entity;
    }

    public bool DeleteServies(int id)
    {

       T entity=_dbSet.Find(id);
        if(entity == null) return false;
        _dbSet.Remove(entity);
        return true;
    }

   

    public List<T> GetServies()
    {
        return _dbSet.ToList();
    }

    public T? GetByIdService(int id)
    {
        return _dbSet.Find(id);
    }



    public T PutServies(int id,T entity)
    {

        T myentity = _dbSet.Find(id);
        if (myentity != null)
        {
            Type entityType = typeof(T);
            PropertyInfo[] propertyInfos = entityType.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                PropertyInfo property = entityType.GetProperty(propertyInfo.Name);
                if (property != null)
                {
                    object value = property.GetValue(entity);
                    if (value != null && property.Name != "Id")
                    {
                        property.SetValue(myentity, value);
                    }
                }

            }
          // _dbSet.Update(entity);
        }
        return entity;
    }
}
