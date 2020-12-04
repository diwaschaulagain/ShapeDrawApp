﻿using System;
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
                                l = Int32.Parse(cmd4);
                                g.DrawEllipse(outline, x, y, l, l);
                                g.FillEllipse(fill_color, x, y, l, l);
                                break;
                            case "square":
                                cmd2 = spilt[1];
                                cmd3 = spilt[2];
                                cmd4 = spilt[3];
                                x = Int32.Parse(cmd2);
                                y = Int32.Parse(cmd3);
                                l = Int32.Parse(cmd4);
                                Console.WriteLine(cmd1);
                                g.DrawRectangle(outline, x, y, l, l);
                                g.FillRectangle(fill_color, x, y, l, l);
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
                                g.DrawRectangle(outline, x, y, l, j);
                                g.FillRectangle(fill_color, x, y, l, j);
                                break;                           
                            case "triangle":
                                    cmd2 = spilt[1];
                                    cmd3 = spilt[2];
                                    cmd4 = spilt[3];

                                z = Int32.Parse(cmd2);
                                v = Int32.Parse(cmd3);
                                l = Int32.Parse(cmd4);

                                Point[] triangle = new Point[3];
                                triangle[0] = new Point(z, v);
                                triangle[1] = new Point(v, l);
                                triangle[2] = new Point(l, z);
                                g.DrawPolygon(outline, triangle);
                                g.FillPolygon(fill_color, triangle);
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
