# HomeSchool Hub

This repository serves as a Monorepo for the base MicroServices of HomeSchool Hub.  HomeSchool Hub is an application for managing homeschool education activities including tracking time, activites, tasks, and communications.

---
## Microservice Setup
Microservices in this project are arranged using the domain driven design pattern.  An outline of this pattern is as follows:

* **Domain Layer**
    * This layer contains the business logic and types, including entities, value objects, and domain events. It represents the business concepts, business state, and business rules. Being the heart of the application, it should have no dependencies.

* **Application Layer**
    * The Application layer orchestrates the execution of business operations, coordinates with the Domain layer, and applies application logic. It defines interfaces that are implemented by the Infrastructure layer but should not depend directly on specific infrastructure concerns. This layer depends on the Domain layer but not on the Presentation, Infrastructure, or Persistence layers directly.

* **Infrastructure Layer**
    * This layer provides implementations for the interfaces defined in the Application layer, such as sending emails, accessing file systems, and database CRUD operations. It also might include the implementation details for repositories from the Domain. The Infrastructure layer depends on the Persistence layer (for database connection), the Application layer (for the interfaces), and the Domain layer (for the domain models it persists or interacts with).

* **Persistence Layer**
    * Although sometimes considered part of the Infrastructure layer, in this project it will be a separate layer. The persistence layer specifically deals with data access and persistence mechanisms (e.g., ORM configurations, database access logic). It should depend on the Domain layer to align with the persistence mechanisms to the domain models but should not have direct dependencies on other layers like Application or Presentation.

* **Presentation Layer**
    * This is the layer where RESTful APIs are defined. It's the entry point to application, handling HTTP requests and responses. It depends on the Application layer to carry out business operations. It should not depend on the Infrastructure or Persistence layers directly, ensuring that the separation of concerns is maintained and that the higher-level modules are not dependent on lower-level modules for core operations.


### Project References Setup:

* **Domain Layer**: No project references to other layers.
* **Application Layer**: References to the Domain layer.
* **Infrastructure Layer**: References to the Persistence, Application, and Domain layers.
* **Persistence Layer**: References to the Domain layer.
* **Presentation Layer**: References to the Application layer.