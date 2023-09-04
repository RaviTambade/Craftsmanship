namespace Transflower.DesignPatterns.Builder;

public class Director{


    public Vehicle ConstructSportsCar( IBuilder builder){
        builder.Reset();
         builder.SetSeats(2);
        builder.SetGPS(true);
        builder.SetEngine(new ElectricEngine());
        builder.SetTripComputer(true);
        return builder.GetProduct();
    }

    public Vehicle ConstructSUV( IBuilder builder){  
        builder.Reset();
        builder.SetSeats(7);
        builder.SetEngine( new PetrolEngine());
        builder.SetTripComputer(true);
        builder.SetGPS(true);
        return builder.GetProduct();
    }

     public Vehicle ConstructPassengerCar( IBuilder builder){  
        builder.Reset();
        builder.SetSeats(4);
        builder.SetEngine( new DiselEngine());
        builder.SetTripComputer(true);
        builder.SetGPS(true);
        return builder.GetProduct();

    }
}