using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_25_07_19
{
    class ArrayLs
    {
        
        const int  STAP_OF_ARRAY_SIZE = 10; //stap to resize array if not enough space
       
        Object[] array = new Object[STAP_OF_ARRAY_SIZE];  // new array for arrayList
        
        private int currentSize =10; //current size of array
        
        private int currentPlace = 0; //last place of not null element

        public int CountAr()// instead of Count method
        {
            return currentPlace;
        }

        
        public void AddNum(int num) ////  instead of Add method for ArrayList
        {
            
            //if index of adding element is in range of current size,simply add an element
            if (currentPlace+1 < currentSize)
            {
                array[currentPlace] = num;
                currentPlace++;
            }
            //if index of adding element is out of range of current size,resize an array
            else
            {
                ResizeAr();

                //add element that it's index out of range
                array[currentPlace] = num;
                currentPlace++;

            }
            //print array
            for (int i = 0; i < currentPlace; i++)
            {
                if (array[i] !=null)
                Console.Write(" {0} is {1} |",i,array[i]);
            }
            Console.WriteLine();
           
        }


        public void RemoveAtNum(int num)// instead of RemoveAt method
        {
            try
            {

                //if index of remove element is bigger than current place set an exeption
                if (num >= currentPlace)
                {
                    throw new IndexOutOfRangeException();
                }

                else
                {
                    //create a temperary new array 
                    Object[] tmpArray = new Object[currentSize];

                    //copy array to temporary array
                    for (int i = 0; i < currentPlace; i++)
                    {
                        tmpArray[i] = array[i];

                    }
                    for (int i = num; i < currentPlace-1; i++)
                    {
                        array[i] = tmpArray[i+1];
                    }
                    currentPlace = currentPlace - 1;
                    array[currentPlace] = null;
                    
                }
            }

            catch (IndexOutOfRangeException a)
            {
                Console.WriteLine("number out of range");
            }
            finally
            {
                //print array
                for (int i = 0; i < currentPlace; i++)
                {
                    //if (array[i] != null)
                        Console.Write(" {0} is {1} |", i, array[i]);
                }
                Console.WriteLine();
            }


        }
        public void InsertInArray(int index, string value)
        {
            try
            {

                //if index of remove element is bigger than current place set an exeption
                if (index >= currentPlace)
                {
                    throw new IndexOutOfRangeException();
                }
                else 
                {
                    if (currentPlace + 1 <= currentSize)
                        ResizeAr();
                    //create a temperary new array 
                    Object[] tmpArray = new Object[currentSize];

                    //copy array to temporary array
                    for (int i = 0; i < currentPlace; i++)
                    {
                        tmpArray[i] = array[i];

                    }
                    for (int i = index; i < currentPlace + 1; i++)
                    {
                        array[i+1] = tmpArray[i ];
                    }
                    currentPlace = currentPlace + 1;
                    array[index] = value;
               
                }
                //print array
                for (int i = 0; i < currentPlace; i++)
                {
                    //if (array[i] != null)
                    Console.Write(" {0} is {1} |", i, array[i]);
                }
                Console.WriteLine();


            }
            catch (IndexOutOfRangeException a)
            {
                Console.WriteLine("number out of range");
            }

        }
            public void ResizeAr ()
            {
                //create a temperary new array with new size
                Object[] tmpArray = new Object[currentSize + STAP_OF_ARRAY_SIZE];

                //copy array to temporary array

                for (int i = 0; i < currentSize; i++)
                {
                    tmpArray[i] = array[i];
                }

                //adjust current size
                currentSize += STAP_OF_ARRAY_SIZE;
                // set an addres of temperaty array to array
                array = tmpArray;
            //tmpArray[currentPlace] = num;
        }



        }


    }

