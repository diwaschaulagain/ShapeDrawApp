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

        string cmd1, cmd2, cmd3, cmd4, cmd5;

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

        public void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btnPColor.BackColor = c.Color;

            }
        }

        int x, y, z, v, l, j;
      
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
                    if (txtProgramArea.Text == "") { 
                        MessageBox.Show("The Command Field Cannot be Empty");
                    }
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
                                l = Int32.Parse(cmd4);
                                Circle cir = new Circle();
                                cir.Draw(g, outline, x, y, l);
                                cir.fill(g, fill_color, x, y, l);
                                //g.DrawEllipse(outline, x, y, l, l);
                                //g.FillEllipse(fill_color, x, y, l, l);
                                break;
                            case "square":
                                cmd2 = spilt[1];
                                cmd3 = spilt[2];
                                cmd4 = spilt[3];
                                x = Int32.Parse(cmd2);
                                y = Int32.Parse(cmd3);
                                l = Int32.Parse(cmd4);
                                Console.WriteLine(cmd1);
                                Square sq = new Square();
                                sq.Draw(g, outline, x, y, l);
                                sq.fill(g, fill_color, x, y, l);
                                //g.DrawRectangle(outline, x, y, l, l);
                                //g.FillRectangle(fill_color, x, y, l, l);
                                break;
                            case "rectangle":
                                cmd2 = spilt[1];
                                cmd3 = spilt[2];
                                cmd4 = spilt[3];
                                cmd5 = spilt[4];
                                x = Int32.Parse(cmd2);
                                y = Int32.Parse(cmd3);
                                l = Int32.Parse(cmd4);
                                j = Int32.Parse(cmd5);
                                Console.WriteLine(cmd1);
                                Rectangle rect = new Rectangle();
                                rect.Draw(g, outline, x, y, l, j);
                                rect.fill(g, fill_color, x, y, l, j);
                                //g.DrawRectangle(outline, x, y, l, j);
                                //g.FillRectangle(fill_color, x, y, l, j);
                                break;                           
              
                          
                            case "triangle":
                                z = Int32.Parse(spilt[1]);
                                v = Int32.Parse(spilt[2]);
                                l = Int32.Parse(spilt[3]);


                                g.DrawLine(outline, x, y, z, y);

                                g.DrawLine(outline, x, y, x, v);
                                g.DrawLine(outline, z, y, x, v);

                                Point p1 = new Point(x, y);
                                Point p2 = new Point(x, v);
                                Point p3 = new Point(z, y);
                                Point[] allpoints = { p1, p2, p3 };

                                g.FillPolygon(fill_color, allpoints);

                                break;
                            default:
                                MessageBox.Show("syntax error: try with a valid command");
                                break;
                        }
                    }
                    
                   


                 
                    break;
                case "clear":
                    g.Clear(Color.White);
                    txtProgramArea.Text = "";
                    break;
                case "moveTo":
                    break;
                case "drawTo":

                default:
                    MessageBox.Show("Please enter either run or clear as commands");
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
