using Flunt.Notifications;
using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;

namespace ProjetoEducar.EndPoints
{
    public static class DetalhesExtensaoProblema
    {
        public static Dictionary<string, string[]> ConvertToProblemDetails(this IReadOnlyCollection<Notification> notifications)
        {
            return notifications
                     .GroupBy(k => k.Key)
                     .ToDictionary(k => k.Key, k => k.Select(x => x.Message).ToArray());
        }

        public static Dictionary<string, string[]> ConvertToProblemDetails(this IEnumerable<IdentityError> error)
        {
           var dictionary = new Dictionary<string, string[]>();
           dictionary.Add("Error", error.Select(e => e.Description).ToArray());    
           return dictionary;
        }
    }
}
