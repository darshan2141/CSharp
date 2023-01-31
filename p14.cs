namespace ConsoleApp1{
    internal class p14{
        class test{
            public int a, b;
            public test(){
                a = b = 0;
            }
            public test(int a, int b){
                this.a = a;
                this.b = b;
            }
            public static test operator +(test m1, test m2){
                test m3 = new test();
                m3.a = m1.a + m2.a;
                m3.b = m1.b + m2.b;
                return m3;
            }
            public static test operator *(test m1, test m2){
                test m3 = new test();
                m3.a = m1.a * m2.a;
                m3.b = m1.b * m2.b;
                return m3;
            }
            public static bool operator ==(test m1, test m2){
                return ((m1.a == m2.a) && (m1.b == m2.b));
            }
            public static bool operator !=(test m1, test m2){
                return ((m1.a != m2.a) && (m1.b != m2.b));
            }
            public static bool operator >(test m1, test m2){
                return ((m1.a + m2.a) > (m1.b + m2.b));
            }
            public static bool operator <(test m1, test m2){
                return ((m1.a + m2.a) < (m1.b + m2.b));
            }
        }
        static void Main(string[] args){
            test m1 = new test(20, 40);
            test m2 = new test(5, 6);
            test m3 = new test();

            m3 = m1 + m2;

            Console.WriteLine("Value of A is : " + m3.a);
            Console.WriteLine("Value of B is : " + m3.b);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Multiplication");
            Console.WriteLine("-----------------------");

            m3 = m1 * m2;

            Console.WriteLine("Value of A is : " + m3.a);
            Console.WriteLine("Value of B is : " + m3.b);

            bool ans;

            ans = m1 == m2;
            Console.WriteLine("Value of Ans with == is : " + ans);

            ans = m1 != m2;
            Console.WriteLine("Value of Ans with != is : " + ans);

            ans = m1 > m2;
            Console.WriteLine("Value of Ans with > is : " + ans);

            ans = m1 < m2;
            Console.WriteLine("Value of Ans with < is : " + ans);
        }
    }
}

