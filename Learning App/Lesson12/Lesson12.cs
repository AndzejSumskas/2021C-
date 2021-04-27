using Learning_App.Lesson12.InterfaceTask.Managers;
using Learning_App.Lesson12.InterfaceTask.Objects;
//using Learning_App.Lesson12.Lesson12Tasks.Animals;
//using Learning_App.Lesson12.Lesson12Tasks.Gui;
//using Learning_App.Lesson12.Lesson12Tasks.Interfaces;
//using Learning_App.Lesson12.Lesson12Tasks.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12
{
    class Lesson12
    {
        static void Main()
        {
            Dog dog = new Dog();
            Ghost ghost = new Ghost();
            Hero hero = new Hero();
            House house = new House();
            Sun sun = new Sun();

            dog.Print();
            ghost.Print();
            hero.Print();
            house.Print();
            sun.Print();

            Renderer renderer = new Renderer();

            renderer.AddRenderItem(dog);
            renderer.AddRenderItem(ghost);
            renderer.AddRenderItem(hero);
            renderer.AddRenderItem(house);
            renderer.AddRenderItem(sun);

            renderer.AddRenderToArray(dog);
            renderer.AddRenderToArray(ghost);
            renderer.AddRenderToArray(hero);
            renderer.AddRenderToArray(house);
            renderer.AddRenderToArray(sun);

            renderer.RenderAll();

            Console.WriteLine("*****************");

            renderer.RenderArray();
            Console.WriteLine("*****************");

            foreach (object item in dog)
            {
                Console.WriteLine(item);
            }
        }

        //static void Lesson12Taskas()
        //{
        //    Pet pet = new Pet();


        //    Animal animal = pet;

        //    IRenderable renderable = pet;

        //    Renderer renderer = new Renderer();

        //    renderer.AddRenderItem(pet);
        //    renderer.AddRenderItem(pet);



        //    Image image = new Image();
        //    renderer.AddRenderItem(image);


        //    renderer.RenderAll();

        //}
    }
}
