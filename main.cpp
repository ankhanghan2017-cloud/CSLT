#include <iostream>
using namespace std;

int GCD(int a, int b) {
    while (b != 0) {
        int temp = a % b;
        a = b;
        b = temp;
    }
    return a;
}

int main() {
    int a, b;

    cout << "Nhap so a: ";
    cin >> a;

    cout << "Nhap so b: ";
    cin >> b;

    int BCNN = (a * b) / GCD(a, b);
    int UCLN = GCD(a, b);

    cout << "UCLN cua " << a << " va " << b << " la: " << UCLN << endl;
Console.WriteLine("LMAO");
    return 0;
    
}
