using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ParallelSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Напишите десктопное приложение в котором параллельно выполняются три различных алгоритма сортировки. На C#
        Размер массива задает пользователь.
        Массив заполняется случайными числами из заданного пользователем диапазона.
        Все алгоритмы должны сортировать один и тот же набор данных.
        Можно просмотреть значения элементов исходного массива и отсортированного (для отображения использовать listBox).
        Сразу после окончания сортировки на форму должно быть выведено соответствующее сообщение (отдельно для каждого алгоритма).
        Для реализации можно использовать класс Tread.
        Для каждого алгоритма вывести количество сравнений и перестановок, а также затраченное время.*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Получение размера массива из numericUpDown
            int arraySize = (int)numericUpDown1.Value;

            // Генерация массива случайных чисел
            Random random = new Random();
            int[] randomNumbers = new int[arraySize];
            int[] randomNumbers2 = new int[arraySize];
            int[] randomNumbers3 = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                int rnd = random.Next(0, 100);// Генерация случайных чисел от 0 до 100
                randomNumbers[i] = rnd;
                randomNumbers2[i] = rnd;
                randomNumbers3[i] = rnd;
            }

            // Очистка ListBox перед добавлением новых элементов
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();

            // Добавление элементов массива в listView1
            foreach (var number in randomNumbers)
            {
                listView1.Items.Add(number.ToString());
                //listView2.Items.Add(number.ToString());
                //listView3.Items.Add(number.ToString());
                //listView4.Items.Add(number.ToString());
            }


            Thread bubbleSortThread = new Thread(() => BubbleSort(randomNumbers, BubbleLabel, BubbleLabelTime));
            bubbleSortThread.Start();

            Thread QuickSortThread = new Thread(() => QuickSort(randomNumbers2, QuickLabel, QuickLabelTime));
            QuickSortThread.Start();

            Thread InsertionSortThread = new Thread(() => InsertionSort(randomNumbers3, InsertLabel, InsertLabelTime));
            InsertionSortThread.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           

        }
        private void UpdateLabelSafe(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => label.Text = text));
            }
            else
            {
                label.Text = text;
            }
        }
        private void UpdatelistViewSafe(ListView listView, int[] Numbers)
        {
            if (listView.InvokeRequired)
            {
                foreach (var number in Numbers)
                {

                    listView.Invoke(new Action(() => listView.Items.Add(number.ToString())));
                }
            }
            else
            {
                foreach (var number in Numbers)
                {
                    listView.Items.Add(number.ToString());
                }
            }
        }
        public void BubbleSort(int[] randomNumbers, Label BubbleLabel, Label BubbleLabelTime)
        {
            int n = randomNumbers.Length;
            int comparisonCount = 0; // Для подсчета количества сравнений
            int swapCount = 0; // Для подсчета количества обменов
            Stopwatch stopwatch = new Stopwatch(); // Таймер для измерения времени выполнения

            stopwatch.Start();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    comparisonCount++; // Увеличиваем счетчик сравнений
                    if (randomNumbers[j] > randomNumbers[j + 1])
                    {
                        // Меняем элементы местами
                        int temp = randomNumbers[j];
                        randomNumbers[j] = randomNumbers[j + 1];
                        randomNumbers[j + 1] = temp;
                        swapCount++; // Увеличиваем счетчик обменов
                    }
                }
            }

            stopwatch.Stop();

            // Выводим результаты
            UpdateLabelSafe(BubbleLabel, $"Сравнений: {comparisonCount}, Обменов: {swapCount}");
            UpdateLabelSafe(BubbleLabelTime, $"Время: {stopwatch.ElapsedMilliseconds} мс");
            UpdatelistViewSafe(listView2, randomNumbers);
        }

        public void QuickSort(int[] randomNumbers, Label QuickLabel, Label QuickLabelTime)
        {
            int comparisonCount = 0; // Для подсчета количества сравнений
            int swapCount = 0; // Для подсчета количества обменов
            Stopwatch stopwatch = new Stopwatch(); // Таймер для измерения времени выполнения

            stopwatch.Start();
            QuickSortHelper(randomNumbers, 0, randomNumbers.Length - 1, ref comparisonCount, ref swapCount);
            stopwatch.Stop();

            // Выводим результаты
            UpdateLabelSafe(QuickLabel, $"Сравнений: {comparisonCount}, Обменов: {swapCount}");
            UpdateLabelSafe(QuickLabelTime, $"Время: {stopwatch.ElapsedMilliseconds} мс");
            UpdatelistViewSafe(listView3, randomNumbers);
        }

        private void QuickSortHelper(int[] array, int low, int high, ref int comparisonCount, ref int swapCount)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high, ref comparisonCount, ref swapCount);
                QuickSortHelper(array, low, pivot - 1, ref comparisonCount, ref swapCount);
                QuickSortHelper(array, pivot + 1, high, ref comparisonCount, ref swapCount);
            }
        }

        private int Partition(int[] array, int low, int high, ref int comparisonCount, ref int swapCount)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                comparisonCount++;
                if (array[j] < pivot)
                {
                    i++;
                    swapCount++;
                    Swap(ref array[i], ref array[j]);
                }
            }
            swapCount++;
            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void InsertionSort(int[] randomNumbers, Label InsertLabel, Label InsertLabelTime)
        {
            int comparisonCount = 0; // Для подсчета количества сравнений
            int swapCount = 0; // Для подсчета количества обменов
            Stopwatch stopwatch = new Stopwatch(); // Таймер для измерения времени выполнения

            stopwatch.Start();

            for (int i = 1; i < randomNumbers.Length; i++)
            {
                int current = randomNumbers[i];
                int j = i - 1;

                // Перемещаем элементы randomNumbers[0..i-1], которые больше, чем current,
                // на одну позицию вперед от их текущего положения
                while (j >= 0 && randomNumbers[j] > current)
                {
                    comparisonCount++;
                    randomNumbers[j + 1] = randomNumbers[j];
                    j--;
                    swapCount++;
                }
                randomNumbers[j + 1] = current;
            }

            stopwatch.Stop();

            // Выводим результаты
            UpdateLabelSafe(InsertLabel, $"Сравнений: {comparisonCount}, Обменов: {swapCount}");
            UpdateLabelSafe(InsertLabelTime, $"Время: {stopwatch.ElapsedMilliseconds} мс");
            UpdatelistViewSafe(listView4, randomNumbers);
        }

        /*
        Напишите реализацию параллельного алгоритма умножения матриц с использованием класса Task.
        Приложение должно иметь графический пользовательский интерфейс.
        Размерность матриц задает пользователь.
        На форме отображаются начальные матрицы и результат их перемножения.
        В приложение реализованы параллельный и последовательный алгоритмы умножения матриц.
        После выполнения умножения на форме отображается потраченное время.
        Можно сравнить скорость выполнения последовательного и параллельного алгоритмов.
        */

        private int[,] matrixA;
        private int[,] matrixB;
        private void button2_Click(object sender, EventArgs e)
        {

            // Создание и отображение матрицы A
            CreateAndDisplayMatrix(matrixAnumeric1, matrixAnumeric2, richTextBoxA, out matrixA);

            // Создание и отображение матрицы B
            CreateAndDisplayMatrix(matrixBnumeric1, matrixBnumeric2, richTextBoxB, out matrixB);
        }

        private void CreateAndDisplayMatrix(NumericUpDown numericUpDownRows, NumericUpDown numericUpDownCols, RichTextBox richTextBox, out int[,] matrix)
        {
            int rows = (int)numericUpDownRows.Value;
            int cols = (int)numericUpDownCols.Value;
            Random random = new Random();
            StringBuilder matrixString = new StringBuilder();

            // Инициализация матрицы
            matrix = new int[rows, cols];

            // Генерация и заполнение матрицы
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                    matrixString.Append(matrix[i, j] + "\t");
                }
                matrixString.AppendLine();
            }

            // Отображение в RichTextBox
            richTextBox.Text = matrixString.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                MessageBox.Show("Невозможно умножить матрицы: количество столбцов первой матрицы не равно количеству строк второй матрицы.");
                return;
            }

            // Последовательное умножение
            var stopwatch = Stopwatch.StartNew();
            var resultSequential = SequentialMatrixMultiply(matrixA, matrixB);
            stopwatch.Stop();
            long sequentialTime = stopwatch.ElapsedMilliseconds;

            // Параллельное умножение
            stopwatch.Restart();
            var resultParallel = ParallelMatrixMultiply(matrixA, matrixB);
            stopwatch.Stop();
            long parallelTime = stopwatch.ElapsedMilliseconds;

            // Вывод результата и времени
            DisplayMatrix(resultParallel, richTextBoxResult); // Можно отобразить resultSequential для сравнения
            label12.Text = $"Последовательное: {sequentialTime} мс, Параллельное: {parallelTime} мс";

        }
        private int[,] SequentialMatrixMultiply(int[,] A, int[,] B)
        {
            int aRows = A.GetLength(0);
            int aCols = A.GetLength(1);
            int bCols = B.GetLength(1);
            var result = new int[aRows, bCols];

            for (int i = 0; i < aRows; i++)
            {
                for (int j = 0; j < bCols; j++)
                {
                    for (int k = 0; k < aCols; k++)
                    {
                        result[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return result;
        }

        private int[,] ParallelMatrixMultiply(int[,] A, int[,] B)
        {
            int aRows = A.GetLength(0);
            int bCols = B.GetLength(1);
            var result = new int[aRows, bCols];
            //Parallel.For, который является частью TPL (Task Parallel Library) и обеспечивает параллельное выполнение, но не использует класс Task напрямую.
            Parallel.For(0, aRows, i =>
            {
                for (int j = 0; j < bCols; j++)
                {
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        result[i, j] += A[i, k] * B[k, j];
                    }
                }
            });

            return result;
        }

        private void DisplayMatrix(int[,] matrix, RichTextBox richTextBox)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    builder.Append(matrix[i, j] + "\t");
                }
                builder.AppendLine();
            }

            richTextBox.Text = builder.ToString();
        }

       
    }
}


 
