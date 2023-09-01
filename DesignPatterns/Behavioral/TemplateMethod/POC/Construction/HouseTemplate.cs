namespace    Transflower.DesignPatterns.TemplateMethod;
public abstract class HouseTemplate{

    public  void BuildHouse(){
        //Construction Process
        BuildFoundation();
        BuildPillars();
        BuildWalls();
        BuildWindows();
        Console.WriteLine("House is built");
    }

    void BuildFoundation(){
        Console.WriteLine("Buildling Foundation with cement, iron, rods and sand");
    }

    public  void BuildWindows(){
          Console.WriteLine("Building Glass Windwos");
    }
    public abstract void BuildWalls();
    public abstract void BuildPillars();
   
}