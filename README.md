Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []


Описание алгоритма решения:

Массив вводим сразу с данными, задали 5 элементов массива.
Метод SecondArray — вначале считает количество элементов массива с 
тремя и менее символами, цикл проверк условия ( <=3 ). 
Затем создает массив нужной размерностью и вносит данные 
из введенного массива в массив-результат.
printA — выводит на экран  массив значений.