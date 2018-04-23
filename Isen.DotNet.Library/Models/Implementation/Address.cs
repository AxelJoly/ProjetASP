namespace Isen.DotNet.Library.Models.Implementation
{
    public class Address
    {
       public string address { get; set; } 
       public string zipCode { get; set; } 
       public Town town { get; set; }
       public float latitude { get; set; }
       public float longitude { get; set; }
    }
}