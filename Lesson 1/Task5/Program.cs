using System.Numerics;

bool characterIsQ(string c){

if ( c.Equals("q")){
return true;
}
return false;
}

bool numberIsEven (int n){

    if (n%2 ==0){
        return true;
    }
    return false;
}


void test (){
    while(true){
    Console.WriteLine("Введите символ");
    string ch = Console.ReadLine();
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
if (numberIsEven(num)||characterIsQ (ch) ){
break;
}
    }
}

test();
