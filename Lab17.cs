/**
 
НАПИСАНО НА С ++ 

 */


/*#include <iostream>

using namespace std;

class Rhombus
{
    private:
double a;
    double b;
    double area;

    public:
Rhombus()
    {
        a = 0;
        b = 0;
    }

    Rhombus(double a, double b)
    {
        setA(a);
        setB(b);
    }

    void setA(double a)
    {
        if (a > 0)
        {
            this->a = a;
        }
        else
        {
            this->a = 0;
            cout << "Значение не может быть меньше нуля!" << endl;
        }
    }

    void setB(double b)
    {
        if (b > 0)
        {
            this->b = b;
        }
        else
        {
            this->b = 0;
            cout << "Value can't be less than zero!" << endl;
        }
    }

    double getA()
    {
        return a;
    }

    double getB()
    {
        return b;
    }

    void areaCalculation()
    {
        area = a * b;
    }

    void print_sqr()
    {
        areaCalculation();
        cout << "Area: " << area << endl;
    }



};

int main()
{
    Rhombus rhombus(5,9);
    rhombus.print_sqr();
}
}
*/