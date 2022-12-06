# calculator_
<h1>Лабораторная работа №1 ВСРПП. Выполнил Котович Николай гр. 20ИТ-1.
<h5><br>Внешний вид калькулятора:<br>
<br><img src="https://user-images.githubusercontent.com/116580117/206019736-132e0d00-ba5a-42f4-b5ec-f5f123a75aa5.gif" ><br>
<br>Выполнены Юнит тесты:<br>
<br><img src="https://raw.githubusercontent.com/CyberSanyok/Images/main/Caclulator%20Images/UTests.png" ><br>
<br>Проект представляет собой обычный калькулятор. Можно использовать сложение, вычитанеи, умножение и деление:<br>
<br><img src="https://user-images.githubusercontent.com/116580117/206020971-e6d8d91e-9d3d-4efc-aa8c-a7533cc5cb06.png" ><br>
<br>Если нужно, можно изменить знак числа с помощью кнопки "+/-:"<br>
<br><img src="https://user-images.githubusercontent.com/116580117/206021394-8ace253a-d0c4-4825-9473-1917e0f1425a.png" ><br>
<br>Для примера введём число "23"и прибавим к нему "-3".<br>
<br><img src="https://user-images.githubusercontent.com/116580117/206022328-576e7c8f-4182-4b56-b127-57097c9cbf86.png" ><br>
<br><img src="https://user-images.githubusercontent.com/116580117/206022558-d22327eb-fe22-4056-a68d-ecf9bc3c52e5.png" ><br>
<br>Нажав на кнопку "="должно получится "20" (20+(-3)=20).<br>
<br><img src="https://user-images.githubusercontent.com/116580117/206022611-944288bb-b893-4a38-9a55-170cdca03921.png" ><br>
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
