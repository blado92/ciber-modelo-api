using BusinessManager;

namespace CiberModelo_WebServices.User
{
    public static class LoginEndpoints
    {
        public static IEndpointRouteBuilder MapLoginEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/login", async (UserBM service, string email, string password) =>
            {
                var user = await service.GetUserByEmailPasswordAsync(email, password);

                if (user is null)
                    return Results.Unauthorized();

                return Results.Ok(user);
            });

            return routes;
        }
    }
}
