[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/5ZerStQK)

**Назва роботи: Використання механізму віртуальних методів
Мета роботи: Ознайомитися з особливостями використання віртуальних методів.** 

**Теоретичні відомості**
Мова С# включає таку властивість, як поліморфізм – можливість для об’єктів різних класів, зв’язаних з допомогою наслідування, реагувати різними способами при виклику однієї функції-елементу. До найважливіших форм поліморфізму можна віднести:
перевантаження методів та операцій;
віртуальні методи (функції);
Перевантаження методів та операцій називаються статичним поліморфізмом, тому що він підтримується на етапі компіляції (тобто до запуску програми). Віртуальні методи відносяться до динамічного поліморфізму, тому що він реалізується при виконанні програм.
При використанні віртуального методу запит здійснюється з допомогою вказівника базового класу (або посилання), тобто середовище виконання С# вибирає правильно перевизначений метод у відповідному похідному класі, який зв’язаний з цим об’єктом.
Іноді метод визначається в базовому класі як віртуальний, але просто перевизначений в похідному класі. Якщо такий метод викликається через вказівник похідного класу, то використовується версія похідного класу. Це не поліморфна поведінка.
Завдяки використанню поліморфних методів та поліморфізму виклик функції-елемента може привести до різних дій, які залежать від типу об’єкту, який викликається.
Завдання
Написати програму, описавши батьківський та похідний класи і використавши віртуальні методи. За основу візьміть попередню лабораторну і додайте віртуальні методи. Використайте динамічне створення об’єктів та показчики на екземпляр класу. 
Продемонструвати роботу віртуальних методів на практичному прикладі коли наперед невідомо який об’єкт буде створено (невідомо на етапі компіляції):
  

      //Вибрати режим роботи-запитати в користувача, змінна userChoose
        if (userChoose=='1'){
            //Працюємо з одним об'єктом
            //Створюємо, ініціалізуємо ітд
    
        }
            else{
            //Працюємо з іншим об'єктом
            //Створюємо, ініціалізуємо ітд
        }
           //Виклик віртуальної функції через вказівник/показчик на базовий клас

Змініть віртуальні методи на звичайні та перевірте роботу програми. Проаналізуйте зміни.


Приклад програми:


> using System; using System.Collections.Generic; using System.Linq;
> using System.Text;
> 
> namespace ConsoleApplication1 {
>     class Celipsoid
>     {
>         public int a1, a2, a3, b1, b2, b3;
>         public double v;
>         virtual public void inita()
>         {
>             System.Console.WriteLine("Введiть пiвосi елiпсоїда a1, a2, a3:");
>             a1 = Convert.ToInt32(Console.ReadLine());
>             a2 = Convert.ToInt32(Console.ReadLine());
>             a3 = Convert.ToInt32(Console.ReadLine());
>         }
>         virtual public void initb()
>         {
>             System.Console.WriteLine("Введiть координати змiщення центру b1, b2, b3:");
>             b1 = Convert.ToInt32(Console.ReadLine());
>             b2 = Convert.ToInt32(Console.ReadLine());
>             b3 = Convert.ToInt32(Console.ReadLine());
>         }
>         virtual public void show()
>         {
>             Console.WriteLine("a1= " + a1);
>             Console.WriteLine("a2= " + a2);
>             Console.WriteLine("a3= " + a3);
>             Console.WriteLine("b1= " + b1);
>             Console.WriteLine("b2= " + b2);
>             Console.WriteLine("b3= " + b3);
>         }
>         virtual public double size()
>         {
>             v = 4.0 * a1 * a2 * a3 / 3.0;
>             Console.Write("v елiпсоїда = ");
>             Console.WriteLine(v);
>             return (v);
>         }
> 
>     }
>     class Cball : Celipsoid
>     {
>         public int r;
>         public override void inita()
>         {
>             System.Console.Write("Введiть радiус кулi:");
>             r = Convert.ToInt32(Console.ReadLine());
>             base.initb();
>         }
>         public override void show()
>         {
>             Console.WriteLine("r= " + r);
>             Console.WriteLine("b1= " + b1);
>             Console.WriteLine("b2= " + b2);
>             Console.WriteLine("b3= " + b3);
>         }
>         public override double size()
>         {
>             v = 4.0 * r * r * r / 3.0;
>             Console.Write("v кулi = ");
>             Console.WriteLine(v);
>             return (v);
>         }
>     }
> 
>     class Program
>     {
>         static void Main(string[] args)
>         {
>             int userSelect;
>             Celipsoid baseobj = new Celipsoid();
>             do
>             {
>                 Console.WriteLine("Enter '0' if you want to work with elipsoid and '1' - with ball");
>                 userSelect = Convert.ToInt32(Console.ReadLine());
>                 if (userSelect == 0)
>                 {
>                     baseobj = new Celipsoid();
>                     baseobj.initb();
>                 }
>                 else if (userSelect == 1)
>                 {
>                     baseobj = new Cball();
>                 }
>                 else
>                 {
>                     return;
>                 }
>                 baseobj.inita();
>                 baseobj.show();
>                 baseobj.size();
>             } while (true);
>         }
>     } }



Варіанти завдань 
Згідно попередньої роботи.

**Хід виконання**
1.	Розробити алгоритми створення класів згідно варіантів завдань.
2.	Написати відповідну програму на мові програмування С#. 
3		Проаналізувати роботу програми з віртуальними методами та звичайними. Тобто потрібно дослідити механізм динамічного поліморфізму. Зверніть увагу на приклад коду, зокрема на механізм створення об'єкту одного з класів. На етапі компіляції програми невідомо який вибір зробить користувач під час виконання програми. 
4.	Порівняти результати виконання програми з віртуальними методами та без віртуальних методів.
5.	В README файл додати скріншоти роботи програми з віртуальними методами і без віртуальних. Описати різницю. 




Порівняти результати виконання програми з віртуальними методами та без віртуальних методів.
Використання віртуальних методів у програмуванні дозволяє досягти поліморфізму, що є однією з основних концепцій об'єктно-орієнтованого програмування. Поліморфізм дозволяє використовувати об'єкти похідних класів через посилання на їх базовий клас, при цьому викликаються методи, що відповідають типу самого об'єкта, а не типу посилання.

У віртуальних методах базового класу ключове слово virtual дозволяє перевизначити ці методи у похідних класах за допомогою ключового слова override, що забезпечує правильний виклик методів у випадку поліморфних об'єктів. Це робить програму більш гнучкою та зручною для розвитку та змін.

Без використання віртуальних методів програма може не коректно реагувати на тип об'єкта в момент виклику методів через посилання на базовий клас, що може призвести до непередбачуваних результатів та помилок.

Таким чином, використання віртуальних методів допомагає забезпечити правильну поведінку програми у випадку поліморфних об'єктів, роблячи її більш стійкою та підтримуваною.







