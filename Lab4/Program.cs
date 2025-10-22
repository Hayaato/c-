using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class P
{
    [STAThread]
    static void Main()
    {
        string s, pr;
        double rk, zn, pz, R;
        int vk;

        // Завдання 1
        pr = Interaction.InputBox("Введіть прізвище студента:", "Завдання 1: Вік", "Петров");
        s = Interaction.InputBox("Введіть рік народження:", "Завдання 1: Вік", "2000");
        rk = Convert.ToDouble(s);
        int prk = DateTime.Now.Year;
        vk = prk - (int)rk;
        string r1 = $"Прізвище: {pr}\nРік народження: {rk}\nВік: {vk} років.";
        MessageBox.Show(r1, "Результат Завдання 1", MessageBoxButtons.OK, MessageBoxIcon.Information);


        // Завдання 2
        s = Interaction.InputBox("Введіть кількість зайнятих осіб:", "Завдання 2: Зайнятість", "150000");
        zn = Convert.ToDouble(s);
        s = Interaction.InputBox("Введіть загальну кількість працездатних осіб:", "Завдання 2: Зайнятість", "200000");
        pz = Convert.ToDouble(s);
        R = (zn / pz) * 100;
        string r2 = $"Зайнятих: {zn}\nПрацездатних: {pz}\nРівень зайнятості: {R:F2}%"; 
        MessageBox.Show(r2, "Результат Завдання 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}