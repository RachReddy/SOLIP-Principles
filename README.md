1. *SINGLE RESPONSIBILITY PRINCIPLE*

   "A class should have one and only one reason to change, or in other words, it should have only one job/responsibility."


It's tempting to pack a class with a lot of functionality. However, the issue is that your class won't be conceptually cohesive, giving it several reasons to change. Reducing the number of reasons to modify a class is essential. If this job's specifications change, you only need to modify that specific class. This change is less likely to break the whole application since other classes continue to function as before. As a result, classes have become smaller, cleaner, and thus easier to maintain.

DEMO1: The Admin of an Billing Application wants to do four activities as shown by the Use Case Diagram: add invoice, delete invoice, send email of invoice to customers and perform error logging operations.
![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/e6c23110-8101-465f-8d46-5a87046bb7e5)

So initially the admin creates a class called Invoice and adds all the above four operations under the class as shown by the class diagram and the code.

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/d395712f-fac8-4fff-9f2f-62ca51205c1e)
This design doesn't adhere to SRP

*Refactored Design*

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/6372ccda-7bbf-490c-a2bb-aaceb6ee5411)


DEMO2: We have a class to represent a simple book
![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/e4dd9b12-ab2d-4068-87c7-94cb944a613f)

Let’s now add a couple of methods to query the text:
![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/dc96af14-e3c8-4c76-b903-2598f7ad2ca8)

But what good is storing the information if we can’t output the text to our console and read it?
![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/841dfc76-ac7c-4843-971c-0995cea11e45)

To fix our mess, we should implement a separate class that deals only with printing our texts:
![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/b6912044-81ba-4388-8bfc-59a512f8ed28)


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2. *OPEN/CLOSED PRINCIPLE*
   
   "It states that the software entities (classes or methods) should be open for extension but closed for modification." OR
   "You should be able to extend a classes behavior, without modifying it."

NOTE: *This can be achieved with inheritance. You don’t have to touch the class you want to extend if you create a subclass of it. The original class is closed for modification but you can add custom code to your subclass to add new behavior.*

> Open for extension: It means that the module’s behavior can be extended. When the requirements of the application change, you can extend the module with new behaviors that adapt to those changes.

> Closed for modification: You shouldn't refactor and modify the existing source code of a module as it has already passed the unit testing, so changing it can affect other existing functionalities. ( one exception to the rule is when fixing bugs in existing code.)


In doing so, BENEFITS OF OCP

 a) Inheritance through interface helps achieve loose coupling between classes implementing that interface.
 
 b) To add a new feature, we don’t change existing code so we don’t break existing features by introducing new bugs.

Note: The one exception to the OCP rule is when fixing bugs in existing code. 


DEMO: ABC corporation wants to create a login service for its e-commerce application. Initial use case requirement given by the company is given below:
 


![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/7a50917a-e34d-44b7-89b3-eda89215b513)

Based on the initial requirement you created a LoginService class to do the login activities of above two actors 

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/beb99b06-25d7-4e63-9110-852507b74135)

Change Request: After some days ABC corporation comes up with a new request to add Customers also under the login process.

*Refactored Design* :  new change without modifying the existing class

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/28d96441-e318-4ba8-a18f-149c41c58d19)


DEMO 2: Simple example with & without adheering to OCP

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/7447fb52-6292-4d44-8d70-41f8276f1c67) Without OCP implemented

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/5151dbc7-59af-435a-bded-7aadde421e2e) With OCP implemented

the main method will be same in both the conditions 

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/27494d64-08c4-4df0-ac81-e5e8afc54623)


DEMO 3: Usecase: if we need to add another company (like big basket) we need to modify the existing code in the switch statement


![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/2221cd87-0f67-4c09-bfaf-e73512ebbaf7)

Solution1 (PREFFERED) : Make Merchent as a interface and make Flipkart, Amazon, Bigbasket as subclasses when implement this interface and then add its own shipping rate percent to each of its Calculateshippingcost method.

Solution2: By creating inheritance, we make it easy to modify by adding a derived class without touching the existing class
![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/db0e30fc-668d-44de-bcc8-fa2820759497)



-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

3. *LISKOV SUBSTITUTION PRINCIPLE*

“You should be able to use any derived class instead of a parent class and have it behave in the same manner without modification.”

>  When you have a parent class and a child class in your project, the child class can be a substitution of the parent class without changing the correctness of the application. 
> In simple words it says “Code designed to work with a Parent must continue to work when provided with it's Children instead.” (if class B is a subtype of class A, we should be able to replace A with B without disrupting the behavior of our program.)
> 


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

4. *INTERFACE SEGREGATION PRINCIPLE*


5. *DEPENDENCY INVERSION PRINCIPLE*

   
