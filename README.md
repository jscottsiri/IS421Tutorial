# IS421Tutorial
Encapsulation:
No other classes may directly modify the private state (being the variables and private functions) of a class, but may use its public methods that will allow its state to be indirectly changed. For example, in a game like Pokemon a creature getting hit by attack wouldn't have its health, stats, or conditions modified directly, but could be modified through the attack methods available.

Abstraction:
Only exposing the high level mechanism for using a complex code base. The mechanism changes infrequently, though the processes that are underneath may be modified. Implementation changes rarely affect the abstraction used. This way the code that uses the processes in the code base don't need to be modified for every change made (it can keep the same high level mechanisms). This is similar to a user interface and a software program- the UI doesn't need to be changed for every change in a computer's data structures. In this case the high level code is like the 'UI' for the more complex code.

Inheritence:
Child classes have the methods and variables a parent class has, but the parent  class doesn't have the variabels and methods all their child classes have. A child class resuses all the parts of code a parent class has and adds a new part unique to itself (and its child classes if it has them). Child classes can be parent classes to their own child classes (which would have access to the functionality of all of its parent classes). If you had a parent class 'Fruit', the child classes 'Apple', 'Citrus', and 'Banana' would have all the variables and functions the 'Fruit' class would have. Likewise, if 'Citrus' had the child classes 'Lemon', 'Lime', and 'Orange', they would have all the functionality of 'Citrus' and 'Fruit'.

Polymorphism:
The child classes that inherit a parent class and all need different versions of the same type of method (like electric, gasoline, and hybrid cars using different methods of the 'Car Powering' methods). The child will implement its own version of the common methods that are different.
