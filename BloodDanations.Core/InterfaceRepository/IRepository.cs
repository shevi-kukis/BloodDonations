
public interface IRepository<T> where T : class
{


     T PostServies(T entity);


   bool DeleteServies(int id);



     List<T> GetServies();


     T? GetByIdService(int id);



     T PutServies(int id,T entity);
 
}
