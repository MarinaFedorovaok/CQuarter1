int count = 0;
int distance = 10000;
int firstFriendSpeed = 2;
int secondFrieidSpeed = 1;
int dogSpeed = 3;
int Friend = 2;
int time = 0;
while distance > 0
    {
        if Friend = 1
            {
                time= distance/(firstFriendSpeed+dogSpeed);
                Friend=2;
            }
            else
            {
                time= distance/(secondFrieidSpeed+dogSpeed);
                Friend=1;
            }
        distance = distance-(firstFriendSpeed+secondFrieidSpeed)*time;
        count++;
    }
    Console.Write(count);