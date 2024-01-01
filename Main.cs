
namespace OSRS_DPS_Calculator {

    public partial class Main : Form
    {

        private int playerAttack = 0;
        private int playerStrength = 0;
        private int playerRanged = 0;
        private int playerMagic = 0;
        private int playerMining = 0;

        public Main()
        {

            InitializeComponent();

            initialiseComboBoxSelectedIndexes();

        }

        private void initialiseComboBoxSelectedIndexes()
        {

            // Stat potions
            attackPotions.SelectedIndex = 2;
            strengthPotions.SelectedIndex = 2;
            rangedPotions.SelectedIndex = 1;
            magicPotions.SelectedIndex = 5;
            miningPotions.SelectedIndex = 0;

            // Stat prayers
            attackPrayers.SelectedIndex = 5;
            strengthPrayers.SelectedIndex = 5;
            rangedPrayers.SelectedIndex = 4;
            magicPrayers.SelectedIndex = 4;

        }

        private void updateAttackTotal()
        {

            // Define boosts
            double[,] potionBoosts = { {0.0, 0.0}, {0.1, 3.0}, {0.15, 5.0}, {0.2, 2.0}, {0.16, 6.0}, {0.16, 11.0} };
            double[] prayerBoosts = { 1.0, 1.05, 1.10, 1.15, 1.15, 1.20 };

            // Apply boosts
            playerAttack = (int) ((Decimal.ToDouble(attackLevel.Value) + Math.Floor(Decimal.ToDouble(attackLevel.Value) * potionBoosts[attackPotions.SelectedIndex, 0]) + potionBoosts[attackPotions.SelectedIndex, 1]) * prayerBoosts[attackPrayers.SelectedIndex]);

            // Set attack total text
            attackTotal.Text = playerAttack.ToString() + " / 99";

        }

        private void updateStrengthTotal()
        {

            // Define boosts
            double[,] potionBoosts = { {0.0, 0.0}, {0.1, 3.0}, {0.15, 5.0}, {0.16, 6.0}, {0.16, 11.0} };
            double[] prayerBoosts = { 1.0, 1.05, 1.10, 1.15, 1.18, 1.23 };

            // Apply boosts
            playerStrength = (int)((Decimal.ToDouble(strengthLevel.Value) + Math.Floor(Decimal.ToDouble(strengthLevel.Value) * potionBoosts[strengthPotions.SelectedIndex, 0]) + potionBoosts[strengthPotions.SelectedIndex, 1]) * prayerBoosts[strengthPrayers.SelectedIndex]);

            // Set strength total text
            strengthTotal.Text = playerStrength.ToString() + " / 99";

        }

        private void updateRangedTotal()
        {

            // Define boosts
            double[,] potionBoosts = { {0.0, 0.0}, {0.1, 4.0}, {0.16, 6.0}, {0.16, 11.0} };
            double[] prayerBoosts = { 1.0, 1.05, 1.10, 1.15, 1.20 };

            // Apply boosts
            playerRanged = (int)((Decimal.ToDouble(rangedLevel.Value) + Math.Floor(Decimal.ToDouble(rangedLevel.Value) * potionBoosts[rangedPotions.SelectedIndex, 0]) + potionBoosts[rangedPotions.SelectedIndex, 1]) * prayerBoosts[rangedPrayers.SelectedIndex]);

            // Set ranged total text
            rangedTotal.Text = playerRanged.ToString() + " / 99";

        }

        private void updateMagicTotal()
        {

            // Define boosts
            double[,] potionBoosts = { {0.0, 0.0}, {0.0, 4.0}, {0.05, 2.0}, {0.08, 3.0}, {0.1, 1.0}, {0.1, 4.0}, {0.16, 6.0}, {0.16, 11.0} };
            double[] prayerBoosts = { 1.0, 1.05, 1.10, 1.15, 1.25 };

            // Apply boosts
            playerMagic = (int)((Decimal.ToDouble(magicLevel.Value) + Math.Floor(Decimal.ToDouble(magicLevel.Value) * potionBoosts[magicPotions.SelectedIndex, 0]) + potionBoosts[magicPotions.SelectedIndex, 1]) * prayerBoosts[magicPrayers.SelectedIndex]);

            // Set magic total text
            magicTotal.Text = playerMagic.ToString() + " / 99";

        }

        private void updateMiningTotal()
        {

            // Set mining total
            playerMining = (int) miningLevel.Value;

            // Apply boost
            if (miningPotions.SelectedIndex == 1)
            {
                playerMining = playerMining + 3;
            }

            // Set mining total text
            miningTotal.Text = playerMining.ToString() + " / 99";

        }

        private void attackLevel_ValueChanged(object sender, EventArgs e)
        {
            if (attackPotions.SelectedIndex != -1 && attackPrayers.SelectedIndex != -1)
            {
                updateAttackTotal();
            }
        }

        private void attackPotions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attackPotions.SelectedIndex != -1 && attackPrayers.SelectedIndex != -1)
            {
                updateAttackTotal();
            }
        }

        private void attackPrayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attackPotions.SelectedIndex != -1 && attackPrayers.SelectedIndex != -1)
            {
                updateAttackTotal();
            }
        }

        private void strengthLevel_ValueChanged(object sender, EventArgs e)
        {
            if (strengthPotions.SelectedIndex != -1 && strengthPrayers.SelectedIndex != -1)
            {
                updateStrengthTotal();
            }
        }

        private void strengthPotions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (strengthPotions.SelectedIndex != -1 && strengthPrayers.SelectedIndex != -1)
            {
                updateStrengthTotal();
            }
        }

        private void strengthPrayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (strengthPotions.SelectedIndex != -1 && strengthPrayers.SelectedIndex != -1)
            {
                updateStrengthTotal();
            }
        }

        private void rangedLevel_ValueChanged(object sender, EventArgs e)
        {
            if (rangedPotions.SelectedIndex != -1 && rangedPrayers.SelectedIndex != -1)
            {
                updateRangedTotal();
            }
        }

        private void rangedPotions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rangedPotions.SelectedIndex != -1 && rangedPrayers.SelectedIndex != -1)
            {
                updateRangedTotal();
            }
        }

        private void rangedPrayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rangedPotions.SelectedIndex != -1 && rangedPrayers.SelectedIndex != -1)
            {
                updateRangedTotal();
            }
        }

        private void magicLevel_ValueChanged(object sender, EventArgs e)
        {
            if (magicPotions.SelectedIndex != -1 && magicPrayers.SelectedIndex != -1)
            {
                updateMagicTotal();
            }
        }

        private void magicPotions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (magicPotions.SelectedIndex != -1 && magicPrayers.SelectedIndex != -1)
            {
                updateMagicTotal();
            }
        }

        private void magicPrayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (magicPotions.SelectedIndex != -1 && magicPrayers.SelectedIndex != -1)
            {
                updateMagicTotal();
            }
        }

        private void miningLevel_ValueChanged(object sender, EventArgs e)
        {
            if (miningPotions.SelectedIndex != -1)
            {
                updateMiningTotal();
            }
        }

        private void miningPotions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (miningPotions.SelectedIndex != -1)
            {
                updateMiningTotal();
            }
        }
    }

}
