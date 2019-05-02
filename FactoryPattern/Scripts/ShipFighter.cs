namespace FactoryPattern.Scripts
{
    public class ShipFighter : ShipEnemy
    {
        byte warpSpeed;

        public byte WarpSpeed { get { return warpSpeed; } set { warpSpeed = value; } }

        public ShipFighter(string name, byte hp, int attackRange, byte warpSpeed)
            : base(name, hp, attackRange)
        {
            Name = name;
            Hp = hp;
            AttackRange = attackRange;
            WarpSpeed = warpSpeed;
        }

        public ShipFighter()
        {

        }
    }
}
