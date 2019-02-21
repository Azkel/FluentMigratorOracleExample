using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMigratorOracle.Migrations
{
    [Migration(20190221211200, "Add Some Stuff to Database")]
    public class IncludeSomeSQLToDb : Migration
    {
        public override void Down()
        {
            Execute.Script("RemoveFromTable.sql");
        }

        public override void Up()
        {
            Execute.Script("InsertToTable.sql");
        }
    }
}
