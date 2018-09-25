﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProject
{
    class Program
    {
        public static void Main()
        {
            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";
            strStore[4] = "five";
            strStore[5] = "six";
            strStore[6] = "seven";
            strStore[7] = "eight";
            strStore[8] = "nine";
            strStore[9] = "ten";
           // strStore[10] = "eleven";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);
        }
    }

    public class StringDataStore
    {

        private string[] strArr = new string[10]; // internal data storage

        public StringDataStore()
        {

        }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                return strArr[index];
            }

            set
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                strArr[index] = value;
            }
        }
    }
}

