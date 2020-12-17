using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    class RestaurantContext : DbContext
    {
        //Tham chieu toi cac nhom mon an bang Category
        public DBSet<Category> Categorys { get; set; }
        //Tham chieu toi cac nhom mon an do uong trong bang Food
        public DbSet<Food> Foods { get; set; }

        public override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //xoa bo quy tac su duung danh tu so nhieu cho ten bang
            //luc nay thuoc tinh Categorys anh xa toi bang Category trong db
            //va thuoc tinh food tuong ung voi bang food trong Co so du lieu
            modelBuilder.Entity<Food>()
                .HasRequired(x => x.Category)
                .WithMany()
                .HasForeignKey(x => char.FoodCategoryId)
                .WillCascadeOnDelete(true);
        }

    }
}
