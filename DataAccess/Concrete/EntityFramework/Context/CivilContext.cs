using Entities.Concrete.CivilTable;
using Entities.Concrete.CivilTable.Procedure;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class CivilContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        public DbSet<ProductHierarchy> ProductHierarchy { get; set; }
        public DbSet<cdColor> CdColor{ get; set; }
        public DbSet<cdColorDesc> CdColorDesc{ get; set; }
        public DbSet<prProductDimSetContent> prProductDimSetContent { get; set; }

        //Procedure
        public DbSet<sp_vm_GetProductDimSetByHierarchyId> sp_vm_GetProductDimSetByHierarchyId { get; set; }
        public DbSet<sp_vm_GetAllAttributeByHierarchyId> sp_vm_GetAllAttributeByHierarchyId { get; set; }
        public DbSet<sp_vm_GetAttrContentsByHiearIdandAttrCode> sp_vm_GetAttrContentsByHiearIdandAttrCode { get; set; }
        public DbSet<sp_vm_GetAllFabricType> sp_vm_GetAllFabricType { get; set; }
        public DbSet<sp_vm_GetAllProductPartType> sp_vm_GetAllProductPartType { get; set; }
        public DbSet<sp_vm_GetAllPriceLevel> sp_vm_GetAllPriceLevel { get; set; }
        public DbSet<sp_vm_GetAllCommercialRole> sp_vm_GetAllCommercialRole { get; set; }
        public DbSet<sp_vm_LastProductNumber> sp_vm_LastProductNumber { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sp_vm_GetAttrContentsByHiearIdandAttrCode>(eb => eb.HasNoKey());
            modelBuilder.Entity<sp_vm_GetProductDimSetByHierarchyId>(eb => eb.HasNoKey());
            modelBuilder.Entity<sp_vm_GetAllFabricType>(eb => eb.HasNoKey());
            modelBuilder.Entity<sp_vm_GetAllProductPartType>(eb => eb.HasNoKey());
            modelBuilder.Entity<sp_vm_GetAllPriceLevel>(eb => eb.HasNoKey());
            modelBuilder.Entity<sp_vm_GetAllCommercialRole>(eb => eb.HasNoKey());
            modelBuilder.Entity<sp_vm_LastProductNumber>(eb => eb.HasNoKey());
            modelBuilder.Entity<prProductDimSetContent>(eb => eb.HasNoKey());

            base.OnModelCreating(modelBuilder);
        }
    }
}
