using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazıYazmaCocuk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Paint += Form2_Paint;       // çizim yapmak için eklenmelidir
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 1);         // kalem tanımlandı
            Pen blackPen = new Pen(Color.Black, 1);

            // point belirleyebilirsiniz
            PointF point1 = new PointF(0, 0);
            PointF point2 = new PointF(100, 100);

            e.Graphics.DrawLine(redPen, point1, point2);

            // float olarak tek tek noktaları belirleyebilirsiniz
            float L1x1 = 40, L1y1 = 40;
            float L1x2 = 0, L1y2 = 100;

            e.Graphics.DrawLine(blackPen, L1x1, L1y1, L1x2, L1y2);

            // point array yaparak

            redPen.Dispose();
            blackPen.Dispose();
        }
    }
}
