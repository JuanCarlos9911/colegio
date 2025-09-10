namespace Library.Service.Framework.Web
{
    public static class EndpointExtensions
    {
        public static IEndpointRouteBuilder MapAllEndpoints(this IEndpointRouteBuilder app)
        {
            Rest.Endpoints.PersonsEndpoints.MapPersonsEndpoints(app);
            return app;
        }
    }
}
