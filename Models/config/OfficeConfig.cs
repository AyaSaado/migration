
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models.config
{
    public class OfficeCofig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedNever();

            builder.Property(x => x.OfficeName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.OfficeLocation)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50).IsRequired();


            builder.ToTable("Offices");


           // builder.HasData(Load());
        }

        // private static List<Office> Load()
        // {
        //     return new List<Office>
        //     {

        //             new Office { id = 1, OfficeName = "Off_05", OfficeLocation = "building A"},
        //             new Office { id = 2, OfficeName = "Off_12", OfficeLocation = "building B"},
        //             new Office { id = 3, OfficeName = "Off_32", OfficeLocation = "Adminstration"},
        //             new Office { id = 4, OfficeName = "Off_44", OfficeLocation = "IT Department"},
        //             new Office { id = 5, OfficeName = "Off_43", OfficeLocation = "IT Department"}
        //     };
        // }
    }
}