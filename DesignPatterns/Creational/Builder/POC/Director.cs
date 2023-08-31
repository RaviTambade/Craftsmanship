namespace Transflower.DesignPatterns.Builder;

public class Director{

    public Car ConstructSportsCar( IBuilder builder){
        builder.reset();
        builder.setSeats(2);
        builder.setEngine(new PetrolEngine());
        builder.setTripComputer(true);
        builder.setGPS(true);
        return builder.GetProduct();
    }

    public Car ConstructSUV( IBuilder builder){  
        builder.reset();
        builder.setSeats(7);
        builder.setEngine( new DiselEngine());
        builder.setTripComputer(true);
        builder.setGPS(true);
        return builder.GetProduct();
    }

     public void ConstructPassengerCar( IBuilder builder){  
        builder.reset();
        builder.setSeats(4);
        builder.setEngine( new ElecticEngine());
        builder.setTripComputer(true);
        builder.setGPS(true);
    }
}