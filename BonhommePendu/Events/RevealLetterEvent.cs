using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer pour CHAQUE positon d'une lettre que l'on veut révéler (alors il faut faire plusieurs événements si la lettre est là plusieurs fois!)
    public class RevealLetterEvent : GameEvent
    {
        public override string EventType { get { return "RevealLetter"; } }

        //une variable pour stocker la lettre
        public char Letter { get; set; }
        //une variable pour stocker l'index
        public int Index { get; set; }

        public RevealLetterEvent(GameData gameData, char letter, int index)
        {
            // Conseil: Vous pouvez utiliser gameData.RevealLetter mettre à jour gameData
            // Conseil: Vous pouvez utiliser gameData.HasGuessedTheWord pour savoir si c'est une victoire

            //on met dans notre variable l'index qu'on veut regarder
            Index = index;
            //on assigne dans notre variable la lettre à l'index indiqué
            Letter = gameData.RevealLetter(index);
            //si le mot est trouvé, on crée un nouvel event WinEvent
            if (gameData.HasGuessedTheWord)
            {
                Events = new List<GameEvent>
                {
                    new WinEvent(gameData)
                };
            }
        }
    }
}
