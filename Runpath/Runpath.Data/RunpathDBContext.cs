using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Runpath.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runpath.Data
{
    /// <summary>
    /// Database Context for Entity Framework
    /// </summary>
    public class RunpathDBContext : DbContext
    {
        private static bool _created = false;

        public RunpathDBContext(DbContextOptions options) : base(options)
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
                Database.Migrate();
            }
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "Runpath.db" };
                var connectionString = connectionStringBuilder.ToString();
                var connection = new SqliteConnection(connectionString);

                optionsBuilder.UseSqlite(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");


            #region Seed Data

            //Users
            builder.Entity<User>().HasData(
                new User { UserID = 1, UserName = "Test1" },
                new User { UserID = 2, UserName = "Test2" },
                new User { UserID = 3, UserName = "Test3" },
                new User { UserID = 4, UserName = "Test4" },
                new User { UserID = 5, UserName = "Test5" },
                new User { UserID = 6, UserName = "Test6" },
                new User { UserID = 7, UserName = "Test7" },
                new User { UserID = 8, UserName = "Test8" },
                new User { UserID = 9, UserName = "Test9" },
                new User { UserID = 10, UserName = "Test10" }
              );

            //Albums 
            builder.Entity<Album>().HasData(
                new Album { AlbumID = 1 , UserID = 1, Title = "quidem molestiae enim" },
                new Album { AlbumID = 2, UserID = 1, Title = "sunt qui excepturi placeat culpa" },
                new Album { AlbumID = 3, UserID = 1, Title = "omnis laborum odio" },
                new Album { AlbumID = 4, UserID = 1, Title = "non esse culpa molestiae omnis sed optio" },
                new Album { AlbumID = 5, UserID = 1, Title = "eaque aut omnis a" },
                new Album { AlbumID = 6, UserID = 1, Title = "natus impedit quibusdam illo est" },
                new Album { AlbumID = 7, UserID = 1, Title = "quibusdam autem aliquid et et quia" },
                new Album { AlbumID = 8, UserID = 1, Title = "qui fuga est a eum" },
                new Album { AlbumID = 9, UserID = 1, Title = "saepe unde necessitatibus rem" },
                new Album { AlbumID = 10, UserID = 1, Title = "distinctio laborum qui" },
                new Album { AlbumID = 11, UserID = 2, Title = "quam nostrum impedit mollitia quod et dolor" },
                new Album { AlbumID = 12, UserID = 2, Title = "consequatur autem doloribus natus consectetur" },
                new Album { AlbumID = 13, UserID = 2, Title = "ab rerum non rerum consequatur ut ea unde" },
                new Album { AlbumID = 14, UserID = 2, Title = "ducimus molestias eos animi atque nihil" },
                new Album { AlbumID = 15, UserID = 2, Title = "ut pariatur rerum ipsum natus repellendus praesentium" },
                new Album { AlbumID = 16, UserID = 2, Title = "voluptatem aut maxime inventore autem magnam atque repellat" },
                new Album { AlbumID = 17, UserID = 2, Title = "aut minima voluptatem ut velit" },
                new Album { AlbumID = 18, UserID = 2, Title = "nesciunt quia et doloremque" },
                new Album { AlbumID = 19, UserID = 2, Title = "velit pariatur quaerat similique libero omnis quia" },
                new Album { AlbumID = 20, UserID = 2, Title = "voluptas rerum iure ut enim" },
                new Album { AlbumID = 21, UserID = 3, Title = "repudiandae voluptatem optio est consequatur rem in temporibus et" },
                new Album { AlbumID = 22, UserID = 3, Title = "et rem non provident vel ut" },
                new Album { AlbumID = 23, UserID = 3, Title = "incidunt quisquam hic adipisci sequi" },
                new Album { AlbumID = 24, UserID = 3, Title = "dolores ut et facere placeat" },
                new Album { AlbumID = 25, UserID = 3, Title = "vero maxime id possimus sunt neque et consequatur" },
                new Album { AlbumID = 26, UserID = 3, Title = "quibusdam saepe ipsa vel harum" },
                new Album { AlbumID = 27, UserID = 3, Title = "id non nostrum expedita" },
                new Album { AlbumID = 28, UserID = 3, Title = "omnis neque exercitationem sed dolor atque maxime aut cum" },
                new Album { AlbumID = 29, UserID = 3, Title = "inventore ut quasi magnam itaque est fugit" },
                new Album { AlbumID = 30, UserID = 3, Title = "tempora assumenda et similique odit distinctio error" },
                new Album { AlbumID = 31, UserID = 4, Title = "adipisci laborum fuga laboriosam" },
                new Album { AlbumID = 32, UserID = 4, Title = "reiciendis dolores a ut qui debitis non quo labore" },
                new Album { AlbumID = 33, UserID = 4, Title = "iste eos nostrum" },
                new Album { AlbumID = 34, UserID = 4, Title = "cumque voluptatibus rerum architecto blanditiis" },
                new Album { AlbumID = 35, UserID = 4, Title = "et impedit nisi quae magni necessitatibus sed aut pariatur" },
                new Album { AlbumID = 36, UserID = 4, Title = "nihil cupiditate voluptate neque" },
                new Album { AlbumID = 37, UserID = 4, Title = "est placeat dicta ut nisi rerum iste" },
                new Album { AlbumID = 38, UserID = 4, Title = "unde a sequi id" },
                new Album { AlbumID = 39, UserID = 4, Title = "ratione porro illum labore eum aperiam se" },
                new Album { AlbumID = 40, UserID = 4, Title = "voluptas neque et sint aut quo odit" },
                new Album { AlbumID = 41, UserID = 5, Title = "ea voluptates maiores eos accusantium officiis tempore mollitia consequatur" },
                new Album { AlbumID = 42, UserID = 5, Title = "tenetur explicabo ea" },
                new Album { AlbumID = 43, UserID = 5, Title = "aperiam doloremque nihil" },
                new Album { AlbumID = 44, UserID = 5, Title = "sapiente cum numquam officia consequatur vel natus quos suscipit" },
                new Album { AlbumID = 45, UserID = 5, Title = "tenetur quos ea unde est enim corrupti qui" },
                new Album { AlbumID = 46, UserID = 5, Title = "molestiae voluptate non" },
                new Album { AlbumID = 47, UserID = 5, Title = "temporibus molestiae aut" },
                new Album { AlbumID = 48, UserID = 5, Title = "modi consequatur culpa aut quam soluta alias perspiciatis laudantium" },
                new Album { AlbumID = 49, UserID = 5, Title = "ut aut vero repudiandae voluptas ullam voluptas at consequatur" },
                new Album { AlbumID = 50, UserID = 5, Title = "sed qui sed quas sit ducimus dolor" },
                new Album { AlbumID = 51, UserID = 6, Title = "odit laboriosam sint quia cupiditate animi quis" },
                new Album { AlbumID = 52, UserID = 6, Title = "necessitatibus quas et sunt at voluptatem" },
                new Album { AlbumID = 53, UserID = 6, Title = "est vel sequi voluptatem nemo quam molestiae modi enim" },
                new Album { AlbumID = 54, UserID = 6, Title = "aut non illo amet perferendis" },
                new Album { AlbumID = 55, UserID = 6, Title = "qui culpa itaque omnis in nesciunt architecto error" },
                new Album { AlbumID = 56, UserID = 6, Title = "omnis qui maiores tempora officiis omnis rerum sed repellat" },
                new Album { AlbumID = 57, UserID = 6, Title = "libero excepturi voluptatem est architecto quae voluptatum officia tempora" },
                new Album { AlbumID = 58, UserID = 6, Title = "nulla illo consequatur aspernatur veritatis aut error delectus e" },
                new Album { AlbumID = 59, UserID = 6, Title = "eligendi similique provident nihil" },
                new Album { AlbumID = 60, UserID = 6, Title = "omnis mollitia sunt aliquid eum consequatur fugit minus laudantium" },
                new Album { AlbumID = 61, UserID = 7, Title = "delectus iusto et" },
                new Album { AlbumID = 62, UserID = 7, Title = "eos ea non recusandae iste ut quasi" },
                new Album { AlbumID = 63, UserID = 7, Title = "velit est quam" },
                new Album { AlbumID = 64, UserID = 7, Title = "autem voluptatem amet iure quae" },
                new Album { AlbumID = 65, UserID = 7, Title = "voluptates delectus iure iste qui" },
                new Album { AlbumID = 66, UserID = 7, Title = "velit sed quia dolor dolores delectus" },
                new Album { AlbumID = 67, UserID = 7, Title = "ad voluptas nostrum et nihil" },
                new Album { AlbumID = 68, UserID = 7, Title = "qui quasi nihil aut voluptatum sit dolore minima" },
                new Album { AlbumID = 69, UserID = 7, Title = "qui aut est" },
                new Album { AlbumID = 70, UserID = 7, Title = "et deleniti unde" },
                new Album { AlbumID = 71, UserID = 8, Title = "et vel corporis" },
                new Album { AlbumID = 72, UserID = 8, Title = "unde exercitationem ut" },
                new Album { AlbumID = 73, UserID = 8, Title = "quos omnis officia" },
                new Album { AlbumID = 74, UserID = 8, Title = "quia est eius vitae dolor" },
                new Album { AlbumID = 75, UserID = 8, Title = "aut quia expedita non" },
                new Album { AlbumID = 76, UserID = 8, Title = "dolorem magnam facere itaque ut reprehenderit tenetur corrupti" },
                new Album { AlbumID = 77, UserID = 8, Title = "cupiditate sapiente maiores iusto ducimus cum excepturi veritatis quia" },
                new Album { AlbumID = 78, UserID = 8, Title = "est minima eius possimus ea ratione velit et" },
                new Album { AlbumID = 79, UserID = 8, Title = "ipsa quae voluptas natus ut suscipit soluta quia quidem" },
                new Album { AlbumID = 80, UserID = 8, Title = "id nihil reprehenderit" },
                new Album { AlbumID = 81, UserID = 9, Title = "quibusdam sapiente et" },
                new Album { AlbumID = 82, UserID = 9, Title = "recusandae consequatur vel amet unde" },
                new Album { AlbumID = 83, UserID = 9, Title = "aperiam odio fugiat" },
                new Album { AlbumID = 84, UserID = 9, Title = "est et at eos expedita" },
                new Album { AlbumID = 85, UserID = 9, Title = "qui voluptatem consequatur aut ab quis temporibus praesentium" },
                new Album { AlbumID = 86, UserID = 9, Title = "eligendi mollitia alias aspernatur vel ut iusto" },
                new Album { AlbumID = 87, UserID = 9, Title = "aut aut architecto" },
                new Album { AlbumID = 88, UserID = 9, Title = "quas perspiciatis optio" },
                new Album { AlbumID = 89, UserID = 9, Title = "sit optio id voluptatem est eum et" },
                new Album { AlbumID = 90, UserID = 9, Title = "est vel dignissimos" },
                new Album { AlbumID = 91, UserID = 9, Title = "repellendus praesentium debitis officiist" },
                new Album { AlbumID = 92, UserID = 9, Title = "incidunt et et eligendi assumenda soluta quia recusandae" },
                new Album { AlbumID = 93, UserID = 9, Title = "nisi qui dolores perspiciatis" },
                new Album { AlbumID = 94, UserID = 9, Title = "quisquam a dolores et earum vitae" },
                new Album { AlbumID = 95, UserID = 9, Title = "consectetur vel rerum qui aperiam modi eos aspernatur ipsa" },
                new Album { AlbumID = 96, UserID = 9, Title = "unde et ut molestiae est molestias voluptatem sint" },
                new Album { AlbumID = 97, UserID = 9, Title = "est quod au" },
                new Album { AlbumID = 98, UserID = 9, Title = "omnis quia possimus nesciunt deleniti assumenda sed autem" },
                new Album { AlbumID = 99, UserID = 9, Title = "consectetur ut id impedit dolores sit ad ex aut" },
                new Album { AlbumID = 100, UserID = 9, Title = "enim repellat iste" }
              );

            //Albums 


            #endregion

        }
    }
}
