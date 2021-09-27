using System.Collections.Generic;

public class Root
{
    public string type { get; set; }
    public string name { get; set; }
    public Crs crs { get; set; }
    public List<Feature> features { get; set; }
}