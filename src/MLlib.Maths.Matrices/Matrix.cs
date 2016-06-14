namespace MLlib.Maths.Matrices
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Matrix
    {
        public Matrix(int rowLength, int columnLength)
        {
            RowLength = rowLength;
            ColumnLength = columnLength;
            MatrixElementArray = new int[rowLength, columnLength];
            ZeroInit();
        }


        public void ZeroInit()
        {
            for (var rowIndex = 0; rowIndex < RowLength + 1; rowIndex++)
            {
                if (MatrixElementArray != null) MatrixElementArray[rowIndex, columnIndex] = 0;
            }
        }

        public void IdentityInit()
        {
            
        }
        public void RandomInit()
        {
            
        }

        public void Transpose()
        {
            
        }


        public Matrix GetSubMatrix()
        {
            return new Matrix(1,1);
        }

        public int GetValueAt(int row, int column)
        {
            return 0;
        }

        public int SetValueAt(int row, int column)
        {
            return 0;
        }            

        public int RowLength { get; }
        public int ColumnLength { get; }

        public int[,] MatrixElementArray { get; set; }
    }


}
