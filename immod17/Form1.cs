using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using immod17;

namespace immod17
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Flow Stream1 = new Flow();
            Flow Stream2 = new Flow();
            Flow Stream1plus2 = new Flow();
            DoubleFlow Stream1and2 = new DoubleFlow();

            Stream1.lambda = (int)lambda1Num.Value;
            Stream2.lambda = (int)lambda2Num.Value;
            Stream1plus2.lambda = (int)lambda1Num.Value + (int)lambda2Num.Value;
            Stream1and2.lambda[0] = (int)lambda1Num.Value;
            Stream1and2.lambda[1] = (int)lambda2Num.Value;
            int N = (int)nNum.Value;
            double T = (double)tNum.Value;

            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();

            for (int i = 0; i < N; i++)
            {
                Stream1.CreateCurrentFlow(T);
                Stream2.CreateCurrentFlow(T);
                Stream1plus2.CreateCurrentFlow(T);
                Stream1and2.CreateCurrentFlow(T);
            }

            flow1Label.Text = "Flow l1:\n";
            flow2Label.Text = "Flow l2:\n";
            andLabel.Text = "Flow l1 and l2:\n";
            sumLabel.Text = "Flow l1+l2:\n";

            for (int i = 0; i < Stream1.currentFlow.Length; i++)
            {
                if (Stream1.currentFlow[i] != 0) 
                {
                    flow1Label.Text += (i + 1) + ": " + ((double)Stream1.currentFlow[i] / N) + "\n";
                }
            }
            for (int i = 0; i < Stream2.currentFlow.Length; i++)
            {
                if (Stream2.currentFlow[i] != 0)
                {
                    flow2Label.Text += (i + 1) + ": " + ((double)Stream2.currentFlow[i] / N) + "\n";
                }
            }
            for (int i = 0; i < Stream1plus2.currentFlow.Length; i++)
            {
                if (Stream1plus2.currentFlow[i] != 0)
                {
                    sumLabel.Text += (i + 1) + ": " + ((double)Stream1plus2.currentFlow[i] / N) + "\n";
                }
                chart1.Series[0].Points.AddXY(i, (double)Stream1plus2.currentFlow[i] / N);
            }
            for (int i = 0; i < Stream1and2.curSumFlow.Length; i++)
            {
                if (Stream1and2.curSumFlow[i] != 0)
                {
                    andLabel.Text += (i + 1) + ": " + ((double)Stream1and2.curSumFlow[i] / N) + "\n";
                }
                chart2.Series[0].Points.AddXY(i, (double)Stream1and2.curSumFlow[i] / N);
            }
        }
    }
}
