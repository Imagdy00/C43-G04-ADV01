namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 1

            //            using System;

            //class Program
            //        {
            //            static void Swap<T>(ref T a, ref T b)
            //            {
            //                T temp = a;
            //                a = b;
            //                b = temp;
            //            }

            //            static void Main()
            //            {
            //                int x = 5, y = 10;
            //                Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            //                Swap(ref x, ref y);
            //                Console.WriteLine($"After Swap: x = {x}, y = {y}");

            //                string str1 = "Hello", str2 = "World";
            //                Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
            //                Swap(ref str1, ref str2);
            //                Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
            //            }
            //        }

            #endregion


            #region Video 2

            //            using System;

            //class Program
            //        {
            //            static int LinearSearch<T>(T[] array, T key) where T : IEquatable<T>
            //            {
            //                for (int i = 0; i < array.Length; i++)
            //                {
            //                    if (array[i].Equals(key))
            //                        return i;
            //                }
            //                return -1;
            //            }

            //            static void Main()
            //            {
            //                int[] numbers = { 1, 2, 3, 4, 5 };
            //                int index = LinearSearch(numbers, 3);
            //                Console.WriteLine($"Index of 3: {index}");

            //                string[] words = { "apple", "banana", "cherry" };
            //                index = LinearSearch(words, "banana");
            //                Console.WriteLine($"Index of 'banana': {index}");
            //            }
            //        }

            #endregion


            #region Video 3
            //            using System;

            //struct Point : IEquatable<Point>
            //        {
            //            public int X { get; set; }
            //            public int Y { get; set; }

            //            public bool Equals(Point other)
            //            {
            //                return X == other.X && Y == other.Y;
            //            }

            //            public override bool Equals(object obj)
            //            {
            //                if (obj is Point other)
            //                    return Equals(other);
            //                return false;
            //            }

            //            public override int GetHashCode()
            //            {
            //                return HashCode.Combine(X, Y);
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                Point p1 = new Point { X = 1, Y = 2 };
            //                Point p2 = new Point { X = 1, Y = 2 };
            //                Console.WriteLine(p1.Equals(p2)); // True
            //            }
            //        }

            #endregion


            #region Video 4

            //            using System;

            //class Program
            //        {
            //            static void BubbleSort<T>(T[] array) where T : IComparable<T>
            //            {
            //                for (int i = 0; i < array.Length - 1; i++)
            //                {
            //                    for (int j = 0; j < array.Length - i - 1; j++)
            //                    {
            //                        if (array[j].CompareTo(array[j + 1]) > 0)
            //                        {
            //                            T temp = array[j];
            //                            array[j] = array[j + 1];
            //                            array[j + 1] = temp;
            //                        }
            //                    }
            //                }
            //            }

            //            static void Main()
            //            {
            //                int[] numbers = { 5, 3, 8, 1, 2 };
            //                BubbleSort(numbers);
            //                Console.WriteLine(string.Join(", ", numbers));
            //            }
            //        }


            #endregion


            #region Video 5
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                object obj = "Hello";

            //                if (obj is string str)
            //                {
            //                    Console.WriteLine($"String length: {str.Length}");
            //                }

            //                obj = null;
            //                string result = obj as string;
            //                Console.WriteLine(result ?? "obj is not a string");
            //            }
            //        }

            #endregion



            #region Video 6
            //            using System;
            //            using System.Collections.Generic;

            //class Student : IComparable<Student>
            //        {
            //            public string Name { get; set; }
            //            public int Grade { get; set; }

            //            public int CompareTo(Student other)
            //            {
            //                return Grade.CompareTo(other.Grade);
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                List<Student> students = new List<Student>
            //        {
            //            new Student { Name = "Alice", Grade = 90 },
            //            new Student { Name = "Bob", Grade = 85 },
            //            new Student { Name = "Charlie", Grade = 95 }
            //        };

            //                students.Sort();
            //                foreach (var student in students)
            //                {
            //                    Console.WriteLine($"{student.Name}: {student.Grade}");
            //                }
            //            }
            //        }

            #endregion



            #region Video 7

            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                // Similar to Example 03
            //            }
            //        }

            #endregion



            #region Video 8
            //            using System;
            //            using System.Collections.Generic;

            //class CaseInsensitiveComparer : IEqualityComparer<string>
            //        {
            //            public bool Equals(string x, string y)
            //            {
            //                return string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
            //            }

            //            public int GetHashCode(string obj)
            //            {
            //                return obj.ToLower().GetHashCode();
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                HashSet<string> set = new HashSet<string>(new CaseInsensitiveComparer());
            //                set.Add("hello");
            //                set.Add("HELLO");

            //                Console.WriteLine(set.Count); // 1
            //            }
            //        }

            #endregion


            #region Video 9
//            using System;
//            using System.Collections.Generic;

//class Program
//        {
//            static void BubbleSort<T>(T[] array, IComparer<T> comparer)
//            {
//                for (int i = 0; i < array.Length - 1; i++)
//                {
//                    for (int j = 0; j < array.Length - i - 1; j++)
//                    {
//                        if (comparer.Compare(array[j], array[j + 1]) > 0)
//                        {
//                            T temp = array[j];
//                            array[j] = array[j + 1];
//                            array[j + 1] = temp;
//                        }
//                    }
//                }
//            }

//            class DescendingComparer : IComparer<int>
//            {
//                public int Compare(int x, int y)
//                {
//                    return y.CompareTo(x);
//                }
//            }

//            static void Main()
//            {
//                int[] numbers = { 5, 3, 8, 1, 2 };

//                Console.WriteLine("Original Array: " + string.Join(", ", numbers));

//                BubbleSort(numbers, Comparer<int>.Default);
//                Console.WriteLine("Ascending Order: " + string.Join(", ", numbers));

//                BubbleSort(numbers, new DescendingComparer());
//                Console.WriteLine("Descending Order: " + string.Join(", ", numbers));
//            }
//        }

        #endregion


        #region Video 10
        //            using System;

        //class Program
        //        {
        //            static void Print<T>(T obj) where T : class
        //            {
        //                Console.WriteLine(obj?.ToString());
        //            }

        //            static void Main()
        //            {
        //                Print("Hello");
        //            }
        //        }

        #endregion




    }
}
}
