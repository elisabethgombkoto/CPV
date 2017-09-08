using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KNZ.CPV.Shapes
{
    public interface IShape
    {
        void DrawOnMyCanvas(Canvas myCanvas);
    }
}
