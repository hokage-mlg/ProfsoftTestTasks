namespace ConsoleApp
{
    /// <summary>
    /// Напишите функцию, которая определяет, попадает ли точка с вещественными координатами X,Y в заданную область.
    /// </summary>
    internal static class Task3
    {
        internal static bool CheckCoordinates(double x, double y)
        {
            var lim = 8;
            for (var i = 1; i < lim; i++)
                if ((x >= i && x <= lim) && (y >= i && y <= (i + 1)))
                    return true;
            return false;
        }
    }
}
