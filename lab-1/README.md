# Used Design Patterns 

## C# samples

All C# files/classes are located in the separate [Application folder](./ConsoleApp).

## SOLID (Single Responsibility Principle):

- ***Single Responsibility, SRP***:
  
  "One entity can solve only one problem" - [class Money](./ConsoleApp/Money.cs#L11-L70) : Class Money is responsible only for operations related to funds and nothing else.

- ***Open/Closed, OCP***:
  
  "Program entities should be open to extension but closed to modification" - [every classes](./ConsoleApp/) are used this principle, because have ***get*** and ***set*** methods to every property (using **Encapsulation**).

- ***Liskov Substitution, LSP***:

  "Entities that use a parent type should work the same way with child types" and "The child entity should complement, not replace, the behavior of the parent entity" - used at [Money.cs child classes](./ConsoleApp/Money.cs#L72-L95).

## KISS (Keep it simple, stupid):

- It is used in almost all methods of different classes, because most of them do not use complex checks, that is, extra lines of code, but at the same time work no worse than their more complex implementations. For example:
  - [InventoryReport](./ConsoleApp/Reporting.cs#L40-L48);
  - [Substract](./ConsoleApp/Money.cs#L47-L64);
  - and else.

## YAGNI (You aren't gonna need it):

- In general, it can be said that this is the basis of my program, since it is implemented according to the principle: ***"There is no need to implement features that are not needed \\ Try to create the Minimum Viable Product (MVP)"***. I implemented only the basic functions that ensure the correct operation of the program.

## DRY (Don’t repeat yourself):

- In the Reporting.cs class, I tried to use this method, as evidenced by the implementation of the `RegisterIncoming` , `RegisterOutgoing` , `InventoryReport methods`, which could be implemented almost identically (duplicating the code with minimal changes), but by adding some simple checks and using a little ingenuity, it was possible to avoid this.  [Reporting.cs](./ConsoleApp/Reporting.cs#L18-L48)

_During the execution of this task, I tried as much as possible to adhere to all known principles of framing to facilitate the further development of the application, the readability of the code itself, without losing functionality._

## [UML Diagrame](https://drive.google.com/file/d/1YdEoo6zP7YqISTa8f9-pVB5FkvDT2xvt/view)
