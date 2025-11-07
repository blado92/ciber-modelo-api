using BusinessManager;
using Microsoft.IdentityModel.Tokens;

namespace CiberModelo_WebServices.QueryType
{
    public static class QueryTypeEndPoints
    {
        public static IEndpointRouteBuilder MapQueryTypeEndPoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/deceased/querytypes", async (QueryTypeBM service, int userId, int deceasedId) =>
            {
                var quertTypes = await service.GetQueryTypesByUserAndDeceasedAsync(userId, deceasedId);

                if (quertTypes.IsNullOrEmpty())
                    return Results.NoContent();

                return Results.Ok(quertTypes);
            });

            return routes;
        }
    }
}
