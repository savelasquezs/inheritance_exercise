using System;
using System.IO;

class Program
{
    static void Main()
    {

        string baseDirectory = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;
        int quantity = 2;
        string baseName= "exercise";

       
        for (int i = 1; i <= quantity; i++)
        {
            string fileName =Path.Combine(baseDirectory, $"{baseName}{i}.cs") ;
            

            string content = $@"namespace workshop2{{
public class Exercise{i}{{
    public void Main(){{

    }}
    static void Solve(){{}}
    static void UsingFor(){{}}
    static void UsingWhile(){{}}
    static void UsingDoWhile(){{}}
}}
}}";

            // Create the file and write the content
            File.WriteAllText(fileName, content);
        }

        Console.WriteLine($"{quantity} files have been created successfully.");
//    Console.WriteLine("Ingrese el número del problema que desea ejecutar (1-30):");
//        if (int.TryParse(Console.ReadLine(), out int problemNumber) && problemNumber >= 1 && problemNumber <= 30)
//        {
//            string namespaceName = $"Problem{problemNumber}";
//    string className = $"{namespaceName}.{namespaceName}Solution";
//    Type type = Type.GetType(className);
//            if (type != null)
//            {
//                var method = type.GetMethod("Solve");
//    method?.Invoke(null, null);
//}
//            else
//{
//    Console.WriteLine($"No se pudo encontrar la clase {className}");
//    Main();
//}
//        }
//        else
//{
//    Console.WriteLine("Número inválido. Debe estar entre 1 y 30.");
//    Main();
//}
    }

}


