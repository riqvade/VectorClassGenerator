using System;

namespace VectorClassGenerator
{
    internal class Vector
    {
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        private double X { get; }
        private double Y { get; }
        private double Z { get; }


        /// <summary>
        /// Возвращает длину вектора
        /// </summary>
        public double Length()
        {
            int degree = 2;

            return Math.Sqrt(Math.Pow(X, degree) + Math.Pow(Y, degree) + Math.Pow(Z, degree));
        }

        /// <summary>
        /// Возвращает скалярное произведение двух векторов
        /// </summary>
        public double ScalarProduct(Vector vector)
        {
            return X * vector.X + Y * vector.Y + Z * vector.Z;
        }

        /// <summary>
        /// Возвращает векторное произведение с другим вектором
        /// </summary>
        public Vector СrossProductWithDifferentVector(Vector vector)
        {
            return new Vector(Y * vector.Z - Z * vector.Y, Z * vector.X - X * vector.Z, X * vector.Y - Y * vector.X);
        }

        /// <summary>
        /// Возвращает угол между векторами
        /// </summary>
        public double Cos(Vector vector)
        {
            return ScalarProduct(vector) / (Length() * vector.Length());
        }

        /// <summary>
        /// Возвращает сумму векторов
        /// </summary>
        public Vector Sum(Vector vector)
        {
            return new Vector(X + vector.X, Y + vector.Y, Z + vector.Z);
        }

        /// <summary>
        /// Возвращает разность векторов
        /// </summary>
        public Vector Difference(Vector vector)
        {
            return new Vector(X - vector.X, Y - vector.Y, Z - vector.Z);
        }

        /// <summary>
        /// Возвращает массив векторов.
        /// </summary>
        /// <param name="number">Колличество генерируемых векторов.</param>
        /// <param name="minRandomСoordinateValue">Минимальное генерируемое значение координаты вектора.</param>
        /// <param name="maxRandomСoordinateValue">Максимальное генерируемое значение координаты вектора.</param>
        public static Vector[] CreateVectors(int number = 2, int minRandomСoordinateValue = 0, int maxRandomСoordinateValue = 100)
        {
            Random random = new Random();
            Vector[] vectors = new Vector[number];
            for(int i = 0; i < number; i++)
            {
                vectors[i] = new Vector(random.Next(minRandomСoordinateValue, maxRandomСoordinateValue),
                    random.Next(minRandomСoordinateValue, maxRandomСoordinateValue),
                    random.Next(minRandomСoordinateValue, maxRandomСoordinateValue));
            }

            return vectors;
        }
        
        public override string ToString()
        {
            return $"Vector: x = {X}, y = {Y}, z = {Z}";
        }
    }
}
