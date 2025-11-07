using BusinessManager;
using Microsoft.IdentityModel.Tokens;

namespace CiberModelo_WebServices.Deceased
{
    public static class DeceasedEndpoints
    {
        public static IEndpointRouteBuilder MapDeceasedEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/deceased", async (DeceasedBM service, int userId) =>
            {
                var deceaseds = await service.GetDeceasedByUserIdAsync(userId);

                if (deceaseds.IsNullOrEmpty())
                    return Results.NoContent();

                return Results.Ok(deceaseds);
            });

            return routes;
        }
    }
}
