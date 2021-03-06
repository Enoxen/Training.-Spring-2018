## Читать (Обязательно!)
- Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012. Chapter 5. Collections.
- C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015. Chapter 7. Collections.
  - *Основное внимание уделить следующим обобщенным строго типизированным коллекциям - List, Queue, Stack, Sets, Dictionaries.*
  - *Обязательно ознакомиться с **Plugging in Equality and Order** (C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015. Chapter 7. Collections)*
  - [Откуда растут руки у GetHashCode в .NET](https://habrahabr.ru/post/188038/)
  - [Правила и рекомендации по переопределению GetHashCode](https://blogs.msdn.microsoft.com/ruericlippert/2011/03/20/943/)

## Материалы (презентация)
- [Generics and Collections](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M10.%20Generics%20and%20Collections)
- [LINQPad Generics and Collections](https://drive.google.com/drive/u/0/folders/1hnixc0qkILYSvmikBzAu3iWRWH3Xj6Hh)

## Задачи (deadline - 16.04.2018, 24.00)
1. Внести исправления в обобщенные методы бинарного поиска, метод-фильтр, метод-трансформер - реализовать как обобщенные методы расширения, а также метод нахождения n-первых чисел последовательности Фибоначчи - реализовать как генератор последовательности.
2. Внести исправления в обобщенный класс-коллекцию Queue.
3. Разработать обобщенный класс-коллекцию BinarySearchTree (бинарное дерево поиска). Предусмотреть возможности использования подключаемого интерфейса для реализации отношения порядка. Реализовать три способа обхода дерева: прямой (preorder), поперечный (inorder), обратный (postorder): для реализации использовать блок-итератор (yield). Протестировать разработанный класс, используя следующие типы:
  - System.Int32 (использовать сравнение по умолчанию и подключаемый компаратор); 
  - System.String (использовать сравнение по умолчанию и подключаемый компаратор); 
  - пользовательский класс Book, для объектов которого реализовано отношения порядка (использовать сравнение по умолчанию и подключаемый компаратор); 
  - пользовательскую структуру Point, для объектов которого не реализовано отношения порядка (использовать подключаемый компаратор).
