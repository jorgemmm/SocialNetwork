namespace SNSimplev7.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SNSimplev7.Models.SocialNetContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SNSimplev7.Models.SocialNetContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(
                 new User
                 {
                     FirstName = "Carson",
                     LastName = "Alexander",
                     Year = AcademicYear.Freshman
                 },
                 new Student
                 {
                     FirstName = "Meredith",
                     LastName = "Alonso",
                     Year = AcademicYear.Freshman
                 },
                 new Student
                 {
                     FirstName = "Arturo",
                     LastName = "Anand",
                     Year = AcademicYear.Sophomore
                 },
                 new Student
                 {
                     FirstName = "Gytis",
                     LastName = "Barzdukas",
                     Year = AcademicYear.Sophomore
                 },
                 new Student
                 {
                     FirstName = "Yan",
                     LastName = "Li",
                     Year = AcademicYear.Junior
                 },
                 new Student
                 {
                     FirstName = "Peggy",
                     LastName = "Justice",
                     Year = AcademicYear.Junior
                 },
                 new Student
                 {
                     FirstName = "Laura",
                     LastName = "Norman",
                     Year = AcademicYear.Senior
                 },
                 new Student
                 {
                     FirstName = "Nino",
                     LastName = "Olivetto",
                     Year = AcademicYear.Senior
                 }
                 );

            context.SaveChanges();
        }
    }
}
