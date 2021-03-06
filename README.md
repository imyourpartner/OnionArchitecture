# OnionArchitecture

## Introduction
The Onion Architecture term was coined by Jeffrey Palermo in 2008. This architecture provides a better way to build applications for better testability, maintainability, and dependability on the infrastructures like databases and services. This architecture's main aim is to address the challenges faced with 3-tier architecture or n-tier architecture, and to provide a solution for common problems, like coupling and separation of concerns. There are two types of coupling - tight coupling and loose coupling. 

## Tight Coupling
When a class is dependent on a concrete dependency, it is said to be tightly coupled to that class. A tightly coupled object is dependent on another object; that means changing one object in a tightly coupled application, often requires changes to a number of other objects. It is not difficult when an application is small but in an enterprise level application, it is too difficult to make the changes.

## Loose Coupling
It means two objects are independent and an object can use another object without being dependent on it. It is a design goal that seeks to reduce the inter-dependencies among components of a system with the goal of reducing the risk that changes in one component will require changes in any other component.

Advantages of Onion Architecture

## There are several advantages of the Onion Architecture, as listed below.

It provides better maintainability as all the codes depend on layers or the center.
*It provides better testabilty as the unit test can be created for separate layers without an effect of other modules of the application.
*It develops a loosely coupled application as the outer layer of the application always communicates with inner layer via interfaces.
*Any concrete implantation would be provided to the application at run time
*Domain entities are core and center part. It can have access to both database and UI layers.
*The internal layers never depend on external layer. The code that may have changed should be part of an external layer.

