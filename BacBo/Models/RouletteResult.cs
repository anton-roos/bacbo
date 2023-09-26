namespace BacBo.Models;

public class RouletteResult
{
    public int Id { get; set; }
    public DateTime DrawDate { get; set; }
    public int DrawNumber { get; set; }
    public string Color { get; set; }
    public string Source { get; set; }
}