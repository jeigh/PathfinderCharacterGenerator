namespace PathfinderCombatSimulator.ConsoleUI
{
    public interface ICombatAlgorithm
    {
        CombatResults ExecuteCombat(List<AlliedCombatGroup> combatGroups);
    }
}
