## **Задача:**
    Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Описание алгоритма решения:**

	### Сначало вводится первый массив. Затем объявяется второй массив. Потом прописывается метод, в котором цикл соразмерный длине массива. Внутри цикла выплняется проверка условия (длина символов в  строке <=3 ), если условие ИСТИННО - элемент первого массива заносится в count элемент второго массива. Переменная count необходима, чтобы поочередно передавать данные из первого массива во второй,  и чтобы потом не было пробелов. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.
	###  После завершения цикла на печать выводится массив состоящий из строк, длинна которых меьше либо равна 3 символам. 
		

**Графическое представление метода в файлах "Блок-схема алгоритма  Задачи" (два файла, с разным расширением).**

**Текстовое описание решения содержится в файле README.md**

**Реализация алгоритма отображена в программе Program.cs**
