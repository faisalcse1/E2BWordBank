# E2BWordBank : Overview
The E2BWordBank package provides a comprehensive English-to-Bangla word database for easy integration into .NET applications.
# Packages
NuGet library: https://www.nuget.org/packages/E2BWordBank
# Installation

````
NuGet\Install-Package E2BWordBank
````
# Features
````
GetAllWords();
GetWordsStartingWith(string prefix, WordType type= WordType.En);
FindWord(string prefix, WordType type = WordType.En);
````

# WordRepository

A simple dictionary repository class that allows for managing and retrieving words from a word database. The class provides methods for retrieving all words, filtering words based on a prefix, and finding a single word that exactly matches a given prefix.

## Methods

### 1. `GetAllWords()`
- **Description**: Retrieves all words from the dictionary.
- **Returns**: A list of `Word` objects containing all available words in the dictionary.

### 2. `GetWordsStartingWith(string prefix, WordType type = WordType.En)`
- **Description**: Retrieves words that start with the specified prefix and match the given word type.
- **Parameters**:
  - `prefix` (string): The starting substring to filter words by.
  - `type` (WordType): The category of words to retrieve (e.g., `WordType.En` for English & `WordType.Bn` for Bangla). Defaults to `WordType.En` (English).
- **Returns**: A list of `Word` objects that start with the specified prefix and match the given type.

### 3. `FindWord(string prefix, WordType type = WordType.En)`
- **Description**: Finds a single word that exactly matches the specified prefix and type.
- **Parameters**:
  - `prefix` (string): The exact word or substring to match.
  - `type` (WordType): The type/category of the word to retrieve (default is `WordType.En` for English).
- **Returns**: A single `Word` object that matches the exact prefix and type. Returns `null` if no match is found.

## Key Notes

- **`Word` Class**: Represents a word in the dictionary. This class holds details about individual words in your dictionary, such as the word itself, its type, and any other related information.
  
- **`WordType` Enum**: Differentiates between different types of words (e.g., English, Bengali). This allows filtering words by language or category.

- **Static Methods**: All methods in the `WordRepository` class are static, meaning you can call them directly without creating an instance of the `WordRepository` class.

## Example Usage

```
// Retrieve all words
List<Word> allWords = WordRepository.GetAllWords();

// Retrieve words starting with a specific prefix
List<Word> wordsStartingWithPrefix = WordRepository.GetWordsStartingWith("pro");

// Find a specific word by exact match
Word foundWord = WordRepository.FindWord("programming");
```
