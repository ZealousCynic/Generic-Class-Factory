namespace FactoryPattern.Scripts
{
    class ShipShipper : ShipEnemy
    {
        int shipsShipped;

        public int ShipsShipped { get { return shipsShipped; } set { shipsShipped = value; } }

        public ShipShipper(string name, byte hp, int attackRange, int shipsShipped)
            : base(name, hp, attackRange)
        {
            Name = name;
            Hp = hp;
            AttackRange = attackRange;
            ShipsShipped = shipsShipped;
        }

        public ShipShipper()
        {

        }

    }
}
