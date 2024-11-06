using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            for (int i = 0; i < 10; i++)
            {
                TestButton TestButton = new TestButton(i,(i%3)*100, (i/3)*100,100,100);
                Controls.Add(TestButton);
            }

            TestLabel testLabel = new TestLabel("ラベル",10, 300, 100, 500);
            Controls.Add(testLabel);



            // Label label = new Label();
            //label.Location = new Point(30, 400);
            // label.Text = "ラベル";
            //Controls.Add(label);











        }
    }
    
}
