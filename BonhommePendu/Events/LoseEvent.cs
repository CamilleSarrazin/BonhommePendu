using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer si il ne reste plus d'essais (NbWrongGuesses est trop grand)
    public class LoseEvent : GameEvent
    {
        public override string EventType { get { return "Lose"; } }

        //une variable pour le mot
        public String Word { get; set; }

        // TODO: Compléter
        public LoseEvent(GameData gameData) {
            //on change la propriété Lost de gameData à true
            gameData.Lost = true;
            //on assigne le mot à notre variable Word
            Word = gameData.Word;
        }
    }
}
