# BÀI 01 - PHẦN LÝ THUYẾT & CÂU HỎI NGẮN

## Câu 1: Value Types và Reference Types
Value Type lưu trực tiếp giá trị của biến.
Các kiểu thường gặp: int, double, bool, char, struct, enum,....
VD: int a = 10;
    int b = a;
    b = 20;
Khi gán b = a, giá trị của a được copy sang một vùng dữ liệu mới. Vì vậy thay đổi b không ảnh hưởng đến a.
Về bộ nhớ, biến cục bộ thuộc Value Type thường được lưu trực tiếp trong vùng nhớ của biến; trong nhiều trường
hợp thực thi nó có thể nằm trên Stack, mặc dù không nên hiểu đơn giản rằng mọi Value Type luôn nằm trên Stack

Reference Type không lưu trực tiếp toàn bộ đối tượng mà lưu tham chiếu đến đối tượng.
Các kiểu thường gặp : void, class, string, array, delegate, interface,...
VD: class Person
    {
        public string Name;
    }
    Person p1 = new Person();
    p1.Name = "An";

    Person p2 = p1;
    p2.Name = "Bình";
    Console.WriteLine(p1.Name); // Bình
p1 và p2 cùng tham chiếu đến một đối tượng Person nên thay đổi thông qua p2 cũng làm dữ liệu mà p1 nhìn thấy thay đổi.
Các object của Reference Type thường được cấp phát trên Managed Heap, còn biến tham chiếu giữ thông tin để truy cập object đó.

