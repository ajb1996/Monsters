namespace Monsters.core
{
    public static class Enums
    {
        public enum StatName
        {
            ATTACK, DEFENCE, SPEED, ACCURACY, SPECIALATTACK, SPECIALDEFENCE
        }
        public enum EffectType
        {
            POISON, SLEEP, PARALYSIS, FREEZE, CONFUSE, NONE
        }
        public enum InputType
        {
            MENU, ATTACK, ITEM, TEAM
        }
        public enum Type
        {
            BUG, DARK, DRAGON, ELECTRIC, FAIRY, FIGHTING, FIRE, FLYING, GHOST, GRASS, GROUND, ICE, NORMAL, POISON, PSYCHIC, ROCK, STEEL, WATER
        }
        public enum Target
        {
            SELF, OTHER
        }
    }
}
