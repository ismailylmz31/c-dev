Student tembel = new();
studentManager tembelManager = new();
tembel.Isim = "ismail";
tembel.Soyisim = "Yılmaz";
tembel.Yas = 24;
tembel.Takım = "Erkek adam top peşinde koşmaz";
tembel.ProgramlamaDilleri = "Java, C#, Python";
tembel.Telno = "+905459729550";
tembel.Yabancidil = true;
tembel.Semt = "Pendik";
tembel.Departman = "Bilgisayar mühendisi";

tembelManager.Add(tembel);
Console.WriteLine(" ---------- ");
tembelManager.Delete(tembel);
Console.WriteLine(" ---------- ");
tembelManager.Update(tembel);
Console.WriteLine(" ---------- ");
tembelManager.iseAl(tembel);
Console.WriteLine(" ---------- ");
tembelManager.YazDostum(tembel);
Console.WriteLine(" ---------- ");
Console.WriteLine(" ---------- ");
Console.WriteLine(" ---------- ");


Student fakeogrenci = new Student();
studentManager fakeogrencimanager = new();
fakeogrencimanager.Add(fakeogrenci);
Console.WriteLine(" ---------- ");
fakeogrencimanager.Delete(fakeogrenci);
Console.WriteLine(" ---------- ");
fakeogrencimanager.Update(fakeogrenci);
Console.WriteLine(" ---------- ");
fakeogrencimanager.YazDostum(fakeogrenci);
Console.WriteLine(" ---------- ");





public class Student
{
    public string Isim;
    public string Soyisim;
    public int Yas;
    public string Departman;
    public string Takım;
    public string ProgramlamaDilleri;
    public string Telno;
    public bool Yabancidil;
    public string Semt;

    public Student()
    {
        Console.WriteLine("boş constructor çalışmış gibi yaptı!!!");
    }
    public Student(string isim, string soyisim, string departman, string takım, string programlamaDilleri, string telno, string semt, int yas, bool yabancidil)
    {
        Isim = isim;
        Soyisim = soyisim;
        Departman = departman;
        Takım = takım;
        ProgramlamaDilleri = programlamaDilleri;
        Telno = telno;
        Semt = semt;
        Yas = yas;
        Yabancidil = yabancidil;     

                   

    }

}
public class studentManager 
{
    public void Add(Student student)
    {
        if (string.IsNullOrEmpty(student.Isim) || string.IsNullOrEmpty(student.Soyisim) || student.Isim.Length <= 2 || student.Soyisim.Length <= 2)
        {
            Console.WriteLine("öğrenci eklenemedi! İsim veya soyisim geçersiz.");
            return;
        }
        if (string.IsNullOrWhiteSpace(student.ProgramlamaDilleri))
        {
            Console.WriteLine("öğrenci ekleme başarısız   1");
            return ;
        }
        if (student.Yas < 18 || student.Yas >= 35)
        {
            Console.WriteLine("öğrenci ekleme başarısız    2");
            return;
        }
        if (!student.Telno.StartsWith("+905"))
        {
            Console.WriteLine("öğrenci ekleme başarısız   3");
            return;
        }
        if (student.Semt.Length<1 || string.IsNullOrWhiteSpace(student.Semt))
        {
            Console.WriteLine("öğrenci ekleme başarısız   4");
            return;
        }
        Console.WriteLine("öğrenci başarıyla eklendi helaaaaalll!!!!!!");
    }
    public void Update(Student student)
    {
        Console.WriteLine("öğrenci güncellendi!");
    }
    public void Delete(Student student) 
    { 
        Console.WriteLine("öğrenci silindi");
    }
    public void iseAl(Student student) { Console.WriteLine("şaka şaka o kadarda değil"); }

    public void YazDostum(Student student) {
        Console.WriteLine($"Öğrencinin adı = {student.Isim}");
        Console.WriteLine($"Öğrencinin Soyadı = {student.Soyisim}");
        Console.WriteLine($"Öğrencinin numarası = {student.Telno}");
        Console.WriteLine($"Öğrencinin Bildiği programlama dilleri = {student.ProgramlamaDilleri}");
        Console.WriteLine($"Öğrencinin departmanı = {student.Departman}");
        Console.WriteLine($"Öğrencinin yaşı = {student.Yas}");
        Console.WriteLine($"Öğrencinin takımı = {student.Takım}");
        Console.WriteLine($"Öğrenci yabancı dil biliyor mu? = {student.Yabancidil}");
    }
}
