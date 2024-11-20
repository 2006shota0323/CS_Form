using CS_Form.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

        TestTextBox textBox;



        public Form1()
        {
            InitializeComponent();

            string[] q = new string[10] {"a","b","c","d","e","f","g","h","i","j"};


            

            for (int i = 0; i < 10; i++)
            {
                TestButton TestButton = new TestButton(this, q[i],(i%3)*100, (i/3)*100,100,100);
                Controls.Add(TestButton);
            }
            
            _testLabel = new TestLabel("ラベル表示",100, 300, 500, 100);
            Controls.Add(_testLabel);

            textBox = new TestTextBox("テキストボックス",10,400,500,100);

            Controls.Add(textBox);

            // Label label = new Label();
            //label.Location = new Point(30, 400);
            // label.Text = "ラベル";
            //Controls.Add(label);

            




        }

        

        /// <summary>
        /// ラベルの文字更新
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

        public string ButtonLabelReplacement(string str)
        {
         string s= textBox.TextReplacement(str);

            return s;
        }



        
    }
    
}
