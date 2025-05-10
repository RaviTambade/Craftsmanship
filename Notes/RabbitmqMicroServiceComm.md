Microservices  Communicaiton using RabbitMQ:

* `OrderService`: Publishes order placed events to RabbitMQ.
* `ShipmentService`: Listens to order events and processes shipments.

We'll use **RabbitMQ** as the message broker to demonstrate **asynchronous communication** between these microservices.

---

### 🔧 Prerequisites

1. [.NET 6 or .NET 7 SDK](https://dotnet.microsoft.com/download)
2. [RabbitMQ server](https://www.rabbitmq.com/download.html) running locally (`localhost:5672`) or via Docker:

   ```bash
   docker run -d --hostname my-rabbit --name some-rabbit -p 5672:5672 -p 15672:15672 rabbitmq:3-management
   ```
3. NuGet packages:

   * `RabbitMQ.Client`

---

## 🧱 Step-by-Step Guide

---

### 📦 1. `OrderService` — Publisher

**Create Project**

```bash
dotnet new webapi -n OrderService
cd OrderService
```

**Install RabbitMQ Client**

```bash
dotnet add package RabbitMQ.Client
```

**Add `OrderController.cs`**

```csharp
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    [HttpPost("place")]
    public IActionResult PlaceOrder([FromBody] Order order)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: "orderQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);

        var message = JsonSerializer.Serialize(order);
        var body = Encoding.UTF8.GetBytes(message);

        channel.BasicPublish(exchange: "", routingKey: "orderQueue", basicProperties: null, body: body);

        return Ok("Order placed successfully");
    }
}

public class Order
{
    public int OrderId { get; set; }
    public string ProductName { get; set; }
}
```

---

### 📦 2. `ShipmentService` — Consumer

**Create Project**

```bash
dotnet new webapi -n ShipmentService
cd ShipmentService
dotnet add package RabbitMQ.Client
```

**Add `OrderConsumer.cs`**

```csharp
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

public class OrderConsumer : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        var connection = factory.CreateConnection();
        var channel = connection.CreateModel();

        channel.QueueDeclare(queue: "orderQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);

        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var order = JsonSerializer.Deserialize<Order>(message);
            Console.WriteLine($"[ShipmentService] Shipping order: {order?.OrderId} - {order?.ProductName}");
        };

        channel.BasicConsume(queue: "orderQueue", autoAck: true, consumer: consumer);

        return Task.CompletedTask;
    }
}

public class Order
{
    public int OrderId { get; set; }
    public string ProductName { get; set; }
}
```

**Register Background Service in `Program.cs`**

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<OrderConsumer>();
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();
```

---

### ✅ Testing the Microservices

1. Run RabbitMQ (`localhost:15672` for UI, user: `guest`, password: `guest`)
2. Run `ShipmentService` first (it will listen to the queue).
3. Run `OrderService`, then hit the endpoint:

```http
POST http://localhost:5000/order/place
Content-Type: application/json

{
  "orderId": 1,
  "productName": "Laptop"
}
```

You’ll see this log from `ShipmentService`:

```
[ShipmentService] Shipping order: 1 - Laptop
```

 
