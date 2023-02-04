/*
 * Name:Steven Garcia-Alamilla
 * Date: 02/03/23 
 *
 * Project: CW4
 *
 * 
 * 
 */








using System;

namespace ClassWork4_FactoryPattern
{

    //enum ShapeType for every GemotricShape
    public enum ShapeType
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE
    }



    //IGeometricShape interface which only has the operation Draw() for concrete classes to implement
    public interface IGeometricShape
    {
        string Draw();
    }


    //line class which inheirts the IGeometricShape class
    public class Line : IGeometricShape
    {
        public string Draw()
        {
            return "Line has been drawn!";
        }
    }



    //Circle class which inheirts the IGeometricShape class
    public class Circle : IGeometricShape
    {
        public string Draw()
        {
            return "Circle has been drawn!";
        }
    }


    //Rectangle class which inheirts the IGeometricShape class
    public class Rectangle : IGeometricShape
    {
        public string Draw()
        {
            return "Rectangle has been drawn!";
        }
    }



    //ShapeFactory class which returns a msg based on the enum that was passed through
    public class ShapeFactory
    {
        public IGeometricShape GetShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.LINE:
                    return new Line();
                case ShapeType.CIRCLE:
                    return new Circle();
                case ShapeType.RECTANGLE:
                    return new Rectangle();
                    //if its none of the ones listed above return null
                default:
                    return null;
            }
        }
    }

    //the entry point of the program 

    class Program
    {

        static void Main()
        {
            

            ShapeFactory shapeFactory = new ShapeFactory();
            foreach (ShapeType shapeType in Enum.GetValues(typeof(ShapeType)))
            {
                IGeometricShape shape = shapeFactory.GetShape(shapeType);
                //check to make sure null was not returned in order to use Draw()
                if (shape != null)
                {
                    Console.WriteLine(shape.Draw());
                }
            }
        }


    }
}

