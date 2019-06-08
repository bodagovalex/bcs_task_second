namespace EFCodeFirstDLL
{
    using EF_CodeFirst.DataModel;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        /// <summary>
        /// Инициализация подключения к БД.
        /// </summary>
        public DataContext()
            : base("name=DBConnectionString")
        { }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleFirstType> ArticleFirstTypes { get; set; }
        public virtual DbSet<ArticleSecondType> ArticleSecondTypes { get; set; }
    }
}