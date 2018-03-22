using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDrawing {
    public partial class Form1 : Form {

        private McDrawing _drawing;

        public Form1() {
            InitializeComponent();
            SetupDoubleBuffering();
            _drawing = new McDrawing(this);
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            _drawing.Paint(e);
        }

        private void SetupDoubleBuffering() {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
    }
}
