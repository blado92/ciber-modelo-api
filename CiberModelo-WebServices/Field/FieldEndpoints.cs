using BusinessManager;
using Microsoft.IdentityModel.Tokens;

namespace CiberModelo_WebServices.Field
{
    public static class FieldEndpoints
    {
        public static IEndpointRouteBuilder MapFieldEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/fields", async (FieldBM service, int queryTypeId, int accessLevelId) =>
            {
                var fields = await service.GetFieldsByQueryTypeAndAccessLevelAsync(queryTypeId, accessLevelId);

                if (fields.IsNullOrEmpty())
                    return Results.NoContent();

                return Results.Ok(fields);
            });

            return routes;
        }
    }
}
