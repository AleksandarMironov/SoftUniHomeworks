package _01Geometry.Interfaces;

public interface IVertex {
    double getX();

    double getY();

    double calculateDistance(IVertex otherVertex);
}
