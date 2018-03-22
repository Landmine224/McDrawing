using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace McDrawing {
    class McRectangle : IMcShape {

        #region Fields

        private static McDrawing _drawing;
        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private Color _color;
        private bool _hidden;

        #endregion

        #region Constructors

        public McRectangle(int x, int y, int width, int height, string color) :
            this(x, y, width, height, McDrawing.ParseColorString(color)) {
        }

        public McRectangle(int x, int y, int width, int height, Color color) :
            this() {
            this._x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
            Invalidate();
        }

        public McRectangle(Rectangle rectangle, string color) :
            this(rectangle, McDrawing.ParseColorString(color)) {
        }

        public McRectangle(Rectangle rectangle, Color color) :
            this() {
            this.x = rectangle.Left;
            this.y = rectangle.Top;
            this.width = rectangle.Width;
            this.height = rectangle.Height;
            this.color = color;
            Invalidate();
        }

        public McRectangle() {
            _drawing.AddShape(this);
        }

        #endregion

        #region Accessors

        public int x {
            get {
                return _x;
            }
            set {
                _x = value;
                Invalidate();
            }
        }

        public int y {
            get {
                return _y;
            }
            set {
                _y = value;
                Invalidate();
            }
        }

        public int width {
            get {
                return _width;
            }
            set {
                _width = value;
                Invalidate();
            }
        }

        public int height {
            get {
                return _height;
            }
            set {
                _height = value;
                Invalidate();
            }
        }

        public Color color {
            get {
                return _color;
            }
            set {
                _color = value;
                Invalidate();
            }
        }

        public bool hidden {
            get {
                return _hidden;
            }
            set {
                _hidden = value;
                Invalidate();
            }
        }

        #endregion Accessors

        #region Methods

        public void Hide() {
            hidden = true;
        }

        public void Show() {
            hidden = false;
        }

        public void Paint(PaintEventArgs e) {
            if (hidden) {
                return;
            }
            Draw(e);
        }

        public void Draw(PaintEventArgs e) {
            e.Graphics.FillRectangle(GetBrush(), GetRectangle());
        }

        public static void SetDrawing(McDrawing drawing) {
            _drawing = drawing;
        }

        public void Invalidate() {
            _drawing.Invalidate();
        }

        private Rectangle GetRectangle() {
            return new Rectangle(x, y, width, height);
        }

        private Brush GetBrush() {
            return new SolidBrush(color);
        }

        #endregion

    }
}
