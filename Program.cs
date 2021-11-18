using System;

namespace VectorClassGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = Vector.CreateVectors(2, 0, 100);

            Console.WriteLine($"Вектор 1: {vectors[0]}");
            Console.WriteLine($"Вектор 2: {vectors[1]}");
            Console.WriteLine($"Длина вектора 1: {vectors[0].Length()}");
            Console.WriteLine($"Длина вектора 2: {vectors[1].Length()}");

            Console.WriteLine($"Скалярное произведение двух векторов: {vectors[0].ScalarProduct(vectors[1])}");
            Console.WriteLine($"Произведение векторов: {vectors[0].СrossProductWithDifferentVector(vectors[1])}");
            Console.WriteLine($"Угол между векторами: {vectors[0].Cos(vectors[1])}");
            Console.WriteLine($"Сумма векторов: {vectors[0].Sum(vectors[1])}");
            Console.WriteLine($"Разность векторов: {vectors[0].Difference(vectors[1])}");
        }
    }
}
