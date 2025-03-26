using BonhommePendu.Models;
using System.Text.Json.Serialization;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre

    public class GuessEvent : GameEvent
    {
        public override string EventType { get { return "Guess"; } }


        // TODO: Compléter
        public GuessEvent(GameData gameData, char letter) {
            // TODO: Commencez par ICI
            bool hasLetter = false;
            Events = new List<GameEvent> { };
            Events.Add(new GuessedLetterEvent(gameData, letter));
            
            for(int i = 0; i < gameData.Word.Length; i++)
            {
                if(gameData.HasSameLetterAtIndex(letter, i))
                {
                    hasLetter = true;
                    Events.Add(new RevealLetterEvent(gameData, letter,i));
                }
            }
            if (!hasLetter)
                Events.Add(new WrongGuessEvent(gameData));
        }
    }
}
