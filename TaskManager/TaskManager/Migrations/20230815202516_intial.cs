using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    taskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks", x => x.taskId);
                });

            migrationBuilder.CreateTable(
     name: "items",
     columns: table => new
     {
         itemId = table.Column<int>(type: "int", nullable: false)
             .Annotation("SqlServer:Identity", "1, 1"),
         content = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
         TodoListtaskId = table.Column<int>(type: "int", nullable: true)
     },
     constraints: table =>
     {
         table.PrimaryKey("PK_items", x => x.itemId);
         table.ForeignKey(
             name: "FK_items_tasks_TodoListtaskId",
             column: x => x.TodoListtaskId,
             principalTable: "tasks",
             principalColumn: "taskId",
             onDelete: ReferentialAction.Cascade); 
     });


            migrationBuilder.CreateIndex(
                name: "IX_items_TodoListtaskId",
                table: "items",
                column: "TodoListtaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "tasks");
        }
    }
}
