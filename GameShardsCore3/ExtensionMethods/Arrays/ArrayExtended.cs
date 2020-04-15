using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.ExtensionMethods.Arrays {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    public static class ArrayExtended {

        [Tested()]
        /// <summary>
        /// Adds an item in the last place of the array, always increasing its size by 1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static T[] Add<T>(this T[] arr, T item) {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
            return arr;
        }

        [Tested()]
        /// <summary>
        /// Concatenates at the end of the array another array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="elem"></param>
        /// <returns></returns>
        public static T[] AddRange<T>(this T[] arr, T[] elem) {
            Array.Resize(ref arr, arr.Length + elem.Length);
            Array.Copy(elem, 0, arr, arr.Length - elem.Length, elem.Length);
            return arr;
        }

        [Tested()]
        /// <summary>
        /// Insert an item in a specified index in the array. The new item will be at index, the following ones
        /// will have their index shifted by +1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static T[] Insert<T>(this T[] arr, T item, int index) {
            if (index >= arr.Length) throw new IndexOutOfRangeException(LangManager.GetString("exception_index_oor", CurrentCulture));
            T[] temp = new T[arr.Length + 1];
            Array.Copy(arr, index, temp, index + 1, arr.Length - index);
            Array.Copy(arr, 0, temp, 0, index);
            arr = temp;
            return arr;
        }

        [Tested()]
        /// <summary>
        /// Injects an array in a specified index in another array. The first element of the injected array is
        /// at index "index". The array will be resized to the sum of both arrays
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="elem"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static T[] InsertRange<T>(this T[] arr, T[] elem, int index) {
            if (index >= arr.Length) throw new IndexOutOfRangeException(LangManager.GetString("exception_index_oor", CurrentCulture));
            T[] temp = new T[arr.Length + elem.Length];
            Array.Copy(arr, 0, temp, 0, index);
            Array.Copy(elem, 0, temp, index, elem.Length);
            Array.Copy(arr, index, temp, index + elem.Length, arr.Length - index);
            arr = temp;
            return arr;
        }

        [Tested()]
        /// <summary>
        /// Removes an item in a specific index
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static T[] RemoveAt<T>(this T[] source, int index) {
            T[] dest = new T[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, dest, 0, index);
            if (index < source.Length - 1)
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);
            source = dest;
            return source;
        }

        [Tested()]
        /// <summary>
        /// Removes "range" elements from arr, starting from "index"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static T[] RemoveRange<T>(this T[] arr, int index, int range) {
            if (index >= arr.Length) throw new IndexOutOfRangeException(LangManager.GetString("exception_index_oor", CurrentCulture));
            if (index + range >= arr.Length) throw new ArgumentOutOfRangeException(LangManager.GetString("exception_argument_oor", CurrentCulture));
            T[] temp = new T[arr.Length - range];
            Array.Copy(arr, 0, temp, 0, index);
            Array.Copy(arr, index + range, temp, index, arr.Length - index - range);
            arr = temp;
            return arr;
        }

        [Tested()]
        /// <summary>
        /// Reverses a portion of the array, from start index to end index
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static T[] Reverse<T>(this T[] arr, int start, int end) {
            if (end < start) throw new ArgumentException(LangManager.GetString("exception_index_end_before_start", CurrentCulture));
            if (start > arr.Length || end > arr.Length) throw new IndexOutOfRangeException(LangManager.GetString("exception_index_oor", CurrentCulture));
            if (end == start) return arr;
            T[] temp = new T[end - start + 1];
            for (int x = start; x <= end; x++) {
                temp[end - x] = arr[x]; 
            }
            Array.Copy(temp, 0, arr, start, end - start + 1);
            return arr;
        }

        [ToTest()]
        /// <summary>
        /// Fills a portion of the array, from start index to end index
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static T[] Fill<T>(this T[] arr, T elem, int start, int end) {
            if (end < start) throw new ArgumentException(LangManager.GetString("exception_index_end_before_start", CurrentCulture));
            if (start > arr.Length || end > arr.Length) throw new IndexOutOfRangeException(LangManager.GetString("exception_index_oor", CurrentCulture));
            if (end == start) return arr;
            for (int x = start; x <= end; x++) {
                arr[x] = elem;
            }
            return arr;
        }

        [ToTest()]
        /// <summary>
        /// Returns the first index in which resides element elem, -1 if not found
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr">Array where to search</param>
        /// <param name="elem">Element to search</param>
        /// <param name="startAt">Index where to start from. The function cycles through the array as a circular list</param>
        /// <param name="leftToRight">If true, the search will start from startAt and will continue to bigger indices and return 
        /// in a circular way to startAt - 1, otherwise the search will continue to smaller indices and continue in a
        /// circular way to startAt + 1</param>
        /// <returns></returns>
        public static int IndexOf<T>(this T[] arr, T elem, int startAt = 0, bool leftToRight = true) {
            if (startAt >= arr.Length) throw new ArgumentException("startAt is bigger than array's size");
            if (startAt < 0) throw new ArgumentException("startAt must be non-negative");
            if (arr.Length == 0) return -1;
            for (int x = 0; x < arr.Length; x++) {
                int index = x + startAt;
                if (arr[index].Equals(elem)) return index;
                if (leftToRight) index++; else index--;
                if (index >= arr.Length) index = 0;
                else if (index < 0) index = arr.Length - 1;
            }
            return -1;
        }


    }

}
