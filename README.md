CanaryProject
Quinn Lindsey

Language: C#

How to run:
    Load solution and build.
    Run Program.cs
    Inside Main in Program.cs, use the functions provided to carryout the actions.


Design Decisions:
Factory,
    It has helper methods to build garage & vehicles.
    I decided to make this a static class since i don't need any instance variables associated with it and its purely a helper function class.
    
Vehicle and it's subclasses,
    I decided to create abstract class due to the functionality of bike, car, truck being nearly the same.
    I didn't use a interface instead because i wanted all the subclasses to automatically inherit Vehicle's functions and instance variables.

ParkingGarage:
    I decided to use the Singleton pattern so there is only one shared instance of ParkingGarage throughout the application.
    This contains a 2D List spots, which contains Spot objects with the first index being the floor and second being the spot number.

PriceStrategy:
    I also decided to use the Singleton pattern so the application has one shared instance that manages the hourly rates and fees.
    This allows the pricing values to be accessed and updated from different parts of the program.


How'd I would extend it:
Add more vehicle types: I can just another class extending Vehicle along with AddHourlyRate of the new vehicle.

Add VIP spots: i'd implement a instance variable for each Spot object & vehicle object that says the tier of the spot & vehicle. 
    It would then only let vehicles with the higher tier be able to park in the Spots with the higher tier.
    Using the Spot tier, it could also be used in PriceStrategy for a new VIP hourly rate.
    
Add Monthly Pass: I could have a variable on Vehicle for a monthly pass and if it is valid, it bypasses the ticket generation when unparking.





