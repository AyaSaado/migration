using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models.config
{

    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x=>x.id);
            builder.Property(x=>x.id).ValueGeneratedNever();
            
            builder.Property(x=>x.FName)
            .HasColumnType("VARCHAR").HasMaxLength(250).IsRequired();
            
            builder.Property(x=>x.LName)
            .HasColumnType("VARCHAR").HasMaxLength(250).IsRequired();

           // builder.HasData(getdataIn());
            builder.ToTable("Instructors");

            builder.HasOne(x=>x.office)
            .WithOne(x=>x.Instructor)
            .HasForeignKey<Instructor>(x=>x.OfficeId)
            .IsRequired(false);
            
            // builder.HasMany(x=>x.Sections).
            // WithOne(x=>x.Instructor)
            // .HasForeignKey(x=>x.InstructorId).
            // IsRequired(false);
            
        }

        // private static List<Instructor> getdataIn()
        // {   
        //         return new List<Instructor>
        //     {
        //         new Instructor { id = 1, FName = "Ahmed"   ,LName = "Dafy" ,OfficeId =1},
        //         new Instructor { id = 2, FName = "Yasmeen", LName = "Fady" ,OfficeId =5},
        //         new Instructor { id = 3, FName = "Khalid",  LName = "Saad" ,OfficeId =4 },
        //         new Instructor { id = 4, FName = "Nadia"  , LName = "Mokyat",OfficeId =3 },
        //         new Instructor { id = 5, FName = "Ahmed"  , LName = "shorok" ,OfficeId =2}
        //     };
        // }
    }
} 