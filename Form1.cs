using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMT
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
            label6.Visible = false;
            label7.Visible = false;
            buttonBack.Visible = false;
        }
        private void ves_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rost_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void resault_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenButton.Checked || WomenButton.Checked)
                {
                    String age = AgeBox.Text;
                    if (age == "")
                    {
                        MessageBox.Show("Введите возраст", "Ошибка!");
                    }
                    int age2 = Convert.ToInt32(age);
                    if (age2 < 18)
                    {
                        MessageBox.Show("Введите возраст 18 или более");
                        IMTBox.Text = "";
                    }
                    String ves1 = ves.Text;
                    if (ves1 == "")
                    {
                        MessageBox.Show("Введите вес");
                    }
                    String rost1 = rost.Text;
                    if (rost1 == "")
                    {
                        MessageBox.Show("Введите рост");
                    }
                    String result = "0";
                    double ves2 = Convert.ToDouble(ves1);
                    double rost2 = Convert.ToDouble(rost1);
                    double resualt = Convert.ToDouble(result);
                    resualt = ves2 / (rost2 * rost2) * 10000;
                    double res2 = Math.Round(resualt, 3);
                    string res3 = Convert.ToString(res2);
                    if (IMTBox.Text == "" && age2 >= 18)
                    {
                        IMTBox.Text = res3;
                    }
                    if (MenButton.Checked)
                    {
                        if (age2 >= 18 && age2 <= 30)
                        {
                            if (resualt <= 18)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Анорексия") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Анорексический синдром — серьезное психическое расстройство, которое представляет реальную угрозу для жизни пациента. Человек не в состоянии адекватно оценивать свое тело, намеренно отказывается от приема еды, а также маниакально одержим похудением.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам следует обратиться к врачу и сделать это нужно как можно быстрее.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt >= 18 && resualt <= 21)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Недостаточный вес") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Причины возникновения недостаточного веса весьма разнообразны. К наиболее распространенным из них принято относить:заболевания желудочно-кишечного тракта, препятствующие нормальному расщеплению пищи и потреблению достаточного количества полезных веществ, образ жизни: недостаточное или несбалансированное питание с малым количеством жиров и углеводов, стрессы, недостаток сна, курение, чрезмерная физическая активность. ";
                                    label6.Visible = true;
                                    label7.Text = "    Вам следует обратиться к врачу и сдать анализы. Профилактика указанного заболевания предполагает: достаточное, регулярное, сбалансированное питание; умеренные физические нагрузки; сокращение стрессовых ситуаций, отказ от вредных привычек.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt >= 21 && resualt < 25)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Нормальный вес") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Нормальный вес это вес, при котором человек имеет максимальные шансы, как можно дольше оставаться здоровым, и, как следствие, красивым. Нормальный вес не является гарантией богатырского здоровья, но значительно снижает риск появления нарушений и заболеваний, вызываемых избыточным или недостаточным весом.";
                                    label6.Visible = true;
                                    label7.Text = "    Так держать ! :)";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt >= 25 && resualt <= 29)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Избыток массы тела") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Прибавка веса ведет к развитию метаболического синдрома. Избыточная жировая ткань интенсивно производит лептин, гормон голода, а заодно преобразует мужские половые гормоны, андростендион и тестостерон, в женские, эстрадиол и эстрон. На фоне андрогенодефицита развиваются проблемы с достижением и поддержанием эрекции, импотенция, психоэмоциональные расстройства, бессонница.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам стоит обратиться к врачу! Врач проведет дополнительную диагностику, лабораторные анализы, при необходимости назначит комплексное лечение, заместительную терапию, поможет составить план похудения.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt >= 29 && resualt <= 32)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Ожирение 1 степени") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    В основе ожирения первой степени лежит, как правило, снижение физической активности при сохранении прежнего рациона питания. Питательные вещества поступают, как и ранее, а их расходование сократилось. В таком случае излишки начинают откладываться в организме в виде жира. Чаще всего ожирение 1 степени рассматривается как косметическая проблема.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам стоит ограничить энергетически насыщенную пищу: жиры, сладости, выпечку, фастфуд, алкоголь. Средние цифры суточной калорийности при 1 степени ожирения — до 1800 ккал — для мужчин. Принимать пищу нужно часто, дробно, маленькими порциями (с кулак) каждые 3 часа. Нельзя есть позднее, чем за 3 часа до сна.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 32 && resualt <= 37)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Ожирение 2 степени") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    У вас это серьезная патология, которая несет серьезные эстетические изменения тела, влияющие также на психическое состояние пациента. Одышка, быстрое утомление при средней или небольшой физической нагрузке, тахикардия — учащенное сердцебиение, повышение артериального давления, начальные степени гипертонической болезни,хроническая усталость, недосып, боли в ногах, отеки, эндокринные нарушения.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам следует пройти обследования у эндокринолога, невролога, диетолога, кардиолога. Сдать анализы: клинический анализ крови и мочи, биохимия крови с показателями печеночных ферментов, липидный профиль, на анемию, уровень витаминов, глюкозу крови натощак и после еды, анализы гормонов щитовидной железы (ТТГ, Т4, Т3).";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 37 && resualt <= 42)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Ожирение 3 степени") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Отдельные части тела человека становится очень крупными, рыхлыми. Заметно увеличивается окружность плеч, бедер, голеней. Ожирение 3 степени часто характеризуется сонливостью, слабостью, одышкой при незначительных нагрузках, нарушениями засыпания и сна, апноэ во сне, утренними и вечерними отеками.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам срочно нужно обратиться к специалистам в больицу! Разрабатывать план лечения ожирения третьей степени должны сразу несколько специалистов: эндокринолог, хирург, терапевт, кардиолог, диетолог, психиатр. Вам подберут безопасные физические упражнения, с помощью которых пациент будет расходовать как можно больше энергии, не перегружая суставы, сердце, легкие.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt >= 42 && resualt <= 1000)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Ожирение 4 степени") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "   Основным вариантом развития у человека ожирения считаются расстройства функций главных центральных механизмов, таких, как кора головного мозга, а также гипоталамус – именно здесь находятся центры, регулирующие аппетит. Расстройства могут быть не только врождёнными, но также и приобретёнными.";
                                    label6.Visible = true;
                                    label7.Text = "   При ожирении 4-й ст. лечение начинается с тщательного обследования всего организма с целью определения всех сопутствующих патологий. Проводить его нужно под контролем врачей – это кардиолог с диетологом и психологом и др. специалистов. Зачастую ожирение на такой стадии лечится хирургическим путём. Но перед самой операцией нужно пройти длительный период подготовки, состоящий из: исправления пищевого поведения больного, соблюдения питательного режима и условий диеты, повышения физ.нагрузок, лечения ожирения вместе с сопутствующими патологиями при помощи медикаментов.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                        }
                        if (age2 > 30 && age2 < 2000)
                        {
                            if (resualt <= 18)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Анорексия") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Анорексический синдром — серьезное психическое расстройство, которое представляет реальную угрозу для жизни пациента. Человек не в состоянии адекватно оценивать свое тело, намеренно отказывается от приема еды, а также маниакально одержим похудением.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам следует обратиться к врачу и сделать это нужно как можно быстрее.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt >= 18 && resualt <= 19)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Анорексия") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Анорексический синдром — серьезное психическое расстройство, которое представляет реальную угрозу для жизни пациента. Человек не в состоянии адекватно оценивать свое тело, намеренно отказывается от приема еды, а также маниакально одержим похудением.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам следует обратиться к врачу и сделать это нужно как можно быстрее.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 19 && resualt <= 22)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Недостаточный вес") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Причины возникновения недостаточного веса весьма разнообразны. К наиболее распространенным из них принято относить:заболевания желудочно-кишечного тракта, препятствующие нормальному расщеплению пищи и потреблению достаточного количества полезных веществ, образ жизни: недостаточное или несбалансированное питание с малым количеством жиров и углеводов, стрессы, недостаток сна, курение, чрезмерная физическая активность. ";
                                    label6.Visible = true;
                                    label7.Text = "    Вам следует обратиться к врачу и сдать анализы. Профилактика указанного заболевания предполагает: достаточное, регулярное, сбалансированное питание; умеренные физические нагрузки; сокращение стрессовых ситуаций, отказ от вредных привычек.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 22 && resualt <= 26)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Нормальный вес") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Нормальный вес это вес, при котором человек имеет максимальные шансы, как можно дольше оставаться здоровым, и, как следствие, красивым. Нормальный вес не является гарантией богатырского здоровья, но значительно снижает риск появления нарушений и заболеваний, вызываемых избыточным или недостаточным весом.";
                                    label6.Visible = true;
                                    label7.Text = "    Так держать ! :)";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 26 && resualt <= 30)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Избыток массы тела") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Прибавка веса ведет к развитию метаболического синдрома. Избыточная жировая ткань интенсивно производит лептин, гормон голода, а заодно преобразует мужские половые гормоны, андростендион и тестостерон, в женские, эстрадиол и эстрон. На фоне андрогенодефицита развиваются проблемы с достижением и поддержанием эрекции, импотенция, психоэмоциональные расстройства, бессонница.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам стоит обратиться к врачу! Врач проведет дополнительную диагностику, лабораторные анализы, при необходимости назначит комплексное лечение, заместительную терапию, поможет составить план похудения.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 30 && resualt <= 34)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Ожирение 1 степени") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    В основе ожирения первой степени лежит, как правило, снижение физической активности при сохранении прежнего рациона питания. Питательные вещества поступают, как и ранее, а их расходование сократилось. В таком случае излишки начинают откладываться в организме в виде жира. Чаще всего ожирение 1 степени рассматривается как косметическая проблема.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам стоит ограничить энергетически насыщенную пищу: жиры, сладости, выпечку, фастфуд, алкоголь. Средние цифры суточной калорийности при 1 степени ожирения — до 1800 ккал — для мужчин. Принимать пищу нужно часто, дробно, маленькими порциями (с кулак) каждые 3 часа. Нельзя есть позднее, чем за 3 часа до сна.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 34 && resualt <= 38)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Ожирение 2 степени") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    У вас это серьезная патология, которая несет серьезные эстетические изменения тела, влияющие также на психическое состояние пациента. Одышка, быстрое утомление при средней или небольшой физической нагрузке, тахикардия — учащенное сердцебиение, повышение артериального давления, начальные степени гипертонической болезни,хроническая усталость, недосып, боли в ногах, отеки, эндокринные нарушения.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам следует пройти обследования у эндокринолога, невролога, диетолога, кардиолога. Сдать анализы: клинический анализ крови и мочи, биохимия крови с показателями печеночных ферментов, липидный профиль, на анемию, уровень витаминов, глюкозу крови натощак и после еды, анализы гормонов щитовидной железы (ТТГ, Т4, Т3).";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 38 && resualt <= 43)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Ожирение 3 степени") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Отдельные части тела человека становится очень крупными, рыхлыми. Заметно увеличивается окружность плеч, бедер, голеней. Ожирение 3 степени часто характеризуется сонливостью, слабостью, одышкой при незначительных нагрузках, нарушениями засыпания и сна, апноэ во сне, утренними и вечерними отеками.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам срочно нужно обратиться к специалистам в больицу! Разрабатывать план лечения ожирения третьей степени должны сразу несколько специалистов: эндокринолог, хирург, терапевт, кардиолог, диетолог, психиатр. Вам подберут безопасные физические упражнения, с помощью которых пациент будет расходовать как можно больше энергии, не перегружая суставы, сердце, легкие.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 43)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Ожирение 4 степени") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "   Основным вариантом развития у человека ожирения считаются расстройства функций главных центральных механизмов, таких, как кора головного мозга, а также гипоталамус – именно здесь находятся центры, регулирующие аппетит. Расстройства могут быть не только врождёнными, но также и приобретёнными.";
                                    label6.Visible = true;
                                    label7.Text = "   При ожирении 4-й ст. лечение начинается с тщательного обследования всего организма с целью определения всех сопутствующих патологий. Проводить его нужно под контролем врачей – это кардиолог с диетологом и психологом и др. специалистов. Зачастую ожирение на такой стадии лечится хирургическим путём. Но перед самой операцией нужно пройти длительный период подготовки, состоящий из: исправления пищевого поведения больного, соблюдения питательного режима и условий диеты, повышения физ.нагрузок, лечения ожирения вместе с сопутствующими патологиями при помощи медикаментов.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                        }
                    }
                    if (WomenButton.Checked)
                    {
                        if (age2 >= 18 && age2 <= 30)
                        {
                            if (resualt < 16)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Анорексия") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "   Девушки больше подвержены такому заболеванию, чем мужчины. Вот как проявляется данное заболевание у представительниц прекрасного пола: землистый цвет лица, тонкая и сухая кожа; ломкость и болезненный вид волос и ногтей; ярко выраженная худоба всего тела; частые головные боли; боли в эпигастральной области; общая слабость и недомогание; бессонница и нарушения сна; дисменорея и аменорея, приводящие к бесплодию; дистрофия внутренних органов; кома и смерть.";
                                    label6.Visible = true;
                                    label7.Text = "   Вам срочно нужно обратиться за помощью к врачам! Борьба с анорексией требует привлечения, помимо психиатра, ряда специалистов других направления медицины. В процессе лечения применяются различные методы: психиатрические; медикаментозные; физиотерапевтические.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt >= 16 && resualt <= 19)
                            {
                                if (MessageBox.Show($"  Ваш ИМТ = {res3} \n  У вас: Недостаточный вес") == DialogResult.OK)
                                {
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    label3.Visible = false;
                                    label4.Visible = false;
                                    label5.Visible = false;
                                    resault.Visible = false;
                                    AgeBox.Visible = false;
                                    ves.Visible = false;
                                    rost.Visible = false;
                                    IMTBox.Visible = false;
                                    label6.Text = "    Недостаток веса может приводить к большому числу неблагоприятных последствий: дистрофия и опущение внутренних органов; гиповитаминозы; склонность к упорным тяжелым инфекциям, сложно поддающимся терапии; бесплодие, нарушение менструального цикла; депрессия; неврологические и психические нарушения — параличи, потеря сознания, кома и др.; в тяжелых случаях наступают летальные исходы.";
                                    label6.Visible = true;
                                    label7.Text = "    Вам следует обратиться к врачу и сдать анализы. Профилактика указанного заболевания предполагает: достаточное, регулярное, сбалансированное питание; умеренные физические нагрузки; сокращение стрессовых ситуаций, отказ от вредных привычек.";
                                    label7.Visible = true;
                                    buttonBack.Visible = true;
                                    IMTBox.Clear();
                                }
                            }
                            if (resualt > 19 && resualt <= 25)
                            {
                                MessageBox.Show("В пределах нормы");
                            }
                            if (resualt > 25 && resualt <= 30)
                            {
                                MessageBox.Show("Избыток массы тела");
                            }
                            if (resualt > 30 && resualt <= 35)
                            {
                                MessageBox.Show("Ожирение 1 степени");
                            }
                            if (resualt > 35 && resualt <= 40)
                            {
                                MessageBox.Show("Ожирение 2 степени");
                            }
                            if (resualt > 40)
                            {
                                MessageBox.Show("Ожирение 3 степен");
                            }
                        }
                        if (age2 > 30 && age2 < 2000)
                        {
                            if (resualt < 16)
                            {
                                MessageBox.Show("Анорексия");
                            }
                            if (resualt >= 16 && resualt <= 18)
                            {
                                MessageBox.Show("Недостаток массы тела");
                            }
                            if (resualt > 18 && resualt <= 22)
                            {
                                MessageBox.Show("В пределах нормы");
                            }
                            if (resualt > 22 && resualt <= 27)
                            {
                                MessageBox.Show("Избыток массы тела");
                            }
                            if (resualt > 27 && resualt <= 33)
                            {
                                MessageBox.Show("Ожирение 1 степени");
                            }
                            if (resualt > 33 && resualt <= 37)
                            {
                                MessageBox.Show("Ожирение 2 степени");
                            }
                            if (resualt > 40)
                            {
                                MessageBox.Show("Ожирение 3 степени");
                            }
                        }

                    }   
                }
                else
                {
                    MessageBox.Show("Выберите пол!", "Ошибка!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введннных данных", "Ошибка!");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            resault.Visible = true;
            AgeBox.Visible = true;
            ves.Visible = true;
            rost.Visible = true;
            IMTBox.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            buttonBack.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
