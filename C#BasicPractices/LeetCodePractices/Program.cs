using LeetCodePractices;
//Gray Code

GrayCode grayCode = new GrayCode();
int n = 2;
IList<int> grayCodeList = grayCode.GrayCodes(n);
Console.Write("[");
for (int i = 0; i < grayCodeList.Count; i++)
{
    Console.Write(grayCodeList[i]);
    if (i < grayCodeList.Count - 1)
        Console.Write(",");
}
Console.Write("]"); 


/*//MergeSoredArray
MergeSortedArray mergeSortedArray = new MergeSortedArray();
int[] nums1 = { 1, 2, 3, 0, 0, 0 };
int m = 3;
int[] nums2 = { 2, 5, 6 };
int n = 3;

mergeSortedArray.Merge(nums1, m, nums2, n);

Console.Write("[");
for (int i = 0; i < nums1.Length; i++)
{
    Console.Write(nums1[i]);
    if (i < nums1.Length - 1)
        Console.Write(", ");
}
Console.WriteLine("]");  // Output: [1, 2, 2, 3, 5, 6]*/