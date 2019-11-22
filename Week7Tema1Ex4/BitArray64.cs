using System;
using System.Collections;
using System.Collections.Generic;


namespace Week7Tema1Ex4
{
    partial class Program
    {
        class BitArray64 : IEnumerable<int>
        {
            ulong state;
            public BitArray64(ulong value)
            {
                state = value;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
            public int this[int i]
            {
                get
                {
                    var newState = state >> i;
                    if (newState % 2 == 0)
                    {
                        return 0;
                    }
                    return 1;
                }
            }
            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 63; i >= 0; i--)
                {
                    yield return this[i];
                }
            }
           

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}
