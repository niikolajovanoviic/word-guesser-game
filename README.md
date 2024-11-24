# Word Guesser Game

**Word Guesser Game** is a console-based application built in **C#**. The game is designed to challenge players to guess a randomly selected word by uncovering it one letter at a time. Words are dynamically fetched from an external API, ensuring a fresh experience with every playthrough.

---

## **Features**
- Fetches a list of words from an online API dynamically.
- Randomly selects a secret word from the fetched list.
- Engaging gameplay where the player guesses the word letter by letter.
- Feedback on correct and incorrect guesses.
- Tracks player's progress by displaying uncovered letters and the number of attempts left.

---

## **How It Works**
1. The application retrieves a list of words from an API at runtime.
2. A word is selected randomly from the list.
3. The player is prompted to guess letters one by one:
   - Correct guesses reveal the position of the letter in the word.
   - Incorrect guesses reduce the number of remaining attempts.
4. The game ends when:
   - The player successfully guesses the entire word.
   - The player runs out of attempts.

---

## **Prerequisites**
- **.NET Core SDK** installed on your machine.
- Internet connection (required for fetching words from the API).

---

## **Getting Started**
### Clone the Repository
```bash
git clone https://github.com/yourusername/word-guesser-game.git
cd word-guesser-game
```

### Run the Application
1. Open the project in your preferred C# IDE (e.g., Visual Studio, Visual Studio Code).
2. Build and run the project.
3. Follow the instructions in the console to start playing!

---

## **API Integration**
The game fetches words from the [Random Word API](https://random-word-api.herokuapp.com/). You can replace the API URL in the code with another API that suits your requirements, including one for words in different languages.

---

## **Planned Enhancements**
- Add difficulty levels (e.g., easy, medium, hard).
- Enable support for custom word lists.
- Add a scoring system based on accuracy and speed.
- Multiplayer mode for competitive play.

---

## **Contributing**
Contributions are welcome! If you'd like to enhance the game or fix any issues, feel free to submit a pull request.

---

## **License**
This project is licensed under the MIT License. See the `LICENSE` file for more details.

---

Enjoy the challenge of guessing words while sharpening your vocabulary! 🎮
