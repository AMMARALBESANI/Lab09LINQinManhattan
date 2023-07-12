using Newtonsoft.Json;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQinManhattan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RootObject rootObject =  RootObject.getData();
                
                //Output all of the neighborhoods
                Console.WriteLine("AllNeighborhoods:\n");
                RootObject.AllNeighborhoods(rootObject);
                //Filter out all the neighborhoods that do not have any names 
                Console.WriteLine("_______________________________");
                Console.WriteLine("FilterEmpty:\n");
                RootObject.FilterEmpty(rootObject);
                //Remove the duplicates from neighborhoods
                Console.WriteLine("_______________________________");
                Console.WriteLine("Duplicates\n");
                RootObject.Duplicates(rootObject);
                Console.WriteLine("_______________________________");


                //allthe queries 
                // RootObject.AllQuery(rootObject);

                //select all Neighborhood whit LINQ Query statements 
                //RootObject.Neighborhood(rootObject);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}