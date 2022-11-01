#region Task-1
int[] numbers = { 2, -10, 0, 455, 34 };
int min = numbers[0];
long length = numbers.Length;

if (length == 0)
{
    Console.WriteLine("Bos array");
}

else if (length != 1)
{
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];
    }
    Console.WriteLine("Array-de olan minimum eded: " + min);
}


#endregion



#region Task-2

//int [] numbers2 = {2,34,-6,0,89,2,9,10,1,-1};
//int count=0;

//for (int i = 0; i < numbers2.Length; i++)
//{
//	if (numbers2[i] < 10 && numbers2[i] > -1) 
//		count++;	
//}
//Console.WriteLine(count);
#endregion
