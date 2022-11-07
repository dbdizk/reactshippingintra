using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Shipments.Any()) return;
            
            var shipments = new List<Shipment>
            {
                new Shipment
                {
                    Title = "Past Shipment 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Shipment 2 months ago",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Past Shipment 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Shipment 1 month ago",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Future Shipment 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Shipment 1 month in future",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Future Shipment 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Shipment 2 months in future",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Future Shipment 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Shipment 3 months in future",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Future Shipment 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Shipment 4 months in future",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Future Shipment 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Shipment 5 months in future",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Future Shipment 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Shipment 6 months in future",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Future Shipment 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Shipment 2 months ago",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                },
                new Shipment
                {
                    Title = "Future Shipment 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Shipment 8 months in future",
                    FromWhere = "culture",
                    ToWhere = "Paris",
                    Weight = 2,
                    Distance = 3,
                }
            };

            await context.Shipments.AddRangeAsync(shipments);
            await context.SaveChangesAsync();
        }
    }
}