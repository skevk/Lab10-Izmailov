string subject = "Программирование";

foreach (char letter in subject) {
    Console.WriteLine(letter);
}
Console.WriteLine("Общее количество букв: " + subject.Length);


int[] grades = { 4, 5, 3, 5, 4 };

int sum = 0; 

foreach (int grade in grades) {
    Console.WriteLine(grade);
    sum += grade; 
}


double average = (double)sum / grades.Length;
Console.WriteLine("Средний балл: " + average);


string[] students = { "Аня", "Ярослав", "Вика" };

int count = 0; 

foreach (string student in students) {
    Console.WriteLine(student);
    count++; 
}

Console.WriteLine("Всего учеников: " + count);



int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++) {
    points[i] = points[i] + 5;
}

foreach (int point in points)
{
    Console.WriteLine(point);
}


string[] students1 = { "Аня", "Борис", "Вика" };
int number = 1;

foreach (string student1 in students1)
{
    Console.WriteLine($"{number}. {student1}");
    number++;
}

int[] numbers1 = { 10, 25, 5, 40, 20 };
int sum1 = 0;

foreach (int number1 in numbers1) {
    Console.WriteLine(number1);
    sum1 += number1;
}

Console.WriteLine("Сумма чисел: " + sum1);

string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

foreach (string day in daysOfWeek)
{
    Console.WriteLine(day + "!");
}



Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname)) {
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new Random(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


Console.Write("Введите слово: ");
string word = Console.ReadLine()!.ToLower(); 

string consonants = "бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxyz";
int count1 = 0;

foreach (char letter in word) {
    
    if (consonants.Contains(letter)) {
        count1++;
    }
}

Console.WriteLine($"Количество согласных букв: {count1}");


int[] numbers = { 1, 2, 3, 4, 5 };

for (int i = 0; i < numbers.Length; i++) {
    numbers[i] = numbers[i] + 1; 
}

foreach (int num in numbers) {
    Console.WriteLine(num);
}