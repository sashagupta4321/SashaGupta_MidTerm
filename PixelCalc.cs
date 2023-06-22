using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework
{
    public static class PixelCalc
    {
        public static void EnterScreenDimensions()
        {
            int width, height, diagonal;

            Console.Write("Enter Screen width (in pixels): ");
            if (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid input for width. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter Screen height (in pixels): ");
            if (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input for height. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter Diagonal size (in inches): ");
            if (!int.TryParse(Console.ReadLine(), out diagonal))
            {
                Console.WriteLine("Invalid input for Diagonal. Please enter a valid integer.");
                return;
            }

            int diagonalPixels = CalculateDiagonalPixels(width, height, diagonal);
            double ppi = CalculatePPI(width, height, diagonalPixels);
            double dotPitch = CalculateDotPitch(width, height, diagonalPixels);

            Console.WriteLine("PPI: " + ppi);
            Console.WriteLine("Diagonal (in pixels): " + diagonalPixels);
            Console.WriteLine("Dot pitch: " + dotPitch);
        }

        private static int CalculateDiagonalPixels(int width, int height, int diagonal)
        {
            double diagonalPixelsSquared = Math.Pow(width, 2) + Math.Pow(height, 2);
            double diagonalPixels = Math.Sqrt(diagonalPixelsSquared);
            return (int)Math.Round(diagonalPixels);
        }

        private static double CalculatePPI(int width, int height, int diagonalPixels)
        {
            double diagonalInches = diagonalPixels / (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));
            return diagonalPixels / diagonalInches;
        }

        private static double CalculateDotPitch(int width, int height, int diagonalPixels)
        {
            double diagonalInches = diagonalPixels / (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));
            return diagonalInches / Math.Sqrt(width * width + height * height);
        }
    }
}
