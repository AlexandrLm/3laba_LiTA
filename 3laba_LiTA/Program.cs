using _3laba_LiTA;

Queue first = new();
Stack second = new(15);
Console.WriteLine(second.MaxItems());
second.Add(1);
second.Add(2);
second.Add(3);

second.GetOne();
second.GetOne();
second.GetOne();