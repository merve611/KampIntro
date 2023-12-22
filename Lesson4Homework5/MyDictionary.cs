using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Homework5
{
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;


        public MyDictionary()
        {
              keys = new K[0];    
              values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] k_tempArray = keys;
            V[] v_tempArray = values;

            keys = new K[keys.Length+1];
            values = new V[values.Length+1];

            for (int i = 0; i < k_tempArray.Length; i++)
            {
                keys[i] = k_tempArray[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < v_tempArray.Length; i++)
            {
                values[i] = v_tempArray[i];
            }
            values[values.Length-1] = value;
        }

        


    } 
}
