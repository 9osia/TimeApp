namespace TimeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTasks : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TaskObjects", newName: "Actions");
            RenameColumn(table: "dbo.Subtasks", name: "TaskObject_Id", newName: "Action_Id");
            RenameIndex(table: "dbo.Subtasks", name: "IX_TaskObject_Id", newName: "IX_Action_Id");
            AddColumn("dbo.Actions", "DurationTimeInMinutes", c => c.Int(nullable: false));
            DropColumn("dbo.Projects", "DurationTimeInMinutes");
            DropColumn("dbo.Actions", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Actions", "Time", c => c.Int(nullable: false));
            AddColumn("dbo.Projects", "DurationTimeInMinutes", c => c.Int(nullable: false));
            DropColumn("dbo.Actions", "DurationTimeInMinutes");
            RenameIndex(table: "dbo.Subtasks", name: "IX_Action_Id", newName: "IX_TaskObject_Id");
            RenameColumn(table: "dbo.Subtasks", name: "Action_Id", newName: "TaskObject_Id");
            RenameTable(name: "dbo.Actions", newName: "TaskObjects");
        }
    }
}
