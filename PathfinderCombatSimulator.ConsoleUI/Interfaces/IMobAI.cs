namespace PathfinderCombatSimulator.ConsoleUI
{
    public interface IMobAI
    {
        Mob? GetTargetFor(Mob item, List<AlliedCombatGroup> acgs);
    }
}