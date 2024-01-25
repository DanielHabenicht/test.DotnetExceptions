using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    public class ExceptionOrNot
    {
        private const int N = 10000;

        static void TestExceptions()
        {
            throw new Exception("Failed");
        }

        static void TestExceptionsLevel1()
        {
            TestExceptions();
        }

        
        static void TestExceptionsLevel2()
        {
            TestExceptionsLevel1();
        }

        static void TestExceptionsLevel3()
        {
            TestExceptionsLevel2();
        }


        static int CatchTestExceptionsLevel1()
        {
            try
            {
                TestExceptionsLevel1();
            }
            catch (Exception)
            {
                // Do nothing
            }
            return 1;  
        }

        static int CatchTestExceptionsLevel2()
        {
            try
            {
                TestExceptionsLevel2();
            }
            catch (Exception)
            {
                // Do nothing
            }
            return 1; 
        }

        static int CatchTestExceptionsLevel3()
        {
            try
            {
                TestExceptionsLevel2();
            }
            catch (Exception)
            {
                // Do nothing
            }
            return 1; 
        }



        static int CatchTestExceptions()
        {
            try
            {
                TestExceptions();
            }
            catch (Exception)
            {
                // Do nothing
            }
            return 1;  
        }

        static int TestReturnCodes()
        {
            return 1;
        }

        public ExceptionOrNot()
        {
            
        }

        [Benchmark]
        public void CatchedExceptions() => CatchTestExceptions();

        [Benchmark]
        public void CatchedTestExceptionsLevel1() => CatchTestExceptionsLevel1();

        [Benchmark]
        public void CatchedTestExceptionsLevel2() => CatchTestExceptionsLevel2();
        public void CatchedTestExceptionsLevel3() => CatchTestExceptionsLevel3();

        [Benchmark]
        public void NoException() => TestReturnCodes();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ExceptionOrNot>();
        }
    }
}