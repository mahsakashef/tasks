using system ;
class test
{
    public static void Main (string [] args)
    {
        string a=cosole.readline();
        string b=console.readline();
        string c=console.readline();
        int x=convert.ToInt32(a);
        int y=convert.ToInt32(b);
        int z=convert.ToInt32(c);
        if (x+y>z && x+z>y && z+y>x)
        {
            mohit(x,y,z);
        }
        else
        {
            console.writeline("no");
        }
        }//Main end
        private mohit(int n, int m, int w)
        {
            int out = n+m+w ;
            console.writeline(out);
        }//end of function
        }

    }
}
