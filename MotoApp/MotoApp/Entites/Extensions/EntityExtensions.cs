using System.Text.Json;

namespace MotoApp.Entites.Extensions
{
    public static class EntityExtensions
    {
        //kopiowanie klasy
        public static T? Copy<T>(T itemToCopy) where T : IEntity
        {
            //serializacja
            var json = JsonSerializer.Serialize<T>(itemToCopy);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}