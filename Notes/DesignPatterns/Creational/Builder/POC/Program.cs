using  Transflower.DesignPatterns.Builder;

Director director=new Director();
IBuilder builder=new CarRoboBuilder();
//IBuilder builder=new CarMannualBuilder();
//director.ConstructSportsCar(builder);
director.ConstructSUV(builder);
Vehicle theCar=builder.GetProduct();
Console.WriteLine(theCar);
