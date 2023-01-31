//jagged Array
using System;

class p13{
    static void Main(String[] args){

        int[][] jagged_arr = new int[4][];
        jagged_arr[0] = new int[4] { 1, 2, 3, 4 };
        jagged_arr[1] = new int[3] { 1, 2, 3 };
        jagged_arr[2] = new int[2] { 11, 22 };
        jagged_arr[3] = new int[4] { 5, 6, 7, 8 };

        for (int i = 0; i < jagged_arr.Length; i++){

            Console.Write("Row({0}) : ", i);

            for (int j = 0; j < jagged_arr[i].Length; j++){

                Console.Write(jagged_arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
