using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            if (end >= start)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = end - (end - start) / 3;

                if (arr[mid1] == key)
                    return mid1;

                if (arr[mid2] == key)
                    return mid2;

                if (key < arr[mid1])
                    return TernarySearch(arr, key, start, mid1 - 1);
                else if (key > arr[mid2])
                    return TernarySearch(arr, key, mid2 + 1, end);
                else
                    return TernarySearch(arr, key, mid1 + 1, mid2 - 1);
            }

            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            if (end >= start)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == key)
                {
                    if (is_first)
                        return BinarySearchForCalculatingRepeated(arr, key, true, start, mid - 1);
                    else
                        return BinarySearchForCalculatingRepeated(arr, key, false, mid + 1, end);
                }

                if (arr[mid] > key || (is_first && arr[mid] >= key))
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid - 1);
                else
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, mid + 1, end);
            }

            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            int first = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            int last = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);

            if (first == -1 || last == -1)
                return 0;

            return last - first + 1;
        }
    }
}

