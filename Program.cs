using System;
namespace HelloWorld { 
class Program { 
static void Main(){ 
    //Console.WriteLine("How many students do you want to enter for");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter ID to search for student");
    int j = Convert.ToInt32(Console.ReadLine());
    //Tuple(n);
    SearchID(n);
} 
static void Tuple(int n){
    (int id, string fir, string sur, string tutor, int age)[] tuple1 = new (int, string, string, string, int)[n];
    for (int i = 0;i < tuple1.Length; i++){
        Console.Write($"Enter id:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter firstname:");
        string fir = Console.ReadLine();
        Console.Write($"Enter surname:");
        string sur = Console.ReadLine();
        Console.Write($"Enter tutor:");
        string tutor = Console.ReadLine();
        Console.Write($"Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());
        tuple1[i].id = id; tuple1[i].fir = fir; tuple1[i].sur = sur; tuple1[i].tutor = tutor; tuple1[i].age = age;
    }
    for (int i = 0; i < tuple1.Length; i++){
        Console.WriteLine($"ID:{tuple1[i].id}");
        Console.WriteLine($"Firstname:{tuple1[i].fir}");
        Console.WriteLine($"Surname:{tuple1[i].sur}");
        Console.WriteLine($"Tutor:{tuple1[i].tutor}");
        Console.WriteLine($"Age:{tuple1[i].age}");
    }
}
static void SearchID(int j){
    (int id, string fir, string sur, string tutor, int age)[] tuple1 = 
    {(1,"River","Maddox","10F1",15),(2,"Iliana","Navarro","11F1",16),(10,"Reid","Graham","11H2",17),(15,"Erik","Wolfe","9F2",13),(200,"Briella","Huber","8H2",12)};
    bool found = false;
    while (found == false){
        for (int i = 0;i < tuple1.Length;i++){
            if (tuple1[i].id == j){
                Console.WriteLine($"ID:{tuple1[i].id}");
                Console.WriteLine($"Firstname:{tuple1[i].fir}");
                Console.WriteLine($"Surname:{tuple1[i].sur}");
                Console.WriteLine($"Tutor:{tuple1[i].tutor}");
                Console.WriteLine($"Age:{tuple1[i].age}");
                found = true;
            }
        }
        if (found == false){
            Console.WriteLine($"Person ID not found");
            break;
        }
    }
} 
}
}

