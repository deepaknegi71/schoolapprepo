using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace amitranetapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    shortname = table.Column<string>(name: "short_name", type: "varchar(100)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    affiliation = table.Column<string>(type: "varchar(100)", nullable: false),
                    phone = table.Column<string>(type: "varchar(100)", nullable: false),
                    photopath = table.Column<string>(name: "photo_path", type: "varchar(200)", nullable: false),
                    organizationid = table.Column<int>(name: "organization_id", type: "integer", nullable: false),
                    establishdate = table.Column<DateTime>(name: "establish_date", type: "timestamp with time zone", nullable: false),
                    accessexpireddate = table.Column<DateTime>(name: "access_expired_date", type: "timestamp with time zone", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    createdby = table.Column<long>(name: "created_by", type: "bigint", nullable: false),
                    createdon = table.Column<DateTime>(name: "created_on", type: "timestamp with time zone", nullable: false),
                    modifiedby = table.Column<long>(name: "modified_by", type: "bigint", nullable: false),
                    modifiedon = table.Column<DateTime>(name: "modified_on", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "School");
        }
    }
}
