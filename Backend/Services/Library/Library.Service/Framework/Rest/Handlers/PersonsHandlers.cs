namespace Library.Service.Framework.Rest.Handlers
{
    public static class PersonsHandlers
    {
        public static IResult GetPersons() 
            {
            var persons = new[] { "Alice", "Bob", "Charlie" };
            return Results.Ok(persons);
        }
    }
}
