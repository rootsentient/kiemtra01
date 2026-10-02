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

## Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính có set thông thường? Nêu trường hợp sử dụng thực tế.
Trong C#, init được giới thiệu từ "C# 9". Nó cho phép gán giá trị cho thuộc tính khi đối tượng được khởi tạo, nhưng sau khi khởi tạo xong thì không thể thay đổi lại thuộc tính đó như set thông thường.

### 1. Thuộc tính dùng set

Với set, giá trị của thuộc tính có thể thay đổi bất kỳ lúc nào.
class Student
{
    public string Name { get; set; }
}

Student s = new Student();
s.Name = "An";
s.Name = "Bình"; // Hợp lệ
### 2. Thuộc tính dùng init

Với init, thuộc tính chỉ được gán giá trị trong lúc khởi tạo đối tượng.
class Student
{
    public string Name { get; init; }
}

Student s = new Student
{
    Name = "An"
};

Sau khi đối tượng đã được tạo:
s.Name = "Bình"; // Lỗi biên dịch
### 3. Trường hợp sử dụng thực tế

init phù hợp với những dữ liệu cần được thiết lập ngay từ đầu và không nên thay đổi sau khi đối tượng đã được tạo.

Ví dụ:
class Employee
{
    public int Id { get; init; }
    public string Name { get; init; }
}

Khi tạo nhân viên:
Employee e = new Employee
{
    Id = 101,
    Name = "Nguyen Van A"
};
Sau đó Id và Name không thể bị thay đổi tùy ý.

## Câu 3:Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương thức override ở lớp con khi triển khai tính Đa hình (Polymorphism).
Trong C#, virtual và override thường được sử dụng cùng nhau để triển khai tính đa hình (Polymorphism).

### virtual ở lớp cha

Từ khóa virtual được khai báo ở lớp cha. Nó cho phép lớp con có thể viết lại cách hoạt động của phương thức đó.
Ví dụ:
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

Ở đây, phương thức Speak() được khai báo là virtual, nghĩa là các lớp kế thừa từ Animal có thể ghi đè phương thức này.

### override ở lớp con
Từ khóa override được khai báo ở lớp con để ghi đè phương thức virtual của lớp cha và cung cấp cách xử lý mới.
Ví dụ:
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}
Lớp Dog kế thừa từ Animal và ghi đè phương thức Speak().

Ví dụ về đa hình
Animal animal = new Dog();
animal.Speak();

## Câu 4: Tại sao thành phần `static` trong Class không thể truy xuất thông qua một Object Instance được tạo bằng new?


Trong C#, một thành phần được khai báo là static sẽ thuộc về chính lớp (Class) chứ không thuộc về từng đối tượng được tạo ra từ lớp đó.
Ví dụ:
class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

Phương thức Add() là static, vì vậy ta gọi trực tiếp thông qua tên lớp:
int result = Calculator.Add(5, 3);

Không cần tạo đối tượng:
Calculator c = new Calculator();
Lý do là mỗi đối tượng được tạo bằng new sẽ có các thành phần instance riêng của nó, trong khi thành phần static chỉ có một bản duy nhất dùng chung cho toàn bộ lớp

Ví dụ:
class Student
{
    public static int Count = 0;

    public Student()
    {
        Count++;
    }
}
Khi tạo nhiều đối tượng:
Student s1 = new Student();
Student s2 = new Student();

Console.WriteLine(Student.Count);
Kết quả:
2

Biến Count không thuộc riêng s1 hay s2, mà thuộc về lớp Student và được tất cả các đối tượng dùng chung.

### Sự khác nhau giữa thành phần static và thành phần instance

| Thành phần static                | Thành phần instance         |
| -------------------------------- | --------------------------- |
| Thuộc về Class                   | Thuộc về Object             |
| Chỉ có một bản dùng chung        | Mỗi object có dữ liệu riêng |
| Truy cập bằng tên Class          | Truy cập thông qua object   |
| Không cần dùng `new` để truy cập | Cần tạo object bằng `new`   |

