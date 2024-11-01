using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
namespace CS_Form
{
     class TestButton:Button
    {



        public TestButton(int id,int x, int y, int width, int height)
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します
            Click += OnClick;

            //ボタン内に文字を表示させる
            Text = id.ToString();

            //ボタンの生成場所の指定
            Location = new Point(x,y);

            //ボタンの大きさを指定
            Size = new Size(width,height);
        }

        public void OnClick(object sender,EventArgs s)
        {
            MessageBox.Show (Text);
        }

    }
}