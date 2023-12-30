using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int N = 1041;

            List<int> arr = new List<int>();
            List<int> add = new List<int>();

            for (int i = 0; N != 0; i++)
            {
                arr.Add(N % 2);
                N = N / 2;
            }

            int[] A = arr.ToArray();

           Array.Reverse(A);

            int fl = 0;
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                {
                    fl = 1;
                }
                if (fl == 1 && A[i] == 0)
                {
                    sum++;
                }
                if (fl == 1 && A[i] == 1)
                {
                    add.Add(sum);
                    sum = 0;
                }
            }

            int[] addMax = add.ToArray();

            
              Console.WriteLine(addMax.Max());
            */
            /*
            int[] nums = { 3, 2, 4 };
            int target = 6;

            int[] num = new int[2];
            int sum = 0;
            bool check = false;


            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j) {
                        sum = nums[j] + nums[i];
                        if (sum == target)
                        {
                            num[0] = i;
                            num[1] = j;
                            check = true;
                            break;
                        }
                    }
                }

                if (check)
                {
                    break;
                }
            }

            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);

            int []nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };

            //int[] result = nums1.Concat(nums2).ToArray();


            //Array.Sort(result);
            //Console.WriteLine(String.Join(",", result));

            double median = 0;



            int[] merge = nums1.Concat(nums2).ToArray();

            Array.Sort(merge);

            //Console.WriteLine(String.Join(",", merge[merge.Length / 2]));
            int n = 5 / 2;
            Console.WriteLine((merge.Length/2)-1);

            if (merge.Length % 2 == 0)
            {
                int num1 = (merge.Length / 2)-1;
                int num2 = (merge.Length / 2);
                double result = (Convert.ToDouble(merge[num1]) + Convert.ToDouble(merge[num2])) / 2;
                median = result;

                Console.WriteLine(result);
            }

            if (merge.Length % 2 == 1)
            {
                int num1 = merge.Length / 2;

                double result = merge[num1];
                median = result;
            }

            Console.WriteLine(median);

            Console.WriteLine("");
            Console.WriteLine(num_char);
            */
            /*
            string s = ")()()(";

            char[] chars = s.ToCharArray();


            int x = 0;
            bool game = true;
                        int highest = 0;
                        for (int i=0; i<chars.Length-1; i++)
              {
                int num_char = 0;
                int j = i;
                int k = i+1;

                while ((j != -1 && k!= chars.Length))
                {
                    if (chars[j] != chars[k])
                    {
                        if ((j ==0 || k == chars.Length-1))
                        {
                                        if (chars[j] != '(' && chars[k] != ')')
                                        {
                                            num_char--;
                                        }             
                        }

                        num_char++;


                    }



                        j--;
                        k++;





                }

                //Console.WriteLine(num_char);


                            if (num_char > highest)
                            {
                                highest = num_char;
                            }


             }

                        Console.WriteLine(highest*2);

            */

            /*
           string s = ")(())(()()))(";



                       //Console.WriteLine(s);

                       int final_higher = 0;
                       int r = 0;
                       while (r <= 1) {

                           List<char> chars = s.ToList();

                           int i_ = 0;
                           while (i_ < s.Length)
                           {

                               if (chars[0] == '(')
                               {

                                   break;
                               }

                               chars.RemoveAt(0);







                               i_++;



                           }

                           Console.WriteLine(chars.Count);




                           // remove close parenthesis beginning
                           // remove open parenthesis last

                           int open = 0;
                           int higher = 0;

                           List<int> my_array = new List<int>();
                           List<int> my_index = new List<int>();

                           for (int i = 0; i < chars.Count; i++)
                           {
                               if (chars[i] == '(')
                               {
                                   if (i == 0)
                                   {
                                       my_array.Add(0);
                                       my_index.Add(i);
                                   }
                                   else if (chars[i - 1] == ')') {
                                       my_array.Add(0);
                                       my_index.Add(i);
                                   }

                                   my_array[my_array.Count - 1] = my_array[my_array.Count - 1] + 1;

                               }

                               if (chars[i] == ')')
                               {

                                   my_array[my_array.Count - 1] = my_array[my_array.Count - 1] - 1;




                               }

                           }



                           List<int> final = new List<int>();
                           List<int> final_index = new List<int>();
                           bool stop = false;
                           int index = -1;

                           for (int i = 0; i < my_array.Count; i++)
                           {

                               if (!stop)
                               {
                                   if (my_array[i] >= 0)
                                   {
                                       stop = true;
                                   }
                                   final.Add(Math.Abs(my_array[i]));
                                   final_index.Add(Math.Abs(my_index[i]));
                                   index++;
                                   //stop = true;

                               }
                               else
                               {
                                   if (my_array[i] > 0)
                                   {
                                       final.Add(Math.Abs(my_array[i]));
                                       final_index.Add(Math.Abs(my_index[i]));
                                       index++;
                                   }

                                   else {
                                       int sum = my_array[index];


                                       for (int j = index + 1; j <= i; j++)
                                       {

                                           if (sum >= Math.Abs(my_array[j]))
                                           {


                                           }
                                           else
                                           {
                                               stop = false;

                                           }
                                           sum = sum + my_array[j];
                                           final[final.Count - 1] = Math.Abs(sum);

                                       }
                                   }
                               }




                           }



                           Console.WriteLine("");

                           for (int i = 0; i < my_index.Count; i++)
                           {
                               Console.WriteLine(my_array[i]);
                           }


                           Console.WriteLine("");



                           for (int i = 0; i < final.Count; i++)
                           {
                               //Console.WriteLine(final[i]);
                               int count = 0;
                               if (i != final.Count - 1)
                               {
                                   for (int j = final_index[i]; j < final_index[i + 1]; j++)
                                   {
                                       count++;
                                   }
                               }
                               else
                               {
                                   for (int j = final_index[i]; j < chars.Count; j++)
                                   {
                                       count++;
                                   }
                               }

                               int sum = count - final[i];

                               if (sum > higher)
                               {
                                   higher = sum;
                               }

                           }



                           char[] charArray = s.ToCharArray();
                           List<char> char_array = new List<char>();

                           for (int i = charArray.Length - 1; i >= 0; i--)
                           {
                               if (charArray[i] == '(')
                               {
                                   char_array.Add(')');
                               }
                               else
                               {
                                   char_array.Add('(');
                               }
                           }

                           string reversedString = new string(char_array.ToArray());

                           s = reversedString;

                           r++;



                           if (higher > final_higher)
                           {
                               final_higher = higher;
                           }



                       }




                       Console.WriteLine(final_higher);


                       */


            //string s = ")(()(()(((())(((((()()))((((()()(()()())())())()))()()()())(())()()(((()))))()((()))(((())()((()()())((())))(())))())((()())()()((()((())))))((()(((((()((()))(()()(())))((()))()))())";
            string s = "(()";
            char[] chars = s.ToCharArray();

            List<int> change = new List<int>();
           

            for (int i=0; i<chars.Length;i++)
            {
                
                if (chars[i] == ')')
                {
                    
                    if (change.Count >0)
                    {
                        
                        bool has_open = true;
                        for (int j=i-1; j>=0; j--)
                        {
                            
                            if (change[j] == 0)
                            {

                                
                                if (chars[j] == '(')
                                {
                                    has_open = false;
                                    change[j] = 1;
                                    
                                }
                                
                                break;
                            }
                        }

                        bool has_close = true;
                        for (int j=0; j<=i; j++)
                        {
                            if (chars[j] == '(')
                            {
                                has_close = false;
                                break;
                            }
                        }

                        if (has_close || has_open)
                        {
                            change.Add(0);
                        }
                        else
                        {
                            change.Add(1);
                        }
                        

                    }
                    else
                    {
                        change.Add(0);
                    }

                    

                }
                if (chars[i] == '(')
                {
                    change.Add(0);
                }
            }
            for (int i = 0; i < change.Count; i++)
            {

                Console.WriteLine(change[i]);
            }


            Console.WriteLine();

            int higher = 0;
            int count = 0;
            for (int i=0;i<change.Count; i++)
            {

                if (change[i] == 1)
                {
                    count++;
                }
                else
                {
                    
                    count = 0;
                }
                if (count > higher)
                {
                    higher = count;
                }
            }

            Console.WriteLine(higher);
            

            //red
            //green


        }
}
}
