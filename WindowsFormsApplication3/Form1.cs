using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoECrafter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Select and load first Item Type and populate the Mod Selectors
            itemTypeBox.SelectedIndex = 0;
            // Just make sure everything is cleared
            itemMod1.Items.Clear();
            itemMod2.Items.Clear();
            itemMod3.Items.Clear();
            itemMod4.Items.Clear();
            itemMod5.Items.Clear();
            itemMod6.Items.Clear();
            //Load some shit
            LoadComboItems(itemTypeBox.Text);
        }

        public void ItemInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            RunSearch();
        }

        public void FindMods(string[] itemLine, string[] affixSearch, decimal[] affixValue, bool[] AmPrefix)
        {
            for (int i = 0; i < itemLine.Length; i++)
            {
                for (int j = 0; j < affixValue.Length; j++)
                {

                    var string1 = Search.removeMinMaxRoll(affixSearch[j].ToLower());
                    var string2 = Search.toText(itemLine[i].ToLower());

                    if (string1 == string2 && Convert.ToDecimal(Search.toDecimal(itemLine[i])) >= affixValue[j])
                    {
                        Print(String.Format("Search {2}: [ Prefix({3}) , {0} >= {1} ]", Search.toDecimal(itemLine[i]), affixValue[j], j + 1, AmPrefix[j]));
                    }

                    if (string1 == string2 && Convert.ToDecimal(Search.toDecimal(itemLine[i])) <= affixValue[j])
                    {
                        Print(String.Format("Search {2}: [ Prefix({3}) , {0} <= {1} ]", Search.toDecimal(itemLine[i]), affixValue[j], j + 1, AmPrefix[j]));
                    }

                }
            }
        }

        public void RunSearch()
        {
            ItemInfoTextBoxParsed.Clear();

            string[] ItemData = Item.SplitLines(ItemInfoTextBox.Text);
            string[] WantedModsText = { itemMod1.Text, itemMod2.Text, itemMod3.Text, itemMod4.Text, itemMod5.Text, itemMod6.Text };
            decimal[] WantedModsValue = { itemMod1Value.Value, itemMod2Value.Value, itemMod3Value.Value, itemMod4Value.Value, itemMod5Value.Value, itemMod6Value.Value };
            bool[] Prefix = { ((ComboBoxItem)itemMod1.SelectedItem).AffixMod, ((ComboBoxItem)itemMod2.SelectedItem).AffixMod, ((ComboBoxItem)itemMod3.SelectedItem).AffixMod, ((ComboBoxItem)itemMod4.SelectedItem).AffixMod, ((ComboBoxItem)itemMod5.SelectedItem).AffixMod, ((ComboBoxItem)itemMod6.SelectedItem).AffixMod };

            FindMods(ItemData, WantedModsText, WantedModsValue, Prefix);
        }

        public void Print(object text)
        {
            ItemInfoTextBoxParsed.Text += text+"\r\n".ToString();
        }

        private void buttonTestItem_Click(object sender, EventArgs e)
        {
            RunSearch();
        }

        #region AffixList
        public class CrimsonJewel
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ViridianJewel
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class CobaltJewel
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EnergyShieldChest
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourChest
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionChest
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEnergyShieldChest
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEvasionChest
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionAndEnergyShieldChest
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourEvasionAndEnergyShieldChest
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourHelm
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionHelm
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EnergyShieldHelm
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEnergyShieldHelm
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEvasionHelm
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionAndEnergyShieldHelm
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourGlove
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionGlove
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EnergyShieldGlove
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEnergyShieldGlove
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEvasionGlove
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionAndEnergyShieldGlove
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourBoot
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionBoot
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EnergyShieldBoot
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEnergyShieldBoot
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEvasionBoot
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionAndEnergyShieldBoot
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourShield
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionShield
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EnergyShieldShield
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEnergyShieldShield
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ArmourAndEvasionShield
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class EvasionAndEnergyShieldShield
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Dagger
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Claw
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Bow
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Quiver
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Wand
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Stave
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Scepter
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class OneHandSword
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class TwohandSword
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class OneHandAx
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class TwoHandAx
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class OneHandMace
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class TwohandMace
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Ring
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Amulet
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class Belt
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class LifeFlask
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class ManaFlask
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class HybridFlask
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class UtilityFlask
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class DiamondFlask
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class AffixList
        {
            public List<CrimsonJewel> CrimsonJewels { get; set; }
            public List<ViridianJewel> ViridianJewels { get; set; }
            public List<CobaltJewel> CobaltJewel { get; set; }
            public List<EnergyShieldChest> EnergyShieldChest { get; set; }
            public List<ArmourChest> ArmourChest { get; set; }
            public List<EvasionChest> EvasionChest { get; set; }
            public List<ArmourAndEnergyShieldChest> ArmourAndEnergyShieldChest { get; set; }
            public List<ArmourAndEvasionChest> ArmourAndEvasionChest { get; set; }
            public List<EvasionAndEnergyShieldChest> EvasionAndEnergyShieldChest { get; set; }
            public List<ArmourEvasionAndEnergyShieldChest> ArmourEvasionAndEnergyShieldChest { get; set; }
            public List<ArmourHelm> ArmourHelm { get; set; }
            public List<EvasionHelm> EvasionHelm { get; set; }
            public List<EnergyShieldHelm> EnergyShieldHelm { get; set; }
            public List<ArmourAndEnergyShieldHelm> ArmourAndEnergyShieldHelm { get; set; }
            public List<ArmourAndEvasionHelm> ArmourAndEvasionHelm { get; set; }
            public List<EvasionAndEnergyShieldHelm> EvasionAndEnergyShieldHelm { get; set; }
            public List<ArmourGlove> ArmourGloves { get; set; }
            public List<EvasionGlove> EvasionGloves { get; set; }
            public List<EnergyShieldGlove> EnergyShieldGloves { get; set; }
            public List<ArmourAndEnergyShieldGlove> ArmourAndEnergyShieldGloves { get; set; }
            public List<ArmourAndEvasionGlove> ArmourAndEvasionGloves { get; set; }
            public List<EvasionAndEnergyShieldGlove> EvasionAndEnergyShieldGloves { get; set; }
            public List<ArmourBoot> ArmourBoots { get; set; }
            public List<EvasionBoot> EvasionBoots { get; set; }
            public List<EnergyShieldBoot> EnergyShieldBoots { get; set; }
            public List<ArmourAndEnergyShieldBoot> ArmourAndEnergyShieldBoots { get; set; }
            public List<ArmourAndEvasionBoot> ArmourAndEvasionBoots { get; set; }
            public List<EvasionAndEnergyShieldBoot> EvasionAndEnergyShieldBoots { get; set; }
            public List<ArmourShield> ArmourShield { get; set; }
            public List<EvasionShield> EvasionShield { get; set; }
            public List<EnergyShieldShield> EnergyShieldShield { get; set; }
            public List<ArmourAndEnergyShieldShield> ArmourAndEnergyShieldShield { get; set; }
            public List<ArmourAndEvasionShield> ArmourAndEvasionShield { get; set; }
            public List<EvasionAndEnergyShieldShield> EvasionAndEnergyShieldShield { get; set; }
            public List<Dagger> Daggers { get; set; }
            public List<Claw> Claws { get; set; }
            public List<Bow> Bows { get; set; }
            public List<Quiver> Quivers { get; set; }
            public List<Wand> Wands { get; set; }
            public List<Stave> Staves { get; set; }
            public List<Scepter> Scepters { get; set; }
            public List<OneHandSword> OneHandSwords { get; set; }
            public List<TwohandSword> TwohandSwords { get; set; }
            public List<OneHandAx> OneHandAxes { get; set; }
            public List<TwoHandAx> TwoHandAxes { get; set; }
            public List<OneHandMace> OneHandMaces { get; set; }
            public List<TwohandMace> TwohandMaces { get; set; }
            public List<Ring> Rings { get; set; }
            public List<Amulet> Amulets { get; set; }
            public List<Belt> Belts { get; set; }
            public List<LifeFlask> LifeFlask { get; set; }
            public List<ManaFlask> ManaFlask { get; set; }
            public List<HybridFlask> HybridFlask { get; set; }
            public List<UtilityFlask> UtilityFlask { get; set; }
            public List<DiamondFlask> DiamondFlask { get; set; }
        }

        public class RootObject
        {
            public AffixList AffixList { get; set; }
        }
        #endregion

        // Then you load int your comboBox

        private void LoadComboItems(string selected)
        {
            // If changes are made to .JSON file they will be reloaded without the need to reload the program
            var str = File.ReadAllText("AffixList.JSON");
            var x = JsonConvert.DeserializeObject<RootObject>(str).AffixList;

            #region CraftingSelection
            switch (selected)
            {
                case "Cobalt Jewels":
                    foreach (var Affix in x.CobaltJewel)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Crimson Jewels":
                    foreach (var Affix in x.CrimsonJewels)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Viridian Jewels":
                    foreach (var Affix in x.ViridianJewels)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Energy Shield Chest":
                    foreach (var Affix in x.EnergyShieldChest)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour Chest":
                    foreach (var Affix in x.ArmourChest)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion Chest":
                    foreach (var Affix in x.EvasionChest)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Energy Shield Chest":
                    foreach (var Affix in x.ArmourAndEnergyShieldChest)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Evasion Chest":
                    foreach (var Affix in x.ArmourAndEvasionChest)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion And Energy Shield Chest":
                    foreach (var Affix in x.EvasionAndEnergyShieldChest)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour, Evasion And Energy Shield Chest":
                    foreach (var Affix in x.ArmourEvasionAndEnergyShieldChest)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour Helm":
                    foreach (var Affix in x.ArmourHelm)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion Helm":
                    foreach (var Affix in x.EvasionHelm)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Energy Shield Helm":
                    foreach (var Affix in x.EnergyShieldHelm)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Energy Shield Helm":
                    foreach (var Affix in x.ArmourAndEnergyShieldHelm)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Evasion Helm":
                    foreach (var Affix in x.ArmourAndEvasionHelm)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion And Energy Shield Helm":
                    foreach (var Affix in x.EvasionAndEnergyShieldHelm)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour Gloves":
                    foreach (var Affix in x.ArmourGloves)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion Gloves":
                    foreach (var Affix in x.EvasionGloves)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Energy Shield Gloves":
                    foreach (var Affix in x.EnergyShieldGloves)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Energy Shield Gloves":
                    foreach (var Affix in x.ArmourAndEnergyShieldGloves)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Evasion Gloves":
                    foreach (var Affix in x.ArmourAndEvasionGloves)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion And Energy Shield Gloves":
                    foreach (var Affix in x.EvasionAndEnergyShieldGloves)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour Boots":
                    foreach (var Affix in x.ArmourBoots)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion Boots":
                    foreach (var Affix in x.EvasionBoots)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Energy Shield Boots":
                    foreach (var Affix in x.EnergyShieldBoots)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Energy Shield Boots":
                    foreach (var Affix in x.ArmourAndEnergyShieldBoots)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Evasion Boots":
                    foreach (var Affix in x.ArmourAndEvasionBoots)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion And Energy Shield Boots":
                    foreach (var Affix in x.EvasionAndEnergyShieldBoots)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour Shield":
                    foreach (var Affix in x.ArmourShield)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion Shield":
                    foreach (var Affix in x.EvasionShield)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Energy Shield Shield":
                    foreach (var Affix in x.EnergyShieldShield)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Energy Shield Shield":
                    foreach (var Affix in x.ArmourAndEnergyShieldShield)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Armour And Evasion Shield":
                    foreach (var Affix in x.ArmourAndEvasionShield)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Evasion And Energy Shield Shield":
                    foreach (var Affix in x.EvasionAndEnergyShieldShield)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Daggers":
                    foreach (var Affix in x.Daggers)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Claws":
                    foreach (var Affix in x.Claws)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Bows":
                    foreach (var Affix in x.Bows)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Quivers":
                    foreach (var Affix in x.Quivers)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Wands":
                    foreach (var Affix in x.Wands)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Staves":
                    foreach (var Affix in x.Staves)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Scepters":
                    foreach (var Affix in x.Scepters)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "One Hand Swords":
                    foreach (var Affix in x.OneHandSwords)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Two Hand Swords":
                    foreach (var Affix in x.TwohandSwords)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "One Hand Axes":
                    foreach (var Affix in x.OneHandAxes)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Two Hand Axes":
                    foreach (var Affix in x.TwoHandAxes)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "One Hand Maces":
                    foreach (var Affix in x.OneHandMaces)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Two Hand Maces":
                    foreach (var Affix in x.TwohandMaces)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Rings":
                    foreach (var Affix in x.Rings)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Amulets":
                    foreach (var Affix in x.Amulets)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Belts":
                    foreach (var Affix in x.Belts)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Life Flask":
                    foreach (var Affix in x.LifeFlask)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Mana Flask":
                    foreach (var Affix in x.ManaFlask)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Hybrid Flask":
                    foreach (var Affix in x.HybridFlask)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Utility Flask":
                    foreach (var Affix in x.UtilityFlask)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "Diamond Flask":
                    foreach (var Affix in x.DiamondFlask)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                default:
                    PopulateComboBox("BLANK", false);
                    break;
            } 
            #endregion

            // Force affix selection to be the first option to stop the error of trying to view its prefix if it does not have one
            itemMod1.SelectedIndex = 0;
            itemMod2.SelectedIndex = 0;
            itemMod3.SelectedIndex = 0;
            itemMod4.SelectedIndex = 0;
            itemMod5.SelectedIndex = 0;
            itemMod6.SelectedIndex = 0;
        }

        private void PopulateComboBox(string affixName, bool prefix)
        {
            itemMod1.Items.Add(new ComboBoxItem(affixName, prefix));
            itemMod2.Items.Add(new ComboBoxItem(affixName, prefix));
            itemMod3.Items.Add(new ComboBoxItem(affixName, prefix));
            itemMod4.Items.Add(new ComboBoxItem(affixName, prefix));
            itemMod5.Items.Add(new ComboBoxItem(affixName, prefix));
            itemMod6.Items.Add(new ComboBoxItem(affixName, prefix));
        }

        private void itemTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemMod1.Items.Clear();
            itemMod2.Items.Clear();
            itemMod3.Items.Clear();
            itemMod4.Items.Clear();
            itemMod5.Items.Clear();
            itemMod6.Items.Clear();
            LoadComboItems(itemTypeBox.Text);

        }

        private void itemMod1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemMod1.Text == "None")
                AffixType1.Text = "";
            else if (((ComboBoxItem)itemMod1.SelectedItem).AffixMod)
                AffixType1.Text = "Prefix";
            else
                AffixType1.Text = "Suffix";
        }

        private void itemMod2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemMod2.Text == "None")
                AffixType2.Text = "";
            else if (((ComboBoxItem)itemMod2.SelectedItem).AffixMod)
                AffixType2.Text = "Prefix";
            else
                AffixType2.Text = "Suffix";
        }

        private void itemMod3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemMod3.Text == "None")
                AffixType3.Text = "";
            else if (((ComboBoxItem)itemMod3.SelectedItem).AffixMod)
                AffixType3.Text = "Prefix";
            else
                AffixType3.Text = "Suffix";
        }

        private void itemMod4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemMod4.Text == "None")
                AffixType4.Text = "";
            else if (((ComboBoxItem)itemMod4.SelectedItem).AffixMod)
                AffixType4.Text = "Prefix";
            else
                AffixType4.Text = "Suffix";
        }

        private void itemMod5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemMod5.Text == "None")
                AffixType5.Text = "";
            else if (((ComboBoxItem)itemMod5.SelectedItem).AffixMod)
                AffixType5.Text = "Prefix";
            else
                AffixType5.Text = "Suffix";
        }

        private void itemMod6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemMod6.Text == "None")
                AffixType6.Text = "";
            else if (((ComboBoxItem)itemMod6.SelectedItem).AffixMod)
                AffixType6.Text = "Prefix";
            else
                AffixType6.Text = "Suffix";
        }
    }

    public class Item
    {
        public static string[] SplitLines(string item)
        {
            string[] SplitItem = Regex.Split(item, "\r\n|\r|\n");
            return SplitItem;
        }

        public static string PrintItem(string item)
        {
            string[] ItemArray = Item.SplitLines(item);

            return String.Join("\r\n", ItemArray);
        }

        public static bool CheckAffix(string item, string affix)
        {
            var match = Regex.Match(item, affix, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                return true;
            }

            return false;
        }
    }

    public class Search
    {
        public static string removeMinMaxRoll(string text)
        {
            string removeDots = text.Replace("#", "");
            return removeDots;
        }

        public static string toText(string text)
        {
            return Regex.Replace(text, "[0-9]", "").Replace(".", "");
        }

        public static decimal toDecimal(string text)
        {
            return Convert.ToDecimal(Regex.Replace(text, "[^0-9.]", ""));
        }
    }

    public class ComboBoxItem
    {
        string DisaplayText;
        bool Affix;

        //Constructor
        public ComboBoxItem(string a, bool b)
        {
            DisaplayText = a;
            Affix = b;
        }

        //Accessor
        public bool AffixMod
        {
            get
            {
                return Affix;
            }
        }

        //Override ToString method
        public override string ToString()
        {
            return DisaplayText;
        }
    }
}
