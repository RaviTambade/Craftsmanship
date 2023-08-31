namespace Transflower.DesignPatterns.Builder;

public class Director{


    public Vehicle ConstructSportsCar( IBuilder builder){
        builder.reset();
         builder.setSeats(2);
        builder.setGPS(true);
        builder.setEngine(new ElecticEngine());
        builder.setTripComputer(true);
        return builder.GetProduct();
    }

    public Vehicle ConstructSUV( IBuilder builder){  
        builder.reset();
        builder.setSeats(7);
        builder.setEngine( new ElecticEngine());
        builder.setTripComputer(true);
        builder.setGPS(true);
        return builder.GetProduct();
    }

     public Vehicle ConstructPassengerCar( IBuilder builder){  
        builder.reset();
        builder.setSeats(4);
        builder.setEngine( new ElecticEngine());
        builder.setTripComputer(true);
        builder.setGPS(true);
        return builder.GetProduct();

    }
}