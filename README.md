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
