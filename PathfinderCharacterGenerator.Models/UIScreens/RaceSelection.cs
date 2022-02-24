namespace PathfinderCharacterGenerator.Models
{
    // screen 1
    public class RaceSelection
    {
        public Guid CharacterId { get; set; }
        public Race SelectedRace { get; set; }

        public Race[] GetAvailableRaces()
        {
            //todo
            return null;
        }
        public Feat[] BonusFeats { get; }
    }

    public class Feat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //todo: prerequisites
    }
}