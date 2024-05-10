using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace Arkanoid_IT2
{
    public class Ball : GameObject
    {

        public override void Draw(Canvas canvas)
        {
            Ellipse Ellipse = new Ellipse();
            Ellipse.Width = 15;
            Ellipse.Height = 15;
            Ellipse.Fill = Brushes.Red;
            canvas.Children.Add(Ellipse);
        }
    }
}
