using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace tetrisWPF
{
    class background : shape
    {
        public Label[,] foneMatrix;
        public Label[,] prevMatrix;
        bool isBottom = false;
        bool loose = false;
        int VerticalRange;
        int HorizontalRange;
        int VePoint = 0;
        int HoPoint;
        int currentScore = 0;
        int currentCentre = 9; // кол-во шагов матрицы фигуры в сторону от центра матрицы фона
        int stepDown; // кол-во шагов данной фигуры вниз от точки появления
        Thickness th = new Thickness(0.1, 0.1, 0.1, 0.1);
        Brush figureBackgroundColor;

        // конструктор
        public background(Grid gameSpace, Grid previewSpace)
        {
            VerticalRange = gameSpace.RowDefinitions.Count;
            HorizontalRange = gameSpace.ColumnDefinitions.Count;
            Random rand = new Random();
            stepDown = 1;
            ShapeMassive = shapeType(rand.Next(7)); // определение типа и создание массива первой фигуры

            // создание матрицы фона
            foneMatrix = new Label[VerticalRange, HorizontalRange];
            for (int i = 0; i < VerticalRange; ++i)
            {
                for (int j = 0; j < HorizontalRange; ++j)
                {
                    foneMatrix[i, j] = new Label();
                    Grid.SetRow(foneMatrix[i, j], i);
                    Grid.SetColumn(foneMatrix[i, j], j);
                    gameSpace.Children.Add(foneMatrix[i, j]);
                }
            }
            // создание матрицы превью
            PrevShapeMassive = prevShapeType(rand.Next(7)); // определение типа и создание массива первого превью
            prevMatrix = new Label[previewSpace.RowDefinitions.Count, previewSpace.ColumnDefinitions.Count];
            for (int i = 0; i < previewSpace.RowDefinitions.Count; ++i)
            {
                for (int j = 0; j < previewSpace.ColumnDefinitions.Count; ++j)
                {
                    prevMatrix[i, j] = new Label();
                    Grid.SetRow(prevMatrix[i, j], i);
                    Grid.SetColumn(prevMatrix[i, j], j);
                    previewSpace.Children.Add(prevMatrix[i, j]);
                }
            }
        }

        // обновление матрицы фигуры в превью
        public void copyShapeToPreview(Array s, Label[,] prevMatrix)
        {
            // очистка матрицы превью от предыдущей фигуры
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    prevMatrix[i, j].Background = Brushes.Transparent;
                    prevMatrix[i, j].BorderBrush = Brushes.Transparent;
                    prevMatrix[i, j].BorderThickness = th;
                }
            }
            // копирование фигуры в превью
            int VePointPrev = 1;
            int HoPointPrev = 1;
            foreach (int i in s)
            {
                if (i == 1)
                    prevMatrix[(VePointPrev - 1), (HoPointPrev - 1)].Background = FigureBackgroundColor;
                if (i == 2)
                    prevMatrix[(VePointPrev - 1), (HoPointPrev)].Background = FigureBackgroundColor;
                if (i == 3)
                    prevMatrix[(VePointPrev - 1), (HoPointPrev + 1)].Background = FigureBackgroundColor;
                if (i == 4)
                    prevMatrix[(VePointPrev), (HoPointPrev - 1)].Background = FigureBackgroundColor;
                if (i == 5)
                    prevMatrix[(VePointPrev), (HoPointPrev)].Background = FigureBackgroundColor;
                if (i == 6)
                    prevMatrix[(VePointPrev), (HoPointPrev + 1)].Background = FigureBackgroundColor;
                if (i == 7)
                    prevMatrix[(VePointPrev + 1), (HoPointPrev - 1)].Background = FigureBackgroundColor;
                if (i == 8)
                    prevMatrix[(VePointPrev + 1), HoPointPrev].Background = FigureBackgroundColor;
                if (i == 9)
                    prevMatrix[(VePointPrev + 1), (HoPointPrev + 1)].Background = FigureBackgroundColor;
            }
        }

        // обновление состояния матрицы фигуры в фоне и проверка достижения дна
        public void copyShapeToFone(Array s, Label[,] f)
        {
            // очистка матрицы фона от следов движения предыдущей фигуры
            for (int i = 0; i < VerticalRange; ++i)
            {
                for (int j = 0; j < HorizontalRange - 1; ++j)
                {
                    if (f[i, j].Name != "stop")
                    {
                        f[i, j].Background = Brushes.Transparent;
                        f[i, j].BorderThickness = th;
                        f[i, j].BorderBrush = Brushes.Black;
                        f[i, j].Name = "empty";
                    }
                }
            }

            // копирование матрицы фигуры в фон с учетом движений
            VePoint = stepDown;
            HoPoint = currentCentre;
            foreach (int i in s)
            {
                if (i == 1)
                {
                    f[(VePoint - 1), (HoPoint - 1)].Background = FigureBackgroundColor;
                    f[(VePoint - 1), (HoPoint - 1)].BorderBrush = Brushes.Transparent;
                    f[(VePoint - 1), (HoPoint - 1)].BorderThickness = th;
                    f[(VePoint - 1), (HoPoint - 1)].Name = "filled";
                }
                if (i == 2)
                {
                    f[(VePoint - 1), HoPoint].Background = FigureBackgroundColor;
                    f[(VePoint - 1), HoPoint].BorderBrush = Brushes.Transparent;
                    f[(VePoint - 1), HoPoint].BorderThickness = th;
                    f[(VePoint - 1), HoPoint].Name = "filled";
                }
                if (i == 3)
                {
                    f[(VePoint - 1), (HoPoint + 1)].Background = FigureBackgroundColor;
                    f[(VePoint - 1), (HoPoint + 1)].BorderBrush = Brushes.Transparent;
                    f[(VePoint - 1), (HoPoint + 1)].BorderThickness = th;
                    f[(VePoint - 1), (HoPoint + 1)].Name = "filled";
                }
                if (i == 4)
                {
                    f[VePoint, (HoPoint - 1)].Background = FigureBackgroundColor;
                    f[VePoint, (HoPoint - 1)].BorderBrush = Brushes.Transparent;
                    f[VePoint, (HoPoint - 1)].BorderThickness = th;
                    f[VePoint, (HoPoint - 1)].Name = "filled";
                }
                if (i == 5)
                {
                    f[VePoint, HoPoint].Background = FigureBackgroundColor;
                    f[VePoint, HoPoint].BorderBrush = Brushes.Transparent;
                    f[VePoint, HoPoint].BorderThickness = th;
                    f[VePoint, HoPoint].Name = "filled";
                }
                if (i == 6)
                {
                    f[VePoint, (HoPoint + 1)].Background = FigureBackgroundColor;
                    f[VePoint, (HoPoint + 1)].BorderBrush = Brushes.Transparent;
                    f[VePoint, (HoPoint + 1)].BorderThickness = th;
                    f[VePoint, (HoPoint + 1)].Name = "filled";
                }
                if (i == 7)
                {
                    f[(VePoint + 1), (HoPoint - 1)].Background = FigureBackgroundColor;
                    f[(VePoint + 1), (HoPoint - 1)].BorderBrush = Brushes.Transparent;
                    f[(VePoint + 1), (HoPoint - 1)].BorderThickness = th;
                    f[(VePoint + 1), (HoPoint - 1)].Name = "filled";
                }
                if (i == 8)
                {
                    f[(VePoint + 1), HoPoint].Background = FigureBackgroundColor;
                    f[(VePoint + 1), HoPoint].BorderBrush = Brushes.Transparent;
                    f[(VePoint + 1), HoPoint].BorderThickness = th;
                    f[(VePoint + 1), HoPoint].Name = "filled";
                }
                if (i == 9)
                {
                    f[(VePoint + 1), (HoPoint + 1)].Background = FigureBackgroundColor;
                    f[(VePoint + 1), (HoPoint + 1)].BorderBrush = Brushes.Transparent;
                    f[(VePoint + 1), (HoPoint + 1)].BorderThickness = th;
                    f[(VePoint + 1), (HoPoint + 1)].Name = "filled";
                }
            }
            // проверка достижения дна или поверхности ранее упавших фигур
            // (f[VePoint][HoPoint] == 1 && f[VePoint + 1][HoPoint] == 2) - если данная ячейка содержит элемент текущей фигуры и
            // следующая ячейка по вертикали содержит элемент закрепленного фона, чтобы не проверялись только
            // нижние ячейки, проверка производится над каждым слоем фигуры снизу-вверх - для этого цикл и нужен

            for (int i = 0; i < 3; ++i)
            {
                if (stepDown >= 18 ||
                    (f[(VePoint + 1 - i), (HoPoint - 1)].Name == "filled" && f[(VePoint + 2 - i), (HoPoint - 1)].Name == "stop") ||
                    (f[(VePoint + 1 - i), HoPoint].Name == "filled" && f[(VePoint + 2 - i), HoPoint].Name == "stop") ||
                    (f[(VePoint + 1 - i), (HoPoint + 1)].Name == "filled" && f[(VePoint + 2 - i), (HoPoint + 1)].Name == "stop"))
                {
                    isBottom = true; // приказ всем клавишам, что фигура остановилась и больше не двигать
                    theBottom();
                }
            }
        }

        // проверка цвета текущей и всех закрепленных фигур
        public void checkFieldColor()
        {
            for (int i = 0; i < VerticalRange; ++i)
            {
                for (int j = 0; j < HorizontalRange - 1; ++j)
                {
                    if (foneMatrix[i, j].Background != Brushes.Transparent)
                        foneMatrix[i, j].Background = figureBackgroundColor;
                }
            }
        }

        // проверка цвета фигуры превью
        public void checkPreviewColor()
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (prevMatrix[i, j].Background != Brushes.Transparent)
                        prevMatrix[i, j].Background = figureBackgroundColor;
                }
            }
        }

        // действия при достижении дна и поиск заполненных линий
        public void theBottom()
        {
            // закрепление упавшей фигуры
            for (int i = 0; i < VerticalRange; ++i)
            {
                for (int j = 0; j < HorizontalRange - 1; ++j)
                {
                    if (foneMatrix[i, j].Name != "empty")
                    {
                        foneMatrix[i, j].Name = "stop";
                        foneMatrix[i, j].Background = figureBackgroundColor;
                    }
                }
            }

            // проверка состояния проигрыша
            if (stepDown <= 2)
                this.Loose = true;
            else
                this.Loose = false;

            if (loose == false)
            {
                // сброс параметров для копирования фигуры из превью и создания новой превью
                Random rand = new Random();
                ShapeMassive = shapeType(CurrentPrevShapeType);// генерация нового массива фигуры в соответствии с типом превью
                PrevShapeMassive = prevShapeType(rand.Next(7));// случайная генерация нового массива превью
                copyShapeToPreview(PrevShapeMassive, prevMatrix);// копирование массива превью в матрицу для отображения во view

                // установка исходных значений для установки новой фигуры на исходную позицию
                stepDown = 1;
                currentCentre = 9;
                isBottom = false;
            }
        }

        // функция очистки заполненной линии
        public void cleanFullLines(int line)
        {
            //создаем вспомагательную матрицу для копирования
            Label[,] helpMatrix = new Label[VerticalRange, HorizontalRange];
            for (int i = 0; i < VerticalRange; ++i)
            {
                for (int j = 0; j < HorizontalRange; ++j)
                    helpMatrix[i, j] = new Label();
            }
            // копируем в нее матрицу фона и выбрасываем заполненную линию
            for (int i = (VerticalRange - 1); i > line; --i)
            {
                for (int j = 1; j < (HorizontalRange - 1); ++j)
                {
                    helpMatrix[i, j].Background = foneMatrix[i, j].Background;
                    helpMatrix[i, j].BorderBrush = foneMatrix[i, j].BorderBrush;
                    helpMatrix[i, j].BorderThickness = foneMatrix[i, j].BorderThickness;
                    helpMatrix[i, j].Name = foneMatrix[i, j].Name;
                }
            }
            for (int i = line; i > 0; --i)
            {
                for (int j = 1; j < (HorizontalRange - 1); ++j)
                {
                    {
                        helpMatrix[i, j].Background = foneMatrix[(i - 1), j].Background;
                        helpMatrix[i, j].BorderBrush = foneMatrix[(i - 1), j].BorderBrush;
                        helpMatrix[i, j].BorderThickness = foneMatrix[(i - 1), j].BorderThickness;
                        helpMatrix[i, j].Name = foneMatrix[(i - 1), j].Name;
                    }

                    if (i == 0)
                    {
                        helpMatrix[i, j].Background = Brushes.Transparent;
                        helpMatrix[i, j].BorderBrush = Brushes.Black;
                        helpMatrix[i, j].BorderThickness = th;
                        helpMatrix[i, j].Name = "empty";
                    }
                }
            }
            double t = 0;
            while ((t++) < 1000000) ;

            // копируем готовую матрицу обратно в матрицу фона
            for (int i = 0; i < VerticalRange; ++i)
            {
                for (int j = 1; j < (HorizontalRange - 1); ++j)
                {
                    foneMatrix[i, j].Background = helpMatrix[i, j].Background;
                    foneMatrix[i, j].BorderBrush = helpMatrix[i, j].BorderBrush;
                    foneMatrix[i, j].BorderThickness = helpMatrix[i, j].BorderThickness;
                    foneMatrix[i, j].Name = helpMatrix[i, j].Name;
                }
            }
        }

        // связь между фоном и методом поворота в shape
        public void foneTurnShape()
        {
            if (!isBottom)
            {
                turnShape();
                // проверка выхода за границы при повороте фигуры с последующей компенсацией
                if (currentCentre == 16)
                    currentCentre = 15;
                else if (currentCentre == 1)
                    currentCentre = 2;
                copyShapeToFone(ShapeMassive, foneMatrix);
            }
        }

        // связь между фоном и методом перемещения в shape
        public void foneMoveShape(char step)
        {
            bool move = true;
            int rightLimit = 15;
            int leftLimit = 2;
            if (!isBottom)
            {
                if (step == 'R')
                {
                    if (foneMatrix[(VePoint + 1), (HoPoint + 1)].Name == "empty" &&
                        foneMatrix[VePoint, (HoPoint + 1)].Name == "empty" &&
                        foneMatrix[(VePoint - 1), (HoPoint + 1)].Name == "empty")
                    {
                        ++rightLimit;
                    }
                    if (currentCentre >= rightLimit ||
                        (foneMatrix[(VePoint + 1), (HoPoint + 1)].Name == "filled" && foneMatrix[(VePoint + 1), (HoPoint + 2)].Name == "stop") ||
                        (foneMatrix[VePoint, (HoPoint + 1)].Name == "filled" && foneMatrix[VePoint, (HoPoint + 2)].Name == "stop") ||
                        (foneMatrix[(VePoint - 1), (HoPoint + 1)].Name == "filled" && foneMatrix[(VePoint - 1), (HoPoint + 2)].Name == "stop") ||

                        (foneMatrix[(VePoint + 1), HoPoint].Name == "filled" && foneMatrix[(VePoint + 1), (HoPoint + 1)].Name == "stop") ||
                        (foneMatrix[VePoint, HoPoint].Name == "filled" && foneMatrix[VePoint, (HoPoint + 1)].Name == "stop") ||
                        (foneMatrix[(VePoint - 1), HoPoint].Name == "filled" && foneMatrix[(VePoint - 1), (HoPoint + 1)].Name == "stop") ||

                        (foneMatrix[(VePoint + 1), (HoPoint - 1)].Name == "filled" && foneMatrix[(VePoint + 1), HoPoint].Name == "stop") ||
                        (foneMatrix[VePoint, (HoPoint - 1)].Name == "filled" && foneMatrix[VePoint, HoPoint].Name == "stop") ||
                        (foneMatrix[(VePoint - 1), (HoPoint - 1)].Name == "filled" && foneMatrix[(VePoint - 1), HoPoint].Name == "stop"))
                    {
                        move = false;
                    }
                    if (move)
                        currentCentre += 1;
                    copyShapeToFone(ShapeMassive, foneMatrix);
                }
                if (step == 'L')
                {
                    if (foneMatrix[(VePoint + 1), (HoPoint - 1)].Name == "empty" &&
                        foneMatrix[VePoint, (HoPoint - 1)].Name == "empty" &&
                        foneMatrix[(VePoint - 1), (HoPoint - 1)].Name == "empty")
                    {
                        --leftLimit;
                    }
                    if (currentCentre <= leftLimit ||
                        (foneMatrix[(VePoint + 1), (HoPoint - 1)].Name == "filled" && foneMatrix[(VePoint + 1), (HoPoint - 2)].Name == "stop") ||
                        (foneMatrix[(VePoint), (HoPoint - 1)].Name == "filled" && foneMatrix[VePoint, (HoPoint - 2)].Name == "stop") ||
                        (foneMatrix[(VePoint - 1), (HoPoint - 1)].Name == "filled" && foneMatrix[(VePoint - 1), (HoPoint - 2)].Name == "stop") ||

                        (foneMatrix[(VePoint + 1), HoPoint].Name == "filled" && foneMatrix[(VePoint + 1), (HoPoint - 1)].Name == "stop") ||
                        (foneMatrix[VePoint, HoPoint].Name == "filled" && foneMatrix[VePoint, (HoPoint - 1)].Name == "stop") ||
                        (foneMatrix[(VePoint - 1), HoPoint].Name == "filled" && foneMatrix[(VePoint - 1), (HoPoint - 1)].Name == "stop") ||

                        (foneMatrix[(VePoint + 1), (HoPoint + 1)].Name == "filled" && foneMatrix[(VePoint + 1), HoPoint].Name == "stop") ||
                        (foneMatrix[VePoint, (HoPoint + 1)].Name == "filled" && foneMatrix[VePoint, HoPoint].Name == "stop") ||
                        (foneMatrix[(VePoint - 1), (HoPoint + 1)].Name == "filled" && foneMatrix[(VePoint - 1), HoPoint].Name == "stop"))
                    {
                        move = false;
                    }
                    if (move)
                        currentCentre -= 1;
                    copyShapeToFone(ShapeMassive, foneMatrix);
                }
            }
        }

        // класс для приращения кол-ва шагов фигуры вниз
        public void encreaseStepDown()
        {
            searchForLines();
            stepDown++;
            copyShapeToFone(ShapeMassive, foneMatrix);
            copyShapeToPreview(PrevShapeMassive, prevMatrix);
        }

        // геттер для получения текущего счета
        public int CurrentScore
        {
            get { return currentScore; }
        }

        // свойство для цвета фигур
        public Brush FigureBackgroundColor
        {
            get { return figureBackgroundColor; }
            set { figureBackgroundColor = value; }
        }

        // геттер для получения статуса о проигрыше
        public bool Loose
        {
            get { return this.loose; }
            set { loose = value; }
        }

        public void searchForLines()
        {
            // поиск заполненных линий            
            int k = 0;
            int qtyOfLines = 0;
            while (k < VerticalRange)
            {
                for (int l = 1; l < (HorizontalRange - 1); ++l)
                {
                    if (foneMatrix[k, l].Name != "stop")
                    {
                        ++k;
                        break;
                    }
                    if (l == 16)
                    {
                        qtyOfLines += 1; // подсчет кол-ва заполненных линий за раз
                        double t = 0;
                        while ((t++) < 100000); // пауза для красивого удаления строк
                        cleanFullLines(k);
                        ++k;
                    }
                }
            }
            // формула для расчета набранных очков по результатам подсчета кол-ва заполненных линий за раз
            currentScore += qtyOfLines * (qtyOfLines + 1) * 5;
        }
    }
}
