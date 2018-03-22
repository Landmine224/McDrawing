using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDrawing {
    interface IMcShape {

        void Paint(PaintEventArgs e);

        void Draw(PaintEventArgs e);

        void Hide();

        void Show();

    }
}
