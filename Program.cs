using System.Text;
using Engine.Renderer;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Murzik", 6.5, true);
            cat.Name = null;

            //Engine.Physics.Vector3D vector3D = new Engine.Physics.Vector3D();
            Vector3D vector3D = new Vector3D();

        }
    }
}
