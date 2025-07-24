//1.Verilmish arrayda murekkeb ededleri ekrana çıxaran algorithm misal:input {5,9,12,11} output 9, 12
int[] numbers = { 5, 9, 12, 7 };


for (int i = 0; i < numbers.Length; i++)
{
    int count = 0;

    for (int j = 2; j < numbers[i]; j++)
	{
		if (numbers[i]%j==0)
		{
            count++;
          
        }
			
	}
    if (count > 0)
    {
        Console.WriteLine(numbers[i]);
    }
}
