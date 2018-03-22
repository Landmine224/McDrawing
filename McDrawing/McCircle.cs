using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace McDrawing {
    class McCircle : IMcShape {

        #region Fields

        private static McDrawing _drawing;
        private int _x;
        private int _y;
        private int _radius;
        private Color _color;
        private bool _hidden;

        #endregion

        #region Constructors

        public McCircle(int x, int y, int radius, string color) :
            this(x, y, radius, McDrawing.ParseColorString(color)) {
        }

        public McCircle(int x, int y, int radius, Color color) {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.color = color;
            Invalidate();
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

        public int radius {
            get {
                return _radius;
            }
            set {
                _radius = value;
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

        #endregion

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
            e.Graphics.FillEllipse(GetBrush(), GetBoundingRectangle());
        }

        public void Invalidate() {
            _drawing.Invalidate();
        }

        private Rectangle GetBoundingRectangle() {
            int left = x - radius;
            int top = y - radius;
            int width = radius * 2;
            int height = radius * 2;
            return new Rectangle(left, top, width, height);
        }

        private Brush GetBrush() {
            return new SolidBrush(color);
        }

        public static void SetDrawing(McDrawing drawing) {
            _drawing = drawing;
        }

        #endregion

    }
}
