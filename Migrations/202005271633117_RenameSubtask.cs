namespace TimeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameSubtask : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Subtasks", newName: "SubActions");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SubActions", newName: "Subtasks");
        }
    }
}
