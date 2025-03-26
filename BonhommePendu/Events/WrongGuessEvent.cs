using BonhommePendu.Models;
using System.Text.Json.Serialization;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois que la lettre n'est pas dans le mot
    public class WrongGuessEvent : GameEvent
    {
        public override string EventType { get { return "WrongGuess"; } }

        // TODO: Compléter

        public WrongGuessEvent(GameData gameData) {

            Events = new List<GameEvent> { };
            gameData.NbWrongGuesses++;
            if(gameData.NbWrongGuesses >= GameData.NB_WRONG_TRIES_FOR_LOSING)
            {
                Events.Add(new LoseEvent(gameData));
            }
        }
    }
}
