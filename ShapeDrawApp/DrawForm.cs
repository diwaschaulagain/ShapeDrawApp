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
    /// <summary>
    /// This is the class in which the entire drawing takes place.
    /// </summary>
    public partial class DrawForm : Form
    {
        /// <summary>
        /// Variables are declared as below to start the drawing.
        /// </summary>
        Graphics g;
        Pen outline;
        SolidBrush fill_color;
        string comd, prgm;

        string cmd1, cmd2, cmd3, cmd4, cmd5;

        private void btnFillIndi_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method is used to select the fill color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fill_Click(object sender, EventArgs e)
        {

            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {

                fill_color = new SolidBrush(c.Color);
                btnFillIndi.BackColor = c.Color;

            }


        }
        /// <summary>
        /// This method selects the pen color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btnPColor.BackColor = c.Color;

            }
        }
        /// <summary>
        /// The variables that are to be used are declared
        /// </summary>
        int x, y, z, v, l, j;
        /// <summary>
        /// This method is the constructor where the component is initialized and the variables of pen and fill color along with graphics creation are declared.
        /// </summary>
        public DrawForm()
        {
            InitializeComponent();
            g = pnlDisplay.CreateGraphics();
            outline = new Pen(btnPColor.BackColor);
            fill_color = new SolidBrush(Color.White);

        }
        /// <summary>
        /// This is the function that is called after the action button is clicked. Whatever is typed in the action area is carried out. There are three cases run, clear and an exception case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPerformAction_Click(object sender, EventArgs e)
        { 
            switch (comd)
            {
                case "run":
                    if (txtProgramArea.Text == "")
                    {
                        MessageBox.Show("The Command Field Cannot be Empty");
                    }
                    else
                    {
                        String[] spilt1 = prgm.Split(' ');
                        foreach (string words in spilt1)
                        {
                            cmd1 = spilt1[0];
                        }
                        switch (cmd1)
                        {
                            case "circle":
                                cmd2 = spilt1[1];
                                cmd3 = spilt1[2];
                                cmd4 = spilt1[3];
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
                                cmd2 = spilt1[1];
                                cmd3 = spilt1[2];
                                cmd4 = spilt1[3];
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
                                cmd2 = spilt1[1];
                                cmd3 = spilt1[2];
                                cmd4 = spilt1[3];
                                cmd5 = spilt1[4];
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
                                z = Int32.Parse(spilt1[1]);
                                v = Int32.Parse(spilt1[2]);
                                l = Int32.Parse(spilt1[3]);


                                g.DrawLine(outline, x, y, z, y);

                                g.DrawLine(outline, x, y, x, v);
                                g.DrawLine(outline, z, y, x, v);

                                Point p1 = new Point(x, y);
                                Point p2 = new Point(x, v);
                                Point p3 = new Point(z, y);
                                Point[] allpoints = { p1, p2, p3 };
                                Triangle tr = new Triangle();
                                tr.fill(g, fill_color, allpoints);
                                //g.FillPolygon(fill_color, allpoints);

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
        /// <summary>
        /// This method changes the text to lowercase in the command area.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            comd = txtCommand.Text.ToLower();
        }
        /// <summary>
        /// This method changes the text to lowercase in the program area.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProgramArea_TextChanged(object sender, EventArgs e)
        {
            prgm = txtProgramArea.Text.ToLower();
        }
    }
}
