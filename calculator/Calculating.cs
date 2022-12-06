using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public class Calculating
    {
        private bool positivity=true; //положительсноть/отрицательность первого числа
        private bool positivity2=true;//положительсноть/отрицательность второго числа
        private int numLimit=9;//лимит символов в числе
        private int action=0;// номер действия(*/+-)
        private double resultCalculations;//результат расчёта в double
        private string result;//результат расчёта в string
        private double firstNum;// первое число
        private double secondNum;// второе число
        public Calculating() { }
        // приписывает введённые числа к общему числу
        public string EnteredNum(string enteredNum)
        {
            if (result == null||result.Length <= numLimit)
            {
                result += enteredNum;
            }
            return result;
        }
        // реакция на */+-
        public void Action(int action2,Label label) 
        {
            try
            {
                label.Text = "";
                // нужно, чтобы решать, не нажимая на кнопку "="
                if (firstNum != 0 && result != "")
                {
                    ClickEquals(label);
                    action = action2;
                    result = "";
                }
                
                // если action выбирается первый раз
                if (result != "" && action == 0)
                {

                    firstNum = Convert.ToDouble(result);
                    action = action2;
                    result = "";
                }
                // если */+- уже были прожаты и нужен новый action
                if (action != 0)
                {
                    action = action2;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // смена знака +/-
        public void PositiveNum(Label label) 
        {
            if (result != "") 
            {
                // если первое число существует, значит уже меняется знак у второго
                if (firstNum != 0)
                {
                    positivity2 = !positivity2;
                    if (positivity2 == true) label.Text = "";
                    else label.Text = "-";
                }
                // если первого числа ещё нет(создаётся), занчит знак меняют ему
                else 
                {
                    positivity = !positivity;
                    if (positivity == true) label.Text = "";
                    else label.Text = "-";
                }
            }
            
        }
        // расчёт(клик по кнопке "равно")
        public string ClickEquals(Label label) 
        {
            if (result != "")
            {
                secondNum = Convert.ToDouble(result);
                // заданём отрицательность чисел(если она есть)
                if (positivity == false) firstNum *= (-1);
                if (positivity2 == false) secondNum *= (-1);
                // происходит расчёт выбранного действия(action */+-)
                switch (action) 
                {
                    //plus
                    case 1:resultCalculations = firstNum + secondNum; break;
                    //minus
                    case 2:resultCalculations = firstNum - secondNum;break;
                    //*
                    case 3:resultCalculations = firstNum * secondNum;break;
                    // divide
                    case 4:resultCalculations = firstNum / secondNum;break;
                    
                }
                
            }
            //округление,т.к. по требованиям нет дробных
            resultCalculations = Math.Round(resultCalculations);
            //если у числа больше 9 знаков => EXCEEDED
            if (resultCalculations.ToString().Length > numLimit) return "EXCEEDED";
            if (resultCalculations < 0)
            {
                positivity = false;
                label.Text = "-";
            }
            else
            {
                positivity = true;
                label.Text = "";
            }
            positivity2 = true;
            resultCalculations = Math.Abs(resultCalculations);
            firstNum = resultCalculations;
            result = resultCalculations.ToString();
            secondNum = 0;
            action = 0;
            return result;
        }
        //сброк(кнопка "C")
        public void Reset(Label label) 
        {
            resultCalculations = 0;
            firstNum = 0;
            secondNum = 0;
            result = "";
            action = 0;
            positivity = true;
            positivity2 = true;
            label.Text = "";
        }


    }
}
