#include <iostream>
#include <string>

using namespace std;

class Person {
public:
    string name;
    int age;
};

class Student : public Person {
public:
    int studentId;
    string department;

    void setData(string n, int a, int id, string dept) {
        name = n;
        age = a;
        studentId = id;
        department = dept;
    }

    void display() {
        cout << "Student Information" << endl;
        cout << "Name       : " << name << endl;
        cout << "Age        : " << age << endl;
        cout << "Student ID : " << studentId << endl;
        cout << "Department : " << department << endl;
    }
};

int main() {
    cout << "Siyam Al Rafi!\nInheritance:" << endl;
    cout << "\n";
    Student s;
    s.setData("Rafi", 21, 105, "CSE");
    s.display();
    return 0;
}
