using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using libAnnaC;

namespace Magical_Item_Generator
{
    public partial class Form1 : Form
    {
        const string libDir = ".\\libAnna\\";
        const string AdjFileName = libDir + "english_adjectives.txt";
        const string VerbFileName = libDir + "english_verbs.txt";
        const string PastVerbFileName = libDir + "english_verbs_past.txt";
        const string IngVerbFileName = libDir + "english_verbs_ing.txt";
        const string NounFileName = libDir + "english_nouns.txt";
        const string Common = "Common";
        const string Fine = "Fine";
        const string Magical = "Magical";
        const string Rare = "Rare";
        const string Legendary = "Legendary";
        const string Unique = "Unique";
        const string SetItem = "Set";
        const int CreateCount = 20;

        List<string> ItemClasses = new List<string>();
        string[] WeaponTypes = { "sword", "axe", "wand", "dagger", "mace", "bow", "dirk", "battleaxe", "halberd", "javelin", "spear", "lance", "blade", "spike", "hatchet", "flail" };
        string[] MiscTypes = { "tome", "ring", "amulet", "sash", "robe", "cloak", "jewel", "earrings", "pin", "anklet", "wristband", "bracelet", "pendant", "necklace", "choker" };
        string[] ArmorTypes = { "shield", "armor", "bracers", "boots", "robe", "cloak", "breastplate", "chainmail", "helmet", "corset", "belt" };
        string[] SetTypes = { "Vestments", "Clothes", "Attire", "Apparel", "Rags", "Garb", "Kit", "Outfit", "Trappings", "Instruments", "Gear", "Regalia", "Getup", "Ensemble", "Raiment", "Garments" };
        string[] VerbTypes = { "basic", "past", "ing" };
        string[] Combinations = { "AVN", "VERB", "AN", "VN", "N", "ADJ", "AV", "PROT", "NN", "ANN", "SLAY" };
        string[] KillingWord = { "murdering", "killing", "slaying", "slaughtering", "extermination", "beheading", "butchery", "assasination" };
        string[] DownfallWord = { "bane", "undoing", "ruin", "downfall", "destruction", "bane", "end", "ruination", "disgrace", "nemesis" };
        string[] Containers = { "vial", "bottle", "potion", "flask", "ampoule", "ewer", "jar", "jug", "cup", "mug", "dose", "can", "chalice", "copita", "bowl", "goblet", "phial", "beaker", "carafe", "cruet", "decanter", "flagon", "gourd", "horn", "pewter", "porringer", "pot", "tankard", "tumbler", "urn", "vase", "vessel", "glass", "cask", "keg", "barrel", "canteen", "waterskin", "flagon" };
        string[] Liquids = { "juice", "sap", "fluid", "solution", "broth", "goop", "nectar", "elixir", "resin", "infusion", "essence", "brew", "drink", "concotion", "mixture", "beverage", "extract", "jelly", "soup", "oil", "syrup", "tonic", "tincture", "serum", "dew", "salve", "cream", "paste", "ointment", "balm", "lotion", "gel", "emulsion" };
        string[] Qualities = { Common, Fine, Magical, Rare, Legendary, SetItem, Unique };
        string[] LiquidQualities = { "Diluted", "Mild", "Moderate", "Potent", "Strong", "Rich", "Extreme" };
        string[] Adjectives = [];
        string[] Verbs = [];
        string[] Nouns = [];
        string[] PastVerbs = [];
        string[] IngVerbs = [];
        string[] ItemTypes = [];

        string SetName = "";
        string SetTitle = "";
        int VerbIndex = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            Adjectives = ReadFile(AdjFileName);
            Nouns = ReadFile(NounFileName);
            PastVerbs = ReadFile(PastVerbFileName);
            IngVerbs = ReadFile(IngVerbFileName);
            Verbs = ReadFile(VerbFileName);

            if (PastVerbs.Length == IngVerbs.Length && PastVerbs.Length == Verbs.Length) {; }
            else { MessageBox.Show("\nVerb files mismatched. Make sure all files are present and correct. Ending Program.\n"); Application.Exit(); }

            btnGenerate.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string MakePlural(string noun)
        {
            string lCharacter = noun[noun.Length - 1].ToString();
            string[] Consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string pNoun = string.Empty;

            switch (lCharacter)
            {
                case "s":
                    pNoun = noun;
                    break;
                case "y":
                    if (Consonants.Any(noun.Substring(noun.Length - 2, 1).Contains)) { pNoun = noun.Substring(0, noun.Length - 1) + "ies"; }
                    else { pNoun = noun + "s"; }
                    break;
                case "f":
                    pNoun = noun.Substring(0, noun.Length - 1) + "ves";
                    break;
                case "x":
                case "h":
                    pNoun = noun;
                    break;
                default:
                    pNoun = noun + "s";
                    break;
            }

            if (noun.Substring(noun.Length - 2, 1) == "f")
            {
                pNoun = noun.Substring(0, noun.Length - 2) + "v" + lCharacter + "s";
            }

            return pNoun;
        }
        private string[] SetItemTypes()
        {
            List<string> types = new List<string>();
            ItemClasses = [];

            if (chkWeapons.Checked) { ItemClasses.Add("weapon"); }
            if (chkArmor.Checked) { ItemClasses.Add("armor"); }
            if (chkMisc.Checked) { ItemClasses.Add("misc"); }
            if (chkPotions.Checked) { ItemClasses.Add("potion"); }

            string ItemClass = PickRandom(ItemClasses.ToArray());

            switch (ItemClass)
            {
                case "weapon":
                    types = types.Concat(WeaponTypes).ToList(); break;
                case "misc":
                    types = types.Concat(MiscTypes).ToList(); break;
                case "armor":
                    types = types.Concat(ArmorTypes).ToList(); break;
                case "potion":
                    types = types.Concat(Containers).ToList(); break;
                default:
                    types.Add("ERROR"); break;
            }

            return types.ToArray();
        }
        private string[] ReadFile(string fileName)
        {
            string[] arrayName = [];
            try
            {
                arrayName = File.ReadAllLines(fileName);
                return arrayName;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"\nError: File {fileName} does not exist. Ending Program.\n");
                Environment.Exit(1);
                return arrayName;
            }
        }
        string ChooseVerbType(string basic, string ing, string past, string type)
        {
            string result = string.Empty;
            switch (type)
            {
                case "basic":
                    result = basic;
                    break;
                case "past":
                    result = past;
                    break;
                case "ing":
                    result = ing;
                    break;
            }
            return result;
        }
        string PickRandom(string[] input)
        {
            Random random = new Random();
            string result = string.Empty;
            result = input[random.Next(input.Length)];
            return result;
        }
        string GenerateItems(int row)
        {
            string ItemType = PickRandom(ItemTypes);
            string ItemClass = PickRandom(ItemClasses.ToArray());
            string VerbType = PickRandom(VerbTypes);
            string Adjective = PickRandom(Adjectives);
            string Noun = PickRandom(Nouns);
            string Noun2 = PickRandom(Nouns);
            string Combination = PickRandom(Combinations);
            int RaritySeverity = random.Next(Qualities.Length);
            string ItemQuality = String.Format("[{0,-9}] ", Qualities[RaritySeverity]);
            string SetType = PickRandom(SetTypes);
            string KillWord = PickRandom(KillingWord);
            string Downfall = PickRandom(DownfallWord);
            string Container = PickRandom(Containers);
            string Liquid = PickRandom(Liquids);

            VerbIndex = random.Next(PastVerbs.Length);

            string PastVerb = PastVerbs[VerbIndex];
            string IngVerb = IngVerbs[VerbIndex];
            string Verb = Verbs[VerbIndex];
            string CurrentRow = libAnna.BOLD + libAnna.BLACK + String.Format("{0, 2}: ", row.ToString()) + libAnna.ENDC;
            string ItemOutput = "";

            string FinalVerb = ChooseVerbType(Verb, IngVerb, PastVerb, VerbType);
            string PluralNoun = MakePlural(Noun);
            string PluralNoun2 = MakePlural(Noun2);

            if (Containers.Any(ItemType.Contains)) { ItemQuality = String.Format("[{0,-9}] ", LiquidQualities[RaritySeverity]); }

            switch (Combination)
            {
                case "AVN":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + Adjective.Capitalize() + " " + FinalVerb.Capitalize() + " " + Noun.Capitalize();
                    SetTitle = Adjective.Capitalize() + " " + PluralNoun.Capitalize();
                    break;
                case "VERB":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + IngVerb.Capitalize();
                    SetTitle = PastVerb.Capitalize();
                    break;
                case "AN":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + Adjective.Capitalize() + " " + Noun.Capitalize();
                    SetTitle = Adjective.Capitalize();
                    break;
                case "VN":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + FinalVerb.Capitalize() + " " + Noun.Capitalize();
                    SetTitle = IngVerb.Capitalize();
                    break;
                case "N":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + Noun.Capitalize();
                    SetTitle = PluralNoun.Capitalize();
                    break;
                case "ADJ":
                    ItemOutput = ItemQuality + Adjective.Capitalize() + " " + ItemType.Capitalize();
                    SetTitle = Adjective.Capitalize();
                    break;
                case "AV":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + Adjective.Capitalize() + " " + IngVerb.Capitalize();
                    SetTitle = PastVerb.Capitalize();
                    break;
                case "NN":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + Noun.Capitalize() + " " + Noun2.Capitalize();
                    SetTitle = PluralNoun.Capitalize();
                    break;
                case "ANN":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + Adjective.Capitalize() + " " + Noun.Capitalize() + " " + Noun2.Capitalize();
                    SetTitle = Adjective.Capitalize() + " " + PluralNoun2.Capitalize();
                    break;
                case "PROT":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of Protection from " + PluralNoun.Capitalize();
                    SetTitle = "the " + Noun.Capitalize();
                    break;
                case "SLAY":
                    ItemOutput = ItemQuality + ItemType.Capitalize() + " of " + Noun.Capitalize() + " " + KillWord.Capitalize();
                    SetTitle = Noun.Capitalize() + "'s " + Downfall.Capitalize();
                    break;
            }

            if (Containers.Any(ItemType.Contains))
            {
                ItemOutput = ItemOutput + " " + Liquid.Capitalize();
            }

            if (ItemQuality == String.Format("[{0,-9}] ", SetItem))
            {
                string[] specialCases = { "AN", "ADJ", "AV", "VERB" };
                SetName = $" ({SetType} of {SetTitle})";
                if (specialCases.Any(Combination.Contains))
                {
                    SetName = $" ({SetTitle} {SetType})";
                }
                return $"{ItemOutput} {SetName}";
            }
            else
            {
                SetName = "";
                return ItemOutput;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudNumItems.Value; i++)
            {
                ItemTypes = SetItemTypes();
                listBoxItems.Items.Add(GenerateItems(1));
            }
        }
        private void CheckGeneratedTypes()
        {
            if (!chkArmor.Checked & !chkMisc.Checked & !chkWeapons.Checked & !chkPotions.Checked) { btnGenerate.Enabled = false; }
            else { btnGenerate.Enabled = true; }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();
        }

        private void chkPotions_CheckedChanged(object sender, EventArgs e)
        {
            CheckGeneratedTypes();
        }

        private void chkWeapons_CheckedChanged(object sender, EventArgs e)
        {
            CheckGeneratedTypes();
        }

        private void chkArmor_CheckedChanged(object sender, EventArgs e)
        {
            CheckGeneratedTypes();
        }

        private void chkMisc_CheckedChanged(object sender, EventArgs e)
        {
            CheckGeneratedTypes();
        }

        private void chkMisc_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckGeneratedTypes();
        }

        private void chkArmor_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckGeneratedTypes();
        }

        private void chkWeapons_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckGeneratedTypes();
        }

        private void gBoxSettings_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxItems_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItems.Count > 0)
            {
                string itmCurrent = listBoxItems.Items[listBoxItems.SelectedIndex].ToString();
                System.Windows.Forms.Clipboard.SetText(itmCurrent);
            }
        }

        private void listBoxItems_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Double click to copy line to clipboard.");
        }

        private void btnGenerate_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Click to generate item(s).");
        }

        private void SetStatus(string status) { tooltipLabel.Text = status; }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Click to clear all generated items.");
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Ready.");
        }

        private void chkWeapons_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Set types of items to generate.");
        }

        private void chkArmor_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Set types of items to generate.");
        }

        private void chkMisc_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Set types of items to generate.");
        }

        private void chkPotions_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Set types of items to generate.");
        }

        private void gBoxResults_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Ready.");
        }

        private void gBoxSettings_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Ready.");
        }

        private void btnQuit_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Click to quit application.");
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Change number of items to create per click.");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void btnGenerate_MouseDown(object sender, MouseEventArgs e)
        {
            btnGenerate.BackgroundImage = Properties.Resources.btnGenerate_down;
        }

        private void btnGenerate_MouseUp(object sender, MouseEventArgs e)
        {
            btnGenerate.BackgroundImage = Properties.Resources.btnGenerate_up;
        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            SetStatus("Display About Dialog.");
        }
    }
}
