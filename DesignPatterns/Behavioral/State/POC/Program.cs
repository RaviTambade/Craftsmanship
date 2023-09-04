using Transflower.DesignPattern.State.Billing;
/*Color color = new RedColor();
var trafficlight=new TrafficLight(color);
trafficlight.ChangeSignal();
trafficlight.ChangeSignal();
trafficlight.ChangeSignal();

*/

var invoice = new Invoice(123, 1000m, "Software Dev Services");

invoice.Pay();
invoice.Pay();
//invoice.Refund();