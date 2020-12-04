using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeDrawApp
{
    public partial class DrawForm : Form
    {
        Graphics g;
        Pen outline;
        SolidBrush fill_color;
        string comd, prgm;

        string cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9, cmd10, cmd11;

        private void btnFillIndi_Click(object sender, EventArgs e)
        {

        }

        private void Fill_Click(object sender, EventArgs e)
        {
          
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                
                fill_color = new SolidBrush(c.Color);
               btnFillIndi.BackColor = c.Color;

            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btnPColor.BackColor = c.Color;

            }
        }

        int x, y, num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;

        public DrawForm()
        {
            InitializeComponent();
            g = pnlDisplay.CreateGraphics();
            outline = new Pen(btnPColor.BackColor);
            fill_color = new SolidBrush(Color.White);
            
        }

        private void btnPerformAction_Click(object sender, EventArgs e)
        {
            switch (comd)
            {
                case "run":
                    if (txtProgramArea.Text == "") { MessageBox.Show("The Command Field Cannot be Empty"); }
                    else
                    {
                        String[] spilt = prgm.Split(' ');
                        foreach (string words in spilt)
                        {
                            cmd1 = spilt[0];
                        }
                        switch (cmd1)
                        {
                            case "circle":
                                cmd2 = spilt[1];
                                cmd3 = spilt[2];
                                cmd4 = spilt[3];
                                x = Int32.Parse(cmd2);
                                y = Int32.Parse(cmd3);
                                num3 = Int32.Parse(cmd4);
                                g.DrawEllipse(outline, x, y, num3, num3);
                                g.FillEllipse(fill_color, x, y, num3, num3);
                                break;
                            case "square":
                                cmd2 = spilt[1];
                                cmd3 = spilt[2];
                                cmd4 = spilt[3];
                                x = Int32.Parse(cmd2);
                                y = Int32.Parse(cmd3);
                                num3 = Int32.Parse(cmd4);
                                Console.WriteLine(cmd1);
                                g.DrawRectangle(outline, x, y, num3, num3);
                                g.FillRectangle(fill_color, x, y, num3, num3);
                                break;
                            case "rectangle":
                                cmd2 = spilt[1];
                                cmd3 = spilt[2];
                                cmd4 = spilt[3];
                                cmd5 = spilt[4];
                                x = Int32.Parse(cmd2);
                                y = Int32.Parse(cmd3);
                                num3 = Int32.Parse(cmd4);
                                num4 = Int32.Parse(cmd5);
                                Console.WriteLine(cmd1);
                                g.DrawRectangle(outline, x, y, num3, num4);
                                g.FillRectangle(fill_color, x, y, num3, num4);
                                break;
                            case "polygon":
                                cmd2 = spilt[1];
                                cmd3 = spilt[2];
                                cmd4 = spilt[3];
                                cmd5 = spilt[4];
                                cmd6 = spilt[5];
                                cmd7 = spilt[6];
                                cmd8 = spilt[7];
                                cmd9 = spilt[8];
                                cmd10 = spilt[9];
                                cmd11 = spilt[10];
                                num1 = Int32.Parse(cmd2);
                                num2 = Int32.Parse(cmd3);
                                num3 = Int32.Parse(cmd4);
                                num4 = Int32.Parse(cmd5);
                                num5 = Int32.Parse(cmd6);
                                num6 = Int32.Parse(cmd7);
                                num7 = Int32.Parse(cmd8);
                                num8 = Int32.Parse(cmd9);
                                num9 = Int32.Parse(cmd10);
                                num10 = Int32.Parse(cmd11);
                                Point[] points = new Point[5];
                                points[0] = new Point(num1, num2);
                                points[1] = new Point(num3, num4);
                                points[2] = new Point(num5, num6);
                                points[3] = new Point(num7, num8);
                                points[4] = new Point(num9, num10);
                                g.DrawPolygon(outline, points);
                                g.FillPolygon(fill_color, points);
                                break;
                            default:
                                MessageBox.Show("you have entered wrong syntax or syntax is missing");
                                break;
                        }
                    }

                    break;
                case "clear":
                    g.Clear(Color.White);
                    txtProgramArea.Text = "";
                    break;
                default:
                    MessageBox.Show("Entered Command must be RUN or CLEAR");
                    break;
            }
        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            comd = txtCommand.Text.ToLower();
        }

        private void txtProgramArea_TextChanged(object sender, EventArgs e)
        {
            prgm = txtProgramArea.Text.ToLower(); 
        }
    }
}
