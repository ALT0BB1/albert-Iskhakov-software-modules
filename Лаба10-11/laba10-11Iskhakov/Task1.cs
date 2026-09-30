namespace laba10_11Iskhakov
{
    internal class Task1
    {
        static void Main1()
        { 
        double a = 2.0, b = 4.0, c = 4.0, d = 2.0; 
        
        double length = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2));
        
        double normA = a / length;
        double normB = b / length;
        double normC = c / length;
        double normD = d / length;
        
        Console.WriteLine($"Длина вектора: {length}");
        Console.WriteLine($"Нормализованный вектор: ({normA}, {normB}, {normC}, {normD})");






        }
   
    }   
}
    

