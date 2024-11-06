using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;

namespace CS_Form
{
     class TestLabel:Label
    {
        public TestLabel(string str, int x, int y, int width, int height)
        {


            //ボタン内に文字を表示させる
            Text = str;

            //ボタンの生成場所の指定
            Location = new Point(x, y);

            //ボタンの大きさを指定
            Size = new Size(width, height);
        }

        






    }
}
