using System;

namespace Domain
{

    // we will be using entity framework to create our database. 
    // entity framework is an object, relational mapper
    // an object relational map allows us to write C# code to query our database
    public class Activity
    {
        // we use GUID because it have very low probability of being duplicated as it is 128-bit integer(16 bytes) 
        // We may store users or products in our database and want somehow to uniquely identify each row in the database.
        // A common approach is to create an auto-incrementing integer; another way would be to create a GUID for your products.
        public Guid Id { get; set; } // reason using Guid is we can generate this form(id) from server side // because we name this ID, then entity framework is going to recognize this is going to be primary key for this table in our database
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}