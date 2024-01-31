using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingСalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            TextWindow.Text = "Debug: ";
        }

        public float CalcСurrentPrice(float basedOre, float basedPrice, float minusCoinCount, float currentOre)
        {
            float result = 0,
                  currentPrice = basedOre;

            while (currentPrice < currentOre)
            {
                currentPrice = minusCoinCount + currentPrice;
                result++;
                if (currentPrice > currentOre)
                    result--;
            }

            result = basedPrice - result;

            double twentyProcentDouble = basedPrice * 0.2;

            int twentyProcent = (int) Math.Round(twentyProcentDouble);

            if (result < twentyProcent)
                result = twentyProcent;

            return result;
        }

        public float OreCost(float basedOre, float minusCoinCount, float currentOre, int addOre)
        {

            // Сохраняем текущую руду Comp
            // Начало цикла
            // цикл просчета след понижения цены Comp
            // проверка на кол-во руды до снижения x <= до снижения Comp
            // if da -> estimatedOre = currentOre - reductionPriceOre Comp
            // estimatedOre/100 * currentPrice Comp

            //Узнать стоимость остатка до понижения цены Comp

            //Покупаем остаток и увеличиваем руду на этот остаток tempOre += estimatedOre
            //Отнимаем от того что покупаем addOre -= estimatedOre
            ///Конец цикла

            
            float totalPrice = 0,
                  tempOre = currentOre; // Текущее количество руды

            float reductionPriceOre = basedOre, // Количество руды при которой происходит понижение
                  estimatedOre = 0,// Остаток руды до понижения цены (НЕ ТО СКОЛЬКО ПОКУПАЕМ, покупаем /2)
                  buyOre = 0;
            while (addOre > 0)
            {
                byte i = 0; // Bruh чел
                while (i != 1) // Просчет остатка руды до понижения цены
                {
                    reductionPriceOre += minusCoinCount;
                    if (tempOre <= reductionPriceOre)
                    {   
                        estimatedOre = reductionPriceOre - tempOre;
                        buyOre = estimatedOre / 2;
                        if (buyOre < addOre)
                        {
                            i = 1;
                            TextWindow.AppendText($"\nСейчас руды: {tempOre}"
                                + $"\nРуды до повышения цены(x2): {estimatedOre}"
                                + $"\nРуды покупаем: {buyOre}"
                                + "\nЦена: " + (buyOre / 100) * CalcСurrentPrice(basedOre, float.Parse(BasedPriceTextBox.Text), minusCoinCount, tempOre)
                                + "\n");
                        }
                        else
                        {
                            buyOre = addOre;
                            i = 1;
                            TextWindow.AppendText($"\nСейчас руды: {tempOre}"
                                + $"\nРуды покупаем: {buyOre}"
                                + "\nЦена: " + (buyOre / 100) * CalcСurrentPrice(basedOre, float.Parse(BasedPriceTextBox.Text), minusCoinCount, tempOre)
                                + "\n");
                        }
                    }
                }

                totalPrice += (buyOre / 100) * CalcСurrentPrice(basedOre, float.Parse(BasedPriceTextBox.Text), minusCoinCount, tempOre);

                tempOre += estimatedOre;
                addOre -= (int)buyOre;
                TextWindow.AppendText($"Руды осталось купить: {addOre}\n");
            }
            return totalPrice;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWindow.Clear();
            TextWindow.Text = "Debug: ";
            try
            {
                float price = OreCost(float.Parse(BasedOreTextBox.Text), float.Parse(MinusCoinTextBox.Text), float.Parse(CurrentOreTextBox.Text), int.Parse(AddOreTextBox.Text));
                PriceTextBox.Text = $"{price}";
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните поля", "Ошибка");
            }
        }

        public float CalcСurrentLeatherPrice(float maxLeather, float basedPrice, float priceReduction, float currentLeatherCount)
        {
            float result = 0,
                  tempLeather = maxLeather;

            while (tempLeather < currentLeatherCount)
            {
                tempLeather = priceReduction + tempLeather;
                result++;
                if (tempLeather > currentLeatherCount)
                    result--;
            }

            result = basedPrice - result;

            double twentyProcentDouble = basedPrice * 0.2;

            int twentyProcent = (int)Math.Round(twentyProcentDouble);

            if (result < twentyProcent)
                result = twentyProcent;

            return result;
        }

        public float LeatherCost(float maxLeather, float priceReduction, float currentLeatherCount, float leatherAdd)
        {
            float totalPrice = 0,
                  tempLeather = currentLeatherCount; // Текущее количество кожи

            float reductionLeatherCount = maxLeather, // Количество кожи при которой происходит понижение
                  estimatedLeather = 0;// Остаток кожи до понижения цены
            while (leatherAdd > 0)
            {
                byte i = 0; 
                while (i != 1)
                {
                    reductionLeatherCount += priceReduction;
                    if (tempLeather <= reductionLeatherCount)
                    {
                        estimatedLeather = reductionLeatherCount - tempLeather;
                        if (estimatedLeather < leatherAdd)
                        {
                            i = 1;
                            TextWindow.AppendText($"\nСейчас кожи: {tempLeather}"
                                + $"\nКожи до повышения цены: {estimatedLeather}"
                                + $"\nКожи покупаем: {estimatedLeather}"
                                + $"\nЦена за единицу: {CalcСurrentLeatherPrice(maxLeather, float.Parse(LeatherBasedPriceTextBox.Text), priceReduction, tempLeather)}"
                                + "\nЦена: " + (estimatedLeather / 100) * CalcСurrentLeatherPrice(maxLeather, float.Parse(LeatherBasedPriceTextBox.Text), priceReduction, tempLeather)
                                + "\n");
                        }
                        else
                        {
                            estimatedLeather = leatherAdd;
                            i = 1;
                            TextWindow.AppendText($"\nСейчас кожи: {tempLeather}"
                                + $"\nКожи покупаем: {estimatedLeather}"
                                + $"\nЦена за единицу: {CalcСurrentLeatherPrice(maxLeather, float.Parse(LeatherBasedPriceTextBox.Text), priceReduction, tempLeather)}"
                                + "\nЦена: " + (estimatedLeather / 100) * CalcСurrentLeatherPrice(maxLeather, float.Parse(LeatherBasedPriceTextBox.Text), priceReduction, tempLeather)
                                + "\n");
                        }
                    }
                }

                totalPrice += (estimatedLeather / 100) * CalcСurrentLeatherPrice(maxLeather, float.Parse(LeatherBasedPriceTextBox.Text), priceReduction, tempLeather);

                tempLeather += estimatedLeather;
                leatherAdd -= (int)estimatedLeather;
                TextWindow.AppendText($"Кожи осталось купить: {leatherAdd}\n");
            }
            return totalPrice;
        }

        private void LeatherCalcButton_Click(object sender, EventArgs e)
        {
            TextWindow.Clear();
            TextWindow.Text = "Debug: ";

            try
            {
                float price = LeatherCost(float.Parse(LeatherMaxTextBox.Text), float.Parse(LeatherPriceReductionTextBox.Text), float.Parse(LeatherCurrentMountTextBox.Text), int.Parse(LeatherAddTextBox.Text));
                LeatherPriceTextBox.Text = $"{price}";
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните поля","Ошибка");
            }
        }

        void Start() 
        {

        }

        #region KeyPress
        private void BasedOreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void MinusCoinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void BasedPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void CurrentOreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AddOreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LeatherMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LeatherPriceReductionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LeatherBasedPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LeatherCurrentMountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LeatherAddTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
