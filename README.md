# HangMan_CSharp
The game reads a random word from a file. The word taken is hidden. The user guesses the alphabets. 
If the alphabet guessed is correct, then it becomes visible in the word.
If the alphabet guessed is incorrect, 1 live is lost.
The scores are calculated for the user and stored in the MSSQL databse.
At the end, scores are displayed along with the username in descending order.

Random word:
bird

Hidden from user : ****     Lives: 10

User guesses i
It is displayed : *i**    Lives: 10

User guesses t
It is displayed: *i**    Lives: 9
