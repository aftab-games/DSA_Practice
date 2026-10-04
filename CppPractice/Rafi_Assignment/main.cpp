#include <iostream>

using namespace std;

class Rectangle {
private:
    double length;
    double width;
public:
    void SetData(double l, double w) {

        length = l;
        width = w;
    }

    double CalculateArea() {
        return length * width;
    }

    double CalculatePerimeter() {
        return 2 * (length + width);
    }

};

int main()
{
    Rectangle rect;
    double l, w;

    cout << "Siyam Al Rafi!\nCalculation of Rectangle:" << endl;
    cout << "\n";
    cout << "Input the length: ";
    cin >> l;
    cout << "Input the width: ";
    cin >> w;

    rect.SetData(l, w);

    cout << "\n";
    cout << "Area: " << rect.CalculateArea() << endl;
    cout << "Perimeter: " << rect.CalculatePerimeter() << endl;
    return 0;
}
