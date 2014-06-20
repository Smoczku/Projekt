namespace Strawberry.Web.Migrations
{
    using Strawberry.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Strawberry.Web.DataAccessLayer.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Strawberry.Web.DataAccessLayer.MyContext context)
        {

        }
    }
}
