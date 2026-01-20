using sicharp;
Console.WriteLine("Введите время разговора в минутах:");
int time = int.Parse(Console.ReadLine());
Console.WriteLine("Введите стоимость 1 минуты разговора:");
int price = int.Parse(Console.ReadLine());
Convertion call = new Convertion();
call.Time = time;
call.Price = price;
Console.WriteLine($"Цена вашего разговора {call.cost()}");