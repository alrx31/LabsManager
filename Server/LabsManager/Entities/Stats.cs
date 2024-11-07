namespace LabsManager.Entities;

public class Stats
{
    public int labCounts { get; set; }
    public int notChecked { get; set; }
    public int notPassed { get; set; }
    public int passed { get; set; }
    public float averagePassed { get; set; }
    public float averageWithNotPassed { get; set; }
    public int percentOfPassed { get; set; }
    public int percentOfPassedInTime { get; set; }
    public float averageLabsInOneStudent { get; set; } 
}