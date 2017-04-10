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

            LoadComboItems();
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
            string[] WantedModsText = { itemMod1.Text, itemMod2.Text };
            decimal[] WantedModsValue = { itemMod1Value.Value, itemMod2Value.Value };
            bool[] Prefix = { ((ComboBoxItem)itemMod1.SelectedItem).AffixMod, ((ComboBoxItem)itemMod2.SelectedItem).AffixMod };

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

        private void LoadComboItems()
        {
            var str = File.ReadAllText("AffixList.JSON");
            var x = JsonConvert.DeserializeObject<RootObject>(str).AffixList;
            foreach (var Affix in x.EnergyShieldChest)
            {
                itemMod1.Items.Add(new ComboBoxItem(Affix.AffixName, Affix.Prefix));
                itemMod2.Items.Add(new ComboBoxItem(Affix.AffixName, Affix.Prefix));
            }

            // Force affix selection to be the first option to stop the error of trying to view its prefix if it does not have one
            itemMod1.SelectedIndex = 0;
            itemMod2.SelectedIndex = 0;
        }

        private void NewLoadComboItems(string selected)
        {
            var str = File.ReadAllText("AffixList.JSON");
            var x = JsonConvert.DeserializeObject<RootObject>(str).AffixList;

            #region CraftingSelection
            switch (selected)
            {
                case "EnergyShieldChest":
                    foreach (var Affix in x.EnergyShieldChest)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                case "CobaltJewel":
                    foreach (var Affix in x.CobaltJewel)
                    {
                        PopulateComboBox(Affix.AffixName, Affix.Prefix);
                    }
                    break;
                default:
                    PopulateComboBox("FAIL", false);
                    break;
            } 
            #endregion

            // Force affix selection to be the first option to stop the error of trying to view its prefix if it does not have one
            itemMod1.SelectedIndex = 0;
            itemMod2.SelectedIndex = 0;
        }

        private void PopulateComboBox(string affixName, bool prefix)
        {
            itemMod1.Items.Add(new ComboBoxItem(affixName, prefix));
            itemMod2.Items.Add(new ComboBoxItem(affixName, prefix));
        }

        private void itemTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemMod1.Items.Clear();
            itemMod2.Items.Clear();
            NewLoadComboItems(itemTypeBox.Text);

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
