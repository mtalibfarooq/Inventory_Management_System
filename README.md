# Inventory_Management_System
Create an issue if you require *ASP.NET MVC* C# IMS web application.

1. Introduction
Inventory management refers to the process by which you track the amount of product you have on your warehouse/godown shelf, in store or sitting with other retailers and distributors. This enables you to succeed in having the right number of units in the right place, at the right time and for the right price.
As a part of your supply chain, inventory management includes aspects such as controlling and overseeing sale and purchases
1.1 Purpose
The main purpose of this document is to provide a working example of a Software Requirements Specification (SRS) based on Inventory Management System.
Some times because of the errors wrong products are sent out which have no requirement & thus a lot of money is being wasted in maintaining the stock. Automating such a process will not only eliminate the errors in the process, but also bring down the delivery times & make the company more competitive. So it was decided that an automated system should be developed to make the whole process simpler & easier.
 Analysis, Design & Data requirements, nonfunctional requirements, design constraints and other factors necessary, To make sure of data integrity we have proper use of variables with their appropriate data types.
1.2 Scope
The scope of an inventory system can cover many needs, including valuing the inventory, measuring the change in inventory and planning for future inventory levels. 
Inventory Management System (IMS) is targeted to the small or medium organization which doesn’t have many godowm or warehouses i.e. only to those organization that has single power of authority. Some of the scope are:
 
Only one person is responsible in assigning the details or records.
It is security driven.
Supplier can be added as per the requirement.
1.3 Definitions, Acronyms, and Abbreviations
Custom Attribute: Additional requirement property capturing additional requirements
properties such as requirements source, status, priority, verification method, fit criterion.
Document: A structured requirements specification capturing textual requirements for a given
product or service.
Link: A directed association between related requirements allowing to analyze requirements
coverage, gaps and impact of changes.
Link Type: Property of traceability links allowing to analyze links with different semantic
independently, e.g., satisfaction and verification links.


CSV: Comma Separated Values
DNF: Disjunctive Normal Form
ID: Identifier
GUI: Graphical User Interface
HTML: Hypertext Markup Language
SRS: Software Requirements Specification
1.4 References
https://www.reqview.com/papers/ReqViewExample_Software_Requirements_Specification_SRS_Document.pdf

1.5 Overview
Utmost delivery performance.
Enhanced customer satisfaction.
Avoid product run-outs.
Optimizing the supply & value chains.
Lower inventory management costs.
Improves inventory accuracy.
High warehouse productivity.
Meets customer demands. 

2. General Description
Inventory management is a systematic approach to sourcing, storing, and selling inventory—both raw materials (components) and finished goods (products). In business terms, inventory management means the right stock, at the right levels, in the right place, at the right time, and at the right cost as well as price.
2.1 Product Perspective
Increased Sales.
Increased Information Transparency.
Shorter Lead Times.
Lower Costs.
Improved Delivery Performance.
Increased Customer Loyalty.
Increased Inventory Turnover.


2.2 Product Functions
Improved Productivity and Efficiency.
Avoid Stock-outs and Over-stock.
Quality Management.
Easy Inventory Management.
Improved Profitability.
Planned Management.
Balanced Supply and Demand.
Inventory Reports.
All-in-one Solution. 
2.3 User Characteristics
Improved inventory control and forecasting/projection.
Improved, actionable inventory analysis.
Configurability.
Integration and Interfaces.
On-premise versus Software as a Service and Cloud system. 

2.4 General Constraints
Constraints are the rules enforced on the data columns of a table. These are used to limit the type of data that can go into a table. This ensures the accuracy and reliability of the data in the database.
NOT NULL Constraint
DEFAULT Constraint
UNIQUE Constraint 
PRIMARY Key 
FOREIGN Key
CHECK Constraint
2.5 Assumptions and Dependencies
Inventory management refers to the process of ordering, storing, using, and selling a company's inventory. This includes the management of raw materials, components, and finished products, as well as warehousing and processing of such items. 
3. Specific Requirements
A system to keep track of the inventory on hand and on order.
A reliable forecast of demand, including forecast error.
Knowledge of lead times and variability.
Estimates of holding, ordering and shortage costs.
Classification system for inventory. 

3.1 External Interface Requirements
3.1.1 User Interfaces
The application GUI provides menus, toolbars, buttons, panes, containers, grids allowing for
easy control by a keyboard and a mouse.
3.1.2 Hardware Interfaces
The Hardware inventory details include information like, memory, operating system, manufacturer, device types, peripherals, etc.
3.1.3 Software Interfaces
•	MS-Sql Database
•	Asp.Net Mvc Entity Framework
•	.Net C#
3.1.4 Communications Interfaces
An effective inventory management system needs to encompass purchasing, inventory management, warehousing, sales orders, order fulfillment, distribution and customer service management. 
Describe any communications interfaces to other systems or devices such as local area networks, remote serial devices, etc.
3.2 Functional Requirements
The main function of inventory management is to determine the sufficient amount and type of input products, products in process and finished products, facilitating production and sales operations and minimizing costs by keeping them at an optimal level. 
3.2.1 <Functional Requirement or Feature #1>
3.2.1.1 Introduction
3.2.1.2 Inputs
3.2.1.3 Processing
3.2.1.4 Outputs
3.2.1.5 Error Handling
3.2.2 <Functional Requirement or Feature #2>
…
3.3 Use Cases










Activity diagram:


3.4 Classes / Objects
3.4.1 <Class / Object #1>

3.4.1.1 Attributes
3.4.1.2 Functions
<Reference to functional requirements and/or use cases>
3.4.2 <Class / Object #2>
…
3.5 Non-Functional Requirements
3.5.1 Performance
To measure performance in inventory management, one of the most common metrics to use is the “number of inventory turns.” This number is calculated using the ratio of the value of purchased stock to the value of stock on hand.

3.5.2 Reliability
Its ability to complete all required processes before they are due.

3.5.3 Availability
Inventory management helps companies identify which and how much stock to order at what time. It tracks inventory from purchase to the sale of goods. The practice identifies and responds to trends to ensure there's always enough stock to fulfill customer orders and proper warning of a shortage.

3.5.4 Security
Inventory security is the process of ensuring the safety and optimum management control of stored goods. It is of central importance for optimum warehouse management because the performance of a company stands or falls with the safety and efficiency of a warehouse.

3.5.5 Maintainability
The probability that a failed component or system will be restored or repaired to a specified condition within a specified period or time when maintenance is performed in accordance with prescribed procedures.

3.5.6 Portability
Periodic systems and perpetual systems.
3.6 Inverse Requirements
An easy-to-use interface that doesn't require advanced training, support or documentation. Automation for eliminating manual processes of business functions related to inventory management. A reliable, secure database that provides accurate, real-time data 
3.7 Design Constraints
This section should indicate any design constraints on the system being built. Design constraints represent design decisions that have been mandated and must be adhered to. Examples include software languages, software process requirements, prescribed use of developmental tools, architectural and design constraints, purchased components, class libraries, etc. 
3.8 Logical Database Requirements
Discover, track, and manage database inventory.It is important to have a way to inventory and determine which SQL Servers need oversight and maintenance. SQL Inventory Manager offers an organized web-based dashboard that captures core information about the entire inventory of SQL Servers across the environment. 
3.9 Other Requirements
System interfaces:
The application runs in the latest version of Chrome or Firefox browser on Windows. 

4. Analysis Models
List all analysis models used in developing specific requirements previously given in this SRS.  Each model should include an introduction and a narrative description.  Furthermore, each model should be traceable the SRS’s requirements.
4.1 Sequence Diagrams

4.3 Collaborative Diagram

4.2 State-Transition Diagrams (STD)

5. Change Management Process
Identify and describe the process that will be used to update the SRS, as needed, when project scope or requirements change.  Who can submit changes and by what means, and how will these changes be approved.






A. Appendices
Appendices may be used to provide additional (and hopefully helpful) information.  If present, the SRS should explicitly state whether the information contained within an appendix is to be considered as a part of the SRS’s overall set of requirements.


A.1 Appendix 1
Our mission is to make the world more productive. To do this, we built one app to replace them all - Tasks, Docs, Goals, and Chat.



