using Transflower.DesignPatterns.State;

Color color = new RedColor();
var trafficlight=new TrafficLight(color);
trafficlight.ChangeSignal();
trafficlight.ChangeSignal();
trafficlight.ChangeSignal();


