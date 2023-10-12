# SoftwareDesign

## Information

### Week 1
Modifications from points 4,5,6 are commented in //EX4 //EX5 //EX6 manner. Relevant files regarding changes are: Player.cs, Color.cs, Game.cs

There is also static class Colors not included in the diagram. The Simulation class is just to generate players, deck and start game.

![800|371536574_288213467289224_5117261151531558073_n](https://github.com/heyimjustalex/SoftwareDesign/assets/21158649/2fde04f5-e269-4639-b247-0da39b5727ff)

### Week 2

SRP and OCP modifications of code.

SRP

- Modified ReportGenerator class - splitting two responsibilites (Generating report, and low-level "compiling")
- Created Interface IReportFormater that is used by ReportGeneratorClient
- Implemented interface into two seperate formats NameFirstFormat and SalaryFirstFormat

OCP
![800|UML2](https://github.com/heyimjustalex/SoftwareDesign/assets/21158649/6bc58537-f6fb-4e03-9838-b3c56dd172ec)

- abstract class Report Formater has generic method that can accept List<T> and print Type.Properties
- abstract class Report Formater accepts method to modify how output is printed
- IReportFormater is implemented by abstract class ReportFormater
- abstract class ReportFormater is implemented in the specific formats (AgeLastFormat,NameFirstFormat, SalaryFirstFormat)
- (AgeLastFormat,NameFirstFormat, SalaryFirstFormat) use IFunctionFormater
- IFunctionFormater is implemented by concrete formaters (FieldLastFormater : IFunctionFormater)

All of these modifications result in OCP:
- If I want to make new Format i just inherit from ReportFormater (as long as there is just one field to be modified)
- If I want to make new fields of Employee it does not affect anything except for Employee Constructors (look at TestClassFieldThatMakesThisSolutionOCP example field)
- If I want to make new Entity (except for Employee) it would not be hard (I would need to change IReportFormater to accept more generic type, but ReportFormater is already generic and able to print all class fields) 


### Week 7

Exercise: Observer pattern

Over the hills and far away…
In these exercises, you will work with the observer design pattern.
Tinky-Winky, Dipsy, La-la and Po live over the hills and far away.
They have not yet learned how to tell time, but fortunately, there is a big “telephone” in the neighborhood, which tells
them when to wake up, have dinner, and watch television and when to say tubbie-bye-bye.

**Exercise 1: (Design)**
Create a UML class diagram where you:
• Define the methods and properties of the teletubbies.
• Define the methods and properties of the big telephone.
• Use the observer pattern to let the tubbies know when to have dinner etc.
Explain your design to one or two of your fellow students.

**Exercise 2: (Implementation)**
Implement your design as a Console application.
Control the telephone from the main() method and have the tubbies write to the console, when they know that they
should do something new.

**Pull Observer implementation**

![Pull](./Week%207/ObserverTeletubbiesPull/class.PNG)

**Push Observer implementation**

![Push](./Week%207/ObserverTeletubbiesPush/class_uml.PNG)

### Week 8

**Exercise 1: Observer Generic implementation**

![Push](./Week%208/ObserverGeneric/class.PNG)

**Exercise 2: Observer generic Stock implementation**

In this exercise, you will design a stock trading system in which stocks values are continuously updated and
in which you can buy and sell stocks. Through this, you will get familiar with the use of the GoF Observer
pattern.

The situation: You are to design and implement a system, which consists of a number of parts:
• Stocks, which live a life of their own. Their values are periodically updated, and when this happens,
a Portfolio must be informed of the changes.
• A Portfolio, which keeps track of the currently owned stocks (stock name, amount of stocks and
value) and the total stock value.
• A Portfolio Display, which is used to output information on the currently held portfolio.

**Exercise 2.1:**
Considering the GoF Observer pattern, what is/are the subject(s), and what is/are the observer(s) in the
stock trading system?
Which variant of GoF Observer is applicable – or would you rather create your own?

**Exercise 2.2:**
Design a system in which Stocks may be added to a Portfolio, which should then automatically be notified if
the value of the Stock changes. When this happens, the Portfolio Display should make sure that the stocks
in the portfolio are printed to screen.
Changing stock values could be done from a command line interface, e.g. VESTAS 570.50 or GOOGLE:
943.29.
Create a design document, with a short description of your design and design choices and the class
diagram(s) and sequence diagram(s) you need to explain your design (at least one of each).

**Exercise 2.3:**
Implement and test your system. As always, remember that any changes to the design discovered during
implementation and/or test must be reflected in the design documentation (class diagram etc.)

**Exercise 2.4:**
Revise your system so that the stocks have a life of their own: They should update their values (e.g. within
the range +/- 5%) at regular intervals.

**Exercise 2.5 (optional):**
Create a market from which it is possible to buy and sell stocks.


