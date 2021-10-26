int [] array = {1, 13, 143, 14734, 53, 4212};
int n = array.Length;
int find = 143;
int index= 0;
while (index < n)
{
    if (array[index] == find)
        {
            Console.WriteLine(index);
            break;
        }
        index++;
}