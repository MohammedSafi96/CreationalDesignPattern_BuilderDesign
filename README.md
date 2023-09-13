# BuilderDesignPattern

What is Builder Design Pattern 

Gang Of Four Definition 

Builder Pattern belongs to creational pattern

Definition: “Separate the construction of a complex object from its representation so that the same construction process can create different representations”

Builder Pattern solves the situation of increasing constructor parameters and  
Constructors of a given class by providing a step by step initialization of 
Parameters. After step by step initialization, it returns the resulting constructed
Object at once

Implementation Guidelines

We need to Choose Builder Design Pattern when
1. We need to break up the construction of a complex object
2. We need to create a complex object and it should be independent of the parts that make up the object
3. The construction process must allow multiple representations of the same class

Business Requirement

Provide an option to choose and build configuration of the system  which is allocated to the employees. The configuration options that user can choose are RAM, HDD, USB Mouse. Etc

If you look at the illustrated diagram of Builder Design Pattern
 
1. Builder: Defines a template for the steps to construct the product. To simplify, Builder Specifies an abstract interface for creating parts of a Product object.
2. Concrete Builder: Implements the builder interface and provides an interface for getting the product. 
3. Director: Is responsible to constructs the object through the builder interface.
4. Product: is the Main object that's constructed and Represents the complex object.


///// Include Fluent Interface Design Pattern to this project /////


6. Business Requirement : Provide an option to choose and build configuration of the system which is allocated to the employees. The configuration options that user can choose are RAM, HDD, USB Mouse etc. Choose the system configurations based on the computer type that we need to build. For example, A laptop users can choose touch screen and the desktop users can configure keyboard and mouse. 

Fluent Interface : The idea behind a fluent interface is that one can apply multiple properties to an object by connecting them with dots and without having to re-specify the object each time

C# uses fluent programming extensively in LINQ to build queries using the standard query operators. The implementation is based on extension methods

Fluent Interface Features : Fluent interface is a method for constructing object oriented APIs, where the readability of the source code is close to that of ordinary written prose

Fluent interface is normally implemented by using method cascading (concretely method chaining)

Fluent code is much more readable and allows to vary a product’s internal representation

Fluent Encapsulates code for construction and representation and Provides control over steps of an object construction process

Searching, Sorting, pagination, grouping with a blend of LINQ are some of the real world usage of fluent interface in combination with builder design pattern.

However, it’s not mandatory to implement fluent interfaces with builder design pattern however, the idea of this session is explore and integrate the fluent interface with builder design pattern.

Fluent Builder Implementation

Step 1 : Change the ISystemBuilder Interface methods to return ISystemBuilder

Step 2 : Implement the ISystemBuilder Interface methods in Laptop and Desktop Builder Classes

By returning the ISystemBuilder and by using this as the return statement we are indicating that after assigning the properties of the desktop or  laptop we are returning back the same ISystemBuilder to allow the method chaining.

Step 3 : Enhance the Configuration builder with Fluent Implementation

Step 4 : Run the application and build the system. Notice that depending on the system type the respective system configurations are built using Fluent Builder implementation.

////////////////////////////////////////////////
/////////////Super Important Summary///////////

Builder Vs Factory and Abstract Factory

Builder design pattern encapsulates complex creation into a single method. 

Builder design pattern focuses on construction of object in a step by step manner whereas Abstract factory pattern is used to solve problems related to the creation of families of products.

Builder design pattern returns the object after step by step construction of the complex object where as in Abstract factory or Factory pattern, we return the created product immediately.

To conclude, many application designs start out using Factory which is less complex and evolve towards Abstract Factory and Builder as the complexity increases with a demand of flexibility.


