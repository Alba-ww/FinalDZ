<<<<<<< HEAD
## Задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


## Решение:
1. Обьявлено два массива.
2. Применяем метод void,используем цикл for, в котором проверяем соответствие длинне массива.
Внутри цикла проверяем условие меньше или равно 3 символам,если да ,то элемент первого массива заносится в count элемента второго массива.После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1.
3. Печать массива.
=======
## Задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


## Решение:
1. Объявление массивов: 
   - Объявляются два массива: первый массив (ArrayStart), который содержит исходные строки, и второй массив (ArrayFinish), который будет использоваться для хранения строк, длина которых меньше или равна 3 символам.

2. Использование метода и цикла:
   - Применяется метод void, в котором используется цикл for для перебора элементов первого массива (ArrayStart).
   - Внутри цикла проверяется условие: если длина текущего элемента меньше или равна 3 символам, то этот элемент добавляется в следующий свободный индекс второго массива (ArrayFinish), используя переменную count для отслеживания текущего индекса.
   - После добавления элемента значение переменной count увеличивается на 1, и цикл продолжает свою работу, увеличивая счетчик i на 1 для перехода к следующему элементу.

3. Вывод массива:
   - После завершения цикла осуществляется печать элементов второго массива (ArrayFinish), чтобы отобразить строки, которые соответствуют условиям.
>>>>>>> 023e6383836e712ce74e5db75f3af4593ed173cf
