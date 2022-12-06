# calculator_
<h1>Лабораторная работа №1 ВСРПП. Выполнил Александр Дмитраница гр. 20ИТ-3.
<h5><br>Внешний вид калькулятора:<br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/Внешний%20вид%20калькулятора.png" ><br>
<br>Выполнены Юнит тесты:<br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/UTests.png" ><br>
<br>Проект представляет собой обычный калькулятор. Можно использовать сложение, вычитанеи, умножение и деление:<br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/Операции.png" ><br>
<br>Если нужно, можно изменить знак числа с помощью кнопки "+/-:"<br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/Изменить%20знак.png" ><br>
<br>Для примера введём число "23"и прибавим к нему "-3".<br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/1.png" ><br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/2.png" ><br>
<br>Нажав на кнопку "="должно получится "20" (20+(-3)=20).<br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/3.png" ><br>
<br>Не вводя заново полученное число, разделим его на "5", умножим на "2" и нажмём кнопку "=".<br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/4.png" ><br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/5.png" ><br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/6.png" ><br>
<br>Получилось число "8" (20/5*2=8).<br>
<h1>Классы
  <h6>
<br>В проекте прописаны 2 класса(+класс для юнит тестов):<br>
<br>-Calculating(+CalculatingTest);<br>
<br>-Form1.<br>
<br>В классе Calculating проводятся все расчёты. Прописано 5 методов:<br>
  <br>-EnteredNum(приписывает введённые числа к общему числу);<br>
  <br>-Action(реакция на */+-);<br>
  <br>-PositiveNum(смена знака +/-);<br>
  <br>-ClickEquals(расчёт,клик по кнопке "равно")<br>
  <br>-Reset(сброс,кнопка "C")<br>
    <br>В классе CalculatingTest тестикуется каждый метод класса Calculating.<br>
    <br>В классе Form1 используются методы класса Calculating.<br>
