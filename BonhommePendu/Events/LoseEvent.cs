using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer si il ne reste plus d'essais (NbWrongGuesses est trop grand)
    public class LoseEvent : GameEvent
    {
        public override string EventType { get { return "Lose"; } }
        public string word { get; set; }
        // TODO: Compléter
        public LoseEvent(GameData gameData) {
            gameData.Lost = true;
            word = gameData.Word;
        }
    }
}
