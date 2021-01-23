using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    

    class MyDictionary<TKey,TValue>
    {
        TKey[] _arrayKey;
        TValue[] _arrayVal;

        TKey[] _tempKey;
        TValue[] _tempVal;
        
        public MyDictionary()
        {

            _arrayKey = new TKey[0];
            _arrayVal = new TValue[0];

        }
        public void Add(TKey item, TValue value)
        {
            _tempKey = _arrayKey;
            _tempVal = _arrayVal;

            _arrayKey = new TKey[_arrayKey.Length + 1];
            _arrayVal = new TValue[_arrayVal.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {

                _arrayKey[i] = _tempKey[i];
            }
            for (int i = 0; i < _tempVal.Length; i++)
            {
                _arrayVal[i] = _tempVal[i];
            }

            _arrayKey[_arrayKey.Length - 1] = item;
            _arrayVal[_arrayVal.Length - 1] = value;

            Output(_arrayKey,_arrayVal);
        }
        public void Output(TKey[] _arraykey, TValue[] _arrayVal)
        {

            for (int i = 0; i < _arrayKey.Length; i++)
            {

                Console.WriteLine(" Key: " + _arrayKey[i] + " Value: " + _arrayVal[i]);

            }


        }
    }
}
