using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois que la lettre n'est pas dans le mot
    public class WrongGuessEvent : GameEvent
    {
        public override string EventType { get { return "WrongGuess"; } }

        // TODO: Compléter
        public WrongGuessEvent(GameData gameData) {
            //on augmente de 1 le nombre de mauvais guess 
            gameData.NbWrongGuesses++;
            //si le nombre de mauvais guess est plus grand ou égal au nombre de mauvais guess défini pour perdre, on crée un event LoseEvent
            if(gameData.NbWrongGuesses >= GameData.NB_WRONG_TRIES_FOR_LOSING)
            {
                Events = new List<GameEvent>
                {
                    new LoseEvent(gameData)
                };
            }
        }
    }
}
