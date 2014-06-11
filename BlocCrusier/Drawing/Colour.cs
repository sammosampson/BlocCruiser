using Cocos2D;
using Microsoft.Xna.Framework;

namespace BlocCrusier.Drawing
{
    public class Colour
    {
        readonly CCColor4B value;

        public static implicit operator CCColor4B(Colour from)
        {
            return from.value;
        }

        public static implicit operator CCColor3B(Colour from)
        {
            return from.value;
        }

        public static implicit operator Colour(CCColor4B from)
        {
            return new Colour(from);
        }

        Colour(Color colour)
        {
            value = new CCColor3B(colour);
        }

        public static Colour Blue
        {
            get { return new Colour(Color.Blue); }
        }
        
        public static Colour Red
        {
            get { return new Colour(Color.Red); }
        }
    }
}