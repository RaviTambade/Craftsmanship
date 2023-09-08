# 𝐀𝐫𝐜𝐡𝐢𝐭𝐞𝐜𝐭𝐮𝐫𝐚𝐥 𝐏𝐚𝐭𝐭𝐞𝐫𝐧𝐬

𝐀𝐫𝐜𝐡𝐢𝐭𝐞𝐜𝐭𝐮𝐫𝐚𝐥 𝐏𝐚𝐭𝐭𝐞𝐫𝐧𝐬 are reusable solutions to common software design problems.
They provide a structured approach to organizing code that improves system quality, scalability, and maintainability.

- 𝐋𝐚𝐲𝐞𝐫𝐞𝐝: Organizes software into distinct layers, each with a specific purpose and responsibility, to improve maintainability and scalability.

- 𝐌𝐢𝐜𝐫𝐨𝐬𝐞𝐫𝐯𝐢𝐜𝐞𝐬: Software is divided into independent services, each with its data storage and logic. Communication between services occurs via APIs, enabling separate development, deployment, and scaling.

- 𝐌𝐨𝐝𝐞𝐥-𝐯𝐢𝐞𝐰-𝐜𝐨𝐧𝐭𝐫𝐨𝐥𝐥𝐞𝐫: Separates software into three components such as model (data), view (user interface), and controller (logic) for easier development and maintenance.

- 𝐏𝐮𝐛-𝐬𝐮𝐛: Publishers send messages (events) to a central message broker, which then distributes the messages to any subscribers that have expressed interest in receiving them.

- 𝐒𝐚𝐠𝐚: Managing distributed transactions across multiple services by breaking them down into a series of smaller, reversible steps.

- 𝐒𝐭𝐫𝐚𝐧𝐠𝐥𝐞𝐫: An approach to software modernization where a new system is gradually introduced alongside an existing one, eventually replacing it entirely.

- 𝐂𝐢𝐫𝐜𝐮𝐢𝐭 𝐁𝐫𝐞𝐚𝐤𝐞𝐫: Helps handle failures and prevent cascading failures in distributed systems by stopping requests to failing services for a period of time.

- 𝐂𝐐𝐑𝐒: separates read and write operations for a data store, allowing for optimization of each type of operation independently.

- 𝐂𝐨𝐧𝐭𝐫𝐨𝐥𝐥𝐞𝐫-𝐫𝐞𝐬𝐩𝐨𝐧𝐝𝐞𝐫: Breaks down tasks into parts and assigns them to responders to perform. The master collects the results and produces a composite output.

- 𝐄𝐯𝐞𝐧𝐭 𝐬𝐨𝐮𝐫𝐜𝐢𝐧𝐠: records all changes to an application's state as a sequence of events, which can be used to reconstruct the state at any point in time.

- 𝐂𝐥𝐢𝐞𝐧𝐭-𝐬𝐞𝐫𝐯𝐞𝐫: Clients request services or resources from servers that provide and manage those resources, often over a network.

- 𝐓𝐡𝐫𝐨𝐭𝐭𝐥𝐢𝐧𝐠: controls the rate of requests to a system, preventing overloading and optimizing resource utilization.
