﻿using System.Collections.Generic;

namespace prep.infrastructure.sorting
{
    public class ReverseComparer<T> : IComparer<T>
    {
        IComparer<T> original;

        public ReverseComparer(IComparer<T> original)
        {
            this.original = original;
        }

        public int Compare(T x, T y)
        {
            return -original.Compare(x, y);
        }
    }
}