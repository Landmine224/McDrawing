using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace McDrawing {
    class McDrawing {

        #region Fields

        private Control _control;
        private List<IMcShape> _shapes;

        #endregion

        #region Constructors

        public McDrawing(Control control) {
            _control = control;
            _shapes = new List<IMcShape>();
            // Attach each type of shape to this McDrawing
            McPoint.SetDrawing(this);
            McRectangle.SetDrawing(this);
            McCircle.SetDrawing(this);
        }

        #endregion

        #region Methods

        public void Paint(PaintEventArgs e) {
            e.Graphics.Clear(Color.White);
            foreach (IMcShape shape in _shapes) {
                shape.Paint(e);
            }
        }

        public void Invalidate() {
            _control.Invalidate();
        }

        public void AddShape(IMcShape shape) {
            _shapes.Add(shape);
        }

        public void RemoveShape(IMcShape shape) {
            _shapes.Remove(shape);
        }

        public static Color ParseColorString(string s) {
            switch (s.ToLower()) {
                case "red":
                    return Color.Red;
                case "orange":
                    return Color.Orange;
                case "yellow":
                    return Color.Yellow;
                case "green":
                    return Color.Green;
                case "blue":
                    return Color.Blue;
                case "indigo":
                    return Color.Indigo;
                case "violet":
                    return Color.Violet;
                case "purple":
                    return Color.Purple;
                case "white":
                    return Color.White;
                case "grey":
                    goto case "gray";
                case "gray":
                    return Color.Gray;
                case "black":
                    return Color.Black;
                case "brown":
                    return Color.Brown;
                default:
                    // ErrorMessageBox
                    MessageBox.Show($"No such color {s}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"No such color {s}");
                    return Color.PeachPuff;
            }
        }

        #endregion

    }
}
