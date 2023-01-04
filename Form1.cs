using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using GRSG.Properties;

namespace GRSG
{
    public partial class GRSG : Form
    {
        public GRSG()
        {
            InitializeComponent();
        }

        // ---------- List Population ----------

        #region List Population
        private void GRSG_Load(object sender, EventArgs e) => FillListBoxes();

        private void refreshButton_Click(object sender, EventArgs e) => FillListBoxes();

        private void FillListBoxes()
        {
            levelListbox.Items.Clear();
            restrictionsListbox.Items.Clear();
            killsListbox.Items.Clear();
            collectablesListbox.Items.Clear();
            boundsListbox.Items.Clear();

            levelListbox.Items.AddRange(Resources.Levels.Split('\n').ToArray());
            restrictionsListbox.Items.AddRange(Resources.Restrictions.Split('\n').ToArray());
            killsListbox.Items.AddRange(Resources.Kills.Split('\n').ToArray());
            collectablesListbox.Items.AddRange(Resources.Collectables.Split('\n').ToArray());
            boundsListbox.Items.AddRange(Resources.Bounds.Split('\n').ToArray());
        }
        #endregion

        // ---------- Randomization ----------

        #region Randomization
        private void levelButton_Click(object sender, EventArgs e)
            => levelListbox.SelectedIndex = new Random(Guid.NewGuid().GetHashCode())
            .Next(0, levelListbox.Items.Count);

        private void restrictionsButton_Click(object sender, EventArgs e)
            => restrictionsListbox.SelectedIndex = new Random(Guid.NewGuid().GetHashCode())
            .Next(0, restrictionsListbox.Items.Count);

        private void killsButton_Click(object sender, EventArgs e)
            => killsListbox.SelectedIndex = new Random(Guid.NewGuid().GetHashCode())
            .Next(0, killsListbox.Items.Count);

        private void collectablesButton_Click(object sender, EventArgs e)
            => collectablesListbox.SelectedIndex = new Random(Guid.NewGuid().GetHashCode())
            .Next(0, collectablesListbox.Items.Count);

        private void boundsButton_Click(object sender, EventArgs e)
            => boundsListbox.SelectedIndex = new Random(Guid.NewGuid().GetHashCode())
            .Next(0, boundsListbox.Items.Count);

        private void randomizeAllButton_Click(object sender, EventArgs e)
        {
            levelButton_Click(this, null);
            restrictionsButton_Click(this, null);
            killsButton_Click(this, null);
            collectablesButton_Click(this, null);
            boundsButton_Click(this, null);
        }
        #endregion

        // ---------- Export ----------

        #region Export
        private string exportPath = "./Exports.txt";

        private void exportResultsMSI_Click(object sender, EventArgs e)
        {
            if (!File.Exists(exportPath))
                File.Create(exportPath);

            StringBuilder builder = new StringBuilder();

            builder.Append(levelListbox.Items[levelListbox.SelectedIndex].ToString());
            builder.Append(restrictionsListbox.Items[restrictionsListbox.SelectedIndex].ToString());
            builder.Append(killsListbox.Items[killsListbox.SelectedIndex].ToString());
            builder.Append(collectablesListbox.Items[collectablesListbox.SelectedIndex].ToString());
            builder.Append(boundsListbox.Items[boundsListbox.SelectedIndex].ToString());

            List<string> newLines = File.ReadAllLines(exportPath).ToList();
            newLines.Add(builder.ToString());

            File.WriteAllLines(exportPath, newLines);
        }
        #endregion
    }
}
