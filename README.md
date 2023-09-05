# FunctionalProgrammingExample

The logic represented in this project helps users combine and display their first and last names in different ways. This project takes user input, provides format choices, and then shows the user's name according to their chosen format. The tool offers the ability for the programmer to dynamically add or remove formats. By using a straightforward approach, the program ensures that users can easily and quickly view their names in various configurations.

This mentoring example aims to help learners understand functional and dynamic programming design patterns by modularizing functionality and using structured logic.

## Usage
```csharp
static void Main(string[] args)
{
    string? firstName = GetFirstName();
    string? lastName = GetLastName();
    NameFormat userDefinedNameFormat = GetNameFormat();
    string fullName = CombineFirstAndLastName(firstName, lastName, userDefinedNameFormat);

    OutputFormattedFullName(fullName);
}
```

## Enumerations

### NameFormat

Provides a set of predefined name formats that can be used to dictate how the first and last names should be combined and displayed. This provides flexibility in the naming conventions according to user preference or context.

#### `NameFormat.FirstCommaLast`
Format: "FirstName, LastName"

This format combines the first name followed by a comma and then the last name. It's a common representation in some professional or formal contexts.

#### `NameFormat.LastCommaFirst`
Format: "LastName, FirstName"

In this format, the last name appears first, followed by a comma, and then the first name. It is often used in directories or bibliographies.

#### `NameFormat.FirstLast`
Format: "FirstName LastName"

A straightforward representation where the first name is followed directly by the last name without any comma in between. This is commonly used in casual and informal situations.

#### `NameFormat.LastFirst`
Format: "LastName FirstName"

This format places the last name before the first name without any comma. It's less common than the other formats but might be used in specific cultural or contextual situations.

## Methods

#### `GetFirstName()`

Prompts the user to input their first name and returns it.

#### `GetLastName()`

Prompts the user to input their last name and returns it.

#### `GetNameFormat()`

* Displays the available name formats to the user.
* Prompts the user to select a format.
* Validates and returns the user's choice as a NameFormat enum value. If the input is invalid, it defaults to LastCommaFirst.

#### `CombineFirstAndLastName(string? firstName, string? lastName, NameFormat nameFormat)`

* Takes the first name, last name, and the chosen name format as arguments.
* Returns the combined names in the desired format.

#### `OutputFormattedFullName(string fullName)`

* Method that displays the combined full name in the format chosen by the user.
