# TRIAL EXAM: Programming Basics

The trial exam is about practicing the **format** of the foundation exam.
The normal exam can be more difficult.

### Getting Started
 
- **Fork** this repository under your own account
- Clone your forked repository to your computer
- Create a `.gitignore` file so generated files won't be committed
- Commit your progress frequently and with descriptive commit messages
- All your answers and solutions should go in this repository
- Take care of style guide
- Take care of the naming of classes, fields, variables, files, etc.
- At the end of the exam upload your solution to **Gradescope** too

### What can I use?

- You can use any resource online, but **please work individually**
- **Don't just copy-paste** your answers and solutions,
  you need to understand every line of your code
- **Don't push your work** to GitHub until your mentor announces
  that the time is up

### Java

- Use [JDK 8 (Java 1.8)](## "Using API from versions newer than Java 1.8 may result in syntax errors on Gradescope") 
- All of your classes should be in the `com.gfa.exam` package
- You may use more packages to separate the exercises within the `com.gfa.exam`
  package
- Use the correct class names, i.e. `SymmetricMatrix`, `MostCommonCharacters`, `Pirate`, `Ship`.  
- Using of `Stream` is **not allowed** in this exam

### TypeScript/JavaScript

- Make sure to export all of your classes and functions.
- Use 3rd party libraries only for converting/running TypeScript, linting, and testing.
Other libraries are not allowed.
- At the end of the exam upload your solution to **Gradescope** too

### Python

- Use `list` instead of `arrays` in exercises below

# Tasks

## Symmetric matrix

Create a function named `isSymmetric` 
that takes an n×n integer matrix (two dimensional array) as a parameter
and returns `true` if the matrix is symmetric
or `false` if it is not.

Symmetric means it has identical values along its diagonal axis from top-left to bottom-right,
as in the first example.

Example 1:

```
[
  [1, 0, 1],
  [0, 2, 2],
  [1, 2, 5]
]
```

Output:

```
true
```

Example 2:

```
[
  [7, 7, 7],
  [6, 5, 7],
  [1, 2, 1]
]
```

Output:

```
false
```

## Most Common Characters

Write a function named `getTwoMostCommonCharacters` that takes a filename as a parameter, and returns the 2 most common characters and their occurrences in the file's content.

- Java: return `Map<Character, Integer>`
- TypeScript/JavaScript: return an `object`
- C#: return a `Dictionary`
- Python: return a `dict`

If the file does not exist throw an exception with the following message:
"File does not exist!"

*Note*: If there is more than one character with the same occurrence, you can return any one of those. For example, if 'a', 'b', and 'c' each occur 8-times, you can return any two combination of them, i.e. (a,b), (a,c), or (b,c).

### Example

[Example file can be found here](./countchar.txt)

### Output

```js
{
  "e": 6,
  "l": 4
}
```

## Pirates
 
Write a program which can store pirates in a ship.

### Pirate
 
 - A pirate has a name (`name`), an amount of gold (`goldAmount`) and health points (`healthPoints`)
 - Pirates can be only created by defining their names
 - Pirates start with 0 amount of gold and 20 healthPoints
 - A pirate may have a wooden leg (`hasWoodenLeg`)
 - A pirate might be a captain, which should be done with inheritence
 - You must create the following methods:
   - `getGoldAmount()` returns the pirate's gold amount
   - `getName()` returns the pirate's name
   - `isPoor()` returns `true` if the pirate has a wooden leg and less than 15 amount of gold; `false` otherwise
   - `toString()` method:
     - if the pirate has a wooden leg, then the string that is returned by the function must look like this:
       > Hello, I'm Jack. I have a wooden leg and 20 amount of gold.
     - If not:
       > Hello, I'm Jack. I still have my real legs and 20 amount of gold.
   - if a pirate is a captain:
      - `work()` which increases the amount of gold possessed by that pirate by 4 and decrease the HP by 3.
      - `party()` which increases the HP by 5.
   - if the pirate is not a captain:
      - `work()` which increases the amount of gold by 1 and decreases the HP by 1.
      - `party()` which increases the HP by 1.

  
### Ship

 - It should have a list of pirates, (`crew`).
 - You must be able to add new pirates to the ship. [There can be only one](https://www.youtube.com/watch?v=ooN9xdAgi5w&t=29s) captain!
 - You must create the following methods:
 - `addPirate(Pirate)` which adds a new pirate to the ship and returns `true` if the pirate was added; 
 `false` otherwise (e.g. the pirates would be a second captain)
 - `getCrewSize()` which returns the number of pirates on the ship
 - `getPoorPirates()` which returns a list of names of *poor* pirates (use the pirate's `isPoor()` method)
 - `getTotalGold()` which returns the sum of gold owned by the pirates on the ship
 - `lastDayOnTheShip()` which calls each pirate's `party()` method.
 - `prepareForBattle()` which calls 
    - each pirate's `work()` method 5 times
    - then the ship's `lastDayOnTheShip()` method.

## Command line exercise

- Take a look at this directory structure:

```text
projects
 |--program
 |   |--.git
 |   |--assets
 |   |   |--data.md
 |   |   |--picture_1.png
 |   |   └--picture_2.jpg
 |   └--data.txt
 └--exam
     |--data.txt
     └--images
         └--picture_3.jpg
```

- Your task is to write commands in the correct order 
  from the directory given below.
- Do it with less commands without chaining them together.
- You can try your commands in the given `cli-exercise` directory
- The staging area is empty.
- Your current directory is `projects/`
  1. Delete both **data.txt**
  1. Move any type of image files from `program/assets/` to `exam/images/`
  1. Commit the changes with the following message "delete txt files and move image files"

- Solution:

*type your answer here*
