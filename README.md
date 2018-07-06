# _Word Counter_

#### _Word Counter | June 29, 2018_

#### By _**Nikki Boyd**_

## Description

_This program will assist users with counting the frequency of a single word throughout a given sentence or paragraph. The program has been built to account for case sensitivity, all forms of punctuation, pluralization, and an infinite amount of entries. Please stay tuned for the user interface portion of this program shortly!_

## Specifications

The program will ask the user which word they would like to check for frequency, and collect that first word.
- Input: "cat"
- Output: "cat" is stored in program as word to check
- Why: The program will first need to reference a saved value to compare with their next input (the sentence to check).

The program will ask the user to enter a sentence to see how many times the word "cat" appears in it.
- Input: "The cat likes to nap."
- Output: The word "cat" appears 1 time.
- Why: The program needs to reference a sentence to calculate the frequency of the initial word to check.

The program will only check for full word matches.
- Input: "Cats are my favorite animal."
- Output: The word "cat" does not appear.
- Why: The program needs to initially eliminate all words that are not a 100% match of the search.

Another example of full word matches: The program will not include words that includes part of the word in the total number of appearances.
- Input: "I ordered catering."
- Output: The word "cat" does not appear.
- Why: The program needs to initially eliminate all words that are not a 100% match of the search.

The program allows periods, commas, semicolons to be attached to the word to check in the sentence.
- Input: "I love my cat.", "This is my cat, Gary."
- Output: The word "cat" appears 1 time.
- Why: The program needs to be able to allow the word to search to include punctuation throughout the sentence.

The program does not allow dashed words to be considered a full word match.
- Input: "Santa Claws is an alley-cat."
- Output: The word "cat" does not appear.
- Why: Even though "alley-cat" is a manipulated version of the word "cat", alley-cat is a much more specific word than just "cat" and may not be relevant to the user's search.

The program can count the same word many different times throughout the same sentence (i.e. no word limit).
- Input: ""Lorem ipsum dolor sit amet, Lorem Lorem Lorem Lorem Lorem Lorem Lorem Lorem Lorem Lorem consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit."
- Output: The word "Lorem" appears 15 times.
- Why: Users should be able to enter a large paragraph and still obtain the correct word count.

## Setup/Installation Requirements

* _1. Clone the master branch of "word-counter" from this repository: (https://github.com/nikkiboyd/word-counter)_
* _2. Ensure .NET Core 1.1 is installed on your machine._
* _3. Ensure Mono is installed on your machine._
* _4. If not running from Visual Studio, please run the command "dotnet restore" in Terminal to refresh packages._
*_5. Tests are located in the file "WordCounter.Tests". All tests for both controllers and models are currently in passing state.

## Known Bugs

_There are no known bugs at this time. All specifications have been thoroughly tested with MSTests._

## Support and contact details

_Please reach out to Nikki Boyd at boyd.nikki@icloud.com if you experience difficulty running this page._

## Technologies Used

_This console app was made with C# and the LINQ .NET Framework._

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Nikki Boyd_**
