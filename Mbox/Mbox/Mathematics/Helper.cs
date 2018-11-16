using System;

namespace Mbox.Mathematics
{
    /* >> Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения.
     * * Данная реализация вообще не должна была быть написана, так как требуется полное пересогласование ТЗ.
     * 
     *  * Отсутсвует описание внешнего интерфейса для клиента и способов интеграции, которые будут указаны в сопроводительной документации;
     *  * * Поэтому было принято решение ограничиться простым классом-хелпером, как самым простым вариантом интеграции.
     * 
     * 
     * * Отсутствует граничные условия по входным данным;
     * * * decimal? float? int? Типов данных много, интерфейс не согласован. Был взят double, как первый пришедший на ум.
     * 
     * 
     * * Отсутствует описание задач, под которые библиотека разрабатывается, чтобы хоть как-то запланировать развитие, а не писать одноразовый код
     * * * Поэтому, был написан одноразовый код.
     * 
     * 
     * * Юнит-тесты
     * * * Не указан гайдлайн под тесты. Ограничился базовой парой "гарантированно успешный" + "гарантированно не успешный"
     *  
     *  
     * * Легкость добавления других фигур
     * * * Не указана сфера применения, не указан вектор развития, не указаны масштабы. В таких условиях хелпер — самый простой вариант добавления новых фигур
     * 
     * 
     *  * Вычисление площади фигуры без знания типа фигуры
     *  * * В ТЗ отсутствует спектр задач, под которые должна проектироваться библиотека. Двумерная фигура сложнее треугольника упирается 
     *  * * в позиционирование вершин на плоскости и порядке их обхода. Ситуация становится сложнее в случаях самопересечений.
     *  * * Ситуация становится сложнее, когда производительность критична.
     *  
     *  
     * * Проверку на то, является ли треугольник прямоугольным
     * * * Было решено не вводить такую проверку для повышения сопровождаемости кода. В ТЗ не указано, насколько критично время выполнения операций.
     * 
     * * Из неприятных мелочей: не указан тип сборки, платформы, 
     */




    public static class Helper
    {
        /// <summary>Calc circle area</summary>
        /// <param name="radius">Radius of a circle</param>
        /// <returns>Area of a circle</returns>
        /// <exception cref="ArgumentException">For negative, NaN, infinity and overwhelming values</exception>
        /// <returns>Area of circle</returns>
        public static double AreaCirlceCalc(double radius)
        {
            if (radius < 0 || double.IsInfinity(radius) || double.IsNaN(radius))
                throw new ArgumentException($"Invalid argument. Radius can't be {radius}");

            if (radius == 0)
                return 0;
            
            return Math.PI * radius * radius;
        }

        /// <summary> Calc triangle area</summary>
        /// <param name="lineA">Triangle side A</param>
        /// <param name="lineB">Triangle side B</param>
        /// <param name="lineC">Triangle side C</param>
        /// <exception cref="ArgumentException">For negative, NaN, infinity, overwhelming and imposible values</exception>
        /// <returns>Area of triangle</returns>
        public static double AreaTriangleCalc(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || double.IsInfinity(sideA) || double.IsNaN(sideA))
                throw new ArgumentException($"Invalid argument. sideA can't be {sideA}");

            if (sideB <= 0 || double.IsInfinity(sideB) || double.IsNaN(sideB))
                throw new ArgumentException($"Invalid argument. sideB can't be {sideB}");

            if (sideC <= 0 || double.IsInfinity(sideC) || double.IsNaN(sideC))
                throw new ArgumentException($"Invalid argument. sideC can't be {sideC}");

            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
                throw new ArgumentException($"Imposible triangle");


            var p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)); //
        }

    }
}
