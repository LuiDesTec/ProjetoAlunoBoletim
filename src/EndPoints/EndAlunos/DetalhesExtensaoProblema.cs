using Flunt.Notifications;
using System.Runtime.CompilerServices;

namespace ProjetoEducar.EndPoints.EndAlunos
{
    public static class DetalhesExtensaoProblema
    {
        public static Dictionary<string, string[]> ConvertToProblemDetails(this IReadOnlyCollection<Notification> notifications) 
        {
           return notifications
                    .GroupBy(k => k.Key)
                    .ToDictionary(k => k.Key, k => k.Select(x => x.Message).ToArray());
        }
    }
}
