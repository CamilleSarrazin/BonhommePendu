using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre
    public class GuessEvent : GameEvent
    {
        public override string EventType { get { return "Guess"; } }

        // TODO: Compléter
        public GuessEvent(GameData gameData, char letter) {
            // TODO: Commencez par ICI
            //on crée une nouvelle liste d'events de game
            Events = new List<GameEvent>();

            //on ajoute l'event dans notre liste et on précise que c'est un GuessedLetterEvent
            Events.Add(new GuessedLetterEvent(gameData, letter));

            //booléen pour stocker si on a guessé correctement une lettre
            bool foundAtLeastOneLetter = false;

            //on regarde pour chaque lettre du mot si la lettre qu'on a guessé correspond, si oui, on met le booléen a true et
            //on ajoute un event de type RevealLetter 
            for(int i = 0; i < gameData.RevealedWord.Length; i++)
            {
                if(gameData.HasSameLetterAtIndex(letter, i))
                {
                    foundAtLeastOneLetter = true;
                    Events.Add(new RevealLetterEvent(gameData, letter, i));
                }
            }

            //Si aucune lettre est trouvée, on ajoute un event de type WrongGuess 
            if (!foundAtLeastOneLetter)
            {
                Events.Add(new WrongGuessEvent(gameData));
            }

        }
    }
}
