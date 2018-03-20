public class myfirstclass {

    public static void main(String[] args){
        System.out.println("Hello world");
       int a =10;
       myfirstclass  myfirstclass = new myfirstclass()

        myfirstclass.myNotStaticMethod(a);

       myStaticMethod();
       float b=4.6f;
       double c=2.4;
       boolean d= true;
       char e= 'A';
       String f ="this is string!!!";

    }
    private void myNotStaticMethod(int numb){
        System.out.println("jusu skaicius"+numb);
    }
    private static void myStaticMethod(){
        System.out.println("cia yra statinis metodas");
    }
}
