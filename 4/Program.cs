/*Учитывая два отсортированных массива nums1и nums2 размер mи n соответственно, вернуть медиану двух отсортированных массивов.*/
//TODO: Решение не оптимальное. Вернуться когда будет настроение и сделать оптимальное.
int[] nums1 = { 1, 2 };
int[] nums2 = { 3 };
Console.WriteLine(FindMedianSortedArrays(nums1, nums2));


static double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
	int[] result = new int[nums1.Length + nums2.Length];
	int index = 0;
	for (int i = 0; i < nums1.Length; i++)
	{
		result[index] = nums1[i];
		index++;
	}
	for (int i = 0; i < nums2.Length; i++)
	{
		result[index] = nums2[i];
		index++;
	}
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = i + 1; j < result.Length; j++)
        {
            if (result[i] > result[j])
            {
                int tmp = result[i];
                result[i] = result[j];
                result[j] = tmp;
            }
        }
    }

    int len = result.Length / 2;
    if (result.Length % 2 == 0)
	{
		
		double sum = (result[len] + result[len - 1]) / 2.0;
		return sum;
	}
	else
	{
        
        return result[len];
    }
    
}