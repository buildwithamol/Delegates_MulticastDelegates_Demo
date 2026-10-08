namespace Delegates_MulticastDelegates_Demo
{
    //Simple Delegate Demo.

    delegate int DelegateAdd(int a,int b);
    internal class Program
    {

        static void Main(string[] args)
        {
            DelegateAdd objdelagateAdd = add ;
                        objdelagateAdd += sub ;


            int res =  objdelagateAdd.Invoke(15, 3);

            foreach (DelegateAdd d in objdelagateAdd.GetInvocationList())
            {
                int result = d(15, 3);
                Console.WriteLine($"{d.Method.Name} result = {result}");
            }
            // Console.WriteLine(res);
        }

        static int add(int x, int y)
        {
            return x + y;
        }

        static int sub(int x, int y)
        {
            return x - y;
        }
    }
}
