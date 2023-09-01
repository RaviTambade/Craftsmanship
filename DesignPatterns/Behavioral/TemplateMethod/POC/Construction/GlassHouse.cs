namespace    Transflower.DesignPatterns.TemplateMethod;

public class GlassHouse: HouseTemplate{
    public override void BuildWalls(){
        Console.WriteLine("Building Glass Walls");
    }
    public override void BuildPillars(){
        Console.WriteLine("Building Pillars with glass coating");
    }
}