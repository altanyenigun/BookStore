using Microsoft.EntityFrameworkCore;

namespace WebApi.DBOperations{
  public class BookStoreDbContext : DbContext{
    //Book bir entity, bu uygulamanın bir nesnesi
    //Entity isimleri tekil yazılır.Dbde yaratılacak refarans çoğul olur.
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) 
    { }

    // bu context'e Book entitysini eklemiş olduk. Books ismiyle o entitiyin her şeyine erişebiliriz
    public DbSet<Book> Books { get;set;} // Buradaki Book, DBdeki Books objesinin bir replikası.
    
  }

}