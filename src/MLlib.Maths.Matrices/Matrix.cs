using System;

namespace MLlib
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Matrix
    {
        public Matrix(int rowLength, int columnLength)
        {
            if (rowLength < 1 || columnLength < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            RowLength = rowLength;
            ColumnLength = columnLength;
            MatrixElementArray = new double[rowLength, columnLength];
            ZeroInit();
        }


        public void ZeroInit()
        {
            for (var columnIndex = 0; columnIndex < ColumnLength + 1; columnIndex++)
            {
                for (var rowIndex = 0; rowIndex < RowLength + 1; rowIndex++)
                {
                    MatrixElementArray[rowIndex, columnIndex] = 0;
                }
            }
        }

        public void IdentityInit()
        {
            for (var columnIndex = 0; columnIndex < ColumnLength + 1; columnIndex++)
            {
                for (var rowIndex = 0; rowIndex < RowLength + 1; rowIndex++)
                {
                    if (rowIndex == columnIndex)
                    {
                        MatrixElementArray[rowIndex,columnIndex] = 1;
                    }
                    else
                    {
                        MatrixElementArray[rowIndex, columnIndex] = 0;
                    }
                }
            }

        }
        public void RandomInit()
        {
            var randomNumberGenerator = new Random();
            for (var columnIndex = 0; columnIndex < ColumnLength + 1; columnIndex++)
            {
                for (var rowIndex = 0; rowIndex < RowLength + 1; rowIndex++)
                {
                    var number = randomNumberGenerator.Next(-100, 100) / 100;
                    MatrixElementArray[rowIndex, columnIndex] = number;
                }
            }
        }

        public Matrix GetTranspose()
        {
            var transposedMatrix = new Matrix(ColumnLength, RowLength);

            for (var columnIndex = 0; columnIndex < transposedMatrix.ColumnLength + 1; columnIndex++)
            {
                for (var rowIndex = 0; rowIndex < transposedMatrix.RowLength + 1; rowIndex++)
                {
                    transposedMatrix.MatrixElementArray[rowIndex, columnIndex] = this.MatrixElementArray[columnIndex, rowIndex];
                }
            }

            return transposedMatrix;
        }


        public Matrix GetSubMatrix(int rowRange, int columnRange)
        {
            return new Matrix(rowRange,columnRange);
        }

        public void SetSubMatrix(int rowRange, int columnRange)
        {

        }

        public double GetValueAt(int row, int column)
        {
            return MatrixElementArray[row, column];
        }

        public void SetValueAt(int row, int column, double value)
        {
            MatrixElementArray[row, column] = value;
        }


        public int RowLength { get; }
        public int ColumnLength { get; }
        public double[,] MatrixElementArray { get; set; }
    }


}
