
using StructuralPatterns.Adapter;
using StructuralPatterns.Bridge;
using StructuralPatterns.Facade;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        FacadeClass facadeClass = new FacadeClass();
        facadeClass.LogIn();

    }
}