namespace Library.Service.Framework.Rest.Endpoints
{
    public static class PersonsEndpoints
    {
        public static void MapPersonsEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/persons", Handlers.PersonsHandlers.GetPersons);

        }
    }
}
