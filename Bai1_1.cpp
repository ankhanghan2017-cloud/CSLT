// Sample C++ code
#include <iostream>
using namespace std;

int main()
{
    int n = 6;
    int k = 5;
    
    // Sửa lỗi dấu phẩy và dấu toán tử <<
    cout << "n = " << n << ", k = " << k << endl;

    int &rn = n;  // rn là tham chiếu (biệt danh) của n
    int *pn = &n; // pn là con trỏ trỏ đến địa chỉ của n
    
    // Sửa lỗi dùng dấu phẩy ở đây
    cout << "rn = " << rn << ", *pn = " << *pn << endl;
    
    rn = k; // Thay đổi giá trị của rn (cũng là thay đổi n) thành giá trị của k (5)
    pn = &k; // Thay đổi con trỏ pn chuyển sang trỏ vào địa chỉ của k
    
    cout << "n = " << n << ", k = " << k << endl;
    cout << "rn = " << rn << ", *pn = " << *pn << endl;
    
    return 0; // Thêm dòng này để kết thúc hàm main chuẩn chỉnh
}
