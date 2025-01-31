public class Vehicle {
    public int Year{get;set;}
    public string Model{get;set;}=string.Empty;
    public string Make{get;set;}=string.Empty;
    public int Tyre{get;set;}
}


public class Car:Vehicle {
    public int NumDoors{get;set;}
    public string EngineType{get;set;}=string.Empty;
}