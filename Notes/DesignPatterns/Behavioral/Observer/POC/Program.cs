using   Transflower.DesignPatterns.Observer;

Publisher _publisher=new Publisher();

EmailSubscriber emailSubscriber=new EmailSubscriber();
_publisher.Subscribe(emailSubscriber);
SMSSubscriber smsSubscriber=new SMSSubscriber();
_publisher.Subscribe(smsSubscriber);

_publisher.Notify();