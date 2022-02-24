namespace PathfinderCharacterGenerator.Models
{

    public class Race
    {
        public SkillModifier[] SkillModifiers { get; set; }

        //todo
    }

    public class ClassSelection
    {
        public Guid CharacterId { get; set; }
        public CharacterClass SelectedClass { get; set; }

    }

    public class CharacterClass
    {
        public Guid CharacterClassId { get; set; }
        public string CharacterClassName { get; set; }
        public string CharacterClassDescription { get; set; }
       //todo
    }

    public class AbilitiesAndSkills
    {
        public Guid CharacterId { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDexterity { get; set; }
        public int BaseConstitution { get; set; }
        public int BaseIntelligence { get; set; }
        public int BaseWisdom { get; set; }
        public int BaseCharisma { get; set; }
        public SkillModifier[] SkillModifiers { get; set; }
        public int CalculatedStrength {get;}
        public int CalculatedDexterity { get; }
        public int CalculatedConstitution { get; }
        public int CalculatedIntelligence { get; }
        public int CalculatedWisdom { get; }
        public int CalculatedCharisma { get; }

    }

    public class SkillModifier
    {
        public Skill ModifiedSkill { get; set; }
        public int Modifier { get; set; }
    }

    public enum Skill
    {
        //todo
    }

    

    public class Spell
    {
        public string SpellName { get;set;}
        public string SpellDescription { get;set;}

    }
}