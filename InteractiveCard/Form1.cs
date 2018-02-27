using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

// Interactive Card - Orion Constellation
// Erik Young
// 27 February, 2018
namespace InteractiveCard
{
    public partial class OrionCard : Form
    {
        public OrionCard()
        {
            InitializeComponent();
            RealKnowledge.Visible = false;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sP1 = new SoundPlayer(Properties.Resources.PRescue);
            SoundPlayer sP2 = new SoundPlayer(Properties.Resources.ZRescue);  // The sounds of the card, from the game StarCraft.
            SoundPlayer sP3 = new SoundPlayer(Properties.Resources.TRescue);  // Might be a bit loud.
            sP1.Play();
            Thread.Sleep(1500);
            StartButton.Visible = false;

            Graphics cardG = this.CreateGraphics();
            Brush redBrush = new SolidBrush(Color.OrangeRed);
            Brush blueBrush = new SolidBrush(Color.Blue);               // the graphics of the card.
            Pen whitePen = new Pen(Color.Wheat, 14);
            Brush textBrush = new SolidBrush(Color.Honeydew);
            Pen bluePen = new Pen(Color.Blue, 2);
            Pen redPen = new Pen(Color.OrangeRed, 2);

            cardG.Clear(Color.Black);
            sP3.Play();
            cardG.FillEllipse(blueBrush, 392, 41, 6, 6);
            Thread.Sleep(250);

            cardG.FillEllipse(redBrush, 268, 108, 14, 14);
            Thread.Sleep(250);

 
            cardG.FillEllipse(blueBrush, 457, 130, 8, 8);
            Thread.Sleep(250);

                                     // These blocks are drawing the stars, with a 250 milli delay
            cardG.FillEllipse(blueBrush, 418, 295, 6, 6);
            Thread.Sleep(250);


            cardG.FillEllipse(blueBrush, 393, 319, 7, 7);
            Thread.Sleep(250);

 
            cardG.FillEllipse(blueBrush, 364, 337, 7, 7);
            Thread.Sleep(250);


            cardG.FillEllipse(blueBrush, 326, 530, 8, 8);
            Thread.Sleep(250);


            cardG.FillEllipse(blueBrush, 533, 488, 16, 16);
            Thread.Sleep(500);

            sP2.Play();
            cardG.DrawLine(redPen, 393, 45, 272, 118);
            Thread.Sleep(150);

            cardG.DrawLine(bluePen, 396, 45, 460, 133);
            Thread.Sleep(150);

            cardG.DrawLine(redPen, 270, 113, 458, 135);
            Thread.Sleep(150);                              // These blocks are drawing the faults/lines inbetween our stars

            cardG.DrawLine(bluePen, 462, 135, 422, 297);
            cardG.DrawLine(redPen, 275, 118, 367, 340);
            Thread.Sleep(150);

            cardG.DrawLine(bluePen, 420, 298, 395, 325);
            cardG.DrawLine(bluePen, 367, 341, 395, 325);
            Thread.Sleep(150);

            cardG.DrawLine(bluePen, 367, 341, 331, 534);
            cardG.DrawLine(bluePen, 422, 298, 537, 490);
            Thread.Sleep(1000);

            cardG.Clear(Color.Black);
            Thread.Sleep(1000);                 // pops open the knowledge to be imparted upon you.
            RealKnowledge.Visible = true;

        }
    }
}