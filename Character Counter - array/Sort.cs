using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Counter___array
{
    class Sort
    {
        private CharacterObject[] _unsortedCharacterObjects;
        private int _left;
        private int _right;

        public Sort(CharacterObject[] unsorted)
        {
            _unsortedCharacterObjects = unsorted;
            _left = 0;
            _right = unsorted.Length -1;
            quickSort(unsorted, _left, _right);
        }

        private CharacterObject Partition(CharacterObject[] unsorted, int left, int right)
        {
            CharacterObject pivot;
            while (unsorted[left] == null) left++;
            while (unsorted[right] == null) right--;
            {
                
            }
            pivot = unsorted[left];
            while (true)
            {
                while (unsorted[left].Frequency < pivot.Frequency)
                {
                    left++;
                }

                while (unsorted[right].Frequency > pivot.Frequency)
                {
                    right--;
                }

                if (unsorted[left].Frequency < unsorted[right].Frequency)
                {
                    CharacterObject temp = new CharacterObject(unsorted[right].Character);
                    unsorted[right] = unsorted[left];
                    unsorted[left] = temp;
                }
                else return unsorted[right];
            }
        }

        public void quickSort(CharacterObject[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right).Frequency;
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
    }
}
