// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int N = Convert.ToInt32(Console.ReadLine());
        int num = 2;
        while (num <= N) {
            int res = num % 2 ;
            if (res != 1) {
                Console.WriteLine("Четное " + num);
                num++;
            }
            else{
                num++;
            }

        }
    


