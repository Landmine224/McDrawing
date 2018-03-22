using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDrawing {
    class McPoint {

        private static McDrawing _drawing;
        private int _x;
        private int _y;

        public McPoint(int x, int y) {
            this.x = x;
            this.y = y;
            Invalidate();
        }

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

        public static void SetDrawing(McDrawing drawing) {
            _drawing = drawing;
        }

        private void Invalidate() {
            _drawing.Invalidate();
        }

    }
}
