# Hollywood  𝐏𝐫𝐢𝐧𝐜𝐢𝐩𝐥𝐞

The Hollywood Principle is a software design principle that states “don’t call us, we’ll call you.” In other words, it encourages loose coupling between modules by having high-level modules depend on abstractions rather than concrete implementations. This makes it easier to swap out implementations without affecting the rest of the system.

But what do "you" and "they" denote here?

To explain "you" and "they" in technical terms, first we need to understand how software design works. When we design a software, we try to implement two things.

API

Framework

API
An API is used to publish some methods/functions, so the caller/user of the API calls this method to get some useful information. So, the caller does not have any action points to take — only call methods and outputs.

Framework
The framework is a little bit more critical than the API. The framework is maintaining an algorithm, but it expects the value to be produced by the caller of the framework. To put it simply, the framework takes the strategy or business implementation from the caller and calls it when required.

With the Hollywood Principle, we can feed our strategy or business implementation, denoting the framework engine/implementation, which calls the fed strategy when required.