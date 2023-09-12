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
