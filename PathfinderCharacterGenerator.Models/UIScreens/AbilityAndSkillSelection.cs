namespace PathfinderCharacterGenerator.Models;

public class AbilityAndSkillSelection
{
    public Guid CharacterId { get; set; }
    public int BaseStrength { get; set; }
    public int BaseDexterity { get; set; }
    public int BaseConstitution { get; set; }
    public int BaseIntelligence { get; set; }
    public int BaseWisdom { get; set; }
    public int BaseCharisma { get; set; }
    public SkillModifier[] SkillModifiers { get; set; }

    public int CalculateStrength()
    {
        return this.BaseStrength;
    }
        
    public int CalculateDexterity()
    {
        return this.BaseDexterity;

    }

    public int CalculateConstitution()
    {
        return this.BaseConstitution;
    }

    public int CalculateIntelligence()
    {
        return this.BaseIntelligence;
    }

    public int CalculateWisdom()
    {
        return this.BaseWisdom;
    }

    public int CalculateCharisma()
    {
        return this.BaseCharisma;
    }

}