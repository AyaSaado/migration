using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models.config
{

    public class StudentConfig : IEntityTypeConfiguration<Particpant>
    {
        public void Configure(EntityTypeBuilder<Particpant> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedNever();

            builder.Property(x => x.FName)
            .HasColumnType("VARCHAR").HasMaxLength(250).IsRequired();

            builder.Property(x => x.LName)
            .HasColumnType("VARCHAR").HasMaxLength(250).IsRequired();

          //  builder.HasData(getdata());
            builder.ToTable("Students");


        }

        // private static List<Student> getdata()
        // {
        //     return new List<Student>
        //     {
        //         new Student() { id = 1, FName = "Fatima", LName = "Ali" },
        //         new Student() { id = 2, FName = "Noor" , LName = "Saleh" },
        //         new Student() { id = 3, FName = "Omar" , LName = "Youssef" },
        //         new Student() { id = 4, FName = "Huda" , LName = "Ahmed" },
        //         new Student() { id = 5, FName = "Amira" , LName = "Tariq" },
        //         new Student() { id = 6, FName = "Zainab" , LName = "Ismail" },
        //         new Student() { id = 7, FName = "Yousef" , LName = "Farid" },
        //         new Student() { id = 8, FName = "Layla" , LName = "Mustafa" },
        //         new Student() { id = 9, FName = "Mohammed" , LName = "Adel" },
        //         new Student() { id = 10, FName = "Samira" , LName = "Nabil" }
        //     };
        // }
    }
}