namespace Clase5.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPerson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Course_Id = c.Int(),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Fee = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Id", "dbo.People");
            DropForeignKey("dbo.Instructors", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Instructors", "Id", "dbo.People");
            DropForeignKey("dbo.Courses", "Student_Id", "dbo.Students");
            DropIndex("dbo.Students", new[] { "Id" });
            DropIndex("dbo.Instructors", new[] { "Course_Id" });
            DropIndex("dbo.Instructors", new[] { "Id" });
            DropIndex("dbo.Courses", new[] { "Student_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Instructors");
            DropTable("dbo.People");
            DropTable("dbo.Courses");
        }
    }
}
