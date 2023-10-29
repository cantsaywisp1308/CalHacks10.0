namespace HealthManagement.Helpers
{
    public class RandomHelper
    {
        public static string CreateCode()
        {
            var guid = Guid.NewGuid().ToString().Replace("-", "");
            return guid;
        }
    }
}
