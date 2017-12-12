using System;

namespace tetrisWPF
{
    class shape
    {
        Array shapeMassive = Array.CreateInstance(typeof(int), 4);
        Array prevShapeMassive = Array.CreateInstance(typeof(int), 4);
        int currentShapeType;
        int currentPrevShapeType;
        int currentShapePosition = 0; // текущий поворот фигуры

        // свойство закрытого массива фигуры
        public Array ShapeMassive
        {
            set { this.shapeMassive = value; }
            get { return this.shapeMassive; }
        }

        // свойство закрытого массива превью
        public Array PrevShapeMassive
        {
            set { prevShapeMassive = value; }
            get { return prevShapeMassive; }
        }

        // создает тип фигуры, формирует массив фигуры
        public Array shapeType(int type)
        {
            switch (type)
            {
                // линия
                case 0:
                    {
                        this.shapeMassive.SetValue(0, 0);
                        this.shapeMassive.SetValue(7, 1);
                        this.shapeMassive.SetValue(8, 2);
                        this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 0;
                        currentShapeType = type; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // треугольник
                case 1:
                    {
                        this.shapeMassive.SetValue(5, 0);
                        this.shapeMassive.SetValue(7, 1);
                        this.shapeMassive.SetValue(8, 2);
                        this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 0;
                        currentShapeType = type; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // квадрат
                case 2:
                    {
                        this.shapeMassive.SetValue(4, 0);
                        this.shapeMassive.SetValue(5, 1);
                        this.shapeMassive.SetValue(7, 2);
                        this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 0;
                        currentShapeType = type; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // зиг-заг 1
                case 3:
                    {
                        this.shapeMassive.SetValue(5, 0);
                        this.shapeMassive.SetValue(6, 1);
                        this.shapeMassive.SetValue(7, 2);
                        this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 0;
                        currentShapeType = type; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // уголок 1
                case 4:
                    {
                        this.shapeMassive.SetValue(1, 0);
                        this.shapeMassive.SetValue(4, 1);
                        this.shapeMassive.SetValue(7, 2);
                        this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 0;
                        currentShapeType = type; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // зиг-заг 2
                case 5:
                    {
                        this.shapeMassive.SetValue(4, 0);
                        this.shapeMassive.SetValue(5, 1);
                        this.shapeMassive.SetValue(8, 2);
                        this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 0;
                        currentShapeType = type; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }

                // уголок 2
                case 6:
                    {
                        shapeMassive.SetValue(3, 0);
                        shapeMassive.SetValue(6, 1);
                        shapeMassive.SetValue(8, 2);
                        shapeMassive.SetValue(9, 3);
                        currentShapePosition = 0;
                        currentShapeType = type; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                default: break;
            }
            return this.shapeMassive;
        }

        // создает тип превью, формирует массив превью
        public Array prevShapeType(int prevType)
        {
            if (prevType == currentShapeType) // алгоритм защиты от повторяющихся фигур
            {
                if (prevType == 6)
                    --prevType;
                else
                    ++prevType;
            }
            switch (prevType)
            {
                // линия
                case 0:
                    {
                        prevShapeMassive.SetValue(0, 0);
                        prevShapeMassive.SetValue(7, 1);
                        prevShapeMassive.SetValue(8, 2);
                        prevShapeMassive.SetValue(9, 3);
                        currentPrevShapeType = prevType; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // треугольник
                case 1:
                    {
                        prevShapeMassive.SetValue(5, 0);
                        prevShapeMassive.SetValue(7, 1);
                        prevShapeMassive.SetValue(8, 2);
                        prevShapeMassive.SetValue(9, 3);
                        currentPrevShapeType = prevType; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // квадрат
                case 2:
                    {
                        prevShapeMassive.SetValue(4, 0);
                        prevShapeMassive.SetValue(5, 1);
                        prevShapeMassive.SetValue(7, 2);
                        prevShapeMassive.SetValue(8, 3);
                        currentPrevShapeType = prevType; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // зиг-заг
                case 3:
                    {
                        prevShapeMassive.SetValue(5, 0);
                        prevShapeMassive.SetValue(6, 1);
                        prevShapeMassive.SetValue(7, 2);
                        prevShapeMassive.SetValue(8, 3);
                        currentPrevShapeType = prevType; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // уголок
                case 4:
                    {
                        prevShapeMassive.SetValue(1, 0);
                        prevShapeMassive.SetValue(4, 1);
                        prevShapeMassive.SetValue(7, 2);
                        prevShapeMassive.SetValue(8, 3);
                        currentPrevShapeType = prevType; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // зиг-заг 2
                case 5:
                    {
                        prevShapeMassive.SetValue(4, 0);
                        prevShapeMassive.SetValue(5, 1);
                        prevShapeMassive.SetValue(8, 2);
                        prevShapeMassive.SetValue(9, 3);
                        currentPrevShapeType = prevType; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                // уголок 2
                case 6:
                    {
                        prevShapeMassive.SetValue(3, 0);
                        prevShapeMassive.SetValue(6, 1);
                        prevShapeMassive.SetValue(8, 2);
                        prevShapeMassive.SetValue(9, 3);
                        currentPrevShapeType = prevType; // фиксирование типа фигуры в переменную класса currentShapeType
                        break;
                    }
                default: break;
            }
            return this.prevShapeMassive;
        }

        // меняет фигуру в соответствии с кол-вом поворотов
        public void turnShape()
        {
            for (int i = 0; i < 4; ++i)
            {
                this.shapeMassive.SetValue(0, i);
            }

            switch (currentShapeType)
            {
                #region линия
                case 0:
                    if (currentShapePosition == 0)
                    {
                        this.shapeMassive.SetValue(0, 0); this.shapeMassive.SetValue(2, 1);
                        this.shapeMassive.SetValue(5, 2); this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 1;
                    }
                    else if (currentShapePosition == 1)
                    {
                        this.shapeMassive.SetValue(0, 0); this.shapeMassive.SetValue(7, 1);
                        this.shapeMassive.SetValue(8, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 0;
                    }
                    break;
                #endregion

                #region треугольник
                case 1:
                    if (currentShapePosition == 0)
                    {
                        this.shapeMassive.SetValue(3, 0); this.shapeMassive.SetValue(5, 1);
                        this.shapeMassive.SetValue(6, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 3;
                    }
                    else if (currentShapePosition == 3)
                    {
                        this.shapeMassive.SetValue(4, 0); this.shapeMassive.SetValue(5, 1);
                        this.shapeMassive.SetValue(6, 2); this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 2;
                    }
                    else if (currentShapePosition == 2)
                    {
                        this.shapeMassive.SetValue(1, 0); this.shapeMassive.SetValue(4, 1);
                        this.shapeMassive.SetValue(5, 2); this.shapeMassive.SetValue(7, 3);
                        currentShapePosition = 1;
                    }
                    else if (currentShapePosition == 1)
                    {
                        this.shapeMassive.SetValue(5, 0); this.shapeMassive.SetValue(7, 1);
                        this.shapeMassive.SetValue(8, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 0;
                    }
                    break;
                #endregion

                #region квадрат
                case 2:
                    this.shapeMassive.SetValue(4, 0); this.shapeMassive.SetValue(5, 1);
                    this.shapeMassive.SetValue(7, 2); this.shapeMassive.SetValue(8, 3);
                    break;

                #endregion

                #region зиг-заг 1
                case 3:
                    if (currentShapePosition == 0)
                    {
                        this.shapeMassive.SetValue(1, 0); this.shapeMassive.SetValue(4, 1);
                        this.shapeMassive.SetValue(5, 2); this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 1;
                    }
                    else if (currentShapePosition == 1)
                    {
                        this.shapeMassive.SetValue(5, 0); this.shapeMassive.SetValue(6, 1);
                        this.shapeMassive.SetValue(7, 2); this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 0;
                    }
                    break;
                #endregion

                #region уголок 1
                case 4:
                    if (currentShapePosition == 0)
                    {
                        this.shapeMassive.SetValue(6, 0); this.shapeMassive.SetValue(7, 1);
                        this.shapeMassive.SetValue(8, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 3;
                    }

                    else if (currentShapePosition == 3)
                    {
                        this.shapeMassive.SetValue(2, 0); this.shapeMassive.SetValue(3, 1);
                        this.shapeMassive.SetValue(6, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 2;
                    }
                    else if (currentShapePosition == 2)
                    {
                        this.shapeMassive.SetValue(4, 0); this.shapeMassive.SetValue(5, 1);
                        this.shapeMassive.SetValue(6, 2); this.shapeMassive.SetValue(7, 3);
                        currentShapePosition = 1;
                    }
                    else if (currentShapePosition == 1)
                    {
                        this.shapeMassive.SetValue(1, 0); this.shapeMassive.SetValue(4, 1);
                        this.shapeMassive.SetValue(7, 2); this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 0;
                    }
                    break;
                #endregion

                #region зиг-заг 2
                case 5:
                    if (currentShapePosition == 0)
                    {
                        this.shapeMassive.SetValue(3, 0); this.shapeMassive.SetValue(5, 1);
                        this.shapeMassive.SetValue(6, 2); this.shapeMassive.SetValue(8, 3);
                        currentShapePosition = 1;
                    }
                    else if (currentShapePosition == 1)
                    {
                        this.shapeMassive.SetValue(4, 0); this.shapeMassive.SetValue(5, 1);
                        this.shapeMassive.SetValue(8, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 0;
                    }
                    break;
                #endregion

                #region уголок 2
                case 6:
                    if (currentShapePosition == 0)
                    {
                        this.shapeMassive.SetValue(4, 0); this.shapeMassive.SetValue(5, 1);
                        this.shapeMassive.SetValue(6, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 3;
                    }

                    else if (currentShapePosition == 3)
                    {
                        this.shapeMassive.SetValue(1, 0); this.shapeMassive.SetValue(2, 1);
                        this.shapeMassive.SetValue(4, 2); this.shapeMassive.SetValue(7, 3);
                        currentShapePosition = 2;
                    }
                    else if (currentShapePosition == 2)
                    {
                        this.shapeMassive.SetValue(4, 0); this.shapeMassive.SetValue(7, 1);
                        this.shapeMassive.SetValue(8, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 1;
                    }
                    else if (currentShapePosition == 1)
                    {
                        this.shapeMassive.SetValue(3, 0); this.shapeMassive.SetValue(6, 1);
                        this.shapeMassive.SetValue(8, 2); this.shapeMassive.SetValue(9, 3);
                        currentShapePosition = 0;
                    }
                    break;
                #endregion
                default:
                    break;
            }
        }

        // получение информации о типе фигуры превью
        public int CurrentPrevShapeType
        {
            get { return this.currentPrevShapeType; }
        }
    }
}
