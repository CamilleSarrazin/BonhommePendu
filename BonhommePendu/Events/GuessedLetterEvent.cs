using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer peu importe si la lettre est dans le mot ou pas!
    public class GuessedLetterEvent : GameEvent
    {
        public override string EventType { get { return "GuessedLetter"; } }

        //on ajoute une variable de type char 
        public char Letter { get; set; }

        // TODO: Compléter
        public GuessedLetterEvent(GameData gameData, char letter)
        {
            //on assigne la letter dans notre variable 
            Letter = letter;
            //on ajoute la lettre dans notre liste de guessedLetters
            gameData.GuessedLetters.Add(Letter);
        }
    }
}
