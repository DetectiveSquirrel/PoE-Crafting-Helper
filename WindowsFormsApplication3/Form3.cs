using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoECrafter;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CraftMatX.Text = PoECrafter.Properties.Settings.Default.CraftItemX.ToString();
            CraftMatY.Text = PoECrafter.Properties.Settings.Default.CraftItemY.ToString();
            FusingX.Text = PoECrafter.Properties.Settings.Default.FusingX.ToString();
            FusingY.Text = PoECrafter.Properties.Settings.Default.FusingY.ToString();
            ChromaticX.Text = PoECrafter.Properties.Settings.Default.ChromaticX.ToString();
            ChromaticY.Text = PoECrafter.Properties.Settings.Default.ChromaticY.ToString();
            JewelersX.Text = PoECrafter.Properties.Settings.Default.JewellerX.ToString();
            JewelersY.Text = PoECrafter.Properties.Settings.Default.JewellerY.ToString();
            AlterationX.Text = PoECrafter.Properties.Settings.Default.AlterationX.ToString();
            AlterationY.Text = PoECrafter.Properties.Settings.Default.AlterationY.ToString();
            AugmentationX.Text = PoECrafter.Properties.Settings.Default.AugmentationX.ToString();
            AugmentationY.Text = PoECrafter.Properties.Settings.Default.AugmentationY.ToString();
            RegalX.Text = PoECrafter.Properties.Settings.Default.RegalX.ToString();
            RegalY.Text = PoECrafter.Properties.Settings.Default.RegalY.ToString();
            TransmutationX.Text = PoECrafter.Properties.Settings.Default.TransmutationX.ToString();
            TransmutaitonY.Text = PoECrafter.Properties.Settings.Default.TransmutaitonY.ToString();
            ScourX.Text = PoECrafter.Properties.Settings.Default.ScourX.ToString();
            ScourY.Text = PoECrafter.Properties.Settings.Default.ScourY.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void CraftMatX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(CraftMatX.Text);
            PoECrafter.Properties.Settings.Default.CraftItemX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void CraftMatY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(CraftMatY.Text);
            PoECrafter.Properties.Settings.Default.CraftItemY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void ChromaticX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(ChromaticX.Text);
            PoECrafter.Properties.Settings.Default.ChromaticX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void ChromaticY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(ChromaticY.Text);
            PoECrafter.Properties.Settings.Default.ChromaticY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void JewelersX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(JewelersX.Text);
            PoECrafter.Properties.Settings.Default.JewellerX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void JewelersY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(JewelersY.Text);
            PoECrafter.Properties.Settings.Default.JewellerY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void FusingX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(FusingX.Text);
            PoECrafter.Properties.Settings.Default.FusingX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void FusingY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(FusingY.Text);
            PoECrafter.Properties.Settings.Default.FusingY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void AlterationX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(AlterationX.Text);
            PoECrafter.Properties.Settings.Default.AlterationX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void AlterationY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(AlterationY.Text);
            PoECrafter.Properties.Settings.Default.AlterationY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void AugmentationX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(AugmentationX.Text);
            PoECrafter.Properties.Settings.Default.AugmentationX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void AugmentationY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(AugmentationY.Text);
            PoECrafter.Properties.Settings.Default.AugmentationY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void RegalX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(RegalX.Text);
            PoECrafter.Properties.Settings.Default.RegalX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void RegalY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(RegalY.Text);
            PoECrafter.Properties.Settings.Default.RegalY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void TransmutationX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(TransmutationX.Text);
            PoECrafter.Properties.Settings.Default.TransmutationX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void TransmutaitonY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(TransmutaitonY.Text);
            PoECrafter.Properties.Settings.Default.TransmutaitonY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void ScourX_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(ScourX.Text);
            PoECrafter.Properties.Settings.Default.ScourX = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }

        private void ScourY_TextChanged(object sender, EventArgs e)
        {
            int Location = int.Parse(ScourY.Text);
            PoECrafter.Properties.Settings.Default.ScourY = Location;
            PoECrafter.Properties.Settings.Default.Save();
            Form1.UpdateLocations();
        }
    }
}
