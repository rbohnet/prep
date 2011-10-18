﻿using System.Collections.Generic;

namespace prep.infrastructure.sorting
{
    public class CombinedComparer<T> : IComparer<T>
    {
        IComparer<T> first;
        IComparer<T> second;

        public CombinedComparer(IComparer<T> first, IComparer<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public int Compare(T x, T y)
        {
            var result = first.Compare(x, y);
            if (result == 0) return second.Compare(x, y);
            return result;
        }
    }
}