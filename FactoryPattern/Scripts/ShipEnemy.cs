namespace FactoryPattern.Scripts
{
    public abstract class ShipEnemy
    {
        string name;
        byte hp;
        int attackRange;

        public string Name { get { return name; } set { name = value; } }
        public byte Hp { get { return hp; } set { hp = value; } }
        public int AttackRange { get { return attackRange; } set { attackRange = value; } }

        protected ShipEnemy(string name, byte hp, int attackRange)
        {
            Name = name;
            Hp = hp;
            AttackRange = attackRange;
        }

        protected ShipEnemy()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
