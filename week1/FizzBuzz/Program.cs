/**
integer n, for every i <=n
if i % 3 == 0 then (Fizz)
if i % 5 == 0 then (Buzz)
if i % 5 and i % 3 then (FizzBuzz)
*/



//  namespace is like a Folder that orginizes your files, 
//different namespaces can help you to have the same filenames and don't mix it up
namespace FizzBuzz;

class Program{

    //Entry Point, dotnet looks for this method
    static void Main(string[] args){

        FizzBuzz(14);

    }


    //Function to print FizzBuzz numbers

    //Public access modifer (access to all classes)
    //Private (restricted to only the same class it declared in)
    //Protected (accessed to itself and subclasses only)
    public static void FizzBuzz(int n){
        
        for(int i = 1; i < n; i++){

            if( i % 15 == 0){
                Console.WriteLine("FizzBuzz");
            }

            else if( i % 3 == 0){
                Console.WriteLine("Fizz");
            }

            else if( i % 5 == 0){
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine(i);
            }
        }

    }
}


