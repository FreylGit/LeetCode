/*
 Учитывая массив целых чисел nums и целое число target, верните индексы двух чисел так, чтобы они составляли в сумме target .

Вы можете предположить, что каждый вход будет иметь ровно одно решение , и вы не можете использовать один и тот же элемент дважды.

Вы можете вернуть ответ в любом порядке.*/
/*

/* Пример 1:

Ввод: nums = [2,7,11,15], target = 9
 Вывод: [0,1]
 Объяснение: Поскольку nums[0] + nums[1] == 9, мы возвращаем [0, 1].
*/

int[] nums = { 3, 2, 4 };
int target = 6;
var result = TwoSum(nums, target);
Console.WriteLine($"[{result[0]},{result[1]}]");
static int[] TwoSum(int[] nums, int target)
{
	for (int i = 0; i < nums.Length; i++)
	{
		for (int j = i+1; j < nums.Length; j++)
		{
			if (nums[i] + nums[j] == target)
			{
				int[] result = { i, j };
				return result;
			}
		}
	}
    return null;
}