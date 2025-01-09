

namespace Business.Helpers;
public static class GuidGenerator
{
    public static string Generate() => Guid.NewGuid().ToString();   
    
}
