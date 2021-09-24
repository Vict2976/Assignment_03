Extensions: 

Given the following collections in scope:

    IEnumerable<int>[] xs;

    int[] ys;

Solve the following questions with extension methods (one-liners):

1. Flatten the numbers in xs.
    
    var flattenXs = xs.SelectMany(i => i);



2. Select numbers in ys which are divisible by 7 and greater than 42.

    var numbersGreaterThanFortyTwoAndDivisibleBySevenInYs = ys.Where(i => i % 7 = 0 && i > 42);


3. Select numbers in ys which are leap years.

    var leapYearsInYs = ys.Where(i => IsLeapYear(i));
