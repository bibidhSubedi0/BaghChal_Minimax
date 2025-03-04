
namespace BaghChal_Minimax
{
    abstract public class Players
    {
        public int position;
        public string iAm;
        public Players() { }
    }

    public class Tiger : Players
    {
        public Tiger() {
            iAm = "T";
        }
        public void TigerCore(Tiger B)
        {
            
        }
    }

    public class Goat : Players
    {
        public Goat() {
            iAm = "G";
        }
    }

    public class Utils:Players
    {
        public void move(Players X,int pos)
        {
            X.position = pos;
        }
    }
}
