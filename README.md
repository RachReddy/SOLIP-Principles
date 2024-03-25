1. *SINGLE RESPONSIBILITY PRINCIPLE*

   "A class should have one and only one reason to change, or in other words, it should have only one job/responsibility."


It's tempting to pack a class with a lot of functionality. However, the issue is that your class won't be conceptually cohesive, giving it several reasons to change. Reducing the number of reasons to modify a class is essential. If this job's specifications change, you only need to modify that specific class. This change is less likely to break the whole application since other classes continue to function as before. As a result, classes have become smaller, cleaner, and thus easier to maintain.

DEMO: The Admin of an Billing Application wants to do four activities as shown by the Use Case Diagram: add invoice, delete invoice, send email of invoice to customers and perform error logging operations.
![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/e6c23110-8101-465f-8d46-5a87046bb7e5)

So initially the admin creates a class called Invoice and adds all the above four operations under the class as shown by the class diagram and the code.

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/d395712f-fac8-4fff-9f2f-62ca51205c1e)
This design doesn't adhere to SRP

*Refactored Design*

![image](https://github.com/RachReddy/SOLIP-Principles/assets/94166047/6372ccda-7bbf-490c-a2bb-aaceb6ee5411)

