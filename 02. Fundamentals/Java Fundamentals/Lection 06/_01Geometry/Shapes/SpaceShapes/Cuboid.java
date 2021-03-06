package _01Geometry.Shapes.SpaceShapes;

import _01Geometry.Vertices.Vertex3D;

import java.util.ArrayList;

public class Cuboid extends SpaceShape {

    private double width;
    private double height;
    private double depth;
    ArrayList<Vertex3D> vertices;

    public Cuboid(Vertex3D vertex, double width, double height, double depth) {
        super(vertex);
        this.setWidth(width);
        this.setHeight(height);
        this.setDepth(depth);

        this.vertices = super.getVertices();
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    public double getDepth() {
        return depth;
    }

    public void setDepth(double depth) {
        this.depth = depth;
    }

    @Override
    public double getArea() {
        double totalSurfaceArea = 2 * (
                this.depth * this.width + this.width * this.height + this.height * this.depth);
        return totalSurfaceArea;
    }

    @Override
    public double getVolume() {
        double volume = this.width * this.height * this.depth;
        return volume;
    }

    @Override
    public String toString() {
        StringBuilder cuboid = new StringBuilder();
        cuboid.append(String.format(
                "Cuboid:%n\tWidth = %.2f;%n\tHeight = %.2f;%n\tDepth = %.2f;%n\tVolume = %.2f;%n\tArea = %.2f;%n",
                this.width, this.height, this.depth, this.getVolume(), this.getArea()));
        cuboid.append(String.format("\tCoordinates: %s%n", this.vertices.toString()));

        return cuboid.toString();
    }
}
