using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;


/// Laitetaan Jypelin fysiikkasääntöjä (Jypeli-kirjasto vaatimuksena) hyödyntämällä pallerot pomppimaan. 
/// Keskimmäistä palloa voi liikuttaa vasemmalle ja oikealle vasemmalla ja oikealla nuolinäppäimellä. 
/// Tilassa on painovoima alaspäin. 
/// Kielenä C#

public class PallerotPomppii : PhysicsGame
{
    public override void Begin()
    {
        Camera.ZoomToLevel();
        Level.BackgroundColor = Color.Black;
        Level.CreateBorders();

        PhysicsObject p1 = new PhysicsObject(2 * 100.0, 2 * 100.0, Shape.Circle);
        p1.Y = Level.Bottom + 200.0;
        Add(p1);

        PhysicsObject p2 = new PhysicsObject(2 * 50.0, 2 * 50.0, Shape.Circle);
        p2.Y = p1.Y + 100 + 50;
        Add(p2);

        PhysicsObject p3 = new PhysicsObject(2 * 30.0, 2 * 30.0, Shape.Circle);
        p3.Y = p2.Y + 50 + 30;
        Add(p3);

        p2.Hit(new Vector(100, 1));

        Gravity = new Vector(0, -400);

        Keyboard.Listen(Key.Right, ButtonState.Pressed, LyoPalloa, "Lyö keskipalloa oikealle päin", p2, new Vector(1000, 0));
        Keyboard.Listen(Key.Left, ButtonState.Pressed, LyoPalloa, "Lyö keskipalloa oikealle päin", p2, new Vector(-1000, 0));
    }

    private void LyoPalloa(PhysicsObject pallo, Vector suunta)
    {
        pallo.Hit(suunta);
    }
}



