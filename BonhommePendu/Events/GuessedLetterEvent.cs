using BonhommePendu.Models;
using System.Text.Json.Serialization;

namespace BonhommePendu.Events
{
    // Un événement à créer peu importe si la lettre est dans le mot ou pas!
    public class GuessedLetterEvent : GameEvent
    {
        public override string EventType { get { return "GuessedLetter"; } }
        public char letter { get; set; }
        // TODO: Compléter
        public GuessedLetterEvent(GameData gameData, char letter)
        {
            this.letter = letter;
            gameData.GuessedLetters.Add(letter);
            
            
            
            
        }
    }
}
