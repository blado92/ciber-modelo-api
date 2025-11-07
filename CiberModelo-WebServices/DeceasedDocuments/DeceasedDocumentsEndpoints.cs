using BusinessManager;
using Microsoft.IdentityModel.Tokens;

namespace CiberModelo_WebServices.DeceasedDocuments
{
    public static class DeceasedDocumentsEndpoints
    {
        public static IEndpointRouteBuilder MapDeceasedDocumentsEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/deceased/documents", async (DeceasedDocumentsBM service, int deceasedId) =>
            {
                var documents = await service.GetDocumentsByDeceasedIdAsync(deceasedId);

                if (documents.IsNullOrEmpty())
                    return Results.NoContent();

                return Results.Ok(documents);
            });

            return routes;
        }
    }
}
