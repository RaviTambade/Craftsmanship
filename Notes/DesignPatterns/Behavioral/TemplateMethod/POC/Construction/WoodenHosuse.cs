namespace    Transflower.DesignPatterns.TemplateMethod;

public class WoodenHouse: HouseTemplate{

    public override void BuildWalls(){
        Console.WriteLine("Building Wooden Walls");
    }
    public override void BuildPillars(){
        Console.WriteLine("Building Pillars with Wood coating");
    }
    public override void BuildDoor(){
        Console.WriteLine("Building Doors with Wood");
        
    }
    public override void BuildWindows(){
        Console.WriteLine("Building Windows with Wood");

    } 
}