package _01Geometry;

import _01Geometry.Shapes.PlaneShapes.Circle;
import _01Geometry.Shapes.PlaneShapes.PlaneShape;
import _01Geometry.Shapes.PlaneShapes.Rectangle;
import _01Geometry.Shapes.PlaneShapes.Triangle;
import _01Geometry.Shapes.Shape;
import _01Geometry.Shapes.SpaceShapes.Cuboid;
import _01Geometry.Shapes.SpaceShapes.SpaceShape;
import _01Geometry.Shapes.SpaceShapes.Sphere;
import _01Geometry.Shapes.SpaceShapes.SquarePyramid;
import _01Geometry.Vertices.Vertex;
import _01Geometry.Vertices.Vertex3D;
import com.sun.javaws.exceptions.InvalidArgumentException;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class GeometryMain {
    public static void main(String[] args) throws InvalidArgumentException {
        Vertex pointA = new Vertex(25, 25);
        Vertex pointB = new Vertex(33, 40);
        Vertex pointC = new Vertex(65, 35);
        Triangle triangle = new Triangle(pointA, pointB, pointC);

        Vertex rectangleVertex = new Vertex(30, 30);
        Rectangle rectangle = new Rectangle(rectangleVertex, 25, 30);

        Vertex circleCenter = new Vertex(40, 40);
        Circle circle = new Circle(circleCenter, 25);

        Vertex3D baseCenter = new Vertex3D(25, 25, 20);
        SquarePyramid squarePyramid = new SquarePyramid(baseCenter, 20, 30);

        Vertex3D cuboidVertex = new Vertex3D(20, 20, 25);
        Cuboid cuboid = new Cuboid(cuboidVertex, 20, 15, 14);

        Vertex3D sphereCenter = new Vertex3D(15, 15, 20);
        Sphere sphere = new Sphere(sphereCenter, 15);

        SpaceShape[] spaceShapes = new SpaceShape[]{squarePyramid, cuboid, sphere};
        PlaneShape[] planeShapes = new PlaneShape[]{triangle, rectangle, circle};

        ArrayList<Shape> shapes = new ArrayList<Shape>() {
            {
                addAll(Arrays.asList(planeShapes));
                addAll(Arrays.asList(spaceShapes));
            }
        };

        shapes.forEach(System.out::println);

        List<SpaceShape> filteredSpaceShapes = shapes.stream()
                .filter(s -> s instanceof SpaceShape)
                .map(s -> (SpaceShape) s)
                .filter(s -> s.getVolume() > 400).collect(Collectors.toList());

        List<PlaneShape> sortedPlaneShapes = shapes.stream()
                .filter(s -> s instanceof PlaneShape)
                .map(s -> (PlaneShape) s)
                .sorted()
                .collect(Collectors.toList());

        System.out.println("Space shapes with over 400 volume");
        for (SpaceShape filteredSpaceShape : filteredSpaceShapes) {
            System.out.println(filteredSpaceShape.toString().trim());
        }

        System.out.println();
        System.out.println("Sorted Plane Shapes");
        for (PlaneShape sortedPlaneShape : sortedPlaneShapes) {
            System.out.println(sortedPlaneShape.toString().trim());
        }
    }
}
