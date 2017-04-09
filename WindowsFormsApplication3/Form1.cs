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

        public void Print(string text)
        {
            ItemInfoTextBoxParsed.Text += text+"\r\n";
        }

        private void buttonTestItem_Click(object sender, EventArgs e)
        {
            RunSearch();
        }

        public class Affix
        {
            public string AffixName { get; set; }
            public bool Prefix { get; set; }
        }

        public class RootObject
        {
            public List<Affix> ESChest { get; set; }
            public List<Affix> CobaltJewel { get; set; }
        }


        // Then you load int your comboBox

        private void LoadComboItems()
        {
            var str = File.ReadAllText("AffixList.JSON");
            var x = JsonConvert.DeserializeObject<RootObject>(str);
            foreach (var Affix in x.CobaltJewel)
            {
                itemMod1.Items.Add(new ComboBoxItem(Affix.AffixName, Affix.Prefix));
                itemMod2.Items.Add(new ComboBoxItem(Affix.AffixName, Affix.Prefix));
            }

            // Force affix selection to be blank
            itemMod1.SelectedIndex = 0;
            itemMod2.SelectedIndex = 0;
        }

        private void itemTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
